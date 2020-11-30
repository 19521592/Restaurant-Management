using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DTO;
using Restaurant_Management.BLL;
namespace Restaurant_Management.GUI.ManagerStaff
{
    public partial class QuanLyNhanVien : Form
    {
        List<staffDTO> listDTO;
        public QuanLyNhanVien()
        {
            InitializeComponent();          
        }   

        public void Staff_Load()
        {
            listDTO = NhanVien.Ins.getListDTO();
            StaffItem item;
            for (int i = 0; i < listDTO.Count; i++)
            {
                item = new StaffItem();
                item.lbID.Text = listDTO[i].Id;
                item.lbName.Text = listDTO[i].Hoten;
                item.lbPhone.Text = listDTO[i].Sdt;
                item.lbSex.Text = listDTO[i].Gtinh;
                item.lbCHUC.Text = listDTO[i].Vitri;
                item.pictureBox1.Image = NhanVien.Ins.ByteToImg(listDTO[i].ImgStr);
                if (i % 2 == 0)
                {
                    item.BackColor = Color.AliceBlue;
                }
                else
                {
                    item.BackColor = Color.LightBlue;
                }
                this.DataPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
            }
            lbCount.Text = listDTO.Count.ToString();
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            Staff_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNhanVien form = new ThemNhanVien();
            form.ShowDialog();
            DataPanel.Controls.Clear();
            QuanLyNhanVien_Load(sender, e);
        }


    }
}
