using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pepito_Appsdev_Finals.Controller;

namespace Pepito_Appsdev_Finals
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
        }

        public void ShowUserControl(UserControl control, TabPage tabPage)
        {
            if (!tabPage.Controls.Contains(control))

            {
                control.Dock = DockStyle.Fill;
                tabPage.Controls.Add(control);
            }

            control.BringToFront();
        }

        private void NavLinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = NavLinks.SelectedTab;

            if (selectedTab == tpStudentDataManagement)
            {
                ShowUserControl(new StudentDataManagement(), tpStudentDataManagement);
            }
            else if (selectedTab == tpCourseManagement)
            {
                ShowUserControl(new CourseManagement(), tpCourseManagement);
            }
            else if (selectedTab == tpCoursePreqManagement)
            {
                ShowUserControl(new CoursePreqManagement(), tpCoursePreqManagement);
            }
            else if (selectedTab == tpCourseSchedManagement)
            {
                ShowUserControl(new CourseSchedManagement(), tpCourseSchedManagement);
            }
            else if (selectedTab == tpStudentEnrollManagement)
            {
                ShowUserControl(new StudentEnrollManagement(), tpStudentEnrollManagement);
            }
            else if (selectedTab == tpHome)
            {
                ShowUserControl(new Home(), tpHome);
            }
        }

        private void Layout_Load(object sender, EventArgs e)
        {
            ShowUserControl(new Home(), tpHome);
        }
    }
}
