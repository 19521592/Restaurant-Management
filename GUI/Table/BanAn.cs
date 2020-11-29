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
        Ban selectingTable;
        public Ban selectedTable { get; set; }
        public BanAn()
        {
            InitializeComponent();
            loadTableIntoFlowLayoutPanel();
        }
        public void loadTableIntoFlowLayoutPanel()
        {
            DataTable listTable = BANAN.Ins.getListTable();
            foreach (DataRow table in listTable.Rows)
            {
                string tableId = table[0].ToString();
                string tableName = table[1].ToString();
                string tableStatus = table[2].ToString();
                Ban tableItem = new Ban(tableId, tableName, tableStatus, this);
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
                    break;
                case "False":
                    this.lblTableStatus.Text = "Trống";
                    break;
                default:
                    this.lblTableStatus.Text = "Đang được đặt";
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
            }
            else
            {
                Form_Alert.Alert("Thêm bàn thất bại!", Form_Alert.enmType.Error);
            }
        }
    }
}
