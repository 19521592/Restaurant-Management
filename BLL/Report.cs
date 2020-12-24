using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;

namespace Restaurant_Management.BLL
{
    class Report
    {
        private static Report ins;
        public static Report Ins
        {
            get { if (ins == null) ins = new Report(); return ins; }
            private set { ins = value; }
        }
        private Report() { }

        public DataTable getDetailRevenueByDate(DateTime time)
        {
            string date = time.ToString("dd/MM/yyyy");
            string query = " SELECT HD.ID AS N'Mã đơn hàng' , FORMAT( HD.NGAYTHANHTOAN , 'HH.mm' ) AS N'Thời gian' , " +
                           " NV.HOTEN AS N'Người bán' , B.TEN AS N'Phòng / Bàn', HD.TONGTIEN AS N'Giá trị' " +
                           " FROM HOADONBAN HD , BANAN BA, BAN B , NHANVIEN NV " +
                           " WHERE HD.ID = BA.ID AND B.ID = BA.IDBAN AND NV.ID = BA.IDNHANVIEN " +
                                 " AND FORMAT(HD.NGAYTHANHTOAN , 'd' , 'en-gb' ) = @date " +
                           " ORDER BY FORMAT(HD.NGAYTHANHTOAN, 'HH.mm') ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { date });
            return rs;
        }

        public DataTable getDetailRevenueBetweenDate(DateTime startTime, DateTime endTime)
        {
            string startTimeString = startTime.ToString();
            string endTimeString = endTime.ToString("d") + " 23:59:59";
            string query = " SELECT HD.ID AS N'Mã đơn hàng' , FORMAT( HD.NGAYTHANHTOAN , 'HH.mm' ) AS N'Thời gian' , " +
                           " NV.HOTEN AS N'Người bán' , B.TEN AS N'Phòng / Bàn', HD.TONGTIEN AS N'Giá trị' , FORMAT(HD.NGAYTHANHTOAN , 'd' , 'en-gb' ) AS N'Ngày bán' " +
                           " FROM HOADONBAN HD , BANAN BA, BAN B , NHANVIEN NV " +
                           " WHERE HD.ID = BA.ID AND B.ID = BA.IDBAN AND NV.ID = BA.IDNHANVIEN " +
                                 " AND HD.NGAYTHANHTOAN BETWEEN CONVERT(smalldatetime, @startTimeString , 104) AND CONVERT(smalldatetime, @endTimeString , 104) " +
                           " ORDER BY FORMAT(HD.NGAYTHANHTOAN, 'HH.mm') ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { startTimeString, endTimeString });
            return rs;
        }
    }
}
