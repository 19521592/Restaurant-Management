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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
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
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 603);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCombo
            // 
            this.btnCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCombo.FlatAppearance.BorderSize = 0;
            this.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCombo.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnCombo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCombo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCombo.IconSize = 32;
            this.btnCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCombo.Location = new System.Drawing.Point(0, 381);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCombo.Size = new System.Drawing.Size(220, 60);
            this.btnCombo.TabIndex = 5;
            this.btnCombo.Text = "Combo";
            this.btnCombo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCombo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.comboBtn_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrink.FlatAppearance.BorderSize = 0;
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDrink.IconChar = FontAwesome.Sharp.IconChar.Cocktail;
            this.btnDrink.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDrink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDrink.IconSize = 32;
            this.btnDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrink.Location = new System.Drawing.Point(0, 320);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDrink.Size = new System.Drawing.Size(220, 61);
            this.btnDrink.TabIndex = 4;
            this.btnDrink.Text = "Thức Uống";
            this.btnDrink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.drinkBtn_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDessert.FlatAppearance.BorderSize = 0;
            this.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDessert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDessert.IconChar = FontAwesome.Sharp.IconChar.Cheese;
            this.btnDessert.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDessert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDessert.IconSize = 32;
            this.btnDessert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDessert.Location = new System.Drawing.Point(0, 260);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDessert.Size = new System.Drawing.Size(220, 60);
            this.btnDessert.TabIndex = 3;
            this.btnDessert.Text = "Món Tráng Miệng";
            this.btnDessert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDessert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.dessertBtn_Click);
            // 
            // btnMainCourse
            // 
            this.btnMainCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainCourse.FlatAppearance.BorderSize = 0;
            this.btnMainCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCourse.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMainCourse.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnMainCourse.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMainCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMainCourse.IconSize = 32;
            this.btnMainCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCourse.Location = new System.Drawing.Point(0, 200);
            this.btnMainCourse.Name = "btnMainCourse";
            this.btnMainCourse.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMainCourse.Size = new System.Drawing.Size(220, 60);
            this.btnMainCourse.TabIndex = 2;
            this.btnMainCourse.Text = "Món Chính";
            this.btnMainCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainCourse.UseVisualStyleBackColor = true;
            this.btnMainCourse.Click += new System.EventHandler(this.mainCourseBtn_Click);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppetizer.FlatAppearance.BorderSize = 0;
            this.btnAppetizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppetizer.IconChar = FontAwesome.Sharp.IconChar.Leaf;
            this.btnAppetizer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAppetizer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAppetizer.IconSize = 32;
            this.btnAppetizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppetizer.Location = new System.Drawing.Point(0, 140);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAppetizer.Size = new System.Drawing.Size(220, 60);
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
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.homeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 108;
            this.homeBtn.Location = new System.Drawing.Point(55, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(108, 108);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.homeBtn.TabIndex = 0;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.iconPictureBox2);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.lblTitleChildForm);
            this.pnlTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1050, 75);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 23;
            this.btnExit.Location = new System.Drawing.Point(1024, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(59, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(12, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1050, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 84);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1050, 519);
            this.pnlDesktop.TabIndex = 3;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 23;
            this.btnMaximize.Location = new System.Drawing.Point(995, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 23);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 23;
            this.iconPictureBox2.Location = new System.Drawing.Point(966, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(23, 23);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 603);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrderForm";
            this.Text = "CustomerOrderForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
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
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel pnlDesktop;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Panel pnlTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
    }
}