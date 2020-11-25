using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class TrangChinh : Form
    {
        public TrangChinh()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            pnlAboutSubMenu.Visible = false;
            pnlAccountSubMenu.Visible = false;
            pnlStatisticsSubMenu.Visible = false;
            pnlManageSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlManageSubMenu);
        }
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlStatisticsSubMenu);
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlAboutSubMenu);
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlAccountSubMenu);
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CustomerOrderForm());
            hideSubMenu();
        }

        private void btnManageFood_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QuanLyMonAn());
            hideSubMenu();
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CustomerOrderForm());
            hideSubMenu();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
