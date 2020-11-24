using Restaurant_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;
using Restaurant_Management.DTO;
namespace Restaurant_Management.BLL
{
    class Account
    {
        private static Account ins;
        public static Account Ins
        {
            get { if (ins == null) ins = new Account(); return ins; }
            private set { ins = value; }
        }
        private Account() { }

        //
        public string getMaNVnext()
        {
            string query = "select ID from account";
            DataTable tbl = Provider.Ins.ExcuteQuery(query);
            string res = (tbl.Rows.Count + 1).ToString();
            while (res.Length < 3)
                res = "0" + res;
            res = "NV" + res;
            return res;
        }
        private string GetHashPassword(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        public string Login(accountDTO p)
        {
            string query = "select * from ACCOUNT where username = @username and pass = @pass ;";          
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { p.UserName,p.PassWords});
            if (rs.Rows.Count > 0)
            {
                return rs.Rows[0][3].ToString(); // Loại tài khoản
            }
            else
            {
                return null;
            }
        }
        public bool Insert(accountDTO p, string type)
        {
            string query = "select * from account where username = @username ;";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { p.UserName });
            if (rs.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                string rquery = "insert into account values ( @ID , @UserName , @Pass , @type );";
                int res = Provider.Ins.ExcuteNonQuery(rquery, new object[]{ this.getMaNVnext(), p.UserName, p.PassWords, type });
                return (res > 0);             
            }
        }
        public bool Delete(string ID)
        {
            string delquery = "delete from account where ID = @ID ";
            int rs = Provider.Ins.ExcuteNonQuery(delquery, new object[] { ID });
            return (rs > 0);
        }
        // -- ResetPassWords
        //      null: Không tồn tại account
        //      false: Oldpass không trùng pass hiện tại
        //      true: thành cong.
        public bool UpdatePassWords(string ID, string NewPass)
        {          
            string UpPassQuery = "UPDATE ACCOUNT SET PASS = @NewPass WHERE ID =  @ID ;";
            int rs = Provider.Ins.ExcuteNonQuery(UpPassQuery, new object[]{ NewPass,ID});
            return (rs > 0);
        }
    }
}
