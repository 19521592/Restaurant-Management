using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
using System.Data;
namespace Restaurant_Management.BLL
{
    class HOADONBAN
    {
        private static HOADONBAN ins;
        public static HOADONBAN Ins
        {
            get { if (ins == null) ins = new HOADONBAN(); return ins; }
            private set { ins = value; }
        }
        private HOADONBAN() { }
        
        public bool Create(string idBANAN, int discount = 0) 
        {
            int Money = 0;
            string query1 = "SELECT SOLUONG, DONGIA FROM dbo.THUCDONBAN,dbo.MONAN WHERE dbo.THUCDONBAN.ID = @ID AND dbo.THUCDONBAN.IDMONAN = dbo.MONAN.ID";
            DataTable tblMONAN = Provider.Ins.ExcuteQuery(query1, new object[] { idBANAN });
            for (int i=0; i < tblMONAN.Rows.Count; i++)
            {
                Money += int.Parse(tblMONAN.Rows[i][0].ToString()) * int.Parse(tblMONAN.Rows[i][1].ToString()); 
            }
            Money -= (Money * discount) / 100;

            string query = "INSERT INTO HOADONBAN VALUES ( @idBANAN, @TONGTIEN , @DISCOUNT , GETDATE() );";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { idBANAN, Money, discount });
            return (rs > 0);
        }
        public DataTable getList()
        {
            string query = "SELECT * FROM HOADONBAN";
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }
    }
}
