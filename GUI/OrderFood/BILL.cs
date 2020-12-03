using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using System.Data.SqlClient;
using PdfSharp.Drawing;


namespace Restaurant_Management.GUI.OrderFood
{
    public partial class BILL : Form
    {
        public BILL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                int i = 0;
                string sql = null;
                int yPoint = 0;
                string TenMonAn = null;
                string SoLuong= null;
                string DonGia = null;
               // string ThanhTien = null;

                connetionString = "Data Source=THANHNGUYEN;Initial Catalog=QLKH;User ID=sa;Password=1334567701";
                sql = "select TenMonAn,SoLuong,DonGia from TestHoaDon";
                connection = new SqlConnection(connetionString);
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                connection.Close();

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 10, XFontStyle.Regular);
                XFont Font_1 = new XFont("Verdana", 30, XFontStyle.Regular);
                yPoint = yPoint + 100;
                graph.DrawString("Hóa Đơn Bán", Font_1, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 50;
                graph.DrawString("khu phố 6 phường Linh Trung ", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;               
                graph.DrawString("--------------------------------------------------------", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                graph.DrawString("Mã Hóa Đơn", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString(txtMaHD.Text, font, XBrushes.Black, new XRect(120, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                graph.DrawString("Ngày Bán", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString(dTimeNgayBan.Text, font, XBrushes.Black, new XRect(120, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                graph.DrawString("--------------------------------------------------------", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                graph.DrawString("Tên Món Ăn", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Số Lượng", font, XBrushes.Black, new XRect(120, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Đơn Giá", font, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                     TenMonAn = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    SoLuong = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    DonGia = ds.Tables[0].Rows[i].ItemArray[2].ToString();

                   graph.DrawString(TenMonAn, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(SoLuong, font, XBrushes.Black, new XRect(120, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                      graph.DrawString(DonGia, font, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                  yPoint = yPoint + 20;
                }
                graph.DrawString("--------------------------------------------------------", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                graph.DrawString("Tổng Tiền", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(txtThanhTien.Text, font, XBrushes.Black, new XRect(120, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                string pdfFilename = "dbtopdf.pdf";
                pdf.Save(pdfFilename);
               Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
                btnHuyHD.Enabled = false;
                btnLuuHD.Enabled = true;
                btnInHD.Enabled = false;
                btnThemHD.Enabled = false;
                ResetValues();
                           
        }

        private void ResetValues()
        {
            txtMaHD.Text = "";
            dTimeNgayBan.Text = DateTime.Now.ToShortDateString();
            cboMaNV.Text = "";
            txtThanhTien.Text = "0";
        }
    }
}
