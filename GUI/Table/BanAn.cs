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
using Restaurant_Management.BLL;
using Restaurant_Management.GUI.CustomNofication;

namespace Restaurant_Management.GUI.Table

{
    public partial class BanAn : Form
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
        IDictionary<string, Ban> listTable { get; set; }
        Ban selectingTable;
        public CustomerOrderForm ParentForm { get; set; }
        public Ban selectedTable { get; set; }
        public BanAn(Ban selectedTable = null, CustomerOrderForm orderForm = null)
        {
            this.ParentForm = orderForm;
            InitializeComponent();
            loadTableIntoFlowLayoutPanel();
            btnPay.Visible = false;
            this.selectedTable = selectedTable;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
            btnPay.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPay.Width, btnPay.Height, 10, 10));
            btnSelectTable.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSelectTable.Width, btnSelectTable.Height, 10, 10));
        }
        public void loadTableIntoFlowLayoutPanel()
        {
            this.flpnlTable.Controls.Clear();
            DataTable listTable = BANAN.Ins.getListTable();
            this.listTable = new Dictionary<string, Ban>();
            foreach (DataRow table in listTable.Rows)
            {
                string tableId = table[0].ToString();
                string tableName = table[1].ToString();
                string tableStatus = table[2].ToString();
                Ban tableItem = new Ban(tableId, tableName, tableStatus, this);
                this.listTable.Add(tableId, tableItem);
                flpnlTable.Controls.Add(tableItem);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void updateTableInfo(Ban table)
        {
            this.lblTableName.Text = table.tableName;
            switch(table.tableStatus)
            {
                case "True":
                    this.lblTableStatus.Text = "Đã có khách";
                    btnPay.Visible = true;
                    btnPay.Text = "Thanh toán";
                    if (this.ParentForm != null)
                    {
                        btnSelectTable.Visible = true;
                        btnSelectTable.Text = "Thêm món";
                    }
                    else
                    {
                        btnPay.Text = "Xem món";
                        btnSelectTable.Visible = false;
                    }
                    break;
                case "False":
                    if (this.ParentForm == null)
                    {
                        btnSelectTable.Visible = false;
                    }
                    else
                    {
                        btnSelectTable.Text = "Chọn món";
                        btnSelectTable.Visible = true;
                    }
                    btnPay.Visible = false;
                    this.lblTableStatus.Text = "Trống";
                    break;
                default:
                    this.lblTableStatus.Text = "Đang được đặt";
                    btnPay.Visible = false;
                    btnSelectTable.Visible = false;
                    break;
            }
            foreach (var control in this.flpnlTable.Controls)
            {
                (control as Ban).BackColor = Color.White;
            }
            this.selectingTable = table;
        }

        private void btnSelectTable_Click(object sender, EventArgs e)
        {
            if (this.lblTableStatus.Text == "Trống")
            {
                if (selectedTable != null)
                {
                    BANAN.Ins.setTableStatus(selectedTable.tableId, "0");
                }
                this.selectedTable = this.selectingTable;
                Form_Alert.Alert("Thêm bàn thành công!", Form_Alert.enmType.Success);
                BANAN.Ins.setTableStatus(selectingTable.tableId, "");
                this.Close();
            }
            else if (this.lblTableStatus.Text == "Đã có khách")
            {
                this.selectedTable = this.selectingTable;
                this.Close();
            }
            else
            {
                Form_Alert.Alert("Thêm bàn thất bại!", Form_Alert.enmType.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            ThanhToanBan thanhToan = new ThanhToanBan(selectingTable, this.ParentForm);
            thanhToan.ShowDialog();
            thanhToan.Focus();
            this.Close();
        }
        public void showPanelInfo()
        {
            this.pnlInfo.Visible = true;
        }
        private void closePanelInfo()
        {
            this.pnlInfo.Visible = false;
        }

        private void btnCloseInfo_Click(object sender, EventArgs e)
        {
            closePanelInfo();
        }
    }
}
