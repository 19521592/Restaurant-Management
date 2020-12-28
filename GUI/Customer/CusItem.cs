using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.GUI.Customer
{
    public partial class CusItem : UserControl
    {
        public CusItem()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lbID.Text;
            // bool rs = NhanVien.Ins.Delete(id);
            //if (rs = true)
            //{
            //    Form_Alert.Alert("Xóa thành công!", Form_Alert.enmType.Success);
            //}
            this.Dispose();
        }
    }
}
