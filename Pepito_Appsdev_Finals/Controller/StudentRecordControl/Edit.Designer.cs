namespace Pepito_Appsdev_Finals.Controller.StudentRecordControl
{
    partial class Edit
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
            this.BTNSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BTNCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TBLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TBYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBRemarks = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CBStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.EditPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.BTNSave.Location = new System.Drawing.Point(193, 547);
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
            this.BTNCancel.Location = new System.Drawing.Point(328, 547);
            this.BTNCancel.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(115, 36);
            this.BTNCancel.TabIndex = 9;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.TBLastName);
            this.flowLayoutPanel1.Controls.Add(this.TBFirstName);
            this.flowLayoutPanel1.Controls.Add(this.TBMiddleName);
            this.flowLayoutPanel1.Controls.Add(this.CBCourse);
            this.flowLayoutPanel1.Controls.Add(this.TBYear);
            this.flowLayoutPanel1.Controls.Add(this.CBRemarks);
            this.flowLayoutPanel1.Controls.Add(this.CBStatus);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(73, 86);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(375, 322);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // TBLastName
            // 
            this.TBLastName.Animated = true;
            this.TBLastName.BackColor = System.Drawing.Color.Transparent;
            this.TBLastName.BorderRadius = 15;
            this.TBLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBLastName.CustomizableEdges.BottomLeft = false;
            this.TBLastName.CustomizableEdges.TopRight = false;
            this.TBLastName.DefaultText = "";
            this.TBLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TBLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBLastName.Location = new System.Drawing.Point(5, 5);
            this.TBLastName.Margin = new System.Windows.Forms.Padding(0);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TBLastName.PlaceholderText = "Last Name";
            this.TBLastName.SelectedText = "";
            this.TBLastName.ShadowDecoration.Color = System.Drawing.Color.White;
            this.TBLastName.ShadowDecoration.Depth = 20;
            this.TBLastName.Size = new System.Drawing.Size(365, 36);
            this.TBLastName.TabIndex = 2;
            // 
            // TBFirstName
            // 
            this.TBFirstName.Animated = true;
            this.TBFirstName.BackColor = System.Drawing.Color.Transparent;
            this.TBFirstName.BorderRadius = 15;
            this.TBFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBFirstName.CustomizableEdges.BottomLeft = false;
            this.TBFirstName.CustomizableEdges.TopRight = false;
            this.TBFirstName.DefaultText = "";
            this.TBFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TBFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBFirstName.Location = new System.Drawing.Point(5, 51);
            this.TBFirstName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TBFirstName.PlaceholderText = "First Name";
            this.TBFirstName.SelectedText = "";
            this.TBFirstName.ShadowDecoration.Color = System.Drawing.Color.White;
            this.TBFirstName.ShadowDecoration.Depth = 20;
            this.TBFirstName.Size = new System.Drawing.Size(365, 36);
            this.TBFirstName.TabIndex = 3;
            // 
            // TBMiddleName
            // 
            this.TBMiddleName.Animated = true;
            this.TBMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.TBMiddleName.BorderRadius = 15;
            this.TBMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBMiddleName.CustomizableEdges.BottomLeft = false;
            this.TBMiddleName.CustomizableEdges.TopRight = false;
            this.TBMiddleName.DefaultText = "";
            this.TBMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBMiddleName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TBMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBMiddleName.Location = new System.Drawing.Point(5, 97);
            this.TBMiddleName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TBMiddleName.Name = "TBMiddleName";
            this.TBMiddleName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TBMiddleName.PlaceholderText = "Middle Name";
            this.TBMiddleName.SelectedText = "";
            this.TBMiddleName.ShadowDecoration.Color = System.Drawing.Color.White;
            this.TBMiddleName.ShadowDecoration.Depth = 20;
            this.TBMiddleName.Size = new System.Drawing.Size(365, 36);
            this.TBMiddleName.TabIndex = 4;
            // 
            // CBCourse
            // 
            this.CBCourse.BackColor = System.Drawing.Color.Transparent;
            this.CBCourse.BorderRadius = 15;
            this.CBCourse.CustomizableEdges.BottomLeft = false;
            this.CBCourse.CustomizableEdges.TopRight = false;
            this.CBCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCourse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CBCourse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CBCourse.ItemHeight = 30;
            this.CBCourse.Location = new System.Drawing.Point(5, 143);
            this.CBCourse.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.CBCourse.Name = "CBCourse";
            this.CBCourse.ShadowDecoration.Color = System.Drawing.Color.White;
            this.CBCourse.ShadowDecoration.Depth = 20;
            this.CBCourse.Size = new System.Drawing.Size(365, 36);
            this.CBCourse.TabIndex = 8;
            // 
            // TBYear
            // 
            this.TBYear.Animated = true;
            this.TBYear.BackColor = System.Drawing.Color.Transparent;
            this.TBYear.BorderRadius = 15;
            this.TBYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBYear.CustomizableEdges.BottomLeft = false;
            this.TBYear.CustomizableEdges.TopRight = false;
            this.TBYear.DefaultText = "";
            this.TBYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBYear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TBYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBYear.Location = new System.Drawing.Point(5, 189);
            this.TBYear.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TBYear.Name = "TBYear";
            this.TBYear.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TBYear.PlaceholderText = "Year";
            this.TBYear.SelectedText = "";
            this.TBYear.ShadowDecoration.Color = System.Drawing.Color.White;
            this.TBYear.ShadowDecoration.Depth = 20;
            this.TBYear.Size = new System.Drawing.Size(365, 36);
            this.TBYear.TabIndex = 6;
            // 
            // CBRemarks
            // 
            this.CBRemarks.BackColor = System.Drawing.Color.Transparent;
            this.CBRemarks.BorderRadius = 15;
            this.CBRemarks.CustomizableEdges.BottomLeft = false;
            this.CBRemarks.CustomizableEdges.TopRight = false;
            this.CBRemarks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRemarks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CBRemarks.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBRemarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBRemarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CBRemarks.ItemHeight = 30;
            this.CBRemarks.Location = new System.Drawing.Point(5, 235);
            this.CBRemarks.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.CBRemarks.Name = "CBRemarks";
            this.CBRemarks.ShadowDecoration.Color = System.Drawing.Color.White;
            this.CBRemarks.ShadowDecoration.Depth = 20;
            this.CBRemarks.Size = new System.Drawing.Size(365, 36);
            this.CBRemarks.TabIndex = 4;
            // 
            // CBStatus
            // 
            this.CBStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBStatus.BorderRadius = 15;
            this.CBStatus.CustomizableEdges.BottomLeft = false;
            this.CBStatus.CustomizableEdges.TopRight = false;
            this.CBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CBStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CBStatus.ItemHeight = 30;
            this.CBStatus.Location = new System.Drawing.Point(5, 281);
            this.CBStatus.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.ShadowDecoration.Color = System.Drawing.Color.White;
            this.CBStatus.ShadowDecoration.Depth = 20;
            this.CBStatus.Size = new System.Drawing.Size(365, 36);
            this.CBStatus.TabIndex = 7;
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.EditPanel.Controls.Add(this.guna2ControlBox1);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditPanel.Location = new System.Drawing.Point(0, 0);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(500, 51);
            this.EditPanel.TabIndex = 6;
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.EditPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MessageDialog
            // 
            this.MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageDialog.Caption = null;
            this.MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.MessageDialog.Parent = this;
            this.MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.MessageDialog.Text = null;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.EditPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton BTNSave;
        private Guna.UI2.WinForms.Guna2GradientButton BTNCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox TBLastName;
        private Guna.UI2.WinForms.Guna2TextBox TBFirstName;
        private Guna.UI2.WinForms.Guna2TextBox TBMiddleName;
        private Guna.UI2.WinForms.Guna2ComboBox CBCourse;
        private Guna.UI2.WinForms.Guna2TextBox TBYear;
        private Guna.UI2.WinForms.Guna2ComboBox CBRemarks;
        private Guna.UI2.WinForms.Guna2ComboBox CBStatus;
        private Guna.UI2.WinForms.Guna2Panel EditPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog;
    }
}