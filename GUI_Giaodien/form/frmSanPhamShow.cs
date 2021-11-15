using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Dienthoai.IServices;
using BUS_Dienthoai.Services;

namespace GUI_Giaodien.form
{
    public partial class frmSanPhamShow : Form
    {
        private IServiceChiTietSanPham sp = new ServiceChiTietChiTietSanPham();

        public frmSanPhamShow()
        {
            InitializeComponent();
            LoadDataBase();
            for (int i = 0; i < dgrid_sanpham.Columns.Count; i++)
            {
                if (dgrid_sanpham.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgrid_sanpham.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }
        void LoadDataBase()
        {

            dgrid_sanpham.Rows.Clear();
            foreach (var x in sp.getlstSP())
            {
                dgrid_sanpham.Rows.Add((x.TenHangDT + " "+ x.Sanpham.Name + " "+ x.TenMau  +" "+ x.TenBoNho),x.Sanpham.Name , x.TenQuocGia,x.Sanpham.Hinhanh,ChuyenAnh(x.Sanpham.Hinhanh));
            }
            

        }
        public byte[] ChuyenFile(string pathIMG)
        {
            try
            {
                Image theImage = Image.FromFile(pathIMG);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    theImage.Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Image ChuyenAnh(byte[] byteArrayIn)
        {
            try
            {
                if (byteArrayIn == null)
                {
                    return null;
                }
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                return Image.FromStream(ms, true);//Exception occurs here
            }
            catch
            {
                return null;
            }
        }

        private void dgrid_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var row = e.ColumnIndex;
            int rowindex = e.RowIndex;
            frmChiTietSanPham chiTietSanPham = new frmChiTietSanPham();
            chiTietSanPham.Sender(dgrid_sanpham.Rows[rowindex].Cells[0].Value.ToString());
            chiTietSanPham.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgrid_sanpham.Rows.Clear();
            foreach (var x in sp.FindSP(txt_find.Text))
            {
                dgrid_sanpham.Rows.Add((x.TenHangDT + " " + x.Sanpham.Name + " " + x.TenMau + " " + x.TenBoNho), x.Sanpham.Name, x.TenQuocGia, x.Sanpham.Hinhanh, ChuyenAnh(x.Sanpham.Hinhanh));
            }
        }
    }
}
