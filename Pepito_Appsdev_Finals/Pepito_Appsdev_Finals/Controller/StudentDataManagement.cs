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
using Pepito_Appsdev_Finals.Controller.StudentRecordControl;

namespace Pepito_Appsdev_Finals.Controller
{
    public partial class StudentDataManagement : UserControl
    {
        public StudentDataManagement()
        {
            InitializeComponent();
            StudentsRecordReader();
        }

        public void StudentsRecordReader()
        {
            var repo = new RepositoryStudentFile();
            DGVStudents.DataSource = repo.GetStudents();
            DGVStudents.Refresh();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new Add())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the grid after successful addition
                    StudentsRecordReader();
                }
            }
        }

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            if (DGVStudents.SelectedRows.Count > 0)
            {
                var selectedRow = DGVStudents.SelectedRows[0];
                long studentId = Convert.ToInt64(selectedRow.Cells["STFSTUDID"].Value);

                try
                {
                    using (var editForm = new Edit(studentId))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            // Refresh the grid after successful update
                            StudentsRecordReader();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening edit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            if (DGVStudents.SelectedRows.Count > 0)
            {
                var selectedRow = DGVStudents.SelectedRows[0];
                long studentId = Convert.ToInt64(selectedRow.Cells["STFSTUDID"].Value);

                var result = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var repo = new RepositoryStudentFile();
                    repo.DeleteStudent(studentId);
                    StudentsRecordReader(); // Refresh the grid
                    MessageBox.Show("Student record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a student record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
