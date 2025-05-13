using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_Appsdev_Finals.Models
{
    [Table("EnrollmentDetailFile")]
    public class EnrollmentDetailFile
    {

        [Required, StringLength(2)]
        public string ENRDFSTUDSTATUS { get; set; } // Withdrawn or Cancelled
        [Key, Column(Order = 2)]
        [Required, StringLength(8)]
        public string ENRDFSTUDEDPCODE { get; set; } // EDPCODE (composite key)

        [Key, Column(Order = 1)]
        [Required]
        public long ENRDFSTUDID { get; set; } // Student ID (composite key)

        [Required, StringLength(15)]
        public string ENRDFSTUDSUBJCDE { get; set; }

    }
}
