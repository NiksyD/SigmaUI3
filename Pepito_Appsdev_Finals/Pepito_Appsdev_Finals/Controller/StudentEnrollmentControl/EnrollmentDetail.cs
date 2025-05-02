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

namespace Pepito_Appsdev_Finals.Controller.StudentEnrollmentControl
{
    public partial class EnrollmentDetail : UserControl
    {
        private readonly long studentId;

        public EnrollmentDetail(long studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            LoadEnrolledSubjectsRecord();
            LoadGradingSubjectsRecord();
        }

        private void LoadEnrolledSubjectsRecord()
        {
            var repo = new RepositoryEnrollmentHeaderFile();
            var dt = repo.GetEnrolledSubjects(studentId);
            DGVEnrolledSubjectsRecord.DataSource = dt;
            DGVEnrolledSubjectsRecord.Refresh();

            // Enable/disable buttons based on row count
            BTNDeleteEnrolledSubject.Enabled = DGVEnrolledSubjectsRecord.Rows.Count > 0;
            BTNDeleteAllEnrolledSubject.Enabled = DGVEnrolledSubjectsRecord.Rows.Count > 0;
            BTNGrading.Enabled = DGVEnrolledSubjectsRecord.Rows.Count > 0;
        }

        private void LoadGradingSubjectsRecord()
        {
            var repo = new RepositoryStudentGradeFile();
            var studentGrades = repo.GetStudentGradesBySubject(studentId);
            DGVGradingSubjectsRecord.DataSource = studentGrades;
            DGVGradingSubjectsRecord.Refresh();

            // Enable/disable buttons based on row count
            BTNDeleteGradedSubject.Enabled = DGVGradingSubjectsRecord.Rows.Count > 0;
            BTNDeleteAllGradedSubject.Enabled = DGVGradingSubjectsRecord.Rows.Count > 0;
        }

        private void BTNDeleteEnrolledSubject_Click(object sender, EventArgs e)
        {
            if (DGVEnrolledSubjectsRecord.SelectedRows.Count > 0)
            {
                var selectedRow = DGVEnrolledSubjectsRecord.SelectedRows[0];
                string subjectCode = selectedRow.Cells["ENRDFSTUDSUBJCDE"].Value.ToString();
                string edpCode = selectedRow.Cells["ENRDFSTUDEDPCODE"].Value.ToString();

                var result = MessageBox.Show(
                    "Are you sure you want to delete this enrolled subject?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var repo = new RepositoryEnrollmentDetailFile();
                    var deleteResult = repo.DeleteEnrollmentDetail(studentId, subjectCode, edpCode);

                    if (deleteResult.Success)
                    {
                        LoadEnrolledSubjectsRecord(); // Refresh the grid
                        MessageBox.Show("Enrolled subject deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete enrolled subject: {deleteResult.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an enrolled subject to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNDeleteGradedSubject_Click(object sender, EventArgs e)
        {
            if (DGVGradingSubjectsRecord.SelectedRows.Count > 0)
            {
                var selectedRow = DGVGradingSubjectsRecord.SelectedRows[0];
                string subjectCode = selectedRow.Cells["SGFSTUDSUBJCODE"].Value.ToString();
                string edpCode = selectedRow.Cells["SGFSTUDEDPCODE"].Value.ToString();

                var result = MessageBox.Show(
                    "Are you sure you want to delete this graded subject?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var repo = new RepositoryStudentGradeFile();
                    var deleteResult = repo.DeleteStudentGrade(studentId, subjectCode, edpCode);

                    if (deleteResult.Success)
                    {
                        LoadGradingSubjectsRecord(); // Refresh the grid
                        MessageBox.Show("Graded subject deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete graded subject: {deleteResult.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a graded subject to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void BTNDeleteAllEnrolledSubject_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete ALL enrolled subjects? This action cannot be undone.",
                "Confirm Delete All",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var repo = new RepositoryEnrollmentDetailFile();
                var deleteResult = repo.DeleteAllEnrollmentDetails(studentId);

                if (deleteResult.Success)
                {
                    LoadEnrolledSubjectsRecord(); // Refresh the grid
                    MessageBox.Show("All enrolled subjects deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to delete all enrolled subjects: {deleteResult.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTNDeleteAllGradedSubject_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete ALL graded subjects? This action cannot be undone.",
                "Confirm Delete All",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var repo = new RepositoryStudentGradeFile();
                var deleteResult = repo.DeleteAllStudentGrades(studentId);

                if (deleteResult.Success)
                {
                    LoadGradingSubjectsRecord(); // Refresh the grid
                    MessageBox.Show("All graded subjects deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to delete all graded subjects: {deleteResult.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTNGrading_Click(object sender, EventArgs e)
        {
            if (DGVEnrolledSubjectsRecord.SelectedRows.Count > 0)
            {
                var selectedRow = DGVEnrolledSubjectsRecord.SelectedRows[0];
                string subjectCode = selectedRow.Cells["ENRDFSTUDSUBJCDE"].Value.ToString();
                string edpCode = selectedRow.Cells["ENRDFSTUDEDPCODE"].Value.ToString();

                // Check if the subject is already graded
                var gradeRepo = new RepositoryStudentGradeFile();
                var existingGrades = gradeRepo.GetStudentGradesBySubject(studentId);
                bool isAlreadyGraded = existingGrades.Any(grade => 
                    grade.SGFSTUDSUBJCODE == subjectCode && 
                    grade.SGFSTUDEDPCODE == edpCode);

                if (isAlreadyGraded)
                {
                    MessageBox.Show("This subject is already graded. Please delete the existing grade first if you want to update it.", 
                        "Already Graded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var gradingForm = new StudentGradingControl.GradingForm())
                {
                    gradingForm.SubjectCode = subjectCode;
                    if (gradingForm.ShowDialog() == DialogResult.OK)
                    {
                        // Get the grade from the form
                        double grade = double.Parse(gradingForm.Grade);
                        string remarks = gradingForm.Remarks;

                        try
                        {
                            // Save the grade
                            var repo = new RepositoryStudentGradeFile();
                            var saveResult = repo.SaveStudentGrade(studentId, subjectCode, edpCode, grade, remarks);

                            if (saveResult.Success)
                            {
                                LoadGradingSubjectsRecord(); // Refresh the grading grid
                                MessageBox.Show("Grade saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Failed to save grade: {saveResult.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while saving the grade: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to grade.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
