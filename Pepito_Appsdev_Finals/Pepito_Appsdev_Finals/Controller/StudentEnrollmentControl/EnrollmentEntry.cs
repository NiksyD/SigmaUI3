using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pepito_Appsdev_Finals.Models;
using Pepito_Appsdev_Finals.Repository;
using Microsoft.Data.SqlClient;

namespace Pepito_Appsdev_Finals.Controller.StudentEnrollmentControl
{
    public partial class EnrollmentEntry : UserControl
    {
        private long studentId;
        private Random random = new Random();
        private Dictionary<string, string> EnrollmentStatusMap = new Dictionary<string, string>
        {
            { "Enrolled", "EN" },
            { "Unenrolled", "UN" }
        };

        public EnrollmentEntry(long studentId)
        {
            InitializeComponent();
            SubjectRecordsReader();
            this.studentId = studentId;
            TBID.Text = studentId.ToString();
            LBSubjectRecords.ItemCheck += LBSubjectRecords_ItemCheck;
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // Initialize Encoder ComboBox
            CBEncoder.Items.AddRange(new string[] {
                "AdminA1",
                "AdminB2",
                "AdminC3",
                "StaffX1",
                "StaffY2",
                "StaffZ3",
                "EncoderE1",
                "EncoderF2"
            });
            CBEncoder.SelectedIndex = 0;

            // Initialize Status ComboBox
            CBStatus.Items.AddRange(new string[] {
                "Enrolled",
                "Unenrolled"
            });
            CBStatus.SelectedIndex = 0;
        }

        private string GetStatusCode(string status)
        {
            return status == "Enrolled" ? "EN" : "UN";
        }

        public void SubjectRecordsReader()
        {
            var repo = new RepositorySubjectSched();
            var subjects = repo.GetSubjectsSched();
            LBSubjectRecords.Items.Clear();
            
            foreach (DataRow row in subjects.Rows)
            {
                string subjectInfo = $"{row["SSFSUBJCODE"]} - {row["SFSUBJDESC"]} ({row["SFSUBJUNITS"]} units) - {row["SSFSTARTTIME"]} - {row["SSFENDTIME"]}";
                LBSubjectRecords.Items.Add(subjectInfo, false);
            }
        }

        private void LBSubjectRecords_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Calculate total units after the check state changes
            float totalUnits = 0;
            for (int i = 0; i < LBSubjectRecords.Items.Count; i++)
            {
                bool isChecked = (i == e.Index) ? (e.NewValue == CheckState.Checked) : LBSubjectRecords.GetItemChecked(i);
                if (isChecked)
                {
                    string itemText = LBSubjectRecords.Items[i].ToString();
                    // Extract units from the string (format: "SUBJCODE - Description (X units) - Time")
                    int startIndex = itemText.IndexOf("(") + 1;
                    int endIndex = itemText.IndexOf(" units)");
                    if (startIndex > 0 && endIndex > startIndex)
                    {
                        string unitsStr = itemText.Substring(startIndex, endIndex - startIndex);
                        if (float.TryParse(unitsStr, out float units))
                        {
                            totalUnits += units;
                        }
                    }
                }
            }
            LBLUnitsCount.Text = totalUnits.ToString("F1"); // Format to 1 decimal place
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            var studentEnrollManagement = new StudentEnrollManagement();

            var parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                parent.Controls.Add(studentEnrollManagement);
                studentEnrollManagement.Dock = DockStyle.Fill;
            }
        }

        private List<string> GetSelectedSubjects()
        {
            List<string> selectedSubjects = new List<string>();
            for (int i = 0; i < LBSubjectRecords.Items.Count; i++)
            {
                if (LBSubjectRecords.GetItemChecked(i))
                {
                    selectedSubjects.Add(LBSubjectRecords.Items[i].ToString());
                }
            }
            return selectedSubjects;
        }

        private float CalculateTotalUnits(List<string> selectedSubjects)
        {
            float totalUnits = 0;
            foreach (string subject in selectedSubjects)
            {
                string unitsStr = subject.Substring(subject.LastIndexOf("(") + 1).Replace(" units)", "");
                if (float.TryParse(unitsStr, out float units))
                {
                    totalUnits += units;
                }
            }
            return totalUnits;
        }

        private void resetListBox()
        {
            for (int i = 0; i < LBSubjectRecords.Items.Count; i++)
            {
                LBSubjectRecords.SetItemChecked(i, false);
            }
            LBLUnitsCount.Text = "0";
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            var repoHeader = new RepositoryEnrollmentHeaderFile();

            // Check if the student is already enrolled
            if (repoHeader.IsStudentEnrolled(studentId))
            {
                MessageBox.Show("The student is already enrolled.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedSubjects = GetSelectedSubjects();
            if (selectedSubjects.Count == 0)
            {
                MessageBox.Show("Please select at least one subject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 1: Save Enrollment Header (Main Record)
            var enrollmentHeader = new EnrollmentHeaderFile
            {
                ENRHFSTUDID = studentId,
                ENRHFSTUDDATEENROLL = DTPCreatedAt.Value,
                ENRHFSTUDSCHLYR = DTPYear.Value.Year.ToString(),
                ENRHFSTUDENCODER = CBEncoder.Text,
                ENRHFSTUDTOTALUNITS = CalculateTotalUnits(selectedSubjects),
                ENRHFSTUDSTATUS = EnrollmentStatusMap.ContainsKey(CBStatus.Text) ? EnrollmentStatusMap[CBStatus.Text] : "UN"
            };

            var resultHeader = repoHeader.AddEnrollmentHeader(enrollmentHeader);
            if (!resultHeader.Success)
            {
                MessageBox.Show($"Enrollment failed: {resultHeader.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Save Enrollment Details (Subjects) and Update Class Size
            var repoDetail = new RepositoryEnrollmentDetailFile();
            using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                connection.Open();
                foreach (var subject in selectedSubjects)
                {
                    string[] subjectParts = subject.Split('-');
                    if (subjectParts.Length < 2) continue;
                    string subjectCode = subjectParts[0].Trim();

                    var enrollmentDetail = new EnrollmentDetailFile
                    {
                        ENRDFSTUDID = studentId,
                        ENRDFSTUDSUBJCDE = subjectCode,
                        ENRDFSTUDEDPCODE = GenerateEdpCode(),
                        ENRDFSTUDSTATUS = "EN"
                    };

                    var resultDetail = repoDetail.AddEnrollmentDetail(enrollmentDetail);
                    if (!resultDetail.Success)
                    {
                        MessageBox.Show($"Enrollment failed: {resultDetail.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update the class size in SubjectSchedFile
                    using (var command = new SqlCommand(@"
                        UPDATE SubjectSchedFile 
                        SET SSFCLASSSIZE = SSFCLASSSIZE + 1 
                        WHERE SSFSUBJCODE = @SubjectCode", connection))
                    {
                        command.Parameters.AddWithValue("@SubjectCode", subjectCode);
                        command.ExecuteNonQuery();
                    }
                }
            }

            resetListBox();
            MessageBox.Show("Enrollment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerateEdpCode()
        {
            int randomDigits = random.Next(100000, 999999); // Ensure exactly 6 digits
            return "6" + randomDigits.ToString(); // Always starts with "6" and is 7 characters total
        }
    }
}
