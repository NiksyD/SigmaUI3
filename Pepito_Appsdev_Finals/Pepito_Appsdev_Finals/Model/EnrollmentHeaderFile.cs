using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_Appsdev_Finals.Models
{
    public class EnrollmentHeaderFile
    {
        public string ENRHFSTUDENCODER { get; set; } // Max 15 chars
        public DateTime ENRHFSTUDDATEENROLL { get; set; } 
        public double ENRHFSTUDTOTALUNITS { get; set; }
        public string ENRHFSTUDSCHLYR { get; set; } //Max 15 chars
        public string ENRHFSTUDSTATUS { get; set; } //Enrolled or Unenrolled
        public long ENRHFSTUDID { get; set; } // Student ID (Primary Key)
    }
}
