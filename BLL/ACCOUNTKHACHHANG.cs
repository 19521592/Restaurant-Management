using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
using System.Data;
using Restaurant_Management.DTO;
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
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { id, userName, pass });
            return (rs > 0);
        }
        public CustomerAccDTO getAccDTO(string id)
        {
            string query = "SELECT * FROM ACCOUNTKHACHHANG WHERE MAKH = @MAKH ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { id });
            if (rs.Rows.Count == 0) return null;

            CustomerAccDTO p = new CustomerAccDTO();
            p.MaKH = id;
            p.UserName = rs.Rows[0][1].ToString();
            p.PassWords = rs.Rows[0][2].ToString();
            return p;
        }
        public bool UpdatePassWords(string ID, string NewPass)
        {
            string UpPassQuery = "UPDATE ACCOUNTKHACHHANG SET PASSWORDS = @NewPass WHERE MAKH =  @ID ";
            int rs = Provider.Ins.ExcuteNonQuery(UpPassQuery, new object[]{
            NewPass,ID});
            return (rs > 0);
        }
    }
}
