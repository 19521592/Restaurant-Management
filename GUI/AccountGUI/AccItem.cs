using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.BLL;
using Restaurant_Management.DTO;
using Restaurant_Management.GUI.CustomNofication;
namespace Restaurant_Management.GUI.AccountGUI
{
    public partial class AccItem : UserControl
    {
        public AccItem()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lbID.Text;
            bool rs = Account.Ins.Delete(id);
            if (rs = true)
            {
                Form_Alert.Alert("Xóa thành công!", Form_Alert.enmType.Success);
            }
            this.Dispose();
        }
    }
}
