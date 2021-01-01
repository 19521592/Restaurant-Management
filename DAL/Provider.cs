using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Restaurant_Management.DAL
{
    class Provider
    {      
        private string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        private static Provider ins;
        public static Provider Ins
        {
            get { if (ins == null) ins = new Provider(); return ins; }
            private set { ins = value; }
        }
        private Provider() { }

        public void setConStr(string conStrName)
        {
            this.conStr = ConfigurationManager.ConnectionStrings[conStrName].ConnectionString;
        }

        public bool TestConStr()
        {
            bool isConStrValid = true;
            try
            {
                var con = new SqlConnectionStringBuilder(conStr);

            }   
            catch
            {
                MessageBox.Show(conStr);
                isConStrValid = false;
            }
            return isConStrValid;
        }

        public int ExcuteNonQuery(string query, object[] param = null)
        {          
            SqlConnection connection = new SqlConnection(conStr);
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
            DataTable data = new DataTable();

            SqlConnection connection = new SqlConnection(conStr);
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
