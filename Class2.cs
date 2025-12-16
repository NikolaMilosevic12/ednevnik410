using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Ednevnik410b
{
    internal class konekcija
    {
        public static SqlConnection povezi()
        {
            string cs;
            cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            SqlConnection rezultat = new SqlConnection(cs);
            return rezultat;
        }
    }
}