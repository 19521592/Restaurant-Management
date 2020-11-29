using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.BLL;
using Restaurant_Management.GUI.CustomNofication;

namespace Restaurant_Management.GUI.Table

{
    public partial class BanAn : Form
    {
        IDictionary<string, Ban> listTable { get; set; }
        Ban selectingTable;
        public Ban selectedTable { get; set; }
        public BanAn()
        {
            InitializeComponent();
            loadTableIntoFlowLayoutPanel();
            btnPay.Visible = false;
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
                    btnSelectTable.Visible = false;
                    break;
                case "False":
                    this.lblTableStatus.Text = "Trống";
                    btnPay.Visible = false;
                    btnSelectTable.Visible = true;
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
                this.selectedTable = this.selectingTable;
                Form_Alert.Alert("Thêm bàn thành công!", Form_Alert.enmType.Success);
                BANAN.Ins.setTableStatus(selectingTable.tableId, "1");
                this.Close();
                //this.ParentForm.Focus();
            }
            else
            {
                Form_Alert.Alert("Thêm bàn thất bại!", Form_Alert.enmType.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Form_Alert.Alert("Thanh toán thành công!", Form_Alert.enmType.Success);
            BANAN.Ins.setTableStatus(selectingTable.tableId, "0");
            loadTableIntoFlowLayoutPanel();
        }
    }
}
