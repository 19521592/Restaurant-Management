
namespace Restaurant_Management.GUI
{
    partial class GioHang
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
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblFoodCount = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.lblPriceName = new System.Windows.Forms.Label();
            this.lblTableNumberName = new System.Windows.Forms.Label();
            this.flpnlSelectedFood = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblFoodCount);
            this.panel1.Controls.Add(this.lblCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 23;
            this.btnExit.Location = new System.Drawing.Point(965, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFoodCount
            // 
            this.lblFoodCount.AutoSize = true;
            this.lblFoodCount.Location = new System.Drawing.Point(113, 13);
            this.lblFoodCount.Name = "lblFoodCount";
            this.lblFoodCount.Size = new System.Drawing.Size(77, 17);
            this.lblFoodCount.TabIndex = 0;
            this.lblFoodCount.Text = "(0 món ăn)";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(8, 10);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(103, 24);
            this.lblCart.TabIndex = 0;
            this.lblCart.Text = "GIỎ HÀNG";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlInfo.Controls.Add(this.btnSubmit);
            this.pnlInfo.Controls.Add(this.panel3);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(754, 45);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(246, 455);
            this.pnlInfo.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(18, 191);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(216, 57);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Controls.Add(this.lblTableNumber);
            this.panel3.Controls.Add(this.lblPriceName);
            this.panel3.Controls.Add(this.lblTableNumberName);
            this.panel3.Location = new System.Drawing.Point(18, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 129);
            this.panel3.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(118, 81);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(16, 17);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "0";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(118, 25);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(53, 17);
            this.lblTableNumber.TabIndex = 0;
            this.lblTableNumber.Text = "Bàn 69";
            // 
            // lblPriceName
            // 
            this.lblPriceName.AutoSize = true;
            this.lblPriceName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPriceName.Location = new System.Drawing.Point(17, 81);
            this.lblPriceName.Name = "lblPriceName";
            this.lblPriceName.Size = new System.Drawing.Size(85, 19);
            this.lblPriceName.TabIndex = 0;
            this.lblPriceName.Text = "Thành tiền";
            // 
            // lblTableNumberName
            // 
            this.lblTableNumberName.AutoSize = true;
            this.lblTableNumberName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTableNumberName.Location = new System.Drawing.Point(17, 25);
            this.lblTableNumberName.Name = "lblTableNumberName";
            this.lblTableNumberName.Size = new System.Drawing.Size(38, 19);
            this.lblTableNumberName.TabIndex = 0;
            this.lblTableNumberName.Text = "Bàn";
            // 
            // flpnlSelectedFood
            // 
            this.flpnlSelectedFood.AutoScroll = true;
            this.flpnlSelectedFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.flpnlSelectedFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlSelectedFood.Location = new System.Drawing.Point(0, 45);
            this.flpnlSelectedFood.Name = "flpnlSelectedFood";
            this.flpnlSelectedFood.Size = new System.Drawing.Size(754, 455);
            this.flpnlSelectedFood.TabIndex = 2;
            // 
            // GioHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.flpnlSelectedFood);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GioHang";
            this.Load += new System.EventHandler(this.GioHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.FlowLayoutPanel flpnlSelectedFood;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label lblPriceName;
        private System.Windows.Forms.Label lblTableNumberName;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Label lblFoodCount;
    }
}