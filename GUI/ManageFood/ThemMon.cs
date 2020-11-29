using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class ThemMon : Form
    {
        public ThemMon()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelEffect_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;

            if (lbl.Location.X == 41)
            {
                lbl.Font = new Font("Microsoft Sans Serif", 9);
                lbl.Cursor = Cursors.Arrow;
                lbl.Location = new Point(lbl.Location.X, lbl.Location.Y - 12);
                foreach (Control txt in pnlInformation.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txtBox" + lbl.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in pnlInformation.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 6))
                {
                    ctrl.BackColor = Color.DodgerBlue;
                }

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 6))
                {
                    ctrl.ForeColor = Color.DodgerBlue;
                    if (ctrl.Location.X != 41)
                    {
                        txt.Clear();
                        ctrl.Font = new Font("Microsoft Sans Serif", 9);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - 12);
                    }
                }


            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in pnlInformation.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 6))
                {
                    ctrl.BackColor = Color.Silver;
                }

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 6))
                {
                    ctrl.ForeColor = Color.Silver;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        txt.Clear();
                        ctrl.Font = new Font("Microsoft Sans Serif", 13);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + 16);
                    }
                }
            }
        }
    }
}
