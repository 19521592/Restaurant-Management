using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DTO;
using Restaurant_Management.BLL;
using Restaurant_Management.GUI.CustomNofication;
namespace Restaurant_Management.GUI.ManagerStaff
{
    public partial class StaffItem : UserControl
    {        
        public StaffItem()
        {
            InitializeComponent();      
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lbID.Text;
            bool rs = NhanVien.Ins.Delete(id);
            if (rs = true)
            {
                Form_Alert.Alert("Xóa thành công!", Form_Alert.enmType.Success);
            }               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuaNhanVien form = new SuaNhanVien(lbID.Text);
            form.ShowDialog();
        }
    }
}
