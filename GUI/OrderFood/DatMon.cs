using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Restaurant_Management.BLL;
using Restaurant_Management.GUI;
using Restaurant_Management.GUI.Table;
using Restaurant_Management.GUI.CustomNofication;

namespace Restaurant_Management
{
    public partial class CustomerOrderForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public string staffId { get; set; }
        public string idBanAn { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        //Constructor
        public CustomerOrderForm(string staffId)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(220, 7);
            panelMenu.Controls.Add(leftBorderBtn);
            orderedFood = new Dictionary<string, Food>();
            idOrderedFood = new List<string>();

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.staffId = staffId;
            IconButton number = new IconButton();          
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y + 60);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
        //Events
        //Reset
        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        //Menu Button_Clicks
        private void appetizerBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            flowLayoutPanelMain.Controls.Clear();
            loadFoodIntoFlowLayoutPanel("Khai Vị");
        }
        private void mainCourseBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            ActivateButton(sender, RGBColors.color2);
            loadFoodIntoFlowLayoutPanel("Món Chính");
        }
        private void dessertBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            ActivateButton(sender, RGBColors.color3);
            loadFoodIntoFlowLayoutPanel("Tráng miệng");
        }
        private void drinkBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            ActivateButton(sender, RGBColors.color4);
            loadFoodIntoFlowLayoutPanel("Thức uống");
        }
        private void comboBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            ActivateButton(sender, RGBColors.color5);
            loadFoodIntoFlowLayoutPanel("Combo");
        }


        //Properties of controls in FlowLayoutPanel
        private IconButton add;
        private PictureBox pic;
        private TextBox num;
        private Label price;
        private Label description;
        private Label detail;
        private Panel pnlFood;
        private IconButton minus;
        private DataTable listFood;

        private void loadFoodIntoFlowLayoutPanel(string loai)
        {
            listFood = MONAN.Ins.getListThucAn(loai);
            foreach (DataRow food in listFood.Rows)
            {
                pnlFood = new Panel();
                pnlFood.Width = 540;
                pnlFood.Height = 300;
                pnlFood.BackColor = Color.White;
                pnlFood.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlFood.Width, pnlFood.Height, 30, 30));

                pic = new PictureBox();
                pic.Width = 350;
                pic.Height = 300;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.BackgroundImage = MONAN.Ins.ByteToImg(food[3].ToString());
                pic.Dock = DockStyle.Left;

                price = new Label();
                price.Text = "" + Convert.ToDouble(food[2]).ToString("#,##0") + "đ";
                price.Width = 200;
                price.BackColor = Color.White;
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Location = new Point(pnlFood.Width - 200, 120);
                price.Font = new Font(new FontFamily("Arial"), 10.0F,
                FontStyle.Regular, this.Font.Unit);

                detail = new Label();
                detail.Font = new Font(new FontFamily("Arial"), 10.0F,
                FontStyle.Regular, this.Font.Unit);
                detail.Text = food[4].ToString();
                detail.AllowDrop = true;
                detail.Width = 180;
                detail.Height = 100;
                detail.BackColor = Color.White;
                detail.TextAlign = ContentAlignment.TopLeft;
                detail.Location = new Point(pnlFood.Width - 180, 160);


                description = new Label();
                description.AllowDrop = true;
                description.Text = food[1].ToString();
                description.Width = 180;
                description.Height = 100;
                description.BackColor = Color.White;
                description.TextAlign = ContentAlignment.MiddleCenter;
                description.Location = new Point(pnlFood.Width - 190, 10);
                description.Font = new Font(new FontFamily("Arial"), 12.0F,
                FontStyle.Regular, description.Font.Unit);

                num = new TextBox();
                num.BackColor = Color.White;
                num.Width = 60;
                num.Height = 60;
                num.Anchor = AnchorStyles.None;
                num.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                num.Location = new Point(pnlFood.Width - 100, pnlFood.Height - 30);
                num.BorderStyle = BorderStyle.None;
                num.Text = "1";
                num.TextAlign = HorizontalAlignment.Left;
                num.Font = new Font(new FontFamily("Arial"), 10.0F,
                FontStyle.Regular, num.Font.Unit);
                num.TextChanged += new EventHandler(checkValue);
                num.Leave += new EventHandler(checkEmpty);

                Food selectedFood = new Food();
                selectedFood.Name = food[1].ToString();
                selectedFood.Id = food[0].ToString();
                selectedFood.Price = Convert.ToDouble(food[2].ToString());
                selectedFood.Num = num;
                selectedFood.Image = pic.BackgroundImage;

                add = new IconButton();
                add.IconChar = IconChar.PlusCircle;
                add.BackColor = Color.White;
                add.Width = 60;
                add.Height = 60;
                add.Anchor = AnchorStyles.None;
                add.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                add.Location = new Point(pnlFood.Width - 50, pnlFood.Height - 50);
                add.FlatStyle = FlatStyle.Flat;
                add.FlatAppearance.BorderSize = 0;
                add.IconColor = Color.FromArgb(203, 101, 104);
                add.Click += new EventHandler(btnAdd_Click);
                add.Tag = selectedFood;

                minus = new IconButton();
                minus.IconChar = IconChar.MinusCircle;
                minus.BackColor = Color.White;
                minus.Width = 60;
                minus.Height = 60;
                minus.Anchor = AnchorStyles.None;
                minus.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                minus.Location = new Point(pnlFood.Width - 200, pnlFood.Height - 50);
                minus.FlatStyle = FlatStyle.Flat;
                minus.FlatAppearance.BorderSize = 0;
                minus.IconColor = Color.FromArgb(56, 165, 255);
                minus.Click += new EventHandler(btnMinus_Click);
                minus.Tag = num;

                pnlFood.Controls.Add(pic);
                pnlFood.Controls.Add(description);
                pnlFood.Controls.Add(price);
                pnlFood.Controls.Add(detail);
                pnlFood.Controls.Add(add);
                pnlFood.Controls.Add(minus);
                pnlFood.Controls.Add(num);
                flowLayoutPanelMain.Controls.Add(pnlFood);
            }
        }

        IDictionary<string, Food> orderedFood { get; set; }
        List<string> idOrderedFood;
        private double tempPrice = 0;
        private int allFoodCount = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedTable == null)
            {
                Form_Alert.Alert("Thêm bàn trước!", Form_Alert.enmType.Warning);
                return;
            }
            IconButton button = sender as IconButton;
            Food selectedFood = button.Tag as Food;
            selectedFood.Number = Convert.ToInt32(selectedFood.Num.Text);
            Food newFoodItem = new Food(selectedFood);
            tempPrice += selectedFood.Price * selectedFood.Number;
            allFoodCount += selectedFood.Number;
            if (orderedFood.ContainsKey(selectedFood.Id))
            {
                orderedFood[selectedFood.Id].Number += selectedFood.Number;
            }
            else
            {
                orderedFood.Add(selectedFood.Id, newFoodItem);
                idOrderedFood.Add(selectedFood.Id);
            }
            //button.Tag = selectedFood;
            btnPrice.Text = tempPrice.ToString("#,##0");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            IconButton button = sender as IconButton;
            TextBox textBox = button.Tag as TextBox;
            int num = Convert.ToInt32(textBox.Text);
            if (num > 1)
            {
                textBox.Text = "" + (--num);
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (selectedTable == null)
            {
                Form_Alert.Alert("Lỗi: Chưa thêm bàn!", Form_Alert.enmType.Error);
                return;
            }
            if (orderedFood.Count == 0)
            {
                Form_Alert.Alert("Lỗi: Chưa thêm món!", Form_Alert.enmType.Error);
                return;
            }
            GioHang gioHang = new GioHang(this, orderedFood, idOrderedFood, selectedTable, staffId);
            gioHang.ShowDialog();
            gioHang.Focus();
        }

        private void btnPrice_Paint(object sender, PaintEventArgs e)
        {
            if (allFoodCount > 0)
            {
                IconButton btn = sender as IconButton;
                Font font = new Font(new FontFamily("Arial"), 9.0F,
                    FontStyle.Regular, btn.Font.Unit);
                Graphics g = e.Graphics;
                SolidBrush redBrush = new SolidBrush(Color.Red);
                SolidBrush whiteBrush = new SolidBrush(Color.White);

                g.FillEllipse(redBrush, 35, 0, 20, 20);
                g.DrawString(allFoodCount.ToString(), font, whiteBrush, 36, 0);
            }
        }
        //Select Table
        public Ban selectedTable { get; set;  }
        BanAn banAn;
        private void btnTable_Click(object sender, EventArgs e)
        {
            banAn = new BanAn(selectedTable, this);
            banAn.FormClosed += new FormClosedEventHandler(updateTableInfo);
            banAn.ShowDialog();
            //this.Focus;
            banAn.Focus();
            banAn.loadTableIntoFlowLayoutPanel();
        }
        private void updateTableInfo(object sender, FormClosedEventArgs e)
        {
            selectedTable = banAn.selectedTable;
            if (selectedTable != null)
            {
                this.btnTable.Text = selectedTable.tableName;
            }
            loadInfo();
        }
        private void checkValue(object sender, EventArgs e)
        {
            TextBox txtBoxNumber = sender as TextBox;
            int num = 0;
            if (txtBoxNumber.Text == "") return;
            if (/*!txtBoxNumber.Text.All(allowedchar.Contains) ||*/ !Int32.TryParse(txtBoxNumber.Text, out num))
            {
                Form_Alert.Alert("Chỉ được nhập số", Form_Alert.enmType.Warning);

                if (txtBoxNumber.Text.Length > 1) txtBoxNumber.Text = txtBoxNumber.Text.Remove(txtBoxNumber.Text.Length - 1, 1);
                else if (txtBoxNumber.Text.Length == 1) txtBoxNumber.Text = "1";
                return;
            }
            if (num <= 0)
            {
                Form_Alert.Alert("Số lượng phải >= 0", Form_Alert.enmType.Warning);
                txtBoxNumber.Text = "1";
                return;
            }
        }

        private void checkEmpty(object sender, EventArgs e)
        {
            TextBox txtBoxNumber = sender as TextBox;
            int num = 0;
            if (txtBoxNumber.Text == "")
            {
                Form_Alert.Alert("Không được để trống", Form_Alert.enmType.Warning);
                txtBoxNumber.Text = "1";
            }
        }
        public void loadInfo()
        {
            this.idBanAn = loadOrderedTableInfo();
        }
        public string loadOrderedTableInfo()
        {
            orderedFood = new Dictionary<string, Food>();
            idOrderedFood = new List<string>();
            tempPrice = 0;
            allFoodCount = 0;
            string idBanAn = null;
            if (selectedTable != null && selectedTable.tableStatus == "True")
            {
                idBanAn = BANAN.Ins.getBanAnChuaThanhToan(selectedTable.tableId).Rows[0][0].ToString();
                var listFood = MONAN.Ins.getListMonThanhToan(idBanAn).Rows;
                foreach (DataRow food in listFood)
                {
                    Food foodItem = new Food();
                    foodItem.Id = food[0].ToString();
                    foodItem.Name = food[1].ToString();
                    foodItem.Price = Convert.ToDouble(food[2]);
                    foodItem.Number = Convert.ToInt32(food[3]);
                    foodItem.Image = MONAN.Ins.ByteToImg(food[4].ToString());

                    idOrderedFood.Add(foodItem.Id);
                    orderedFood.Add(foodItem.Id, foodItem);
                    tempPrice += foodItem.Price * foodItem.Number;
                    allFoodCount += foodItem.Number;
                }
            }
            btnPrice.Text = tempPrice.ToString("#,##0");

            return idBanAn;
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            if (selectedTable != null && idBanAn != null && (BANAN.Ins.getBanAnChuaThanhToan(selectedTable.tableId).Rows[0][0].ToString()) != null)
            {
                ThanhToanBan thanhToan = new ThanhToanBan(selectedTable, this);
                thanhToan.ShowDialog();
                thanhToan.Focus();
            }
            else
            {
                Form_Alert.Alert("Chưa đặt món!", Form_Alert.enmType.Info);
            }
        }
        public void resetInfoForm()
        {
            this.btnPrice.Text = "0";
            this.btnTable.Text = "Chọn bàn";
            this.allFoodCount = 0;
            this.selectedTable = null;
        }
    }
}
