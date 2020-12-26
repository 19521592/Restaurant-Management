using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.BUS.Report
{
    class ReportTitle
    {
        public string title;
        public string createdTime;
        public string kindOfTime;
        public ReportTitle(string kindOfReport, ReportTime reportTime)
        {
            this.createdTime = DateTime.Now.ToString("dd/MM/yyyy");
            this.kindOfTime = String.Format("Từ ngày {0} đến ngày {1}",
                 reportTime.startTime.ToString("dd/MM/yyyy"), reportTime.endTime.ToString("dd/MM/yyyy"));
            this.title = kindOfReport;
        }
    }
}
