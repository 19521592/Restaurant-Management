using System;
using System.Data;
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
        public DataTable getStaffRevenueBetweenDate(DateTime startTime, DateTime endTime)
        {
            string startTimeString = startTime.ToString();
            string endTimeString = endTime.ToString("d") + " 23:59:59";
            string query = " SELECT HD.ID AS N'Mã đơn hàng' , FORMAT( HD.NGAYTHANHTOAN , 'HH.mm, dd/MM/yyyy' ) AS N'Ngày bán' , " +
                           " KH.HOTEN AS N'Tên khách hàng', HD.TONGTIEN AS N'Giá trị' , " +
	                       " NV.HOTEN AS N'Nhân viên' "+
                           " FROM HOADONBAN HD , NHANVIEN NV, KHACHHANG KH RIGHT JOIN BANAN BA ON BA.IDKHACHHANG = KH.MAKH " +
                           " WHERE HD.ID = BA.ID  AND NV.ID = BA.IDNHANVIEN " +
                           " AND HD.NGAYTHANHTOAN BETWEEN CONVERT(smalldatetime, @startTimeString , 104) AND CONVERT(smalldatetime, @endTimeString , 104) " +
                           " ORDER BY FORMAT(HD.NGAYTHANHTOAN, 'HH.mm, dd/MM/yyyy') ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { startTimeString, endTimeString });
            return rs;
        }


        public DataTable getFoodListBetweenDate(DateTime startTime, DateTime endTime)
        {
            string startTimeString = startTime.ToString();
            string endTimeString = endTime.ToString("d") + " 23:59:59";
            string query = " SELECT MA.ID AS N'Mã món', MA.TEN AS N'Tên món'  , MA.DONGIA AS N'Giá bán' , SUM(TD.SOLUONG) AS N'Số lượng' , " +
                           " SUM(TD.SOLUONG) * MA.DONGIA AS N'Giá trị' , MA.LOAI AS N'Loại món' " +
                           " FROM MONAN MA , THUCDONBAN TD , HOADONBAN HD , BANAN BA " +
                           " WHERE MA.ID = TD.IDMONAN AND TD.ID = BA.ID AND HD.ID = BA.ID " +
                           " AND HD.NGAYTHANHTOAN BETWEEN CONVERT(smalldatetime, @startTimeString , 104) AND CONVERT(smalldatetime, @endTimeString , 104) " +
                           " GROUP BY MA.ID , MA.TEN , MA.DONGIA , MA.LOAI ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { startTimeString, endTimeString });
            return rs;
        }

        public DataTable getFoodListByStaffBetweenDate(DateTime startTime, DateTime endTime)
        {
            string startTimeString = startTime.ToString();
            string endTimeString = endTime.ToString("d") + " 23:59:59";
            string query = " SELECT MA.ID AS N'Mã món', MA.TEN AS N'Tên món'  , MA.DONGIA AS N'Giá bán' , SUM(TD.SOLUONG) AS N'Số lượng' , " +
                           " SUM(TD.SOLUONG) * MA.DONGIA AS N'Giá trị' , NV.HOTEN AS N'Nhân viên' " +
                           " FROM MONAN MA , THUCDONBAN TD , HOADONBAN HD , BANAN BA , NHANVIEN NV" +
                           " WHERE MA.ID = TD.IDMONAN AND TD.ID = BA.ID AND HD.ID = BA.ID AND NV.ID = BA.IDNHANVIEN " +
                           " AND HD.NGAYTHANHTOAN BETWEEN CONVERT(smalldatetime, @startTimeString , 104) AND CONVERT(smalldatetime, @endTimeString , 104) " +
                           " GROUP BY MA.ID , MA.TEN , MA.DONGIA , NV.HOTEN ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { startTimeString, endTimeString });
            return rs;
        }

        public DataTable getFoodListByCustomerBetweenDate(DateTime startTime, DateTime endTime)
        {
            string startTimeString = startTime.ToString();
            string endTimeString = endTime.ToString("d") + " 23:59:59";
            string query = " SELECT MA.ID AS N'Mã món', MA.TEN AS N'Tên món'  , MA.DONGIA AS N'Giá bán' , SUM(TD.SOLUONG) AS N'Số lượng' , " +
                           " SUM(TD.SOLUONG) * MA.DONGIA AS N'Giá trị' , KH.HOTEN AS N'Khách hàng' " +
                           " FROM MONAN MA , THUCDONBAN TD , HOADONBAN HD , BANAN BA , KHACHHANG KH" +
                           " WHERE MA.ID = TD.IDMONAN AND TD.ID = BA.ID AND HD.ID = BA.ID AND KH.MAKH = BA.IDKHACHHANG " +
                           " AND HD.NGAYTHANHTOAN BETWEEN CONVERT(smalldatetime, @startTimeString , 104) AND CONVERT(smalldatetime, @endTimeString , 104) " +
                           " GROUP BY MA.ID , MA.TEN , MA.DONGIA , KH.HOTEN ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { startTimeString, endTimeString });
            return rs;
        }

        public DataTable getCustomerRevenueBetweenDate(DateTime startTime, DateTime endTime)
        {
            string startTimeString = startTime.ToString();
            string endTimeString = endTime.ToString("d") + " 23:59:59";
            string query = " SELECT KH.MAKH AS N'Mã khách hàng' , KH.HOTEN AS N'Tên khách hàng' , " +
                           " KH.SDT AS N'Điện thoại khách hàng', SUM(HD.TONGTIEN) AS 'Giá trị' " +
                           " FROM HOADONBAN HD , KHACHHANG KH, BANAN BA " +
                           " WHERE HD.ID = BA.ID  AND BA.IDKHACHHANG = KH.MAKH " +
                           " AND HD.NGAYTHANHTOAN BETWEEN CONVERT(smalldatetime, @startTimeString , 104) AND CONVERT(smalldatetime, @endTimeString , 104) " +
                           " GROUP BY KH.MAKH , KH.HOTEN , KH.SDT  ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { startTimeString, endTimeString });
            return rs;
        }
    }
}
