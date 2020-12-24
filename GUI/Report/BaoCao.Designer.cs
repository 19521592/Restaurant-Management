
using Restaurant_Management.BUS.Report;

namespace Restaurant_Management.GUI.Report
{
    partial class BaoCao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlOptionalTimeApply = new System.Windows.Forms.Panel();
            this.btnOptionalTimeApply = new FontAwesome.Sharp.IconButton();
            this.pnlOptionalTime = new System.Windows.Forms.Panel();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.rdBtn7daysLeft = new System.Windows.Forms.RadioButton();
            this.rdBtnOptinalTime = new System.Windows.Forms.RadioButton();
            this.rdBtnToday = new System.Windows.Forms.RadioButton();
            this.rdBtnThisQuarter = new System.Windows.Forms.RadioButton();
            this.rdBtnYesterday = new System.Windows.Forms.RadioButton();
            this.rdBtnLastMonth = new System.Windows.Forms.RadioButton();
            this.rdBtnThisMonth = new System.Windows.Forms.RadioButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.rdBtnRevenueDetail = new System.Windows.Forms.RadioButton();
            this.rdBtnFoodByStaff = new System.Windows.Forms.RadioButton();
            this.rdBtnRevenueByStaff = new System.Windows.Forms.RadioButton();
            this.rdBtnFoodByCustomer = new System.Windows.Forms.RadioButton();
            this.rdBtnRevenueByCustomer = new System.Windows.Forms.RadioButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlOptionalTimeApply.SuspendLayout();
            this.pnlOptionalTime.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.pnlPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlOptionalTimeApply);
            this.panel3.Controls.Add(this.pnlOptionalTime);
            this.panel3.Controls.Add(this.pnlTime);
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 353);
            this.panel3.TabIndex = 1;
            // 
            // pnlOptionalTimeApply
            // 
            this.pnlOptionalTimeApply.Controls.Add(this.btnOptionalTimeApply);
            this.pnlOptionalTimeApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptionalTimeApply.Location = new System.Drawing.Point(0, 304);
            this.pnlOptionalTimeApply.Name = "pnlOptionalTimeApply";
            this.pnlOptionalTimeApply.Size = new System.Drawing.Size(224, 49);
            this.pnlOptionalTimeApply.TabIndex = 5;
            // 
            // btnOptionalTimeApply
            // 
            this.btnOptionalTimeApply.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnOptionalTimeApply.IconColor = System.Drawing.Color.Black;
            this.btnOptionalTimeApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOptionalTimeApply.IconSize = 36;
            this.btnOptionalTimeApply.Location = new System.Drawing.Point(8, 14);
            this.btnOptionalTimeApply.Name = "btnOptionalTimeApply";
            this.btnOptionalTimeApply.Size = new System.Drawing.Size(210, 23);
            this.btnOptionalTimeApply.TabIndex = 1;
            this.btnOptionalTimeApply.UseVisualStyleBackColor = true;
            this.btnOptionalTimeApply.Visible = false;
            this.btnOptionalTimeApply.Click += new System.EventHandler(this.btnOptionalTimeApply_Click);
            // 
            // pnlOptionalTime
            // 
            this.pnlOptionalTime.Controls.Add(this.dateTimePickerEnd);
            this.pnlOptionalTime.Controls.Add(this.dateTimePickerStart);
            this.pnlOptionalTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptionalTime.Location = new System.Drawing.Point(0, 238);
            this.pnlOptionalTime.Name = "pnlOptionalTime";
            this.pnlOptionalTime.Size = new System.Drawing.Size(224, 66);
            this.pnlOptionalTime.TabIndex = 0;
            this.pnlOptionalTime.Visible = false;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(8, 34);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(210, 22);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(8, 6);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(210, 22);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.rdBtn7daysLeft);
            this.pnlTime.Controls.Add(this.rdBtnOptinalTime);
            this.pnlTime.Controls.Add(this.rdBtnToday);
            this.pnlTime.Controls.Add(this.rdBtnThisQuarter);
            this.pnlTime.Controls.Add(this.rdBtnYesterday);
            this.pnlTime.Controls.Add(this.rdBtnLastMonth);
            this.pnlTime.Controls.Add(this.rdBtnThisMonth);
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTime.Location = new System.Drawing.Point(0, 38);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(224, 200);
            this.pnlTime.TabIndex = 4;
            // 
            // rdBtn7daysLeft
            // 
            this.rdBtn7daysLeft.AutoSize = true;
            this.rdBtn7daysLeft.Location = new System.Drawing.Point(6, 59);
            this.rdBtn7daysLeft.Name = "rdBtn7daysLeft";
            this.rdBtn7daysLeft.Size = new System.Drawing.Size(108, 21);
            this.rdBtn7daysLeft.TabIndex = 2;
            this.rdBtn7daysLeft.TabStop = true;
            this.rdBtn7daysLeft.Text = "7 ngày trước";
            this.rdBtn7daysLeft.UseVisualStyleBackColor = true;
            this.rdBtn7daysLeft.CheckedChanged += new System.EventHandler(this.rdBtnToday_CheckedChanged);
            // 
            // rdBtnOptinalTime
            // 
            this.rdBtnOptinalTime.AutoSize = true;
            this.rdBtnOptinalTime.Location = new System.Drawing.Point(6, 167);
            this.rdBtnOptinalTime.Name = "rdBtnOptinalTime";
            this.rdBtnOptinalTime.Size = new System.Drawing.Size(122, 21);
            this.rdBtnOptinalTime.TabIndex = 2;
            this.rdBtnOptinalTime.TabStop = true;
            this.rdBtnOptinalTime.Tag = Restaurant_Management.BUS.Report.ReportForm.Time.Optional;
            this.rdBtnOptinalTime.Text = "Lựa chọn khác";
            this.rdBtnOptinalTime.UseVisualStyleBackColor = true;
            this.rdBtnOptinalTime.CheckedChanged += new System.EventHandler(this.rdBtnOptionalTime_CheckedChanged);
            // 
            // rdBtnToday
            // 
            this.rdBtnToday.AutoSize = true;
            this.rdBtnToday.Location = new System.Drawing.Point(6, 5);
            this.rdBtnToday.Name = "rdBtnToday";
            this.rdBtnToday.Size = new System.Drawing.Size(85, 21);
            this.rdBtnToday.TabIndex = 2;
            this.rdBtnToday.TabStop = true;
            this.rdBtnToday.Tag = Restaurant_Management.BUS.Report.ReportForm.Time.Today;
            this.rdBtnToday.Text = "Hôm nay";
            this.rdBtnToday.UseVisualStyleBackColor = true;
            this.rdBtnToday.CheckedChanged += new System.EventHandler(this.rdBtnToday_CheckedChanged);
            // 
            // rdBtnThisQuarter
            // 
            this.rdBtnThisQuarter.AutoSize = true;
            this.rdBtnThisQuarter.Location = new System.Drawing.Point(6, 140);
            this.rdBtnThisQuarter.Name = "rdBtnThisQuarter";
            this.rdBtnThisQuarter.Size = new System.Drawing.Size(82, 21);
            this.rdBtnThisQuarter.TabIndex = 2;
            this.rdBtnThisQuarter.TabStop = true;
            this.rdBtnThisQuarter.Tag = Restaurant_Management.BUS.Report.ReportForm.Time.ThisQuarter;
            this.rdBtnThisQuarter.Text = "Quý này";
            this.rdBtnThisQuarter.UseVisualStyleBackColor = true;
            this.rdBtnThisQuarter.CheckedChanged += new System.EventHandler(this.rdBtnToday_CheckedChanged);
            // 
            // rdBtnYesterday
            // 
            this.rdBtnYesterday.AutoSize = true;
            this.rdBtnYesterday.Location = new System.Drawing.Point(6, 32);
            this.rdBtnYesterday.Name = "rdBtnYesterday";
            this.rdBtnYesterday.Size = new System.Drawing.Size(86, 21);
            this.rdBtnYesterday.TabIndex = 2;
            this.rdBtnYesterday.TabStop = true;
            this.rdBtnYesterday.Tag = Restaurant_Management.BUS.Report.ReportForm.Time.ThisQuarter;
            this.rdBtnYesterday.Text = "Hôm qua";
            this.rdBtnYesterday.UseVisualStyleBackColor = true;
            this.rdBtnYesterday.CheckedChanged += new System.EventHandler(this.rdBtnToday_CheckedChanged);
            // 
            // rdBtnLastMonth
            // 
            this.rdBtnLastMonth.AutoSize = true;
            this.rdBtnLastMonth.Location = new System.Drawing.Point(6, 113);
            this.rdBtnLastMonth.Name = "rdBtnLastMonth";
            this.rdBtnLastMonth.Size = new System.Drawing.Size(106, 21);
            this.rdBtnLastMonth.TabIndex = 2;
            this.rdBtnLastMonth.TabStop = true;
            this.rdBtnLastMonth.Tag = Restaurant_Management.BUS.Report.ReportForm.Time.LastMonth;
            this.rdBtnLastMonth.Text = "Tháng trước";
            this.rdBtnLastMonth.UseVisualStyleBackColor = true;
            this.rdBtnLastMonth.CheckedChanged += new System.EventHandler(this.rdBtnToday_CheckedChanged);
            // 
            // rdBtnThisMonth
            // 
            this.rdBtnThisMonth.AutoSize = true;
            this.rdBtnThisMonth.Location = new System.Drawing.Point(6, 86);
            this.rdBtnThisMonth.Name = "rdBtnThisMonth";
            this.rdBtnThisMonth.Size = new System.Drawing.Size(97, 21);
            this.rdBtnThisMonth.TabIndex = 2;
            this.rdBtnThisMonth.TabStop = true;
            this.rdBtnThisMonth.Tag = Restaurant_Management.BUS.Report.ReportForm.Time.ThisMonth;
            this.rdBtnThisMonth.Text = "Tháng này";
            this.rdBtnThisMonth.UseVisualStyleBackColor = true;
            this.rdBtnThisMonth.CheckedChanged += new System.EventHandler(this.rdBtnToday_CheckedChanged);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.label2);
            this.panel15.Controls.Add(this.iconPictureBox2);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(224, 38);
            this.panel15.TabIndex = 3;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 34);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(224, 4);
            this.panel16.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(46, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "LỌC THEO THỜI GIAN";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(8, 6);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 247);
            this.panel2.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.rdBtnRevenueDetail);
            this.panel14.Controls.Add(this.rdBtnFoodByStaff);
            this.panel14.Controls.Add(this.rdBtnRevenueByStaff);
            this.panel14.Controls.Add(this.rdBtnFoodByCustomer);
            this.panel14.Controls.Add(this.rdBtnRevenueByCustomer);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 43);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(224, 204);
            this.panel14.TabIndex = 4;
            // 
            // rdBtnRevenueDetail
            // 
            this.rdBtnRevenueDetail.AutoSize = true;
            this.rdBtnRevenueDetail.Location = new System.Drawing.Point(3, 11);
            this.rdBtnRevenueDetail.Name = "rdBtnRevenueDetail";
            this.rdBtnRevenueDetail.Size = new System.Drawing.Size(140, 21);
            this.rdBtnRevenueDetail.TabIndex = 2;
            this.rdBtnRevenueDetail.TabStop = true;
            this.rdBtnRevenueDetail.Text = "Chi tiết doanh thu";
            this.rdBtnRevenueDetail.UseVisualStyleBackColor = true;
            // 
            // rdBtnFoodByStaff
            // 
            this.rdBtnFoodByStaff.AutoSize = true;
            this.rdBtnFoodByStaff.Location = new System.Drawing.Point(3, 121);
            this.rdBtnFoodByStaff.Name = "rdBtnFoodByStaff";
            this.rdBtnFoodByStaff.Size = new System.Drawing.Size(189, 21);
            this.rdBtnFoodByStaff.TabIndex = 2;
            this.rdBtnFoodByStaff.TabStop = true;
            this.rdBtnFoodByStaff.Text = "Hàng bán theo nhân viên";
            this.rdBtnFoodByStaff.UseVisualStyleBackColor = true;
            // 
            // rdBtnRevenueByStaff
            // 
            this.rdBtnRevenueByStaff.AutoSize = true;
            this.rdBtnRevenueByStaff.Location = new System.Drawing.Point(3, 66);
            this.rdBtnRevenueByStaff.Name = "rdBtnRevenueByStaff";
            this.rdBtnRevenueByStaff.Size = new System.Drawing.Size(193, 21);
            this.rdBtnRevenueByStaff.TabIndex = 2;
            this.rdBtnRevenueByStaff.TabStop = true;
            this.rdBtnRevenueByStaff.Text = "Doanh thu theo nhân viên";
            this.rdBtnRevenueByStaff.UseVisualStyleBackColor = true;
            // 
            // rdBtnFoodByCustomer
            // 
            this.rdBtnFoodByCustomer.AutoSize = true;
            this.rdBtnFoodByCustomer.Location = new System.Drawing.Point(3, 93);
            this.rdBtnFoodByCustomer.Name = "rdBtnFoodByCustomer";
            this.rdBtnFoodByCustomer.Size = new System.Drawing.Size(201, 21);
            this.rdBtnFoodByCustomer.TabIndex = 2;
            this.rdBtnFoodByCustomer.TabStop = true;
            this.rdBtnFoodByCustomer.Text = "Hàng bán theo khách hàng";
            this.rdBtnFoodByCustomer.UseVisualStyleBackColor = true;
            // 
            // rdBtnRevenueByCustomer
            // 
            this.rdBtnRevenueByCustomer.AutoSize = true;
            this.rdBtnRevenueByCustomer.Location = new System.Drawing.Point(3, 38);
            this.rdBtnRevenueByCustomer.Name = "rdBtnRevenueByCustomer";
            this.rdBtnRevenueByCustomer.Size = new System.Drawing.Size(205, 21);
            this.rdBtnRevenueByCustomer.TabIndex = 2;
            this.rdBtnRevenueByCustomer.TabStop = true;
            this.rdBtnRevenueByCustomer.Text = "Doanh thu theo khách hàng";
            this.rdBtnRevenueByCustomer.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel11);
            this.panel13.Controls.Add(this.iconPictureBox1);
            this.panel13.Controls.Add(this.label1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(224, 43);
            this.panel13.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 39);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(224, 4);
            this.panel11.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(224, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1056, 70);
            this.panel4.TabIndex = 1;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(13, 12);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 0;
            this.iconPictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(51, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "BÁO CÁO BÁN HÀNG";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1263, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(17, 530);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(224, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(17, 530);
            this.panel6.TabIndex = 3;
            // 
            // pnlPreview
            // 
            this.pnlPreview.Controls.Add(this.crystalReportViewer);
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Location = new System.Drawing.Point(241, 70);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(1022, 530);
            this.pnlPreview.TabIndex = 4;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1022, 530);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // BaoCao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 600);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCao";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlOptionalTimeApply.ResumeLayout(false);
            this.pnlOptionalTime.ResumeLayout(false);
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.pnlPreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdBtnOptinalTime;
        private System.Windows.Forms.RadioButton rdBtnThisQuarter;
        private System.Windows.Forms.RadioButton rdBtnLastMonth;
        private System.Windows.Forms.RadioButton rdBtnThisMonth;
        private System.Windows.Forms.RadioButton rdBtn7daysLeft;
        private System.Windows.Forms.RadioButton rdBtnYesterday;
        private System.Windows.Forms.RadioButton rdBtnToday;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdBtnRevenueByCustomer;
        private System.Windows.Forms.RadioButton rdBtnRevenueDetail;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Panel pnlOptionalTime;
        private FontAwesome.Sharp.IconButton btnOptionalTimeApply;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.RadioButton rdBtnFoodByStaff;
        private System.Windows.Forms.RadioButton rdBtnRevenueByStaff;
        private System.Windows.Forms.RadioButton rdBtnFoodByCustomer;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel pnlOptionalTimeApply;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}