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

namespace Restaurant_Management.BLL
{
    class Account
    {
        public enum TypeAcc
        {
            Admin = 1,
            Staff = 0
        }
        
        //
        private string userName;
        private string passWords;
        public string UserName { get { return userName; } set { userName = value; } }
        public string PassWords { get { return passWords; } set { passWords = value; } }

        private static Account ins;
        public static Account Ins
        {
            get { if (ins == null) ins = new Account(); return ins; }
            private set { ins = value; }
        }
        private Account() 
        {
            this.userName = "";
            this.passWords = "";
        }
        //
        public string GetHashPassword(string password)
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
        public TypeAcc? Login(string userName = null, string passWords = null)
        {
            string query = "select * from ACCOUNT where username = @username and pass = @pass ;";
            if (userName != null && passWords != null)
            {
                this.userName = userName;
                this.passWords = passWords;
            }
            object[] acc = { this.userName, this.passWords };

            DataTable result = Provider.Ins.ExcuteQuery(query, acc);
            if (result.Rows.Count > 0)
            {
                switch (result.Rows[0][3].ToString()) // 
                {
                    case "Admin":
                        return TypeAcc.Staff;
                        break;
                    case "Staff":
                        return TypeAcc.Admin;
                        break;
                    default:
                        return null;
                        break;
                }
            }
            else
            {
                return null;
            }
        }
        private string getMaNVnext()
        {
            string query = "select ID from account";
            DataTable tbl = Provider.Ins.ExcuteQuery(query);
            string res = (tbl.Rows.Count + 1).ToString();
            while (res.Length < 3)
                res = "0" + res;
            res = "NV" + res;
            return res;
        }
        public bool Insert(TypeAcc atype)
        {
            string query = "select * from account where username = @username and pass = @pass ;";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { userName, passWords });
            if (rs.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                string Rgtquery = "insert into account values ( @ID , @UserName , @Pass , @type );";

                int res = Provider.Ins.ExcuteNonQuery(Rgtquery, new object[]{
                    this.getMaNVnext(), userName, passWords, atype.ToString()});

                if (res > 0)
                    return true;
                else
                    return false;               
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
            int rs = Provider.Ins.ExcuteNonQuery(UpPassQuery, new object[]{
            NewPass,ID});
            return (rs > 0);
        }
    }
}
