namespace Pepito_Appsdev_Finals.Controller.StudentEnrollmentControl
{
    partial class EnrollmentEntry
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BTNBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BTNSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TBID = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBEncoder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DTPCreatedAt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DTPYear = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CBStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LBLUnitsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBSubjectRecords = new System.Windows.Forms.CheckedListBox();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.LBSubjectRecords);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.LBLUnitsCount);
            this.guna2GroupBox1.Controls.Add(this.CBStatus);
            this.guna2GroupBox1.Controls.Add(this.DTPYear);
            this.guna2GroupBox1.Controls.Add(this.DTPCreatedAt);
            this.guna2GroupBox1.Controls.Add(this.CBEncoder);
            this.guna2GroupBox1.Controls.Add(this.TBID);
            this.guna2GroupBox1.Controls.Add(this.BTNSave);
            this.guna2GroupBox1.Controls.Add(this.BTNBack);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(985, 724);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "Enrollment Entry";
            // 
            // BTNBack
            // 
            this.BTNBack.Animated = true;
            this.BTNBack.BorderRadius = 10;
            this.BTNBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTNBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BTNBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBack.ForeColor = System.Drawing.Color.White;
            this.BTNBack.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTNBack.Image = global::Pepito_Appsdev_Finals.Properties.Resources.left_arrow;
            this.BTNBack.ImageSize = new System.Drawing.Size(30, 30);
            this.BTNBack.Location = new System.Drawing.Point(62, 649);
            this.BTNBack.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(115, 45);
            this.BTNBack.TabIndex = 5;
            this.BTNBack.Text = "Back";
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.Animated = true;
            this.BTNSave.BorderRadius = 10;
            this.BTNSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.BTNSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BTNSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BTNSave.ForeColor = System.Drawing.Color.White;
            this.BTNSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTNSave.Image = global::Pepito_Appsdev_Finals.Properties.Resources.floppy_disc;
            this.BTNSave.Location = new System.Drawing.Point(810, 649);
            this.BTNSave.Margin = new System.Windows.Forms.Padding(0);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(115, 45);
            this.BTNSave.TabIndex = 10;
            this.BTNSave.Text = "Save";
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // TBID
            // 
            this.TBID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBID.DefaultText = "";
            this.TBID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBID.Enabled = false;
            this.TBID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TBID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBID.Location = new System.Drawing.Point(62, 89);
            this.TBID.Name = "TBID";
            this.TBID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TBID.PlaceholderText = "Student\'s ID";
            this.TBID.SelectedText = "";
            this.TBID.Size = new System.Drawing.Size(230, 51);
            this.TBID.TabIndex = 11;
            // 
            // CBEncoder
            // 
            this.CBEncoder.BackColor = System.Drawing.Color.Transparent;
            this.CBEncoder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEncoder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CBEncoder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBEncoder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBEncoder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEncoder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CBEncoder.ItemHeight = 45;
            this.CBEncoder.Location = new System.Drawing.Point(381, 89);
            this.CBEncoder.Name = "CBEncoder";
            this.CBEncoder.Size = new System.Drawing.Size(230, 51);
            this.CBEncoder.TabIndex = 12;
            // 
            // DTPCreatedAt
            // 
            this.DTPCreatedAt.Checked = true;
            this.DTPCreatedAt.Enabled = false;
            this.DTPCreatedAt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DTPCreatedAt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DTPCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPCreatedAt.Location = new System.Drawing.Point(62, 171);
            this.DTPCreatedAt.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.DTPCreatedAt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPCreatedAt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPCreatedAt.Name = "DTPCreatedAt";
            this.DTPCreatedAt.Size = new System.Drawing.Size(230, 51);
            this.DTPCreatedAt.TabIndex = 53;
            this.DTPCreatedAt.Value = new System.DateTime(2025, 3, 21, 20, 46, 50, 278);
            // 
            // DTPYear
            // 
            this.DTPYear.Checked = true;
            this.DTPYear.CustomFormat = "yyyy";
            this.DTPYear.Enabled = false;
            this.DTPYear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DTPYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DTPYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPYear.Location = new System.Drawing.Point(62, 252);
            this.DTPYear.Margin = new System.Windows.Forms.Padding(0);
            this.DTPYear.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPYear.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPYear.Name = "DTPYear";
            this.DTPYear.ShowUpDown = true;
            this.DTPYear.Size = new System.Drawing.Size(230, 51);
            this.DTPYear.TabIndex = 60;
            this.DTPYear.Value = new System.DateTime(2025, 3, 21, 12, 12, 43, 953);
            // 
            // CBStatus
            // 
            this.CBStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CBStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CBStatus.ItemHeight = 45;
            this.CBStatus.Location = new System.Drawing.Point(381, 171);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(230, 51);
            this.CBStatus.TabIndex = 61;
            // 
            // LBLUnitsCount
            // 
            this.LBLUnitsCount.AutoSize = true;
            this.LBLUnitsCount.Location = new System.Drawing.Point(868, 588);
            this.LBLUnitsCount.Name = "LBLUnitsCount";
            this.LBLUnitsCount.Size = new System.Drawing.Size(19, 21);
            this.LBLUnitsCount.TabIndex = 64;
            this.LBLUnitsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "Units :";
            // 
            // LBSubjectRecords
            // 
            this.LBSubjectRecords.FormattingEnabled = true;
            this.LBSubjectRecords.Location = new System.Drawing.Point(62, 317);
            this.LBSubjectRecords.Name = "LBSubjectRecords";
            this.LBSubjectRecords.Size = new System.Drawing.Size(863, 268);
            this.LBSubjectRecords.TabIndex = 66;
            // 
            // EnrollmentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "EnrollmentEntry";
            this.Size = new System.Drawing.Size(985, 724);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton BTNBack;
        private Guna.UI2.WinForms.Guna2TextBox TBID;
        private Guna.UI2.WinForms.Guna2GradientButton BTNSave;
        private Guna.UI2.WinForms.Guna2ComboBox CBEncoder;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPCreatedAt;
        private Guna.UI2.WinForms.Guna2ComboBox CBStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLUnitsCount;
        private System.Windows.Forms.CheckedListBox LBSubjectRecords;
    }
}
