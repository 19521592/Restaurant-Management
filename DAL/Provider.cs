using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAL
{
    class Provider
    {      
        private static Provider ins;
        public static Provider Ins
        {
            get { if (ins == null) ins = new Provider(); return ins; }
            private set { ins = value; }
        }
        private Provider() { }

        public int ExcuteNonQuery(string query, object[] param = null)
        {
            string connStr = @"Server=DESKTOP-ALSR012;Database=Restaurent;User Id=sa;Password=14725836;";
            SqlConnection connection = new SqlConnection(connStr);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            if (param == null)
            {
                int result = cmd.ExecuteNonQuery();
                connection.Close();
                return result;
            }
            else
            {
                string[] listParam = query.Split(' ');
                int i = -1;
                foreach(string item in listParam)
                {
                    if (item.Contains('@'))
                    {
                        i++;
                        cmd.Parameters.AddWithValue(item, param[i]);
                    }
                }
                int result = cmd.ExecuteNonQuery();
                connection.Close();
                return result;
            }
         
        }

        public DataTable ExcuteQuery(string query, object[] param = null)
        {
            string connStr = @"Server=DESKTOP-ALSR012;Database=Restaurent;User Id=sa;Password=14725836;";
            DataTable data = new DataTable();

            SqlConnection connection = new SqlConnection(connStr);
            connection.Open();

            if (param == null)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);              
            }
            else
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                string[] listParam = query.Split(' ');
                int i = -1;
                foreach (string item in listParam)
                {
                    if (item.Contains('@'))
                    {
                        i++;
                        cmd.Parameters.AddWithValue(item, param[i]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);              
            }
            connection.Close();
            return data;
        }
    }
}
