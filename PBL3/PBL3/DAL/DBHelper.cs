using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DBHelper
    {
        private SqlConnection cnn;
        private static DBHelper _Instance;
        private string connectionSTR = @"Data Source=BI\SQLEXPRESS;Initial Catalog=QuanLyBanGiay;Integrated Security=True";

        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=BI\SQLEXPRESS;Initial Catalog=QuanLyBanGiay;Integrated Security=True";
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }

        private DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void excuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetReCords(string query)
        {
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(data);
            cnn.Close();
            return data;
        }
        public object ExcuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR)) //dùng using để nếu có bị lỗi thì dữ liệu bên trong cũng đc giải phóng
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR)) //dùng using để nếu có bị lỗi thì dữ liệu bên trong cũng đc giải phóng
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
    }
}
