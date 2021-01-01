using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Restaurant_Management.BUS.Report.ReportForm;

namespace Restaurant_Management.BUS.Report
{
    class ReportTime
    {
        public DateTime startTime;
        public DateTime endTime;
        Time _kindOfTime;
        public List<DateTime> _listTime;
        DateTime createdTime;
        Panel pnlOptionalTime;
        public Time kindOfTime
        {
            get => _kindOfTime;
            set
            {
                switch (value)
                {
                    case Time.Today:
                        addListTimeByNearlyDay(1);
                        break;
                    case Time.SevenDaysLeft:
                        addListTimeByNearlyDay(7);
                        break;
                    case Time.ThisMonth:
                        int daysOfThisMonth = createdTime.Day;
                        addListTimeByNearlyDay(daysOfThisMonth);
                        break;
                    case Time.ThisQuarter:
                        DateTime firstDayOfQuarter = new DateTime(createdTime.Year, (createdTime.Month + 2) / 3, 1);
                        int daysOfThisQuarter = (createdTime - firstDayOfQuarter).Days;
                        addListTimeByNearlyDay(daysOfThisQuarter);
                        break;
                    case Time.Yesterday:
                        addYesterdayToListTime();
                        break;
                    case Time.LastMonth:
                        addLastMonthToListTime();
                        break;
                    case Time.Optional:
                        addOptionalTimeToListTime();
                        break;

                }
                _kindOfTime = value;
            }
        }
        public ReportTime(Time kindOfTime, Panel pnlOptionalTime)
        {
            this.pnlOptionalTime = pnlOptionalTime;
            this._listTime = new List<DateTime>();
            this.createdTime = DateTime.Now;
            this.kindOfTime = kindOfTime;
        }
        public void addListTimeByNearlyDay(int days)
        {
            endTime = createdTime;
            for (int i = 0; i < days; i++)
            {
                _listTime.Add(DateTime.Now.AddDays(-i));
            }
            startTime = _listTime[_listTime.Count - 1].Date;
        }
        public void addYesterdayToListTime()
        {
            DateTime yesterday = DateTime.Now.AddDays(-1);
            _listTime.Add(yesterday);
            startTime = endTime = yesterday;
        }
        public void addLastMonthToListTime()
        {
            DateTime lastMonth = this.createdTime.AddMonths(-1);
            startTime = new DateTime(lastMonth.Year, lastMonth.Month, 1);
            int daysOfLastMonth = DateTime.DaysInMonth(lastMonth.Year, lastMonth.Month);
            endTime = new DateTime(lastMonth.Year, lastMonth.Month, daysOfLastMonth);
            for (int i = 0; i < daysOfLastMonth; i++)
            {
                _listTime.Add(DateTime.Now.AddDays(-i-createdTime.Day)); //Add from the end day of last month
            }
        }
        public void addOptionalTimeToListTime()
        {
            startTime = (pnlOptionalTime.Controls[1] as DateTimePicker).Value;
            endTime = (pnlOptionalTime.Controls[0] as DateTimePicker).Value;   //Easy to get mistake
            DateTime timeItem = startTime;
            for (int i = 0; timeItem <= endTime; i++)
            {
                _listTime.Add(startTime.AddDays(i));
                timeItem = startTime.AddDays(i);
            }
        }
    }
}
