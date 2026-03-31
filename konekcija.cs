using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Ednevnik410b
{
    class konekcija
    {
        public static SqlConnection povezi()
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            return new SqlConnection(cs);
        }
    }
}
