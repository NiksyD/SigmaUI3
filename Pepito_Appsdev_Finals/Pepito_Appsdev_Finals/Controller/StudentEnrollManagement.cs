using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pepito_Appsdev_Finals.Controller.StudentEnrollmentControl;
using Pepito_Appsdev_Finals.Repository;

namespace Pepito_Appsdev_Finals.Controller
{
    public partial class StudentEnrollManagement : UserControl
    {
        public StudentEnrollManagement()
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

        private void BTNEnrolledStudentLIst_Click(object sender, EventArgs e)
        {
            // Create and show the EnrolledList user control
            var enrolledList = new EnrolledList();
            
            // Get the parent form/container
            var parent = this.Parent;
            if (parent != null)
            {
                // Clear existing controls
                parent.Controls.Clear();
                
                // Add the new control
                parent.Controls.Add(enrolledList);
                
                // Dock the control to fill the parent
                enrolledList.Dock = DockStyle.Fill;
            }
        }

        private void BTNEnrollmentOverview_Click(object sender, EventArgs e)
        {
            if (DGVStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to view enrollment overview.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Safely parse Student ID
                if (!long.TryParse(DGVStudents.SelectedRows[0].Cells[0].Value?.ToString(), out long studentId))
                {
                    MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create and show the EnrollmentDetail user control
                var enrollmentDetail = new EnrollmentDetail(studentId);
                ShowUserControl(enrollmentDetail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error showing enrollment overview: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowUserControl(UserControl control)
        {
            // Get the parent form/container
            var parent = this.Parent;
            if (parent != null)
            {
                // Clear existing controls
                parent.Controls.Clear();
                
                // Add the new control
                parent.Controls.Add(control);
                
                // Dock the control to fill the parent
                control.Dock = DockStyle.Fill;
            }
        }

        private void BTNEnrollmentEntry_Click(object sender, EventArgs e)
        {
            if (DGVStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to enroll.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Safely parse Student ID
                if (!long.TryParse(DGVStudents.SelectedRows[0].Cells[0].Value?.ToString(), out long studentId))
                {
                    MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pass only the student ID to EnrollStudent UserControl
                EnrollmentEntry enrollStudent = new EnrollmentEntry(studentId);

                ShowUserControl(enrollStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enrolling student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
