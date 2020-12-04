using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DTO;

namespace Restaurant_Management.GUI.Revenue
{
    public partial class RecentAction : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public RecentAction(string staffName, string tableName, string totalPrice, long time)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.lblInfo.Text = string.Format("{0} vừa thanh toán {1}: {2}đ", staffName, tableName, totalPrice);
            if (time > 1440)
            {
                this.lblTime.Text = string.Format("{0} ngày trước", time / 1440);
            }
            else if (time > 60)
            {
                this.lblTime.Text = string.Format("{0} giờ trước", time / 60);
            }
            else
            {
                this.lblTime.Text = string.Format("{0} phút trước", time);
            }
        }
    }
}
