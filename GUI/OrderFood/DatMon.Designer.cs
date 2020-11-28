namespace Restaurant_Management
{
    partial class CustomerOrderForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCombo = new FontAwesome.Sharp.IconButton();
            this.btnDrink = new FontAwesome.Sharp.IconButton();
            this.btnDessert = new FontAwesome.Sharp.IconButton();
            this.btnMainCourse = new FontAwesome.Sharp.IconButton();
            this.btnAppetizer = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.homeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPurchase = new System.Windows.Forms.Panel();
            this.btnPrice = new FontAwesome.Sharp.IconButton();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.pnlPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnCombo);
            this.panelMenu.Controls.Add(this.btnDrink);
            this.panelMenu.Controls.Add(this.btnDessert);
            this.panelMenu.Controls.Add(this.btnMainCourse);
            this.panelMenu.Controls.Add(this.btnAppetizer);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1280, 72);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCombo
            // 
            this.btnCombo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCombo.FlatAppearance.BorderSize = 0;
            this.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCombo.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnCombo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCombo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCombo.IconSize = 32;
            this.btnCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCombo.Location = new System.Drawing.Point(992, 0);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCombo.Size = new System.Drawing.Size(220, 72);
            this.btnCombo.TabIndex = 5;
            this.btnCombo.Text = "Combo";
            this.btnCombo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCombo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.comboBtn_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDrink.FlatAppearance.BorderSize = 0;
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDrink.IconChar = FontAwesome.Sharp.IconChar.Cocktail;
            this.btnDrink.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDrink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDrink.IconSize = 32;
            this.btnDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrink.Location = new System.Drawing.Point(772, 0);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDrink.Size = new System.Drawing.Size(220, 72);
            this.btnDrink.TabIndex = 4;
            this.btnDrink.Text = "Thức Uống";
            this.btnDrink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.drinkBtn_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDessert.FlatAppearance.BorderSize = 0;
            this.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDessert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDessert.IconChar = FontAwesome.Sharp.IconChar.Cheese;
            this.btnDessert.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDessert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDessert.IconSize = 32;
            this.btnDessert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDessert.Location = new System.Drawing.Point(552, 0);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDessert.Size = new System.Drawing.Size(220, 72);
            this.btnDessert.TabIndex = 3;
            this.btnDessert.Text = "Món Tráng Miệng";
            this.btnDessert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDessert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.dessertBtn_Click);
            // 
            // btnMainCourse
            // 
            this.btnMainCourse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMainCourse.FlatAppearance.BorderSize = 0;
            this.btnMainCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCourse.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMainCourse.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnMainCourse.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMainCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMainCourse.IconSize = 32;
            this.btnMainCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCourse.Location = new System.Drawing.Point(332, 0);
            this.btnMainCourse.Name = "btnMainCourse";
            this.btnMainCourse.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMainCourse.Size = new System.Drawing.Size(220, 72);
            this.btnMainCourse.TabIndex = 2;
            this.btnMainCourse.Text = "Món Chính";
            this.btnMainCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainCourse.UseVisualStyleBackColor = true;
            this.btnMainCourse.Click += new System.EventHandler(this.mainCourseBtn_Click);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppetizer.FlatAppearance.BorderSize = 0;
            this.btnAppetizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppetizer.IconChar = FontAwesome.Sharp.IconChar.Leaf;
            this.btnAppetizer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAppetizer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAppetizer.IconSize = 32;
            this.btnAppetizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppetizer.Location = new System.Drawing.Point(108, 0);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAppetizer.Size = new System.Drawing.Size(224, 72);
            this.btnAppetizer.TabIndex = 1;
            this.btnAppetizer.Text = "Món Khai Vị";
            this.btnAppetizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppetizer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppetizer.UseVisualStyleBackColor = true;
            this.btnAppetizer.Click += new System.EventHandler(this.appetizerBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.homeBtn);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(108, 72);
            this.panelLogo.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.homeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 44;
            this.homeBtn.Location = new System.Drawing.Point(12, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(74, 44);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 0;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(7, 72);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1273, 475);
            this.flowLayoutPanelMain.TabIndex = 3;
            // 
            // pnlPurchase
            // 
            this.pnlPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlPurchase.Controls.Add(this.btnPrice);
            this.pnlPurchase.Controls.Add(this.btnCart);
            this.pnlPurchase.Controls.Add(this.btnTable);
            this.pnlPurchase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPurchase.Location = new System.Drawing.Point(0, 547);
            this.pnlPurchase.Name = "pnlPurchase";
            this.pnlPurchase.Size = new System.Drawing.Size(1280, 53);
            this.pnlPurchase.TabIndex = 4;
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(147)))), ((int)(((byte)(185)))));
            this.btnPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrice.FlatAppearance.BorderSize = 0;
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.ForeColor = System.Drawing.Color.White;
            this.btnPrice.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnPrice.IconColor = System.Drawing.Color.White;
            this.btnPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrice.Location = new System.Drawing.Point(894, 0);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(228, 53);
            this.btnPrice.TabIndex = 1;
            this.btnPrice.Text = "0";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPrice_Paint);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Location = new System.Drawing.Point(1122, 0);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(158, 53);
            this.btnCart.TabIndex = 0;
            this.btnCart.Text = "Giỏ hàng";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Location = new System.Drawing.Point(0, 0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(170, 53);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "Bàn";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 475);
            this.panel1.TabIndex = 6;
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 600);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pnlPurchase);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrderForm";
            this.Text = "CustomerOrderForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.pnlPurchase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnCombo;
        private FontAwesome.Sharp.IconButton btnDrink;
        private FontAwesome.Sharp.IconButton btnDessert;
        private FontAwesome.Sharp.IconButton btnMainCourse;
        private FontAwesome.Sharp.IconButton btnAppetizer;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconPictureBox homeBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Panel pnlPurchase;
        private FontAwesome.Sharp.IconButton btnPrice;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Panel panel1;
    }
}