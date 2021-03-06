﻿namespace Restaurant_Management.GUI.ManageFood
{
    partial class SuaMon
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
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.pnlKind = new System.Windows.Forms.Panel();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.pnlUnitPrice = new System.Windows.Forms.Panel();
            this.txtBoxKind = new System.Windows.Forms.TextBox();
            this.txtBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformation
            // 
            this.pnlInformation.BackColor = System.Drawing.Color.White;
            this.pnlInformation.Controls.Add(this.button1);
            this.pnlInformation.Controls.Add(this.pnlNote);
            this.pnlInformation.Controls.Add(this.pnlKind);
            this.pnlInformation.Controls.Add(this.txtBoxNote);
            this.pnlInformation.Controls.Add(this.pnlUnitPrice);
            this.pnlInformation.Controls.Add(this.txtBoxKind);
            this.pnlInformation.Controls.Add(this.txtBoxUnitPrice);
            this.pnlInformation.Controls.Add(this.pnlName);
            this.pnlInformation.Controls.Add(this.txtBoxName);
            this.pnlInformation.Controls.Add(this.pictureBox1);
            this.pnlInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformation.Location = new System.Drawing.Point(0, 41);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(824, 319);
            this.pnlInformation.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(652, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dùng ảnh củ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlNote
            // 
            this.pnlNote.BackColor = System.Drawing.Color.Silver;
            this.pnlNote.Location = new System.Drawing.Point(41, 249);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(276, 2);
            this.pnlNote.TabIndex = 3;
            // 
            // pnlKind
            // 
            this.pnlKind.BackColor = System.Drawing.Color.Silver;
            this.pnlKind.Location = new System.Drawing.Point(41, 193);
            this.pnlKind.Name = "pnlKind";
            this.pnlKind.Size = new System.Drawing.Size(276, 2);
            this.pnlKind.TabIndex = 3;
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.BackColor = System.Drawing.Color.White;
            this.txtBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBoxNote.Location = new System.Drawing.Point(41, 228);
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(276, 31);
            this.txtBoxNote.TabIndex = 4;
            this.txtBoxNote.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtBoxNote.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // pnlUnitPrice
            // 
            this.pnlUnitPrice.BackColor = System.Drawing.Color.Silver;
            this.pnlUnitPrice.Location = new System.Drawing.Point(41, 137);
            this.pnlUnitPrice.Name = "pnlUnitPrice";
            this.pnlUnitPrice.Size = new System.Drawing.Size(276, 2);
            this.pnlUnitPrice.TabIndex = 3;
            // 
            // txtBoxKind
            // 
            this.txtBoxKind.BackColor = System.Drawing.Color.White;
            this.txtBoxKind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBoxKind.Location = new System.Drawing.Point(41, 169);
            this.txtBoxKind.Name = "txtBoxKind";
            this.txtBoxKind.Size = new System.Drawing.Size(276, 31);
            this.txtBoxKind.TabIndex = 3;
            this.txtBoxKind.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtBoxKind.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtBoxUnitPrice
            // 
            this.txtBoxUnitPrice.BackColor = System.Drawing.Color.White;
            this.txtBoxUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBoxUnitPrice.Location = new System.Drawing.Point(41, 113);
            this.txtBoxUnitPrice.Name = "txtBoxUnitPrice";
            this.txtBoxUnitPrice.Size = new System.Drawing.Size(276, 31);
            this.txtBoxUnitPrice.TabIndex = 2;
            this.txtBoxUnitPrice.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtBoxUnitPrice.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.Silver;
            this.pnlName.Location = new System.Drawing.Point(41, 69);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(276, 2);
            this.pnlName.TabIndex = 3;
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.Color.White;
            this.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBoxName.Location = new System.Drawing.Point(41, 44);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(276, 31);
            this.txtBoxName.TabIndex = 1;
            this.txtBoxName.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtBoxName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(336, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(824, 41);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập Nhật Món Ăn";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(90, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 54);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Tomato;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(577, 16);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(134, 54);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Bỏ Qua";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 83);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 0);
            this.panel2.TabIndex = 8;
            // 
            // SuaMon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlInformation);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuaMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaMon";
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Panel pnlKind;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.Panel pnlUnitPrice;
        private System.Windows.Forms.TextBox txtBoxKind;
        private System.Windows.Forms.TextBox txtBoxUnitPrice;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }

        #endregion
}