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
using Restaurant_Management.GUI.ManagerStaff;
using Restaurant_Management.GUI.Login;
using Restaurant_Management.GUI.About;
using Restaurant_Management.GUI.Revenue;

namespace Restaurant_Management
{
    public partial class TrangChinh : Form
    {

        public formLogin ParentForm { get; set; }
        public AccountApp Account { get; set; }

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

        Region normalRegion;
        public TrangChinh(AccountApp account = null, formLogin ParentForm = null)
        {
            this.ParentForm = ParentForm;
            this.Account = account;
            normalRegion = Region;
            this.Controls.Clear();
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 40, 40));
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


        private void btnManageFood_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QuanLyMonAn());
            hideSubMenu();
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CustomerOrderForm(Account.Id));
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
            {
                Region = normalRegion;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                
                WindowState = FormWindowState.Normal;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 40, 40));
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QuanLyNhanVien());
            hideSubMenu();
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new QuanLyNhanVien());
            hideSubMenu();
        }

        private void btnRestaurantInfo_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new NhaHang());
            hideSubMenu();
        }

        private void btnDevInfo_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new deverloper());
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.ParentForm.Show();
            this.ParentForm.Focus();
            this.Close();
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DoanhThu());
            hideSubMenu();
        }
    }
}
