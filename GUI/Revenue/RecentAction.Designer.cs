
namespace Restaurant_Management.GUI.Revenue
{
    partial class RecentAction
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
            this.iconAction = new FontAwesome.Sharp.IconPictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconAction)).BeginInit();
            this.SuspendLayout();
            // 
            // iconAction
            // 
            this.iconAction.BackColor = System.Drawing.Color.LimeGreen;
            this.iconAction.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.iconAction.IconColor = System.Drawing.Color.White;
            this.iconAction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAction.Location = new System.Drawing.Point(7, 12);
            this.iconAction.Name = "iconAction";
            this.iconAction.Size = new System.Drawing.Size(32, 32);
            this.iconAction.TabIndex = 0;
            this.iconAction.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AllowDrop = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(40, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(207, 39);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Thông tin";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Location = new System.Drawing.Point(159, 42);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 15);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Thời gian";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RecentAction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.iconAction);
            this.DoubleBuffered = true;
            this.Name = "RecentAction";
            this.Size = new System.Drawing.Size(245, 59);
            ((System.ComponentModel.ISupportInitialize)(this.iconAction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconAction;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTime;
    }
}
