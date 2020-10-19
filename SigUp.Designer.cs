namespace Restaurant_Management
{
    partial class SigUp
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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbRPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDangKi = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(201, 67);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(214, 39);
            this.tbUser.TabIndex = 0;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(201, 143);
            this.tbPassWord.Multiline = true;
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(214, 36);
            this.tbPassWord.TabIndex = 1;
            // 
            // tbRPassWord
            // 
            this.tbRPassWord.Location = new System.Drawing.Point(201, 209);
            this.tbRPassWord.Multiline = true;
            this.tbRPassWord.Name = "tbRPassWord";
            this.tbRPassWord.Size = new System.Drawing.Size(214, 37);
            this.tbRPassWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Đăng Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập Lại Mật Khẩu";
            // 
            // btDangKi
            // 
            this.btDangKi.Location = new System.Drawing.Point(184, 295);
            this.btDangKi.Name = "btDangKi";
            this.btDangKi.Size = new System.Drawing.Size(116, 40);
            this.btDangKi.TabIndex = 6;
            this.btDangKi.Text = "Đăng Kí";
            this.btDangKi.UseVisualStyleBackColor = true;
            this.btDangKi.Click += new System.EventHandler(this.btDangKi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(319, 295);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(110, 40);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sig Up";
            // 
            // SigUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangKi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRPassWord);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.tbUser);
            this.Name = "SigUp";
            this.Text = "SigUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.TextBox tbRPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDangKi;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label4;
    }
}