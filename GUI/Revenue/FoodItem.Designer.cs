
namespace Restaurant_Management.GUI.Revenue
{
    partial class FoodItem
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
            this.lblFoodNumber = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFoodNumber
            // 
            this.lblFoodNumber.AutoSize = true;
            this.lblFoodNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblFoodNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodNumber.Location = new System.Drawing.Point(202, 7);
            this.lblFoodNumber.Name = "lblFoodNumber";
            this.lblFoodNumber.Size = new System.Drawing.Size(18, 20);
            this.lblFoodNumber.TabIndex = 0;
            this.lblFoodNumber.Text = "0";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(8, 9);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(64, 17);
            this.lblFoodName.TabIndex = 1;
            this.lblFoodName.Text = "Tên món";
            // 
            // FoodItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.lblFoodNumber);
            this.DoubleBuffered = true;
            this.Name = "FoodItem";
            this.Size = new System.Drawing.Size(245, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodNumber;
        private System.Windows.Forms.Label lblFoodName;
    }
}
