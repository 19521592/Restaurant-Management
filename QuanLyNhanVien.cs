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

namespace Restaurant_Management
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadStaffData();
            //AddStaffBinding();
        }

        public void AddStaffBinding()
        {
            foreach (var item in pnlStaffInformation.Controls)
            {
                TextBox textbox = item as TextBox;
                if (textbox != null)
                {
                    int columnIndex = textbox.TabIndex + 1; //Column co ID la cot dau tien [0]
                    string columnName = dataGridViewStaffList.Columns[columnIndex].HeaderText;
                    textbox.DataBindings.Add(new Binding("Text", dataGridViewStaffList.DataSource, columnName));
                }
            }
            
        }


        private void LoadStaffData()
        {
           //dataGridViewStaffList.DataSource = BLL.NhanVien.Ins.Display_Datatbl();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }

        private void readOnlyStaffAttribute(bool value)
        {
            txtBoxAddress.ReadOnly = txtBoxBirth.ReadOnly = txtBoxCMND.ReadOnly = 
                txtBoxGender.ReadOnly = txtBoxName.ReadOnly = txtBoxPhoneNumber.ReadOnly = value;
        }
        private void emptyStaffAttribute()
        {
            txtBoxAddress.Text = txtBoxBirth.Text = txtBoxCMND.Text =
                txtBoxGender.Text = txtBoxName.Text = txtBoxPhoneNumber.Text = "";
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (btnAddStaff.Text.CompareTo("Thêm") == 0)
            {
                readOnlyStaffAttribute(false);
                emptyStaffAttribute();
                btnAddStaff.Text = "Xong";
                btnEditStaff.Enabled = false;
                btnDeleteStaff.Enabled = false;
            }
            //else
            //{
            //    NhanVien.Ins.Insert(txtBoxName.Text, txtBoxGender.Text, txtBoxBirth.Text, txtBoxAddress.Text, txtBoxPhoneNumber.Text, txtBoxCMND.Text);
            //    readOnlyStaffAttribute(true);
            //    emptyStaffAttribute();
            //    btnAddStaff.Text = "Thêm";
            //    btnEditStaff.Enabled = true;
            //    btnDeleteStaff.Enabled = true;
            //    LoadStaffData();
            //}

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedStaff = dataGridViewStaffList.SelectedCells;
                if (selectedStaff != null)
                {
                    string staffName = selectedStaff[0].OwningRow.Cells[1].Value.ToString();
                    string staffId = selectedStaff[0].OwningRow.Cells[0].Value.ToString();
                    btnAddStaff.Enabled = false;
                    btnDeleteStaff.Enabled = false;
                    var result = MessageBox.Show(String.Format("Bạn có muốn xóa nhân viên {0} không?", staffName), "Thông báo", MessageBoxButtons.OKCancel);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        NhanVien.Ins.Delete(staffId);
                        readOnlyStaffAttribute(true);
                        emptyStaffAttribute();
                        LoadStaffData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditStaff.Text.CompareTo("Sửa") == 0)
                {
                    readOnlyStaffAttribute(false);
                    btnEditStaff.Text = "Xong";
                    btnAddStaff.Enabled = false;
                    btnDeleteStaff.Enabled = false;
                }
                //else
                //{

                //    NhanVien.Ins.Update(dataGridViewStaffList.SelectedCells[0].OwningRow.Cells[0].Value.ToString(), txtBoxName.Text, txtBoxGender.Text, txtBoxBirth.Text, txtBoxAddress.Text, txtBoxPhoneNumber.Text, txtBoxCMND.Text);
                //    readOnlyStaffAttribute(true);
                //    emptyStaffAttribute();
                //    btnEditStaff.Text = "Sửa";
                //    btnAddStaff.Enabled = true;
                //    btnDeleteStaff.Enabled = true;
                //    LoadStaffData();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewStaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var item in pnlStaffInformation.Controls)
            {
                TextBox textbox = item as TextBox;
                if (textbox != null)
                {
                    int columnIndex = textbox.TabIndex + 1; //Column trong Datasource co ID la cot dau tien [0]
                    textbox.Text = dataGridViewStaffList.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
                }
            }
        }

        private void txtBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxPhoneNumber.Text, "  ^ [0-9]"))
            {
                txtBoxPhoneNumber.Text = "";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
         
        }

        private void txtBoxBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCMND_TextChanged(object sender, EventArgs e)
        {
             if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxCMND.Text, "  ^ [0-9]"))
            {
                txtBoxCMND.Text = "";
            }
        }

        private void txtBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        //private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        //{
            
            
        //}
    }
}
