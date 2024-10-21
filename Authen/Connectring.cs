using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTDK_CanHo_DaoCongTri.Authen
{
     class Connectring
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDSG\IT\CTDLVGT\project\Apartment\AppData\db.mdf;Integrated Security=True";
            public static SqlConnection GetSqlConnection()
            {
                return new SqlConnection(stringConnection);
            }
    }
}
