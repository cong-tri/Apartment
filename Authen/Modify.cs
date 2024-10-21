using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KTDK_CanHo_DaoCongTri.Authen
{
     class Modify
    {
        public Modify() { }

        SqlCommand sqlCommand; //Dung truy van cau lenh unsert update delete
        SqlDataReader dataReader; //Dung doc du lieu trong bang !( string doc trong file)
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connectring.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Command(string query) //Dakii tai khoan
        {
            using (SqlConnection sqlConnection = Connectring.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thuc thi cau truy van 
                sqlConnection.Close();
            }
        }
    }
}

