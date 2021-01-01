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
using Restaurant_Management.BLL;

namespace Restaurant_Management.GUI.OrderFood
{
    public partial class BILL : Form
    {
        string idBanAn;
        public BILL(string idBanAn)
        {
            InitializeComponent();
            this.idBanAn = idBanAn;
        }
        public void printBill()
        {
            try
            {
                int i = 0;
                int yPoint = 0;
                string TenMonAn = null;
                string SoLuong = null;
                string DonGia = null;
                string ThanhTien = null;
                string MaHoaDon = null;
                if (idBanAn != null)
                    ThanhTien = Double.Parse(HOADONBAN.Ins.getTongTienTheoBanAn(idBanAn).Rows[0][0].ToString()).ToString("#,##0");

                DataTable ds = BLL.MONAN.Ins.getListMonTheoId(idBanAn);
                string NgayBan = ds.Rows[0].ItemArray[4].ToString();
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
                graph.DrawString(idBanAn, font, XBrushes.Black, new XRect(120, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                graph.DrawString("Ngày Bán", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString(NgayBan, font, XBrushes.Black, new XRect(120, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                graph.DrawString("--------------------------------------------------------", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                graph.DrawString("Tên Món Ăn", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Số Lượng", font, XBrushes.Black, new XRect(160, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Đơn Giá", font, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                for (i = 0; i <= ds.Rows.Count - 1; i++)
                {
                    TenMonAn = ds.Rows[i].ItemArray[1].ToString();
                    SoLuong = ds.Rows[i].ItemArray[3].ToString();
                    DonGia = ds.Rows[i].ItemArray[2].ToString();

                    graph.DrawString(TenMonAn, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(SoLuong, font, XBrushes.Black, new XRect(160, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(DonGia, font, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    yPoint = yPoint + 20;
                }
                graph.DrawString("--------------------------------------------------------", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 20;
                graph.DrawString("Tổng Tiền", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(ThanhTien, font, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                string pdfFilename = "dbtopdf.pdf";
                pdf.Save("D:\\"+pdfFilename);
                Process.Start("D:\\" + pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printBill();
        }
    }
}
