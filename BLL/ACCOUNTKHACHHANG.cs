using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
using System.Data;
namespace Restaurant_Management.BLL
{
    class ACCOUNTKHACHHANG
    {
        private static ACCOUNTKHACHHANG ins;
        public static ACCOUNTKHACHHANG Ins
        {
            get { if (ins == null) ins = new ACCOUNTKHACHHANG(); return ins; }
            private set { ins = value; }
        }
        private ACCOUNTKHACHHANG()
        {
        }
        public bool Exists_UserName(string userName)
        {
            string query = "SELECT MAKH FROM ACCOUNTKHACHHANG WHERE USERNAME = @1";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { userName });
            return (rs.Rows.Count > 0);
        }
        public bool Insert(string id, string userName, string pass)
        {
            string query = "INSERT INTO ACCOUNTKHACHHANG VALUES ( @1 , @2 , @3 )";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { id, userName, pass});
            return (rs > 0);
        }
    }
}
