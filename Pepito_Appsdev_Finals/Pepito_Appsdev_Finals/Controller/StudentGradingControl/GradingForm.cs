using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Pepito_Appsdev_Finals.Controller.StudentGradingControl
{
    public partial class GradingForm : Form
    {
        private bool isValidGrade = false;
        private string _subjectCode;

        // Add public properties to access the textboxes
        public string Grade => TBGrade.Text;
        public string Remarks => TBRemarks.Text;
        public string SubjectCode
        {
            get => _subjectCode;
            set
            {
                _subjectCode = value;
                TBSubjectCode.Text = value;
            }
        }

        public GradingForm()
        {
            InitializeComponent();
            TBSubjectCode.ReadOnly = true; // Make subject code read-only
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate if subject code is set
                if (string.IsNullOrWhiteSpace(_subjectCode))
                {
                    guna2MessageDialog1.Icon = MessageDialogIcon.Warning;
                    guna2MessageDialog1.Show("Subject code is required.", "Validation Error");
                    return;
                }

                // Validate if grade is entered
                if (string.IsNullOrWhiteSpace(TBGrade.Text))
                {
                    guna2MessageDialog1.Icon = MessageDialogIcon.Warning;
                    guna2MessageDialog1.Show("Please enter a grade.", "Validation Error");
                    return;
                }

                // Validate if grade is a valid number
                if (!double.TryParse(TBGrade.Text, out double grade))
                {
                    guna2MessageDialog1.Icon = MessageDialogIcon.Warning;
                    guna2MessageDialog1.Show("Please enter a valid number for the grade.", "Validation Error");
                    return;
                }

                // Validate grade range (assuming 0-100 scale)
                if (grade < 0 || grade > 100)
                {
                    guna2MessageDialog1.Icon = MessageDialogIcon.Warning;
                    guna2MessageDialog1.Show("Grade must be between 0 and 100.", "Validation Error");
                    return;
                }

                // Check if grade is valid based on remarks
                if (!isValidGrade)
                {
                    guna2MessageDialog1.Icon = MessageDialogIcon.Warning;
                    guna2MessageDialog1.Show("Cannot save an invalid grade.", "Validation Error");
                    return;
                }

                // TODO: Add your database save logic here
                // For example:
                // _studentService.SaveGrade(studentId, grade);

                guna2MessageDialog1.Icon = MessageDialogIcon.Information;
                guna2MessageDialog1.Show("Grade saved successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Icon = MessageDialogIcon.Error;
                guna2MessageDialog1.Show($"An error occurred while saving the grade: {ex.Message}", "Error");
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TBGrade_TextChanged(object sender, EventArgs e)
        {
            // Only allow numbers and decimal point
            if (!string.IsNullOrEmpty(TBGrade.Text))
            {
                // Remove any non-numeric characters except decimal point
                string filteredText = new string(TBGrade.Text.Where(c => char.IsDigit(c) || c == '.').ToArray());
                
                // Ensure only one decimal point
                int decimalCount = filteredText.Count(c => c == '.');
                if (decimalCount > 1)
                {
                    filteredText = filteredText.Substring(0, filteredText.LastIndexOf('.'));
                }

                // Update text if it was changed
                if (filteredText != TBGrade.Text)
                {
                    TBGrade.Text = filteredText;
                    TBGrade.SelectionStart = TBGrade.Text.Length;
                }

                // Update remarks based on grade value
                if (double.TryParse(filteredText, out double grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        if (grade >= 75) // Assuming 75 is the passing grade
                        {
                            TBRemarks.Text = "Passed";
                            isValidGrade = true;
                        }
                        else
                        {
                            TBRemarks.Text = "Failed";
                            isValidGrade = true;
                        }
                    }
                    else
                    {
                        TBRemarks.Text = "Invalid";
                        isValidGrade = false;
                    }
                }
                else
                {
                    TBRemarks.Text = "Invalid";
                    isValidGrade = false;
                }
            }
            else
            {
                TBRemarks.Text = "Invalid";
                isValidGrade = false;
            }
        }
    }
}
