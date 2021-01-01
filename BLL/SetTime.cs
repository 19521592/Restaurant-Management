using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
namespace Restaurant_Management.BLL
{
    class SetTime
    {
        public static void setTimeDMY()
        {
            string query = "SET DATEFORMAT dmy";
            query = "UPDATE KHACHHANG SET HOTEN = 'Khách vãng lai' WHERE MAKH = 'KH001' ";
            int rs = Provider.Ins.ExcuteNonQuery(query);
        }
    }
}
