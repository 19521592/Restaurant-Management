namespace Restaurant_Management
{
    partial class frmLogin
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
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.lb_Uesr = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.lb_PassWord = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txb_UserName);
            this.panel1.Controls.Add(this.lb_Uesr);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(175, 17);
            this.txb_UserName.Multiline = true;
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(289, 33);
            this.txb_UserName.TabIndex = 0;
            this.txb_UserName.TextChanged += new System.EventHandler(this.txb_UserName_TextChanged);
            // 
            // lb_Uesr
            // 
            this.lb_Uesr.AutoSize = true;
            this.lb_Uesr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Uesr.Location = new System.Drawing.Point(3, 26);
            this.lb_Uesr.Name = "lb_Uesr";
            this.lb_Uesr.Size = new System.Drawing.Size(156, 24);
            this.lb_Uesr.TabIndex = 0;
            this.lb_Uesr.Text = "Tên Đăng Nhập";
            this.lb_Uesr.Click += new System.EventHandler(this.lb_Uesr_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPassWord);
            this.panel2.Controls.Add(this.lb_PassWord);
            this.panel2.Location = new System.Drawing.Point(3, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 65);
            this.panel2.TabIndex = 1;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(175, 17);
            this.txbPassWord.Multiline = true;
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '•';
            this.txbPassWord.Size = new System.Drawing.Size(289, 31);
            this.txbPassWord.TabIndex = 1;
            // 
            // lb_PassWord
            // 
            this.lb_PassWord.AutoSize = true;
            this.lb_PassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PassWord.Location = new System.Drawing.Point(3, 26);
            this.lb_PassWord.Name = "lb_PassWord";
            this.lb_PassWord.Size = new System.Drawing.Size(100, 24);
            this.lb_PassWord.TabIndex = 0;
            this.lb_PassWord.Text = "Mật Khẩu";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(314, 176);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(114, 37);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(178, 176);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(109, 37);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 251);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion`

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label lb_Uesr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_PassWord;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txbPassWord;
    }
}

