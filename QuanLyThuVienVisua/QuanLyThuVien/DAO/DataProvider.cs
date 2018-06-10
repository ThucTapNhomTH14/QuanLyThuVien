using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        public string connectionSRT = "Data Source=.;Initial Catalog=quan ly thu vien;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter=null)
        {
            // bien data hung ket qua 
            DataTable data = new DataTable();

            using (/*Mo ket noi*/SqlConnection connection = new SqlConnection(connectionSRT))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
               
                //trung gian 
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
                       
            return data;
        }

    // Ham tra ve số trường dữ liệu thỏa mãn
        public int ExecuteNoneQuery(string query, object[] parameter = null)
        {
            // bien data hung ket qua 
            int data = 0;

            using (/*Mo ket noi*/SqlConnection connection = new SqlConnection(connectionSRT))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();                                  
                connection.Close();
            }

            return data;
        }
    
    //Ham tra ve so luong dong
        public object ExecuteScalaQuery(string query, object[] parameter = null)
        {
            // bien data hung ket qua 
            object data = 0;

            using (/*Mo ket noi*/SqlConnection connection = new SqlConnection(connectionSRT))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                

                connection.Close();
            }

            return data;
        }
    }
}
