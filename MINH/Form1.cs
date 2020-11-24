using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.MINH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = BLL.NhanVien.Ins.getList();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            DTO.nhanvienDTO rs = BLL.NhanVien.Ins.getNV(id);
            richTextBox1.Text += rs.Hoten;
            richTextBox1.Text += rs.Ngsinh.Day + "/" + rs.Ngsinh.Month + "/" + rs.Ngsinh.Year;
            richTextBox1.Text += rs.Dchi;
            richTextBox1.Text += rs.Cmnd;
            richTextBox1.Text += rs.Gtinh;
            richTextBox1.Text += rs.Vitri;
            pictureBox1.Image = BLL.NhanVien.Ins.ByteToImg(rs.ImgStr);

        }
    }
}
