namespace Pepito_Appsdev_Finals.Controller.StudentGradingControl
{
    partial class GradingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ControlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TBGrade = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBSubjectCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBRemarks = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BTNCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.ControlPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ControlPanel.Controls.Add(this.guna2ControlBox1);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(500, 51);
            this.ControlPanel.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(458, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.TBSubjectCode);
            this.flowLayoutPanel1.Controls.Add(this.TBRemarks);
            this.flowLayoutPanel1.Controls.Add(this.TBGrade);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 114);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(375, 138);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // TBGrade
            // 
            this.TBGrade.Animated = true;
            this.TBGrade.BackColor = System.Drawing.Color.Transparent;
            this.TBGrade.BorderRadius = 15;
            this.TBGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBGrade.CustomizableEdges.BottomLeft = false;
            this.TBGrade.CustomizableEdges.TopRight = false;
            this.TBGrade.DefaultText = "";
            this.TBGrade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBGrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBGrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBGrade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBGrade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TBGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBGrade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBGrade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBGrade.Location = new System.Drawing.Point(5, 97);
            this.TBGrade.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TBGrade.Name = "TBGrade";
            this.TBGrade.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TBGrade.PlaceholderText = "Grade";
            this.TBGrade.SelectedText = "";
            this.TBGrade.ShadowDecoration.Color = System.Drawing.Color.White;
            this.TBGrade.ShadowDecoration.Depth = 20;
            this.TBGrade.Size = new System.Drawing.Size(365, 36);
            this.TBGrade.TabIndex = 3;
            this.TBGrade.TextChanged += new System.EventHandler(this.TBGrade_TextChanged);
            // 
            // TBSubjectCode
            // 
            this.TBSubjectCode.Animated = true;
            this.TBSubjectCode.BackColor = System.Drawing.Color.Transparent;
            this.TBSubjectCode.BorderRadius = 15;
            this.TBSubjectCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBSubjectCode.CustomizableEdges.BottomLeft = false;
            this.TBSubjectCode.CustomizableEdges.TopRight = false;
            this.TBSubjectCode.DefaultText = "";
            this.TBSubjectCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBSubjectCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBSubjectCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSubjectCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSubjectCode.Enabled = false;
            this.TBSubjectCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TBSubjectCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSubjectCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBSubjectCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBSubjectCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSubjectCode.Location = new System.Drawing.Point(5, 5);
            this.TBSubjectCode.Margin = new System.Windows.Forms.Padding(0);
            this.TBSubjectCode.Name = "TBSubjectCode";
            this.TBSubjectCode.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TBSubjectCode.PlaceholderText = "Subject Code";
            this.TBSubjectCode.SelectedText = "";
            this.TBSubjectCode.ShadowDecoration.Color = System.Drawing.Color.White;
            this.TBSubjectCode.ShadowDecoration.Depth = 20;
            this.TBSubjectCode.Size = new System.Drawing.Size(365, 36);
            this.TBSubjectCode.TabIndex = 2;
            // 
            // TBRemarks
            // 
            this.TBRemarks.Animated = true;
            this.TBRemarks.BackColor = System.Drawing.Color.Transparent;
            this.TBRemarks.BorderRadius = 15;
            this.TBRemarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBRemarks.CustomizableEdges.BottomLeft = false;
            this.TBRemarks.CustomizableEdges.TopRight = false;
            this.TBRemarks.DefaultText = "";
            this.TBRemarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBRemarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBRemarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBRemarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBRemarks.Enabled = false;
            this.TBRemarks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TBRemarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBRemarks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBRemarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBRemarks.Location = new System.Drawing.Point(5, 51);
            this.TBRemarks.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TBRemarks.Name = "TBRemarks";
            this.TBRemarks.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TBRemarks.PlaceholderText = "Remarks";
            this.TBRemarks.SelectedText = "";
            this.TBRemarks.ShadowDecoration.Color = System.Drawing.Color.White;
            this.TBRemarks.ShadowDecoration.Depth = 20;
            this.TBRemarks.Size = new System.Drawing.Size(365, 36);
            this.TBRemarks.TabIndex = 6;
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
            this.BTNSave.Location = new System.Drawing.Point(183, 288);
            this.BTNSave.Margin = new System.Windows.Forms.Padding(0);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(115, 36);
            this.BTNSave.TabIndex = 8;
            this.BTNSave.Text = "Save";
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.Animated = true;
            this.BTNCancel.BorderRadius = 10;
            this.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BTNCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BTNCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancel.ForeColor = System.Drawing.Color.White;
            this.BTNCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTNCancel.Image = global::Pepito_Appsdev_Finals.Properties.Resources.cancel;
            this.BTNCancel.Location = new System.Drawing.Point(318, 288);
            this.BTNCancel.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(115, 36);
            this.BTNCancel.TabIndex = 9;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // GradingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(500, 359);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GradingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradingForm";
            this.ControlPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel ControlPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox TBSubjectCode;
        private Guna.UI2.WinForms.Guna2TextBox TBGrade;
        private Guna.UI2.WinForms.Guna2TextBox TBRemarks;
        private Guna.UI2.WinForms.Guna2GradientButton BTNSave;
        private Guna.UI2.WinForms.Guna2GradientButton BTNCancel;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}