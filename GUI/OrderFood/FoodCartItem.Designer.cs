
namespace Restaurant_Management.GUI
{
    partial class FoodCartItem
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
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFood.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(211, 172);
            this.pictureBoxFood.TabIndex = 0;
            this.pictureBoxFood.TabStop = false;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodName.Location = new System.Drawing.Point(273, 32);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(116, 23);
            this.lblFoodName.TabIndex = 1;
            this.lblFoodName.Text = "Tên Món Ăn";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.Location = new System.Drawing.Point(465, 100);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(25, 27);
            this.lblFoodPrice.TabIndex = 2;
            this.lblFoodPrice.Text = "0";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Location = new System.Drawing.Point(571, 100);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(41, 30);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumber.Location = new System.Drawing.Point(613, 100);
            this.txtBoxNumber.Multiline = true;
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(47, 30);
            this.txtBoxNumber.TabIndex = 4;
            this.txtBoxNumber.Text = "1";
            this.txtBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Location = new System.Drawing.Point(661, 100);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(41, 30);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "-";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // FoodCartItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.pictureBoxFood);
            this.Name = "FoodCartItem";
            this.Size = new System.Drawing.Size(723, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Button btnPlus;
    }
}
