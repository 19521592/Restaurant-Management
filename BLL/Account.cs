using Restaurant_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    case "False":
                        return TypeAcc.Staff;
                        break;
                    case "True":
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

        //public bool Register(TypeAcc aType)
        //{
        //    string query = "select * from ACCOUNT where username = @username and pass = @pass ;";
        //    DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { userName, passWords});
        //    if (rs.Rows.Count > 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        //    string query = 
        //        return true;
        //    }
        //}
    }
}
