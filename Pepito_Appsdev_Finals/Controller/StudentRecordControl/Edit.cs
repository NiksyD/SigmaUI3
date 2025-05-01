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
using Guna.UI2.WinForms;

namespace Pepito_Appsdev_Finals.Controller.StudentRecordControl
{
    public partial class Edit : Form
    {
        private readonly long _studentId;
        private readonly StudentFile _student;

        public Edit(long studentId)
        {
            InitializeComponent();
            _studentId = studentId;
            _student = LoadStudentData();
            InitializeComboBoxes();
            LoadStudentDataToForm();
        }

        private StudentFile LoadStudentData()
        {
            var repo = new RepositoryStudentFile();
            var students = repo.GetStudents();
            var studentRow = students.Select($"STFSTUDID = {_studentId}").FirstOrDefault();

            if (studentRow == null)
            {
                throw new Exception("Student record not found.");
            }

            return new StudentFile
            {
                STFSTUDID = Convert.ToInt64(studentRow["STFSTUDID"]),
                STFSTUDLNAME = studentRow["STFSTUDLNAME"].ToString(),
                STFSTUDFNAME = studentRow["STFSTUDFNAME"].ToString(),
                STFSTUDMNAME = studentRow["STFSTUDMNAME"].ToString(),
                STFSTUDCOURSE = studentRow["STFSTUDCOURSE"].ToString(),
                STFSTUDYEAR = Convert.ToInt32(studentRow["STFSTUDYEAR"]),
                STFSTUDREMARKS = studentRow["STFSTUDREMARKS"].ToString(),
                STFSTUDSTATUS = studentRow["STFSTUDSTATUS"].ToString()
            };
        }

        private void InitializeComboBoxes()
        {
            // Initialize Remarks combo box
            CBRemarks.Items.AddRange(Enum.GetNames(typeof(StudentRemarks)));
            CBRemarks.SelectedItem = _student.STFSTUDREMARKS;

            // Initialize Status combo box
            CBStatus.Items.AddRange(Enum.GetNames(typeof(StudentStatus)));
            CBStatus.SelectedItem = _student.STFSTUDSTATUS;

            // Initialize Course combo box with common courses
            CBCourse.Items.AddRange(new string[] { "BSCS", "BSIT", "BSCE", "BSEE", "BSChem" });
            CBCourse.SelectedItem = _student.STFSTUDCOURSE;
        }

        private void LoadStudentDataToForm()
        {
            TBLastName.Text = _student.STFSTUDLNAME;
            TBFirstName.Text = _student.STFSTUDFNAME;
            TBMiddleName.Text = _student.STFSTUDMNAME;
            TBYear.Text = _student.STFSTUDYEAR.ToString();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(TBLastName.Text) ||
                string.IsNullOrWhiteSpace(TBFirstName.Text) ||
                string.IsNullOrWhiteSpace(CBCourse.Text) ||
                string.IsNullOrWhiteSpace(TBYear.Text))
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("Please fill in all required fields.", "Validation Error");
                return;
            }

            // Validate year is a number between 1 and 5
            if (!int.TryParse(TBYear.Text, out int year) || year < 1 || year > 5)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("Year must be a number between 1 and 5.", "Validation Error");
                return;
            }

            try
            {
                // Update student record
                _student.STFSTUDLNAME = TBLastName.Text.Trim();
                _student.STFSTUDFNAME = TBFirstName.Text.Trim();
                _student.STFSTUDMNAME = TBMiddleName.Text.Trim();
                _student.STFSTUDCOURSE = CBCourse.Text.Trim();
                _student.STFSTUDYEAR = year;
                _student.STFSTUDREMARKS = CBRemarks.Text.Trim();
                _student.STFSTUDSTATUS = CBStatus.Text.Trim();

                // Save to database
                var repo = new RepositoryStudentFile();
                int rowsAffected = repo.UpdateStudent(_student);

                if (rowsAffected > 0)
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog.Show("Student record updated successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog.Show("No changes were made to the student record.", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
