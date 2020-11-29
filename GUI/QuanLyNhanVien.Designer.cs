namespace Restaurant_Management
{
    partial class QuanLyNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStaffList = new System.Windows.Forms.DataGridView();
            this.txtBoxBirth = new System.Windows.Forms.TextBox();
            this.txtBoxGender = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxCMND = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lbQLNV = new System.Windows.Forms.Label();
            this.cbBoxSearchType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlStaffInformation = new System.Windows.Forms.Panel();
            this.lbTTNV = new System.Windows.Forms.Label();
            this.btnDeletePicture = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.openFileDialogStaffPicture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlStaffInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStaffList
            // 
            this.dataGridViewStaffList.AllowUserToAddRows = false;
            this.dataGridViewStaffList.AllowUserToDeleteRows = false;
            this.dataGridViewStaffList.ColumnHeadersHeight = 29;
            this.dataGridViewStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStaffList.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewStaffList.Name = "dataGridViewStaffList";
            this.dataGridViewStaffList.ReadOnly = true;
            this.dataGridViewStaffList.RowHeadersWidth = 51;
            this.dataGridViewStaffList.RowTemplate.Height = 24;
            this.dataGridViewStaffList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStaffList.Size = new System.Drawing.Size(868, 329);
            this.dataGridViewStaffList.TabIndex = 2;
            this.dataGridViewStaffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaffList_CellClick);
            // 
            // txtBoxBirth
            // 
            this.txtBoxBirth.Location = new System.Drawing.Point(284, 139);
            this.txtBoxBirth.Name = "txtBoxBirth";
            this.txtBoxBirth.ReadOnly = true;
            this.txtBoxBirth.Size = new System.Drawing.Size(168, 22);
            this.txtBoxBirth.TabIndex = 2;
            // 
            // txtBoxGender
            // 
            this.txtBoxGender.Location = new System.Drawing.Point(284, 101);
            this.txtBoxGender.Name = "txtBoxGender";
            this.txtBoxGender.ReadOnly = true;
            this.txtBoxGender.Size = new System.Drawing.Size(168, 22);
            this.txtBoxGender.TabIndex = 1;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(284, 62);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.ReadOnly = true;
            this.txtBoxName.Size = new System.Drawing.Size(168, 22);
            this.txtBoxName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, -34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, -69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(284, 217);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.ReadOnly = true;
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(168, 22);
            this.txtBoxPhoneNumber.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "CMND/CCCD";
            // 
            // txtBoxCMND
            // 
            this.txtBoxCMND.Location = new System.Drawing.Point(284, 257);
            this.txtBoxCMND.Name = "txtBoxCMND";
            this.txtBoxCMND.ReadOnly = true;
            this.txtBoxCMND.Size = new System.Drawing.Size(168, 22);
            this.txtBoxCMND.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(284, 176);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.ReadOnly = true;
            this.txtBoxAddress.Size = new System.Drawing.Size(168, 22);
            this.txtBoxAddress.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 209);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(10, 10);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(185, 23);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(270, 10);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(185, 23);
            this.btnDeleteStaff.TabIndex = 1;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Location = new System.Drawing.Point(540, 10);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(185, 23);
            this.btnEditStaff.TabIndex = 2;
            this.btnEditStaff.Text = "Sửa";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnAddStaff);
            this.panel1.Controls.Add(this.btnEditStaff);
            this.panel1.Controls.Add(this.btnDeleteStaff);
            this.panel1.Location = new System.Drawing.Point(162, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(776, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(185, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(510, 22);
            this.txtBoxSearch.TabIndex = 0;
            // 
            // lbQLNV
            // 
            this.lbQLNV.AutoSize = true;
            this.lbQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLNV.Location = new System.Drawing.Point(502, 13);
            this.lbQLNV.Name = "lbQLNV";
            this.lbQLNV.Size = new System.Drawing.Size(367, 46);
            this.lbQLNV.TabIndex = 3;
            this.lbQLNV.Text = "Quản Lý Nhân Viên";
            // 
            // cbBoxSearchType
            // 
            this.cbBoxSearchType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbBoxSearchType.FormattingEnabled = true;
            this.cbBoxSearchType.Items.AddRange(new object[] {
            "Tìm kiếm theo Tên nhân viên",
            "Tìm kiếm theo Số điện thoại"});
            this.cbBoxSearchType.Location = new System.Drawing.Point(557, 3);
            this.cbBoxSearchType.Name = "cbBoxSearchType";
            this.cbBoxSearchType.Size = new System.Drawing.Size(314, 24);
            this.cbBoxSearchType.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewStaffList);
            this.panel2.Controls.Add(this.txtBoxSearch);
            this.panel2.Controls.Add(this.cbBoxSearchType);
            this.panel2.Location = new System.Drawing.Point(12, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 369);
            this.panel2.TabIndex = 2;
            // 
            // pnlStaffInformation
            // 
            this.pnlStaffInformation.Controls.Add(this.lbTTNV);
            this.pnlStaffInformation.Controls.Add(this.btnDeletePicture);
            this.pnlStaffInformation.Controls.Add(this.btnAddPicture);
            this.pnlStaffInformation.Controls.Add(this.pictureBox1);
            this.pnlStaffInformation.Controls.Add(this.label1);
            this.pnlStaffInformation.Controls.Add(this.txtBoxPhoneNumber);
            this.pnlStaffInformation.Controls.Add(this.label7);
            this.pnlStaffInformation.Controls.Add(this.label5);
            this.pnlStaffInformation.Controls.Add(this.label3);
            this.pnlStaffInformation.Controls.Add(this.txtBoxAddress);
            this.pnlStaffInformation.Controls.Add(this.label8);
            this.pnlStaffInformation.Controls.Add(this.txtBoxName);
            this.pnlStaffInformation.Controls.Add(this.label6);
            this.pnlStaffInformation.Controls.Add(this.txtBoxBirth);
            this.pnlStaffInformation.Controls.Add(this.txtBoxCMND);
            this.pnlStaffInformation.Controls.Add(this.label2);
            this.pnlStaffInformation.Controls.Add(this.label4);
            this.pnlStaffInformation.Controls.Add(this.txtBoxGender);
            this.pnlStaffInformation.Location = new System.Drawing.Point(889, 80);
            this.pnlStaffInformation.Name = "pnlStaffInformation";
            this.pnlStaffInformation.Size = new System.Drawing.Size(474, 369);
            this.pnlStaffInformation.TabIndex = 1;
            // 
            // lbTTNV
            // 
            this.lbTTNV.AutoSize = true;
            this.lbTTNV.Location = new System.Drawing.Point(183, 4);
            this.lbTTNV.Name = "lbTTNV";
            this.lbTTNV.Size = new System.Drawing.Size(134, 17);
            this.lbTTNV.TabIndex = 6;
            this.lbTTNV.Text = "Thông tin nhân viên";
            // 
            // btnDeletePicture
            // 
            this.btnDeletePicture.Location = new System.Drawing.Point(92, 280);
            this.btnDeletePicture.Name = "btnDeletePicture";
            this.btnDeletePicture.Size = new System.Drawing.Size(86, 23);
            this.btnDeletePicture.TabIndex = 7;
            this.btnDeletePicture.Text = "Xóa ảnh";
            this.btnDeletePicture.UseVisualStyleBackColor = true;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(5, 280);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(81, 23);
            this.btnAddPicture.TabIndex = 6;
            this.btnAddPicture.Text = "Thêm ảnh";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            // 
            // openFileDialogStaffPicture
            // 
            this.openFileDialogStaffPicture.FileName = "openFileDialog1";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1375, 520);
            this.Controls.Add(this.pnlStaffInformation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbQLNV);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlStaffInformation.ResumeLayout(false);
            this.pnlStaffInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewStaffList;
        private System.Windows.Forms.TextBox txtBoxBirth;
        private System.Windows.Forms.TextBox txtBoxGender;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxCMND;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label lbQLNV;
        private System.Windows.Forms.ComboBox cbBoxSearchType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlStaffInformation;
        private System.Windows.Forms.Label lbTTNV;
        private System.Windows.Forms.Button btnDeletePicture;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialogStaffPicture;
    }
}