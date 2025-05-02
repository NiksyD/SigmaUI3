namespace Pepito_Appsdev_Finals.Controller.StudentEnrollmentControl
{
    partial class EnrolledList
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
            this.DGVEnrolledStudentsRecord = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BTNBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BTNDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEnrolledStudentsRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.BTNBack);
            this.guna2GroupBox1.Controls.Add(this.BTNDelete);
            this.guna2GroupBox1.Controls.Add(this.DGVEnrolledStudentsRecord);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(985, 724);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Enrolled Students List";
            // 
            // DGVEnrolledStudentsRecord
            // 
            this.DGVEnrolledStudentsRecord.AllowUserToAddRows = false;
            this.DGVEnrolledStudentsRecord.AllowUserToDeleteRows = false;
            this.DGVEnrolledStudentsRecord.AllowUserToResizeColumns = false;
            this.DGVEnrolledStudentsRecord.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVEnrolledStudentsRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVEnrolledStudentsRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEnrolledStudentsRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVEnrolledStudentsRecord.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVEnrolledStudentsRecord.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVEnrolledStudentsRecord.EnableHeadersVisualStyles = true;
            this.DGVEnrolledStudentsRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DGVEnrolledStudentsRecord.Location = new System.Drawing.Point(62, 169);
            this.DGVEnrolledStudentsRecord.Name = "DGVEnrolledStudentsRecord";
            this.DGVEnrolledStudentsRecord.ReadOnly = true;
            this.DGVEnrolledStudentsRecord.RowHeadersVisible = false;
            this.DGVEnrolledStudentsRecord.Size = new System.Drawing.Size(863, 411);
            this.DGVEnrolledStudentsRecord.TabIndex = 3;
            this.DGVEnrolledStudentsRecord.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVEnrolledStudentsRecord.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVEnrolledStudentsRecord.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVEnrolledStudentsRecord.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVEnrolledStudentsRecord.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVEnrolledStudentsRecord.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DGVEnrolledStudentsRecord.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DGVEnrolledStudentsRecord.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVEnrolledStudentsRecord.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVEnrolledStudentsRecord.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVEnrolledStudentsRecord.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVEnrolledStudentsRecord.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVEnrolledStudentsRecord.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVEnrolledStudentsRecord.ThemeStyle.ReadOnly = true;
            this.DGVEnrolledStudentsRecord.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVEnrolledStudentsRecord.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVEnrolledStudentsRecord.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVEnrolledStudentsRecord.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DGVEnrolledStudentsRecord.ThemeStyle.RowsStyle.Height = 22;
            this.DGVEnrolledStudentsRecord.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVEnrolledStudentsRecord.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // BTNDelete
            // 
            this.BTNDelete.Animated = true;
            this.BTNDelete.BorderRadius = 10;
            this.BTNDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BTNDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BTNDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.ForeColor = System.Drawing.Color.White;
            this.BTNDelete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTNDelete.Image = global::Pepito_Appsdev_Finals.Properties.Resources.bin;
            this.BTNDelete.Location = new System.Drawing.Point(810, 101);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(115, 45);
            this.BTNDelete.TabIndex = 4;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // EnrolledList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "EnrolledList";
            this.Size = new System.Drawing.Size(985, 724);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEnrolledStudentsRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVEnrolledStudentsRecord;
        private Guna.UI2.WinForms.Guna2GradientButton BTNDelete;
        private Guna.UI2.WinForms.Guna2GradientButton BTNBack;
    }
}
