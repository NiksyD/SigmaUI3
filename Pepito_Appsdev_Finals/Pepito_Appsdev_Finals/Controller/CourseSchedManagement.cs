using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pepito_Appsdev_Finals.Controller.CourseScheduleControl;
using Pepito_Appsdev_Finals.Repository;
using Pepito_Appsdev_Finals.Models;

namespace Pepito_Appsdev_Finals.Controller
{
    public partial class CourseSchedManagement : UserControl
    {
        public CourseSchedManagement()
        {
            InitializeComponent();
            SubjectSchedRecordReader();
        }

        private void SubjectSchedRecordReader()
        {
            var repo = new RepositorySubjectSched();
            DGVSubjectSchedRecord.DataSource = repo.GetSubjectsSched();
            DGVSubjectSchedRecord.Refresh();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new Add())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the grid after successful addition
                    SubjectSchedRecordReader();
                }
            }
        }

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            if (DGVSubjectSchedRecord.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = DGVSubjectSchedRecord.SelectedRows[0];

                // Create a new SubjectSchedFile object with the selected data
                var schedule = new SubjectSchedFile
                {
                    SSFEDPCODE = selectedRow.Cells["SSFEDPCODE"].Value.ToString(),
                    SSFSUBJCODE = selectedRow.Cells["SSFSUBJCODE"].Value.ToString(),
                    SSFSTARTTIME = (DateTime)selectedRow.Cells["SSFSTARTTIME"].Value,
                    SSFENDTIME = (DateTime)selectedRow.Cells["SSFENDTIME"].Value,
                    SSFDAYS = selectedRow.Cells["SSFDAYS"].Value.ToString(),
                    SSFROOM = selectedRow.Cells["SSFROOM"].Value.ToString(),
                    SSFMAXSIZE = Convert.ToInt32(selectedRow.Cells["SSFMAXSIZE"].Value),
                    SSFCLASSSIZE = Convert.ToInt32(selectedRow.Cells["SSFCLASSSIZE"].Value),
                    SSFSTATUS = selectedRow.Cells["SSFSTATUS"].Value.ToString(),
                    SSFXM = selectedRow.Cells["SSFXM"].Value.ToString(),
                    SSFSECTION = selectedRow.Cells["SSFSECTION"].Value.ToString(),
                    SSFSCHOOLYEAR = Convert.ToInt32(selectedRow.Cells["SSFSCHOOLYEAR"].Value)
                };

                // Open the edit form
                using (var editForm = new Edit(schedule))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh the grid after successful edit
                        SubjectSchedRecordReader();
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
            if (DGVSubjectSchedRecord.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = DGVSubjectSchedRecord.SelectedRows[0];
            string edpCode = selectedRow.Cells["SSFEDPCODE"].Value.ToString();

            var result = MessageBox.Show(
                "Are you sure you want to delete this course schedule?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var repo = new RepositorySubjectSched();
                if (repo.DeleteSubjectSched(edpCode))
                {
                    MessageBox.Show("Course schedule deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SubjectSchedRecordReader(); // Refresh the grid
                }
                else
                {
                    MessageBox.Show("Failed to delete course schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}