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
using Restaurant_Management.GUI.Login;
namespace Restaurant_Management.BLL
{
    class Account
    {
        public enum TypeAcc
        {
            Admin = 1,
            Staff = 0,
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
            string query = "select * from ACCOUNT where username = @username and passwords = @pass ;";
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
        public bool Insert(string id ,string userName, string pass, TypeAcc atype)
        {
            string query = "INSERT INTO ACCOUNT VALUES( @1 , @2 , @3 , @4 )";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { id, userName, pass, atype });
            return (rs > 0);
            
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
            string UpPassQuery = "UPDATE ACCOUNT SET PASSWORDS = @NewPass WHERE ID =  @ID ;";
            int rs = Provider.Ins.ExcuteNonQuery(UpPassQuery, new object[]{
            NewPass,ID});
            return (rs > 0);
        }
        public string getMaNV(string userName)
        {
            string query = "select ID from account where username = @userName";
            DataTable tbl = Provider.Ins.ExcuteQuery(query, new object[] { userName });
            return tbl.Rows[0][0].ToString();
        }
        public AccountApp getAccount(string id)
        {
            string query = "SELECT USERNAME, PASSWORDS FROM ACCOUNT WHERE ID = @ID ";
            DataTable tmp = Provider.Ins.ExcuteQuery(query, new object[] { id });
            
            if (tmp.Rows.Count == 0) return null;

            AccountApp rs = new AccountApp();
            rs.Username = tmp.Rows[0][0].ToString();
            rs.Passwords = tmp.Rows[0][1].ToString();
            return rs;
            
        }
        public string getUserName(string id)
        {
            string query = "SELECT USERNAME FROM ACCOUNT WHERE ID = @ID ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { id });
            return rs.Rows[0][0].ToString();
        }
        public List<string> getListID()
        {
            List<string> rs = new List<string>();
            string query = "SELECT ID FROM ACCOUNT";
            DataTable tmp = Provider.Ins.ExcuteQuery(query);
            for(int i=0; i < tmp.Rows.Count; i++)
            {
                rs.Add(tmp.Rows[i][0].ToString());
            }
            return rs;
        }
        public List<string> getListStaffID()
        {
            List<string> rs = new List<string>();
            string query = "SELECT ID FROM NHANVIEN WHERE VITRI = N'Nhân viên' AND ACTIVE = 1 AND ID NOT IN (SELECT ID FROM ACCOUNT)";
            DataTable tmp = Provider.Ins.ExcuteQuery(query);
            for (int i = 0; i < tmp.Rows.Count; i++)
            {
                rs.Add(tmp.Rows[i][0].ToString());
            }
            return rs;
        }
        public bool ExistUserName(string userName)
        {
            string query = "SELECT ID FROM ACCOUNT WHERE USERNAME = @USERNAME ";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { userName });
            return (rs > 0);
        }
    }
}
