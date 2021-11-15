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
using BUS_QLBH.Untility;
using SellingPhone.Aplication.Entities;

namespace GUI_Giaodien.form
{
    public partial class frmSanPham : Form
    {
        private IServiceChiTietSanPham sp = new ServiceChiTietChiTietSanPham();
        private string mess = "Thông báo";
        private Sanpham _sanpham;
        private int IDwhenClick;
        private int IDHangwhenClick;
        private string path = "";
        private byte[] _arrImg;
        private byte[] arrCellClik;
        private bool flag;
        private unitity uni = new unitity();


        public frmSanPham()
        {
            InitializeComponent();
            _sanpham = new Sanpham();
            bool flag = false;
            loadCRUD();
            loadDB();
            for (int i = 0; i < txt_find.Columns.Count; i++)
            {
                if (txt_find.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)txt_find.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }
        public string File()
        {
            path = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.jfif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return path = dlg.FileName;
            }
            return path;
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
        void loadDB()
        {
            txt_find.Rows.Clear();
            foreach (var x in sp.getlistSanPhams())
            {
                txt_find.Rows.Add(x.Id,sp.GetlistHangDts().Where(c=>c.Id == x.IdHang).Select(c=>c.Name).FirstOrDefault(), x.Name, x.Mota, x.Hinhanh, ChuyenAnh(x.Hinhanh),x.Imei);
            }
        }
        void loadCRUD()
        {
            CRUD.Items.Add("Add");
            CRUD.Items.Add("Update");
            CRUD.Items.Add("Delete");
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                var row = e.ColumnIndex;
                int rowindex = e.RowIndex;
                
                if (row == txt_find.Columns["HaShow"].Index)
                {
                    string path1 = File();
                    _arrImg = ChuyenFile(path1);
                    txt_find.Rows[rowindex].Cells[txt_find.Columns["HaShow"].Index].Value = ChuyenAnh(_arrImg);
                    flag = true;
                }


                if (row == txt_find.Columns["Ok"].Index)
                {
                    if (txt_find.Rows[rowindex].Cells[txt_find.Columns["CRUD"].Index].Value
                        == null || txt_find.Rows[rowindex].Cells[txt_find.Columns["CRUD"].Index].Value == "") return;
                    string a = txt_find.Rows[rowindex].Cells[txt_find.Columns["CRUD"].Index].Value.ToString();

                    if (a == "Add")
                    {

                        if (MessageBox.Show("Bạn có chắc thêm không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            _sanpham = new Sanpham();

                            _sanpham.Name = txt_find.Rows[rowindex].Cells[2].Value.ToString();
                            _sanpham.Mota = txt_find.Rows[rowindex].Cells[3].Value.ToString();
                            if (flag)
                            {
                                _sanpham.Hinhanh = _arrImg;
                            }
                            else
                            {
                                _sanpham.Hinhanh = null;
                            }

                            _sanpham.Imei = uni.RandomSO(15);
                            if (IDHangwhenClick == -1)
                            {
                                HangDT hangdt = new HangDT();
                                hangdt.Name = txt_find.Rows[rowindex].Cells[1].Value.ToString();
                                sp.AddHangDT(hangdt);
                                IDHangwhenClick = hangdt.Id;

                            }
                            _sanpham.IdHang = IDHangwhenClick;
                            MessageBox.Show(sp.AddSP(_sanpham), mess);
                            loadDB();
                        }
                    }
                    if (a == "Update")
                    {
                        if (sp.selectsSanphamUP(IDwhenClick) == null)
                        {
                            return;
                        }
                        else
                        {

                            var sprs = sp.selectsSanphamUP(IDwhenClick);
                            sprs.Name = txt_find.Rows[rowindex].Cells[2].Value.ToString();
                            sprs.Mota = txt_find.Rows[rowindex].Cells[3].Value.ToString();
                            if (flag)
                            {
                                sprs.Hinhanh = _arrImg;
                                flag = false;
                            }
                            else
                            {
                                sprs.Hinhanh = arrCellClik;
                            }
                            if (IDHangwhenClick == -1)
                            {
                                HangDT hangdt = new HangDT();
                                hangdt.Name = txt_find.Rows[rowindex].Cells[1].Value.ToString();
                                sp.AddHangDT(hangdt);
                                IDHangwhenClick = hangdt.Id;
                            }
                            sprs.IdHang = IDHangwhenClick;
                            if (MessageBox.Show("Bạn có chắc sửa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                MessageBox.Show(sp.UpdateSP(sprs), mess);
                                loadDB();
                            }
                        }
                    }
                    if (a == "Delete")
                    {
                        if (MessageBox.Show("Bạn có chắc xóa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            MessageBox.Show(sp.DeleteSP(IDwhenClick), mess);
                            loadDB();
                        }
                    }
                }

            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.ColumnIndex;
            int rowindex = e.RowIndex;

            if (row == txt_find.Columns["CRUD"].Index)
            {
                return;
            }
            if (string.IsNullOrEmpty(txt_find.Rows[e.RowIndex].Cells[0].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(txt_find.Rows[e.RowIndex].Cells[1].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(txt_find.Rows[e.RowIndex].Cells[3].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(txt_find.Rows[e.RowIndex].Cells[4].Value?.ToString()))
            {
                return;
            }if (string.IsNullOrEmpty(txt_find.Rows[e.RowIndex].Cells[5].Value?.ToString()))
            {
                return;
            }

            if (rowindex == sp.getlistSanPhams().Count || rowindex == -1) return;
            IDwhenClick = Convert.ToInt32(txt_find.Rows[rowindex].Cells[0].Value.ToString());
            IDHangwhenClick = sp.selectHangDt(txt_find.Rows[rowindex].Cells[1].Value.ToString());
            arrCellClik = (byte[])txt_find.Rows[rowindex].Cells[4].Value;


        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            txt_find.Rows.Clear();
            foreach (var x in sp.getlistSanPhams().Where(c=>c.Name == txt_find.Text))
            {
                txt_find.Rows.Add(x.Id, sp.GetlistHangDts().Where(c => c.Id == x.IdHang).Select(c => c.Name).FirstOrDefault(), x.Name, x.Mota, x.Hinhanh, ChuyenAnh(x.Hinhanh), x.Imei);
            }
        }
    }
}
