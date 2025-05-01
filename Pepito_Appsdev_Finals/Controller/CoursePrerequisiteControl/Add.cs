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

namespace Pepito_Appsdev_Finals.Controller.CoursePrerequisiteControl
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            CBCategory.Items.AddRange(new string[] { "PR", "CR" });
            CBCategory.SelectedIndex = 0;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(TBSubjectCode.Text) ||
                string.IsNullOrWhiteSpace(TBPreqCode.Text))
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("Please fill in all required fields.", "Validation Error");
                return;
            }

            // Create new subject prerequisite
            var subjectPreq = new SubjectPreqFile
            {
                SUBJCODE = TBSubjectCode.Text.Trim(),
                SUBJPRECODE = TBPreqCode.Text.Trim(),
                SUBJCATEGORY = CBCategory.SelectedItem.ToString()
            };

            // Check if prerequisite already exists
            var repo = new RepositorySubjectPreq();
            if (repo.IsSubjectPreqExists(subjectPreq.SUBJCODE, subjectPreq.SUBJPRECODE))
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("This prerequisite already exists.", "Duplicate Entry");
                return;
            }

            // Save the prerequisite
            if (repo.AddSubjectPreq(subjectPreq))
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                MessageDialog.Show("Subject prerequisite added successfully.", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog.Show("Failed to add subject prerequisite.", "Error");
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
