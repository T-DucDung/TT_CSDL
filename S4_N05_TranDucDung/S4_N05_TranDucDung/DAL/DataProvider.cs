using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace S4_N05_TranDucDung.DAL
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }


        private string str = @"Data Source=desktop-cdu70qa;Initial Catalog=Ttcsdl_db;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                conn.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                data = command.ExecuteNonQuery();

                conn.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query)
        {
            object data;

            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                data = command.ExecuteScalar();

                conn.Close();
            }

            return data;
        }
    }
}
