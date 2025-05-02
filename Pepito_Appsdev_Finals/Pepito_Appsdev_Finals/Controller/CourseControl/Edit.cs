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
    public partial class Edit : Form
    {
        private SubjectFile _subject;

        public Edit(SubjectFile subject)
        {
            InitializeComponent();
            _subject = subject;
            InitializeComboBoxes();
            LoadSubjectData();
        }

        private void InitializeComboBoxes()
        {
            // Initialize Offering combo box
            CBOffering.Items.AddRange(new string[] { "1st Semester", "2nd Semester", "Summer" });
            CBOffering.SelectedIndex = 0;

            // Initialize Category combo box
            CBCategory.Items.AddRange(new string[] { "LAB", "LEC" });
            CBCategory.SelectedIndex = 0;

            // Initialize Status combo box
            CBStatus.Items.AddRange(new string[] { "AC", "IN" });
            CBStatus.SelectedIndex = 0;

            // Initialize Course Code combo box
            CBCourseCode.Items.AddRange(new string[] { "BSCS", "BSIT" });
            CBCourseCode.SelectedIndex = 0;
        }

        private void LoadSubjectData()
        {
            if (_subject != null)
            {
                TBSubjectCode.Text = _subject.SFSUBJCODE;
                TBDescription.Text = _subject.SFSUBJDESC;
                NUDUnits.Value = (decimal)_subject.SFSUBJUNITS;
                CBOffering.SelectedIndex = _subject.SFSUBJREGOFRNG - 1;
                CBCategory.SelectedItem = _subject.SFSUBJCATEGORY;
                CBStatus.SelectedItem = _subject.SFSUBJSTATUS;
                CBCourseCode.SelectedItem = _subject.SFSUBJCOURSECODE;
                TBCurriculumCode.Text = _subject.SFSUBJCURRCODE;
            }
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the subject object with form values
                _subject.SFSUBJDESC = TBDescription.Text;
                _subject.SFSUBJUNITS = (float)NUDUnits.Value;
                _subject.SFSUBJREGOFRNG = CBOffering.SelectedIndex + 1;
                _subject.SFSUBJCATEGORY = CBCategory.SelectedItem.ToString();
                _subject.SFSUBJSTATUS = CBStatus.SelectedItem.ToString();
                _subject.SFSUBJCOURSECODE = CBCourseCode.SelectedItem.ToString();
                _subject.SFSUBJCURRCODE = TBCurriculumCode.Text;

                // Create repository instance and update the subject
                var repository = new RepositorySubjectFile();
                bool success = repository.UpdateSubject(_subject);

                if (success)
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    MessageDialog.Show("Subject updated successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    MessageDialog.Show("Failed to update subject.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
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
