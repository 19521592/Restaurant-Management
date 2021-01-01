namespace Restaurant_Management.GUI.Reviews
{
    partial class FoodRate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnReview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlRate = new System.Windows.Forms.Panel();
            this.picRate = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.btnReview);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pnlRate);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.picFood);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 225);
            this.panel1.TabIndex = 0;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(262, 119);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(69, 22);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "lbPrice";
            // 
            // btnReview
            // 
            this.btnReview.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.White;
            this.btnReview.Location = new System.Drawing.Point(250, 180);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(121, 43);
            this.btnReview.TabIndex = 6;
            this.btnReview.Text = "Viết đánh giá";
            this.btnReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.UseVisualStyleBackColor = false;
            this.btnReview.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xem đánh giá";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlRate
            // 
            this.pnlRate.Controls.Add(this.picRate);
            this.pnlRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRate.Location = new System.Drawing.Point(250, 0);
            this.pnlRate.Name = "pnlRate";
            this.pnlRate.Size = new System.Drawing.Size(246, 60);
            this.pnlRate.TabIndex = 4;
            // 
            // picRate
            // 
            this.picRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.picRate.Location = new System.Drawing.Point(0, 0);
            this.picRate.Name = "picRate";
            this.picRate.Size = new System.Drawing.Size(250, 60);
            this.picRate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRate.TabIndex = 0;
            this.picRate.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(262, 78);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 22);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "lbName";
            // 
            // picFood
            // 
            this.picFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.picFood.Location = new System.Drawing.Point(0, 0);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(250, 221);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 0;
            this.picFood.TabStop = false;
            // 
            // FoodRate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "FoodRate";
            this.Size = new System.Drawing.Size(534, 258);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Panel pnlRate;
        private System.Windows.Forms.PictureBox picRate;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Label lbPrice;
    }
}
