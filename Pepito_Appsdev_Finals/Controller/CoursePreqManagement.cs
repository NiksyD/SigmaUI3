using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pepito_Appsdev_Finals.Controller.CoursePrerequisiteControl;
using Pepito_Appsdev_Finals.Repository;
using Pepito_Appsdev_Finals.Models;

namespace Pepito_Appsdev_Finals.Controller
{
    public partial class CoursePreqManagement : UserControl
    {
        public CoursePreqManagement()
        {
            InitializeComponent();
            SubjectsPreqRecords();
        }

        private void SubjectsPreqRecords()
        {
            var repo = new RepositorySubjectPreq();
            DGVSubjectsPreqRecords.DataSource = repo.GetSubjectPreq();
            DGVSubjectsPreqRecords.Refresh();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new Add())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the grid after successful addition
                    SubjectsPreqRecords();
                }
            }
        }

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            if (DGVSubjectsPreqRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a prerequisite to edit.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = DGVSubjectsPreqRecords.SelectedRows[0];
                
                // Create subject prerequisite object from selected row
                var subjectPreq = new SubjectPreqFile
                {
                    SUBJCODE = selectedRow.Cells["SUBJCODE"].Value.ToString(),
                    SUBJPRECODE = selectedRow.Cells["SUBJPRECODE"].Value.ToString(),
                    SUBJCATEGORY = selectedRow.Cells["SUBJCATEGORY"].Value.ToString()
                };

                // Open edit form
                using (var editForm = new Edit(subjectPreq))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh the grid after successful edit
                        SubjectsPreqRecords();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while editing the prerequisite: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            if (DGVSubjectsPreqRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a prerequisite to delete.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = DGVSubjectsPreqRecords.SelectedRows[0];
                string subjectCode = selectedRow.Cells["SUBJCODE"].Value.ToString();
                string preqCode = selectedRow.Cells["SUBJPRECODE"].Value.ToString();

                // Confirm deletion with user
                var result = MessageBox.Show(
                    $"Are you sure you want to delete the prerequisite relationship between {subjectCode} and {preqCode}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var repo = new RepositorySubjectPreq();
                    if (repo.DeleteSubjectPreq(subjectCode, preqCode))
                    {
                        MessageBox.Show("Prerequisite deleted successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the grid after successful deletion
                        SubjectsPreqRecords();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete prerequisite.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the prerequisite: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
