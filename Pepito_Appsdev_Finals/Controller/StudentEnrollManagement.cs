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
    public partial class StudentEnrollManagement : UserControl
    {
        public StudentEnrollManagement()
        {
            InitializeComponent();
            StudentsRecordReader();
        }

        public void StudentsRecordReader()
        {
            var repo = new RepositoryStudentFile();
            DGVStudents.DataSource = repo.GetStudents();
            DGVStudents.Refresh();
        }
    }
}
