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
    public partial class Edit : Form
    {
        private SubjectPreqFile _subjectPreq;

        public Edit(SubjectPreqFile subjectPreq)
        {
            InitializeComponent();
            _subjectPreq = subjectPreq;
            InitializeComboBox();
            LoadSubjectPreqData();
        }

        private void InitializeComboBox()
        {
            CBCategory.Items.AddRange(new string[] { "PR", "CR" });
            CBCategory.SelectedIndex = 0;
        }

        private void LoadSubjectPreqData()
        {
            if (_subjectPreq != null)
            {
                TBSubjectCode.Text = _subjectPreq.SUBJCODE;
                TBPreqCode.Text = _subjectPreq.SUBJPRECODE;
                CBCategory.SelectedItem = _subjectPreq.SUBJCATEGORY;
            }
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Only update the category
                _subjectPreq.SUBJCATEGORY = CBCategory.SelectedItem.ToString();

                // Save to database
                var repo = new RepositorySubjectPreq();
                if (repo.UpdateSubjectPreq(_subjectPreq))
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog.Show("Subject prerequisite updated successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    MessageDialog.Show("Failed to update subject prerequisite.", "Error");
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
            this.Close();
        }
    }
}
