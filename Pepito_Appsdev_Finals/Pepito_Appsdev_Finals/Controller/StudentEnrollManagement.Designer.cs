namespace Pepito_Appsdev_Finals.Controller
{
    partial class StudentEnrollManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DGVStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNEnrolledStudentLIst = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BTNEnrollmentOverview = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BTNEnrollmentEntry = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.DGVStudents);
            this.guna2GroupBox1.Controls.Add(this.flowLayoutPanel1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(985, 724);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Student Enroll Management";
            // 
            // DGVStudents
            // 
            this.DGVStudents.AllowUserToAddRows = false;
            this.DGVStudents.AllowUserToDeleteRows = false;
            this.DGVStudents.AllowUserToResizeColumns = false;
            this.DGVStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStudents.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVStudents.EnableHeadersVisualStyles = true;
            this.DGVStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DGVStudents.Location = new System.Drawing.Point(62, 238);
            this.DGVStudents.Name = "DGVStudents";
            this.DGVStudents.ReadOnly = true;
            this.DGVStudents.RowHeadersVisible = false;
            this.DGVStudents.Size = new System.Drawing.Size(863, 411);
            this.DGVStudents.TabIndex = 3;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVStudents.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DGVStudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DGVStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVStudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVStudents.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVStudents.ThemeStyle.ReadOnly = true;
            this.DGVStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVStudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DGVStudents.ThemeStyle.RowsStyle.Height = 22;
            this.DGVStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.BTNEnrolledStudentLIst);
            this.flowLayoutPanel1.Controls.Add(this.BTNEnrollmentOverview);
            this.flowLayoutPanel1.Controls.Add(this.BTNEnrollmentEntry);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(62, 142);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(863, 45);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BTNEnrolledStudentLIst
            // 
            this.BTNEnrolledStudentLIst.Animated = true;
            this.BTNEnrolledStudentLIst.BorderRadius = 10;
            this.BTNEnrolledStudentLIst.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNEnrolledStudentLIst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNEnrolledStudentLIst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNEnrolledStudentLIst.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNEnrolledStudentLIst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNEnrolledStudentLIst.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(92)))), ((int)(((byte)(97)))));
            this.BTNEnrolledStudentLIst.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BTNEnrolledStudentLIst.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEnrolledStudentLIst.ForeColor = System.Drawing.Color.White;
            this.BTNEnrolledStudentLIst.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTNEnrolledStudentLIst.Image = global::Pepito_Appsdev_Finals.Properties.Resources.task_list;
            this.BTNEnrolledStudentLIst.Location = new System.Drawing.Point(0, 0);
            this.BTNEnrolledStudentLIst.Margin = new System.Windows.Forms.Padding(0);
            this.BTNEnrolledStudentLIst.Name = "BTNEnrolledStudentLIst";
            this.BTNEnrolledStudentLIst.Size = new System.Drawing.Size(273, 45);
            this.BTNEnrolledStudentLIst.TabIndex = 0;
            this.BTNEnrolledStudentLIst.Text = "Enrolled Students List";
            this.BTNEnrolledStudentLIst.Click += new System.EventHandler(this.BTNEnrolledStudentLIst_Click);
            // 
            // BTNEnrollmentOverview
            // 
            this.BTNEnrollmentOverview.Animated = true;
            this.BTNEnrollmentOverview.BorderRadius = 10;
            this.BTNEnrollmentOverview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNEnrollmentOverview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNEnrollmentOverview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNEnrollmentOverview.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNEnrollmentOverview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNEnrollmentOverview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(92)))), ((int)(((byte)(97)))));
            this.BTNEnrollmentOverview.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BTNEnrollmentOverview.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BTNEnrollmentOverview.ForeColor = System.Drawing.Color.White;
            this.BTNEnrollmentOverview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTNEnrollmentOverview.Image = global::Pepito_Appsdev_Finals.Properties.Resources.info;
            this.BTNEnrollmentOverview.Location = new System.Drawing.Point(293, 0);
            this.BTNEnrollmentOverview.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BTNEnrollmentOverview.Name = "BTNEnrollmentOverview";
            this.BTNEnrollmentOverview.Size = new System.Drawing.Size(273, 45);
            this.BTNEnrollmentOverview.TabIndex = 1;
            this.BTNEnrollmentOverview.Text = "Enrollment Overview";
            this.BTNEnrollmentOverview.Click += new System.EventHandler(this.BTNEnrollmentOverview_Click);
            // 
            // BTNEnrollmentEntry
            // 
            this.BTNEnrollmentEntry.Animated = true;
            this.BTNEnrollmentEntry.BorderRadius = 10;
            this.BTNEnrollmentEntry.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNEnrollmentEntry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNEnrollmentEntry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNEnrollmentEntry.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNEnrollmentEntry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNEnrollmentEntry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(92)))), ((int)(((byte)(97)))));
            this.BTNEnrollmentEntry.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BTNEnrollmentEntry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BTNEnrollmentEntry.ForeColor = System.Drawing.Color.White;
            this.BTNEnrollmentEntry.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTNEnrollmentEntry.Image = global::Pepito_Appsdev_Finals.Properties.Resources.document;
            this.BTNEnrollmentEntry.Location = new System.Drawing.Point(586, 0);
            this.BTNEnrollmentEntry.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BTNEnrollmentEntry.Name = "BTNEnrollmentEntry";
            this.BTNEnrollmentEntry.Size = new System.Drawing.Size(277, 45);
            this.BTNEnrollmentEntry.TabIndex = 2;
            this.BTNEnrollmentEntry.Text = "Student Enrollment Form";
            this.BTNEnrollmentEntry.Click += new System.EventHandler(this.BTNEnrollmentEntry_Click);
            // 
            // StudentEnrollManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "StudentEnrollManagement";
            this.Size = new System.Drawing.Size(985, 724);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVStudents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton BTNEnrolledStudentLIst;
        private Guna.UI2.WinForms.Guna2GradientButton BTNEnrollmentOverview;
        private Guna.UI2.WinForms.Guna2GradientButton BTNEnrollmentEntry;
    }
}
