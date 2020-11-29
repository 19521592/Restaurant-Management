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
        public string Insert(string idNV, string idKH, string idBAN)
        {
            int rs;
            string idBanAn = this.getIDnext();
            string query = "INSERT INTO BANAN VALUES ( @ID , @IDNHANVIEN , @IDKHACHHANG , @IDBAN , GETDATE() , GETDATE() )";
            if (idKH == "")
            {
                rs = Provider.Ins.ExcuteNonQuery(query, new object[] { idBanAn, idNV, DBNull.Value, idBAN });
            }
            else
            {
                rs = Provider.Ins.ExcuteNonQuery(query, new object[] { idBanAn, idNV, idKH, idBAN });
            }
            return idBanAn;                   
        }
        public DataRow getInfo(string id)
        {
            string query = "SELECT * FROM BANAN WHERE ID = @ID ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { id });
            if (rs.Rows.Count > 0)
                return rs.Rows[0];
            return null;
        }
        public DataTable getListTable()
        {
            string query = "SELECT * FROM BAN";
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }
        public void setTableStatus(string id, string status)
        {

            string query = "UPDATE BAN SET TINHTRANG = @tableStatus WHERE ID = @id ";
            if (status != "")
            {
                Provider.Ins.ExcuteNonQuery(query, new object[] { status, id });
            }
            else
            {
                Provider.Ins.ExcuteNonQuery(query, new object[] { DBNull.Value, id });
            }
        }

    }
}
