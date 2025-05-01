using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pepito_Appsdev_Finals.Models;
using Pepito_Appsdev_Finals.Repository;

namespace Pepito_Appsdev_Finals.Controller.CourseScheduleControl
{
    public partial class Add : Form
    {
        private readonly RepositorySubjectSched _repository;

        public Add()
        {
            InitializeComponent();
            _repository = new RepositorySubjectSched();
            InitializeComboBoxes();
            InitializeDateTimePickers();
        }

        private void InitializeDateTimePickers()
        {
            // Set format to show only time
            DTPStartTime.Format = DateTimePickerFormat.Time;
            DTPStartTime.ShowUpDown = true;
            DTPStartTime.CustomFormat = "HH:mm:ss";

            DTPEndTime.Format = DateTimePickerFormat.Time;
            DTPEndTime.ShowUpDown = true;
            DTPEndTime.CustomFormat = "HH:mm:ss";
        }

        private void InitializeComboBoxes()
        {
            // Initialize Days combo box
            CBDays.Items.AddRange(new string[] { "MON", "TUE", "WED", "THU", "FRI", "SAT" });
            CBDays.SelectedIndex = 0;

            // Initialize Status combo box
            CBStatus.Items.AddRange(new string[] { "Active", "Inactive", "Dissolved", "Restricted", "Closed" });
            CBStatus.SelectedIndex = 0;

            // Initialize Meridian Time Format combo box
            CBMeridianTimeFormat.Items.AddRange(new string[] { "AM", "PM" });
            CBMeridianTimeFormat.SelectedIndex = 0;
        }

        private string GetStatusCode(string displayStatus)
        {
            switch (displayStatus)
            {
                case "Active":
                    return "ACT";
                case "Inactive":
                    return "INA";
                case "Dissolved":
                    return "DIS";
                case "Restricted":
                    return "RES";
                case "Closed":
                    return "CLD";
                default:
                    return "ACT"; // Default to Active if somehow an invalid status is passed
            }
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(TBEdpCode.Text) ||
                string.IsNullOrWhiteSpace(TBSubjectCode.Text) ||
                string.IsNullOrWhiteSpace(CBDays.Text) ||
                string.IsNullOrWhiteSpace(TBRoom.Text) ||
                string.IsNullOrWhiteSpace(CBStatus.Text) ||
                string.IsNullOrWhiteSpace(CBMeridianTimeFormat.Text) ||
                string.IsNullOrWhiteSpace(TBClassSection.Text) ||
                string.IsNullOrWhiteSpace(DTPYear.Text))
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("Please fill in all required fields.", "Validation Error");
                return;
            }

            // Validate room and section length
            if (TBRoom.Text.Trim().Length > 3)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("Room must be 3 characters or less.", "Validation Error");
                return;
            }

            if (TBClassSection.Text.Trim().Length > 3)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("Class Section must be 3 characters or less.", "Validation Error");
                return;
            }

            // Validate enrolled students count
            if (NUDStudentEnrolledCount.Value > NUDClassMaxSize.Value)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("Number of enrolled students cannot exceed the maximum class size.", "Validation Error");
                return;
            }

            // Check if EDP code already exists
            if (_repository.IsSubjectSchedExists(TBEdpCode.Text.Trim()))
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("EDP Code already exists. Please use a different code.", "Duplicate Entry");
                return;
            }

            // Get the time values
            TimeSpan startTime = DTPStartTime.Value.TimeOfDay;
            TimeSpan endTime = DTPEndTime.Value.TimeOfDay;

            // Validate time range
            if (startTime >= endTime)
            {
                MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                MessageDialog.Show("End time must be greater than start time.", "Validation Error");
                return;
            }

            try
            {
                // Create new schedule object
                var schedule = new SubjectSchedFile
                {
                    SSFEDPCODE = TBEdpCode.Text.Trim(),
                    SSFSUBJCODE = TBSubjectCode.Text.Trim(),
                    SSFSTARTTIME = DateTime.Today.Add(startTime), // Convert TimeSpan to DateTime
                    SSFENDTIME = DateTime.Today.Add(endTime), // Convert TimeSpan to DateTime
                    SSFDAYS = CBDays.Text.Trim(),
                    SSFROOM = TBRoom.Text.Trim(),
                    SSFMAXSIZE = (int)NUDClassMaxSize.Value,
                    SSFCLASSSIZE = (int)NUDStudentEnrolledCount.Value,
                    SSFSTATUS = GetStatusCode(CBStatus.Text.Trim()),
                    SSFXM = CBMeridianTimeFormat.Text.Trim(),
                    SSFSECTION = TBClassSection.Text.Trim(),
                    SSFSCHOOLYEAR = int.Parse(DTPYear.Text.Trim())
                };

                // Check for schedule conflicts
                var existingSchedules = _repository.GetSubjectsSched();
                var hasConflict = existingSchedules.AsEnumerable().Any(row =>
                {
                    var existingStartTime = ((DateTime)row["SSFSTARTTIME"]).TimeOfDay;
                    var existingEndTime = ((DateTime)row["SSFENDTIME"]).TimeOfDay;
                    var existingDays = row["SSFDAYS"].ToString();
                    var existingRoom = row["SSFROOM"].ToString();

                    // Check if there's a time overlap on the same day and room
                    return existingDays == schedule.SSFDAYS &&
                           existingRoom == schedule.SSFROOM &&
                           ((startTime >= existingStartTime && startTime < existingEndTime) ||
                            (endTime > existingStartTime && endTime <= existingEndTime) ||
                            (startTime <= existingStartTime && endTime >= existingEndTime));
                });

                if (hasConflict)
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    MessageDialog.Show("Schedule conflict detected! There is already a class scheduled in this room during the selected time.", "Conflict Error");
                    return;
                }

                // Save to database
                if (_repository.AddSubjectSched(schedule))
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog.Show("Schedule added successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    MessageDialog.Show("Failed to add schedule. Please try again.", "Error");
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
