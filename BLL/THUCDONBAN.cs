using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
namespace Restaurant_Management.BLL
{
    class THUCDONBAN
    {
        private static THUCDONBAN ins;
        public static THUCDONBAN Ins
        {
            get { if (ins == null) ins = new THUCDONBAN(); return ins; }
            private set { ins = value; }
        }
        private THUCDONBAN() {  }

        public bool ThemMon(string idBANAN, string idMONAN, int soluong)
        {
            string query = "INSERT INTO THUCDONBAN VALUES( @idBANAN , @idMONAN , @soluong );";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { idBANAN, idMONAN, soluong });
            return (rs > 0);
        }
        public bool XoaMon(string idBANAN, string idMONAN)
        {
            string query = "DELETE THUCDONBAN WHERE ID = @idBANAN AND IDMONAN = @idMONAN";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { idBANAN, idMONAN });
            return (rs > 0);
        }

        public bool XoaAllMonTheoBanAn(string idBANAN)
        {
            string query = "DELETE THUCDONBAN WHERE ID = @idBANAN ";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { idBANAN });
            return (rs > 0);
        }
    }
}
