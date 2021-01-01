
namespace Restaurant_Management.GUI.Table
{
    partial class BanAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCloseInfo = new FontAwesome.Sharp.IconPictureBox();
            this.btnSelectTable = new System.Windows.Forms.Button();
            this.lblTableStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.flpnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn bàn";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 23;
            this.btnExit.Location = new System.Drawing.Point(613, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.btnPay);
            this.pnlInfo.Controls.Add(this.btnCloseInfo);
            this.pnlInfo.Controls.Add(this.btnSelectTable);
            this.pnlInfo.Controls.Add(this.lblTableStatus);
            this.pnlInfo.Controls.Add(this.lblStatus);
            this.pnlInfo.Controls.Add(this.lblTableName);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(644, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(156, 450);
            this.pnlInfo.TabIndex = 1;
            this.pnlInfo.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(31, 329);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(96, 44);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCloseInfo
            // 
            this.btnCloseInfo.BackColor = System.Drawing.Color.White;
            this.btnCloseInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCloseInfo.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCloseInfo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCloseInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseInfo.IconSize = 23;
            this.btnCloseInfo.Location = new System.Drawing.Point(10, 12);
            this.btnCloseInfo.Name = "btnCloseInfo";
            this.btnCloseInfo.Size = new System.Drawing.Size(23, 23);
            this.btnCloseInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseInfo.TabIndex = 4;
            this.btnCloseInfo.TabStop = false;
            this.btnCloseInfo.Click += new System.EventHandler(this.btnCloseInfo_Click);
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectTable.FlatAppearance.BorderSize = 0;
            this.btnSelectTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectTable.ForeColor = System.Drawing.Color.White;
            this.btnSelectTable.Location = new System.Drawing.Point(31, 214);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(96, 44);
            this.btnSelectTable.TabIndex = 2;
            this.btnSelectTable.Text = "Chọn bàn";
            this.btnSelectTable.UseVisualStyleBackColor = false;
            this.btnSelectTable.Click += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // lblTableStatus
            // 
            this.lblTableStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTableStatus.Location = new System.Drawing.Point(6, 147);
            this.lblTableStatus.Name = "lblTableStatus";
            this.lblTableStatus.Size = new System.Drawing.Size(147, 64);
            this.lblTableStatus.TabIndex = 1;
            this.lblTableStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.Location = new System.Drawing.Point(35, 126);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 19);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Tình trạng";
            // 
            // lblTableName
            // 
            this.lblTableName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTableName.Location = new System.Drawing.Point(31, 60);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(87, 33);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Bàn";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpnlTable
            // 
            this.flpnlTable.AutoScroll = true;
            this.flpnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlTable.Location = new System.Drawing.Point(0, 41);
            this.flpnlTable.Name = "flpnlTable";
            this.flpnlTable.Size = new System.Drawing.Size(644, 409);
            this.flpnlTable.TabIndex = 2;
            // 
            // BanAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpnlTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanAn";
            this.MouseLeave += new System.EventHandler(this.BanAn_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.FlowLayoutPanel flpnlTable;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Label lblTableStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Button btnSelectTable;
        private System.Windows.Forms.Button btnPay;
        private FontAwesome.Sharp.IconPictureBox btnCloseInfo;
    }
}