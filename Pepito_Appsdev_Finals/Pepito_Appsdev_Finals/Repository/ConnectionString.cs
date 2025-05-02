using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_Appsdev_Finals.Repository
{
    public static class ConnectionString
    {
        public static string GetConnectionString()
        {
            return "Data Source=NIKOY\\SQLEXPRESS;Initial Catalog=AppsdevEnrollment;Integrated Security=True;Trust Server Certificate=True";
        }
    }
}
