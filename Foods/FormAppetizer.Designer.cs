namespace Restaurant_Management.Foods
{
    partial class FormAppetizer
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
            this.fpnlFoodList = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // fpnlFoodList
            // 
            this.fpnlFoodList.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpnlFoodList.Location = new System.Drawing.Point(0, 0);
            this.fpnlFoodList.Name = "fpnlFoodList";
            this.fpnlFoodList.Size = new System.Drawing.Size(800, 390);
            this.fpnlFoodList.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(514, 396);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(136, 42);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "50000$";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FormAppetizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.fpnlFoodList);
            this.Name = "FormAppetizer";
            this.Text = "FormAppetizer";
            this.Load += new System.EventHandler(this.FormAppetizer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlFoodList;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}