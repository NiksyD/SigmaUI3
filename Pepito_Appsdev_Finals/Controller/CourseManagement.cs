using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pepito_Appsdev_Finals.Controller.CourseControl;
using Pepito_Appsdev_Finals.Repository;
using Pepito_Appsdev_Finals.Models;

namespace Pepito_Appsdev_Finals.Controller
{
    public partial class CourseManagement : UserControl
    {
        public CourseManagement()
        {
            InitializeComponent();
            SubjectRecordReader();
        }

        public void SubjectRecordReader()
        {
            var repo = new RepositorySubjectFile();
            DGVSubjects.DataSource = repo.GetSubjects();
            DGVSubjects.Refresh();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new Add())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the grid after successful addition
                    SubjectRecordReader();
                }
            }
        }

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            if (DGVSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subject to edit.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = DGVSubjects.SelectedRows[0];

                // Create a new SubjectFile object with the selected data
                var subject = new SubjectFile
                {
                    SFSUBJCODE = selectedRow.Cells["SFSUBJCODE"].Value.ToString(),
                    SFSUBJDESC = selectedRow.Cells["SFSUBJDESC"].Value.ToString(),
                    SFSUBJUNITS = Convert.ToSingle(selectedRow.Cells["SFSUBJUNITS"].Value),
                    SFSUBJREGOFRNG = Convert.ToInt32(selectedRow.Cells["SFSUBJREGOFRNG"].Value),
                    SFSUBJCATEGORY = selectedRow.Cells["SFSUBJCATEGORY"].Value.ToString(),
                    SFSUBJSTATUS = selectedRow.Cells["SFSUBJSTATUS"].Value.ToString(),
                    SFSUBJCOURSECODE = selectedRow.Cells["SFSUBJCOURSECODE"].Value.ToString(),
                    SFSUBJCURRCODE = selectedRow.Cells["SFSUBJCURRCODE"].Value.ToString()
                };

                // Open the edit form
                using (var editForm = new Edit(subject))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh the grid after successful edit
                        SubjectRecordReader();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while preparing to edit: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            if (DGVSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = DGVSubjects.SelectedRows[0];
                string subjectCode = selectedRow.Cells["SFSUBJCODE"].Value.ToString();
                string courseCode = selectedRow.Cells["SFSUBJCOURSECODE"].Value.ToString();

                // Confirm deletion with user
                var result = MessageBox.Show(
                    $"Are you sure you want to delete subject {subjectCode}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var repo = new RepositorySubjectFile();
                    if (repo.DeleteSubject(subjectCode, courseCode))
                    {
                        MessageBox.Show("Subject deleted successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the grid after successful deletion
                        SubjectRecordReader();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete subject.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the subject: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
