using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pepito_Appsdev_Finals.Controller;
using Pepito_Appsdev_Finals.Repository;

namespace Pepito_Appsdev_Finals.Controller.StudentEnrollmentControl
{
    public partial class EnrolledList : UserControl
    {
        public EnrolledList()
        {
            InitializeComponent();
            LoadEnrolledStudentsRecord();
        }

        private void LoadEnrolledStudentsRecord()
        {
            var repo = new RepositoryEnrollmentHeaderFile();
            var enrolledStudents = repo.GetAllEnrollmentHeaders();
            DGVEnrolledStudentsRecord.DataSource = enrolledStudents;
            DGVEnrolledStudentsRecord.Refresh();
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

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            if (DGVEnrolledStudentsRecord.SelectedRows.Count > 0)
            {
                var selectedRow = DGVEnrolledStudentsRecord.SelectedRows[0];
                long studentId = Convert.ToInt64(selectedRow.Cells["ENRHFSTUDID"].Value);

                var result = MessageBox.Show(
                    "Are you sure you want to delete this enrollment record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var repo = new RepositoryEnrollmentHeaderFile();
                    var deleteResult = repo.DeleteEnrollmentHeader(studentId);

                    if (deleteResult.Success)
                    {
                        LoadEnrolledStudentsRecord(); // Refresh the grid
                        MessageBox.Show("Enrollment record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete enrollment record: {deleteResult.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an enrollment record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
