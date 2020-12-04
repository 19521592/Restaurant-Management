
namespace Restaurant_Management.GUI.Revenue
{
    partial class DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblUsingTable = new System.Windows.Forms.Label();
            this.btnUsingTable = new FontAwesome.Sharp.IconButton();
            this.btnBill = new FontAwesome.Sharp.IconButton();
            this.btnRevenue = new FontAwesome.Sharp.IconButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.flpnlActivities = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.flpnlTopFood = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopFood = new System.Windows.Forms.Panel();
            this.cbBoxFood = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbBoxChart = new System.Windows.Forms.ComboBox();
            this.lblRevenueName = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnlTopFood.SuspendLayout();
            this.pnlChart.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 114);
            this.panel1.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.lblTableNumber);
            this.panel15.Controls.Add(this.lblSlash);
            this.panel15.Controls.Add(this.lblBillNumber);
            this.panel15.Controls.Add(this.lblRevenue);
            this.panel15.Controls.Add(this.lblUsingTable);
            this.panel15.Controls.Add(this.btnUsingTable);
            this.panel15.Controls.Add(this.btnBill);
            this.panel15.Controls.Add(this.btnRevenue);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 36);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1280, 78);
            this.panel15.TabIndex = 3;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.BackColor = System.Drawing.Color.White;
            this.lblTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumber.ForeColor = System.Drawing.Color.Crimson;
            this.lblTableNumber.Location = new System.Drawing.Point(1140, 40);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(20, 24);
            this.lblTableNumber.TabIndex = 2;
            this.lblTableNumber.Text = "0";
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.BackColor = System.Drawing.Color.White;
            this.lblSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.ForeColor = System.Drawing.Color.Gold;
            this.lblSlash.Location = new System.Drawing.Point(1118, 40);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(15, 24);
            this.lblSlash.TabIndex = 2;
            this.lblSlash.Text = "/";
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.AutoSize = true;
            this.lblBillNumber.BackColor = System.Drawing.Color.White;
            this.lblBillNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNumber.ForeColor = System.Drawing.Color.Tomato;
            this.lblBillNumber.Location = new System.Drawing.Point(326, 41);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(18, 20);
            this.lblBillNumber.TabIndex = 2;
            this.lblBillNumber.Text = "0";
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.White;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRevenue.Location = new System.Drawing.Point(664, 41);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(108, 24);
            this.lblRevenue.TabIndex = 2;
            this.lblRevenue.Text = "0";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsingTable
            // 
            this.lblUsingTable.AutoSize = true;
            this.lblUsingTable.BackColor = System.Drawing.Color.White;
            this.lblUsingTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsingTable.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUsingTable.Location = new System.Drawing.Point(1096, 40);
            this.lblUsingTable.Name = "lblUsingTable";
            this.lblUsingTable.Size = new System.Drawing.Size(20, 24);
            this.lblUsingTable.TabIndex = 2;
            this.lblUsingTable.Text = "0";
            // 
            // btnUsingTable
            // 
            this.btnUsingTable.BackColor = System.Drawing.Color.White;
            this.btnUsingTable.FlatAppearance.BorderSize = 0;
            this.btnUsingTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsingTable.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUsingTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnUsingTable.IconColor = System.Drawing.Color.Gold;
            this.btnUsingTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsingTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsingTable.Location = new System.Drawing.Point(905, 16);
            this.btnUsingTable.Name = "btnUsingTable";
            this.btnUsingTable.Size = new System.Drawing.Size(280, 49);
            this.btnUsingTable.TabIndex = 1;
            this.btnUsingTable.Text = "ĐANG SỬ DỤNG";
            this.btnUsingTable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUsingTable.UseVisualStyleBackColor = false;
            this.btnUsingTable.Click += new System.EventHandler(this.btnUsingTable_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.White;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBill.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnBill.IconColor = System.Drawing.Color.Tomato;
            this.btnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(92, 16);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(280, 49);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "HÓA ĐƠN";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.White;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnRevenue.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.Location = new System.Drawing.Point(501, 16);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(280, 49);
            this.btnRevenue.TabIndex = 1;
            this.btnRevenue.Text = "DOANH THU";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRevenue.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1280, 36);
            this.panel14.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng quan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(995, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 486);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.pnlAction);
            this.panel4.Controls.Add(this.panel18);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 242);
            this.panel4.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.flpnlActivities);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 47);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(272, 195);
            this.panel13.TabIndex = 2;
            // 
            // flpnlActivities
            // 
            this.flpnlActivities.AutoScroll = true;
            this.flpnlActivities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlActivities.BackColor = System.Drawing.SystemColors.Control;
            this.flpnlActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlActivities.Location = new System.Drawing.Point(0, 0);
            this.flpnlActivities.Name = "flpnlActivities";
            this.flpnlActivities.Size = new System.Drawing.Size(272, 195);
            this.flpnlActivities.TabIndex = 0;
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.White;
            this.pnlAction.Controls.Add(this.label2);
            this.pnlAction.Controls.Add(this.comboBox3);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAction.Location = new System.Drawing.Point(0, 0);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(272, 47);
            this.pnlAction.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hoạt động gần đây";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "7 ngày trước",
            "Tháng này",
            "Năm này"});
            this.comboBox3.Location = new System.Drawing.Point(152, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(116, 24);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.Visible = false;
            // 
            // panel18
            // 
            this.panel18.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel18.Location = new System.Drawing.Point(272, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(13, 242);
            this.panel18.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 230);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(285, 14);
            this.panel9.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.pnlTopFood);
            this.panel3.Controls.Add(this.panel17);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 230);
            this.panel3.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.flpnlTopFood);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 55);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(275, 175);
            this.panel12.TabIndex = 2;
            // 
            // flpnlTopFood
            // 
            this.flpnlTopFood.AutoScroll = true;
            this.flpnlTopFood.BackColor = System.Drawing.SystemColors.Control;
            this.flpnlTopFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlTopFood.Location = new System.Drawing.Point(0, 0);
            this.flpnlTopFood.Name = "flpnlTopFood";
            this.flpnlTopFood.Size = new System.Drawing.Size(275, 175);
            this.flpnlTopFood.TabIndex = 0;
            // 
            // pnlTopFood
            // 
            this.pnlTopFood.BackColor = System.Drawing.Color.White;
            this.pnlTopFood.Controls.Add(this.cbBoxFood);
            this.pnlTopFood.Controls.Add(this.label3);
            this.pnlTopFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFood.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFood.Name = "pnlTopFood";
            this.pnlTopFood.Size = new System.Drawing.Size(275, 55);
            this.pnlTopFood.TabIndex = 1;
            // 
            // cbBoxFood
            // 
            this.cbBoxFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoxFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxFood.ForeColor = System.Drawing.Color.DarkGray;
            this.cbBoxFood.FormattingEnabled = true;
            this.cbBoxFood.Items.AddRange(new object[] {
            "7 ngày trước",
            "Tháng này",
            "Quý",
            "Năm này",
            "Các năm"});
            this.cbBoxFood.Location = new System.Drawing.Point(152, 14);
            this.cbBoxFood.Name = "cbBoxFood";
            this.cbBoxFood.Size = new System.Drawing.Size(117, 24);
            this.cbBoxFood.TabIndex = 2;
            this.cbBoxFood.TextChanged += new System.EventHandler(this.cbBoxFood_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Món ăn bán chạy";
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(275, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(10, 230);
            this.panel17.TabIndex = 3;
            // 
            // pnlChart
            // 
            this.pnlChart.Controls.Add(this.panel7);
            this.pnlChart.Controls.Add(this.panel6);
            this.pnlChart.Controls.Add(this.panel16);
            this.pnlChart.Controls.Add(this.panel8);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(0, 114);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(995, 486);
            this.pnlChart.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.chartRevenue);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 55);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(972, 431);
            this.panel7.TabIndex = 1;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(0, 0);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(972, 431);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.cbBoxChart);
            this.panel6.Controls.Add(this.lblRevenueName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(972, 55);
            this.panel6.TabIndex = 0;
            // 
            // cbBoxChart
            // 
            this.cbBoxChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoxChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxChart.ForeColor = System.Drawing.Color.DarkGray;
            this.cbBoxChart.FormattingEnabled = true;
            this.cbBoxChart.Items.AddRange(new object[] {
            "7 ngày trước",
            "Tháng này",
            "Quý",
            "Năm này",
            "Các năm"});
            this.cbBoxChart.Location = new System.Drawing.Point(840, 11);
            this.cbBoxChart.Name = "cbBoxChart";
            this.cbBoxChart.Size = new System.Drawing.Size(121, 24);
            this.cbBoxChart.TabIndex = 2;
            this.cbBoxChart.TextChanged += new System.EventHandler(this.cbBoxChart_TextChanged);
            // 
            // lblRevenueName
            // 
            this.lblRevenueName.AutoSize = true;
            this.lblRevenueName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRevenueName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRevenueName.Location = new System.Drawing.Point(31, 14);
            this.lblRevenueName.Name = "lblRevenueName";
            this.lblRevenueName.Size = new System.Drawing.Size(143, 22);
            this.lblRevenueName.TabIndex = 1;
            this.lblRevenueName.Text = "Doanh thu trong";
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(10, 486);
            this.panel16.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(982, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(13, 486);
            this.panel8.TabIndex = 2;
            // 
            // DoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 600);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.pnlTopFood.ResumeLayout(false);
            this.pnlTopFood.PerformLayout();
            this.pnlChart.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel15;
        private FontAwesome.Sharp.IconButton btnUsingTable;
        private FontAwesome.Sharp.IconButton btnBill;
        private FontAwesome.Sharp.IconButton btnRevenue;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel pnlTopFood;
        private System.Windows.Forms.ComboBox cbBoxFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbBoxChart;
        private System.Windows.Forms.Label lblRevenueName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.FlowLayoutPanel flpnlTopFood;
        private System.Windows.Forms.FlowLayoutPanel flpnlActivities;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.Label lblUsingTable;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblBillNumber;
    }
}