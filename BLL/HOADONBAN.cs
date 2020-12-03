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

            string query = "INSERT INTO HOADONBAN (id, tongtien, ngaythanhtoan) VALUES ( @idBANAN , @TONGTIEN , GETDATE() )";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { idBANAN, Money});
            return (rs > 0);
        }
        public DataTable getList()
        {
            string query = "SELECT * FROM HOADONBAN";
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }

        public DataTable getRevenueChartData(string kindOfChart)
        {
            string query = "";
            switch (kindOfChart)
            {
                case "7 ngày trước":
                    query = "SELECT FORMAT( NGAYTHANHTOAN, 'M') AS N'DATE' , SUM( TONGTIEN ) AS N'MONEY' , COUNT(*) FROM HOADONBAN WHERE ( DATEDIFF( DAY , NGAYTHANHTOAN , GETDATE() ) <= 7 )  GROUP BY FORMAT( NGAYTHANHTOAN , 'M' ) ORDER BY FORMAT( NGAYTHANHTOAN , 'M' ) ";
                    break;
                case "Tháng này":
                    query = "SELECT FORMAT( NGAYTHANHTOAN, 'dd' ) AS N'DATE', SUM( TONGTIEN ) AS N'MONEY' , COUNT(*) FROM HOADONBAN WHERE MONTH(NGAYTHANHTOAN) = MONTH(GETDATE()) GROUP BY FORMAT( NGAYTHANHTOAN , 'dd' ) ORDER BY FORMAT( NGAYTHANHTOAN, 'dd' ) ";
                    break;
                case "Quý":
                    query = "SELECT MONTH(NGAYTHANHTOAN) AS N'DATE', SUM( TONGTIEN ) AS N'MONEY' , COUNT(*) FROM HOADONBAN WHERE YEAR( NGAYTHANHTOAN ) = YEAR( GETDATE() ) AND DATEPART( QUARTER , GETDATE() ) = DATEPART( QUARTER , NGAYTHANHTOAN ) GROUP BY MONTH( NGAYTHANHTOAN ) ORDER BY MONTH( NGAYTHANHTOAN ) ";
                    break;
                case "Năm này":
                    query = "SELECT FORMAT( NGAYTHANHTOAN , 'MM' ) AS N'DATE', SUM( TONGTIEN ) AS N'MONEY' , COUNT(*) FROM HOADONBAN WHERE YEAR( NGAYTHANHTOAN ) = YEAR( GETDATE() ) GROUP BY FORMAT( NGAYTHANHTOAN , 'MM' ) ORDER BY FORMAT( NGAYTHANHTOAN , 'MM' ) ";
                    break;
                case "Các năm":
                    query = "SELECT FORMAT( NGAYTHANHTOAN , 'yyyy' ) AS N'DATE', SUM( TONGTIEN ) AS N'MONEY' , COUNT(*) FROM HOADONBAN GROUP BY FORMAT( NGAYTHANHTOAN , 'yyyy' ) ORDER BY FORMAT( NGAYTHANHTOAN , 'yyyy' ) ";
                    break;
            }
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }

        public DataTable getHoaDonTheoThoiGian(string kindOfTime)
        {
            int day = 0;
            switch (kindOfTime)
            {
                case "7 ngày trước":
                    day = 7;
                    break;
                case "Tháng này":
                    day = 30;
                    break;
                case "Quý":
                    day = 180;
                    break;
                case "Năm này":
                    day = 360;
                    break;
                case "Các năm":
                    day = 69696;
                    break;
            }
            string query = " SELECT BA.ID , NV.HOTEN , TONGTIEN FROM BANAN BA , NHANVIEN NV , HOADONBAN HD WHERE BA.ID = HD.ID AND NV.ID = BA.IDNHANVIEN AND ( DATEDIFF( DAY , HD.NGAYTHANHTOAN , GETDATE() ) <= @day ) ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { day });
            return rs;
        }

    }
}
