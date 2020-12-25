using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
using Restaurant_Management.DTO;
using System.Data;
namespace Restaurant_Management.BLL
{
    class DANHGIAMONAN
    {
        private static DANHGIAMONAN ins;
        public static DANHGIAMONAN Ins
        {
            get { if (ins == null) ins = new DANHGIAMONAN(); return ins; }
            private set { ins = value; }
        }
        private DANHGIAMONAN() { }

        public string getMaDANHGIAnext()
        {
            string query = "select ID from DANHGIAMONAN";
            DataTable tbl = DAL.Provider.Ins.ExcuteQuery(query);
            string res = (tbl.Rows.Count + 1).ToString();
            while (res.Length < 4)
                res = "0" + res;
            res = "D" + res;
            return res;
        }

        public void Insert(DanhGiaDTO p)
        {
            string query = "INSERT INTO DANHGIAMONAN VALUES ( @ID , @IDKH , @IDMONAN , @NOIDUNG , @SAO )";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { this.getMaDANHGIAnext() , p.Idkhachhang, p.Idmonan, p.Noidung, p.Sao });
        }

        public List<DanhGiaDTO> getList(string idmonan)
        {
            List<DanhGiaDTO> list = new List<DanhGiaDTO>();
            string query = "SELECT ID, IDKHACHHANG, IDMONAN, NOIDUNG, SAO FROM DANHGIAMONAN WHERE IDMONAN = @IDMONAN ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { idmonan });
            DanhGiaDTO dg;
            for (int i =0; i<rs.Rows.Count; i++)
            {
                dg = new DanhGiaDTO();
                dg.Id = rs.Rows[i][0].ToString();
                dg.Idkhachhang = rs.Rows[i][1].ToString();
                dg.Idmonan = rs.Rows[i][2].ToString();
                dg.Noidung = rs.Rows[i][3].ToString();
                dg.Sao = rs.Rows[i][4].ToString();
                list.Add(dg);
            }
            return list;
        }

        public float getAvgStar(string idMonan)
        {
            string query = "SELECT SAO FROM DANHGIAMONAN WHERE IDMONAN = @IDMONAN ";
            DataTable data = Provider.Ins.ExcuteQuery(query, new object[] { idMonan });
            float sum = 0;
            for(int i=0; i < data.Rows.Count; i++)
            {
                sum += int.Parse(data.Rows[i][0].ToString());
            }
            return (data.Rows.Count == 0) ? 0 :(sum / data.Rows.Count);
        }
    }
}
