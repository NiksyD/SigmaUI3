namespace Pepito_Appsdev_Finals
{
    partial class Layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.topBar = new System.Windows.Forms.Panel();
            this.NavLinks = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tpStudentDataManagement = new System.Windows.Forms.TabPage();
            this.tpCourseManagement = new System.Windows.Forms.TabPage();
            this.tpCoursePreqManagement = new System.Windows.Forms.TabPage();
            this.tpCourseSchedManagement = new System.Windows.Forms.TabPage();
            this.tpStudentEnrollManagement = new System.Windows.Forms.TabPage();
            this.imageLayout = new System.Windows.Forms.ImageList(this.components);
            this.topBar.SuspendLayout();
            this.NavLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1172, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.topBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.topBar.Controls.Add(this.guna2ControlBox1);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1213, 51);
            this.topBar.TabIndex = 2;
            // 
            // NavLinks
            // 
            this.NavLinks.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.NavLinks.Controls.Add(this.tpHome);
            this.NavLinks.Controls.Add(this.tpStudentDataManagement);
            this.NavLinks.Controls.Add(this.tpCourseManagement);
            this.NavLinks.Controls.Add(this.tpCoursePreqManagement);
            this.NavLinks.Controls.Add(this.tpCourseSchedManagement);
            this.NavLinks.Controls.Add(this.tpStudentEnrollManagement);
            this.NavLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavLinks.ImageList = this.imageLayout;
            this.NavLinks.ItemSize = new System.Drawing.Size(220, 50);
            this.NavLinks.Location = new System.Drawing.Point(0, 51);
            this.NavLinks.Margin = new System.Windows.Forms.Padding(0);
            this.NavLinks.Name = "NavLinks";
            this.NavLinks.SelectedIndex = 0;
            this.NavLinks.Size = new System.Drawing.Size(1213, 732);
            this.NavLinks.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.NavLinks.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.NavLinks.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.NavLinks.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.NavLinks.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.NavLinks.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.NavLinks.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NavLinks.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.NavLinks.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.NavLinks.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NavLinks.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NavLinks.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.NavLinks.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.NavLinks.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.NavLinks.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.NavLinks.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NavLinks.TabButtonSize = new System.Drawing.Size(220, 50);
            this.NavLinks.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NavLinks.TabIndex = 3;
            this.NavLinks.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NavLinks.SelectedIndexChanged += new System.EventHandler(this.NavLinks_SelectedIndexChanged);
            // 
            // tpHome
            // 
            this.tpHome.ImageKey = "home.png";
            this.tpHome.Location = new System.Drawing.Point(224, 4);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(10);
            this.tpHome.Size = new System.Drawing.Size(985, 724);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tpStudentDataManagement
            // 
            this.tpStudentDataManagement.ImageKey = "graduation.png";
            this.tpStudentDataManagement.Location = new System.Drawing.Point(224, 4);
            this.tpStudentDataManagement.Name = "tpStudentDataManagement";
            this.tpStudentDataManagement.Padding = new System.Windows.Forms.Padding(10);
            this.tpStudentDataManagement.Size = new System.Drawing.Size(985, 724);
            this.tpStudentDataManagement.TabIndex = 1;
            this.tpStudentDataManagement.Text = "Student Records";
            this.tpStudentDataManagement.UseVisualStyleBackColor = true;
            // 
            // tpCourseManagement
            // 
            this.tpCourseManagement.ImageKey = "graduate.png";
            this.tpCourseManagement.Location = new System.Drawing.Point(224, 4);
            this.tpCourseManagement.Name = "tpCourseManagement";
            this.tpCourseManagement.Padding = new System.Windows.Forms.Padding(10);
            this.tpCourseManagement.Size = new System.Drawing.Size(985, 724);
            this.tpCourseManagement.TabIndex = 2;
            this.tpCourseManagement.Text = "Course Management";
            this.tpCourseManagement.UseVisualStyleBackColor = true;
            // 
            // tpCoursePreqManagement
            // 
            this.tpCoursePreqManagement.ImageKey = "books.png";
            this.tpCoursePreqManagement.Location = new System.Drawing.Point(224, 4);
            this.tpCoursePreqManagement.Name = "tpCoursePreqManagement";
            this.tpCoursePreqManagement.Padding = new System.Windows.Forms.Padding(10);
            this.tpCoursePreqManagement.Size = new System.Drawing.Size(985, 724);
            this.tpCoursePreqManagement.TabIndex = 3;
            this.tpCoursePreqManagement.Text = "Prerequisite Setup";
            this.tpCoursePreqManagement.UseVisualStyleBackColor = true;
            // 
            // tpCourseSchedManagement
            // 
            this.tpCourseSchedManagement.ImageKey = "calendar.png";
            this.tpCourseSchedManagement.Location = new System.Drawing.Point(224, 4);
            this.tpCourseSchedManagement.Name = "tpCourseSchedManagement";
            this.tpCourseSchedManagement.Padding = new System.Windows.Forms.Padding(10);
            this.tpCourseSchedManagement.Size = new System.Drawing.Size(985, 724);
            this.tpCourseSchedManagement.TabIndex = 4;
            this.tpCourseSchedManagement.Text = "Schedule Planning";
            this.tpCourseSchedManagement.UseVisualStyleBackColor = true;
            // 
            // tpStudentEnrollManagement
            // 
            this.tpStudentEnrollManagement.ImageKey = "open-enrollment.png";
            this.tpStudentEnrollManagement.Location = new System.Drawing.Point(224, 4);
            this.tpStudentEnrollManagement.Name = "tpStudentEnrollManagement";
            this.tpStudentEnrollManagement.Padding = new System.Windows.Forms.Padding(10);
            this.tpStudentEnrollManagement.Size = new System.Drawing.Size(985, 724);
            this.tpStudentEnrollManagement.TabIndex = 5;
            this.tpStudentEnrollManagement.Text = "Enrollment Control";
            this.tpStudentEnrollManagement.UseVisualStyleBackColor = true;
            // 
            // imageLayout
            // 
            this.imageLayout.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLayout.ImageStream")));
            this.imageLayout.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLayout.Images.SetKeyName(0, "graduation.png");
            this.imageLayout.Images.SetKeyName(1, "graduate.png");
            this.imageLayout.Images.SetKeyName(2, "books.png");
            this.imageLayout.Images.SetKeyName(3, "calendar.png");
            this.imageLayout.Images.SetKeyName(4, "open-enrollment.png");
            this.imageLayout.Images.SetKeyName(5, "home.png");
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1213, 783);
            this.Controls.Add(this.NavLinks);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Layout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment System";
            this.Load += new System.EventHandler(this.Layout_Load);
            this.topBar.ResumeLayout(false);
            this.NavLinks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel topBar;
        private Guna.UI2.WinForms.Guna2TabControl NavLinks;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpStudentDataManagement;
        private System.Windows.Forms.TabPage tpCourseManagement;
        private System.Windows.Forms.TabPage tpCoursePreqManagement;
        private System.Windows.Forms.TabPage tpCourseSchedManagement;
        private System.Windows.Forms.TabPage tpStudentEnrollManagement;
        private System.Windows.Forms.ImageList imageLayout;
    }
}

