namespace Restaurant_Management.GUI.Reviews
{
    partial class ReviewFood
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
            this.picRate = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRate)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.picRate);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 73);
            this.panel1.TabIndex = 0;
            // 
            // picRate
            // 
            this.picRate.Location = new System.Drawing.Point(830, 12);
            this.picRate.Name = "picRate";
            this.picRate.Size = new System.Drawing.Size(200, 50);
            this.picRate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRate.TabIndex = 1;
            this.picRate.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(40, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(130, 34);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên món";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.lbCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 59);
            this.panel2.TabIndex = 1;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(158, 18);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(76, 23);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "Số lượt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lượt đánh giá: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1030, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 521);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 521);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlData);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(20, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1010, 521);
            this.panel5.TabIndex = 5;
            // 
            // pnlData
            // 
            this.pnlData.AutoScroll = true;
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1010, 521);
            this.pnlData.TabIndex = 0;
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
            this.iconButton2.Location = new System.Drawing.Point(859, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(156, 54);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "Bỏ Qua";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ReviewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 653);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReviewFood";
            this.Text = "ReviewFood";
            this.Load += new System.EventHandler(this.ReviewFood_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRate)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picRate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlData;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}