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

namespace Pepito_Appsdev_Finals.Controller
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            UpdateEnrolledStudentsCount();
        }

        private void UpdateEnrolledStudentsCount()
        {
            var repo = new RepositoryEnrollmentHeaderFile();
            int count = repo.GetTotalEnrolledStudents();
            NumStudentsEnrolled.Text = count.ToString();
        }
    }
}
