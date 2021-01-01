namespace Restaurant_Management.GUI.Reviews
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlR = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
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
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
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
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
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
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
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
            this.btnMainCourse.Click += new System.EventHandler(this.btnMainCourse_Click);
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
            this.btnAppetizer.Click += new System.EventHandler(this.btnAppetizer_Click);
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
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(7, 72);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1273, 528);
            this.flowLayoutPanelMain.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 528);
            this.panel1.TabIndex = 6;
            // 
            // pnlR
            // 
            this.pnlR.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlR.Location = new System.Drawing.Point(1280, 72);
            this.pnlR.Name = "pnlR";
            this.pnlR.Size = new System.Drawing.Size(0, 528);
            this.pnlR.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 600);
            this.Controls.Add(this.pnlR);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "CustomerOrderForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlR;
    }
}