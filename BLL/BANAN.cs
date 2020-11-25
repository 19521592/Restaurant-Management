using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
using System.Data;
namespace Restaurant_Management.BLL
{
    class BANAN
    {
        private static BANAN ins;
        public static BANAN Ins
        {
            get { if (ins == null) ins = new BANAN(); return ins; }
            private set { ins = value; }
        }
        private BANAN() { }
        //   ID VARCHAR(5) NOT NULL,
        //   IDNHANVIEN VARCHAR(5) NOT NULL,
        //   IDKHACHHANG VARCHAR(5),
        //   IDBAN VARCHAR(5) NOT NULL,
        //   NGBATDAU SMALLDATETIME,
        //   NGKETTHUC SMALLDATETIME,
        private string getIDnext()
        {
            string query = "SELECT ID FROM BANAN";
            DataTable tbl = Provider.Ins.ExcuteQuery(query);
            string res = (tbl.Rows.Count + 1).ToString();
            while (res.Length < 5)
                res = "0" + res;              
            return res;
        }
        public bool Insert(string idNV, string idKH, string idBAN)
        {
            string query = "INSERT INTO BANAN VALUES ( @ID , @IDNHANVIEN , @IDKHACHHANG , @IDBAN , GETDATE() , GETDATE() )";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { this.getIDnext(), idNV, idKH, idBAN });
            return (rs > 0);           
           
        }
        //public DataRow getInfo(string id)
        //{
        //    string query = "SELECT * FROM BANAN WHERE ID = @ID ";
        //    DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { id });
        //    if (rs.Rows.Count > 0)
        //        return rs.Rows[0];
        //    return null;
        //}

    }
}
