using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pepito_Appsdev_Finals.Repository;
using Pepito_Appsdev_Finals.Models;

namespace Pepito_Appsdev_Finals.Controller.CourseControl
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
            // Initialize Offering combo box
            CBOffering.Items.AddRange(new string[] { "1st Semester", "2nd Semester" });
            CBOffering.SelectedIndex = 0;

            // Initialize Category combo box
            CBCategory.Items.AddRange(new string[] { "LAB", "LEC" });
            CBCategory.SelectedIndex = 0;

            // Initialize Status combo box
            CBStatus.Items.AddRange(new string[] { "AC", "IN" });
            CBStatus.SelectedIndex = 0;

            // Initialize Course Code combo box
            CBCourseCode.Items.AddRange(new string[] { "BSCS", "BSIT"});
            CBCourseCode.SelectedIndex = 0;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(TBSubjectCode.Text) ||
                string.IsNullOrWhiteSpace(TBDescription.Text) ||
                string.IsNullOrWhiteSpace(TBCurriculumCode.Text))
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("Please fill in all required fields.", "Validation Error");
                return;
            }

            // Validate year (1-5)
            if (!int.TryParse(TBCurriculumCode.Text, out int year) || year < 1 || year > 5)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("Year must be between 1 and 5.", "Validation Error");
                return;
            }

            // Validate description length
            const int MAX_DESCRIPTION_LENGTH = 40;
            if (TBDescription.Text.Length > MAX_DESCRIPTION_LENGTH)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show($"Description exceeds maximum length of {MAX_DESCRIPTION_LENGTH} characters. It will be truncated.", "Warning");
                return;
            }

            try
            {
                // Create new subject object
                var subject = new SubjectFile
                {
                    SFSUBJCODE = TBSubjectCode.Text.Trim(),
                    SFSUBJDESC = TBDescription.Text.Trim(),
                    SFSUBJUNITS = (float)NUDUnits.Value,
                    SFSUBJREGOFRNG = CBOffering.SelectedIndex + 1,
                    SFSUBJCATEGORY = CBCategory.SelectedItem.ToString(),
                    SFSUBJSTATUS = CBStatus.SelectedItem.ToString(),
                    SFSUBJCOURSECODE = CBCourseCode.SelectedItem.ToString(),
                    SFSUBJCURRCODE = TBCurriculumCode.Text.Trim()
                };

                // Save to database
                var repo = new RepositorySubjectFile();
                if (repo.AddSubject(subject))
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog.Show("Subject added successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    MessageDialog.Show("Failed to add subject. Please try again.", "Error");
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
