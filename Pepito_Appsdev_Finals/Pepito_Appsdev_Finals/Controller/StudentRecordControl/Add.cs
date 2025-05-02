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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // Initialize Remarks combo box
            CBRemarks.Items.AddRange(Enum.GetNames(typeof(StudentRemarks)));
            CBRemarks.SelectedIndex = 0;

            // Initialize Status combo box
            CBStatus.Items.AddRange(Enum.GetNames(typeof(StudentStatus)));
            CBStatus.SelectedIndex = 0;

            // Initialize Course combo box with common courses
            CBCourse.Items.AddRange(new string[] { "BSCS", "BSIT", "BSCE", "BSEE", "BSChem" });
            CBCourse.SelectedIndex = 0;
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
                // Create new student record
                var student = new StudentFile
                {
                    STFSTUDID = GenerateStudentId(), // You'll need to implement this method
                    STFSTUDLNAME = TBLastName.Text.Trim(),
                    STFSTUDFNAME = TBFirstName.Text.Trim(),
                    STFSTUDMNAME = TBMiddleName.Text.Trim(),
                    STFSTUDCOURSE = CBCourse.Text.Trim(),
                    STFSTUDYEAR = year,
                    STFSTUDREMARKS = CBRemarks.Text.Trim(),
                    STFSTUDSTATUS = CBStatus.Text.Trim()
                };

                // Save to database
                var repo = new RepositoryStudentFile();
                var result = repo.CreateStudent(student);

                if (result.Success)
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog.Show("Student record saved successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    MessageDialog.Show($"Error saving student record: {result.ErrorMessage}", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private long GenerateStudentId()
        {
            // Generate a student ID based on current year and a random number
            // Format: YYYYXXXX where YYYY is current year and XXXX is a random number
            int currentYear = DateTime.Now.Year;
            Random random = new Random();
            int randomNum = random.Next(1000, 9999);
            return long.Parse($"{currentYear}{randomNum}");
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
