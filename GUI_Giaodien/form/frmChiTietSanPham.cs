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
using System.Xml.Linq;
using BUS_Dienthoai.IServices;
using BUS_Dienthoai.Model;
using BUS_Dienthoai.Services;
using BUS_QLBH.Untility;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace GUI_Giaodien.form
{
    public partial class frmChiTietSanPham : Form
    {
        private int _IDctsp;
        private int _IDbn;
        private int _IDsp;
        private int _IDhdh;
        private int _IDhdt;
        private int _IDms;
        private int _IDqg;
        private int _IDdpg;
        private IServiceChiTietSanPham sp = new ServiceChiTietChiTietSanPham();

        //private Hang _hang;
        //private string _email;
        //public delegate void SendMessage(string Message);
        //public SendMessage Sender;
        private string mess = "Thông báo";
        //public string _manvlogin;
        //private unitity uni = new unitity();
        private byte[] _arrImg;
        string path = "";
        //private string anh;
        private Sanpham _sanpham;
        private Quocgia _quocgia;
        private Mausac _mausac;
        private Bonho _bonho;
        private DoPhanGiai _doPhanGiai;
        private HangDT _hangDt;
        private Hedieuhanh _hedieuhanh;
        private Chitietsanpham _chitietsanpham;
        private ChiTietSanPhamBUS _chiTietSanPhamBus;
        private unitity uni;

        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        public frmChiTietSanPham()
        {
            InitializeComponent();
            uni = new unitity();
            LoadDataBase();
            Sender = new SendMessage(GetMessage);
            _sanpham = new Sanpham();
            _quocgia = new Quocgia();
            _mausac = new Mausac();
            _bonho = new Bonho();
            _doPhanGiai = new DoPhanGiai();
            _hangDt = new HangDT();
            _hedieuhanh = new Hedieuhanh();
            _chitietsanpham = new Chitietsanpham();
            _chiTietSanPhamBus = new ChiTietSanPhamBUS();
            SetDataToCollection();
            for (int i = 0; i < dgrid_sanpham.Columns.Count; i++)
            {
                if (dgrid_sanpham.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgrid_sanpham.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            LoadLoaiLoc();
            loadLoc();

        }

        private void LoadLoaiLoc()
        {
            cmb_LoaiLoc.Items.Add("Màu Sắc");
            cmb_LoaiLoc.Items.Add("Quốc Gia");
            cmb_LoaiLoc.Items.Add("Hệ Điều Hành");
            cmb_LoaiLoc.Items.Add("Hãng Điện Thoại");
            cmb_LoaiLoc.Items.Add("Độ Phân Giải");
            cmb_LoaiLoc.Items.Add("Bộ Nhớ");
        }

        private void loadLoc()
        {
            cmb_Loc.Items.Clear();

            if (cmb_LoaiLoc.SelectedItem == "" || cmb_LoaiLoc.SelectedText == null)
            {
                return;
            }

            if (cmb_LoaiLoc.SelectedItem == "Bộ Nhớ")
            {
                foreach (var x in sp.GetlistBonhos())
                {
                    cmb_Loc.Items.Add(x.Name);
                }

            }
            if (cmb_LoaiLoc.SelectedItem == "Màu Sắc")
            {
                foreach (var x in sp.GetlistMausacs())
                {
                    cmb_Loc.Items.Add(x.Color);
                }
            }

            if (cmb_LoaiLoc.SelectedItem == "Quốc Gia")
            {
                foreach (var x in sp.GetlistQuocgias())
                {
                    cmb_Loc.Items.Add(x.Name);
                }
            }
            if (cmb_LoaiLoc.SelectedItem == "Độ Phân Giải")
            {
                foreach (var x in sp.GetlistDoPhanGiais())
                {
                    cmb_Loc.Items.Add(x.Name);
                }
            }
            if (cmb_LoaiLoc.SelectedItem == "Hệ Điều Hành")
            {
                foreach (var x in sp.GetlisthHedieuhanhs())
                {
                    cmb_Loc.Items.Add(x.Name);
                }
            }
            if (cmb_LoaiLoc.SelectedItem == "Hãng Điện Thoại")
            {
                foreach (var x in sp.GetlistHangDts())
                {
                    cmb_Loc.Items.Add(x.Name);
                }
            }



        }
        private void GetMessage(string Message)
        {
            txt_find.Text = Message;
        }
        private void SetDataToCollection()
        {
            AutoCompleteStringCollection autoqg = new AutoCompleteStringCollection();
            txt_quocGia.AutoCompleteMode = AutoCompleteMode.Append;
            txt_quocGia.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection automt = new AutoCompleteStringCollection();
            txt_MotaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_MotaSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autobn = new AutoCompleteStringCollection();
            txt_boNho.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_boNho.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autodpg = new AutoCompleteStringCollection();
            txt_doPhanGiai.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_doPhanGiai.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection automs = new AutoCompleteStringCollection();
            txt_mauSac.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_mauSac.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autohdt = new AutoCompleteStringCollection();
            txt_hangĐT.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_hangĐT.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autohdh = new AutoCompleteStringCollection();
            txt_heDieuHanh.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_heDieuHanh.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autonamesp = new AutoCompleteStringCollection();

            txt_nameSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_nameSP.AutoCompleteSource = AutoCompleteSource.CustomSource;


            foreach (var x in sp.GetlistBonhos())
            {
                autobn.Add(x.Name);
            }
            txt_boNho.AutoCompleteCustomSource = autobn;

            foreach (var x in sp.GetlistQuocgias())
            {
                autoqg.Add(x.Name);
            }
            txt_quocGia.AutoCompleteCustomSource = autoqg;

            foreach (var x in sp.GetlistDoPhanGiais())
            {
                autodpg.Add(x.Name);
            }
            txt_doPhanGiai.AutoCompleteCustomSource = autodpg;

            foreach (var x in sp.GetlisthHedieuhanhs())
            {
                autohdh.Add(x.Name);
            }
            txt_heDieuHanh.AutoCompleteCustomSource = autohdh;

            foreach (var x in sp.GetlistHangDts())
            {
                autohdt.Add(x.Name);
            }
            txt_hangĐT.AutoCompleteCustomSource = autohdt;

            foreach (var x in sp.GetlistMausacs())
            {
                automs.Add(x.Color);
            }
            txt_mauSac.AutoCompleteCustomSource = automs;

            foreach (var x in sp.getlistSanPhams().Where(c => c.Name == txt_nameSP.Text))
            {
                automt.Add(x.Mota);
            }
            txt_MotaSP.AutoCompleteCustomSource = automt;

            foreach (var x in sp.getlistSanPhams())
            {
                autonamesp.Add(x.Name);
            }
            txt_nameSP.AutoCompleteCustomSource = autonamesp;


        }
        
        void LoadDataBase()
        {

            dgrid_sanpham.Rows.Clear();
            foreach (var x in sp.getlstSP())
            {
                dgrid_sanpham.Rows.Add(x.TenHangDT, x.Sanpham.Name, x.TenQuocGia, x.TenMau, x.TenBoNho, x.TenDoPhanGiai,
                    x.TenHeDieuHanh, x.Sanpham.Mota, x.Chitietsanpham.Gia, x.Chitietsanpham.Soluong,
                    (x.Sanpham.Hinhanh), ChuyenAnh(x.Sanpham.Hinhanh), x.Chitietsanpham.IDChitietsp, x.TenCTSP);
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


        private void btn_add_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc thêm không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (sp.selectQuocgia(txt_quocGia.Text) != -1)
                {
                    _quocgia = new Quocgia();
                    _quocgia.Id = sp.selectQuocgia(txt_quocGia.Text);
                }
                else
                {
                    _quocgia = new Quocgia();
                    _quocgia.Name = txt_quocGia.Text;
                    sp.AddQG(_quocgia);
                }


                if (sp.selectMausac(txt_mauSac.Text) != -1)
                {
                    _mausac = new Mausac();
                    _mausac.Id = sp.selectMausac(txt_mauSac.Text);
                }
                else
                {
                    _mausac = new Mausac();
                    _mausac.Color = txt_mauSac.Text;
                    sp.AddMS(_mausac);
                }
                if (sp.selectBonho(txt_boNho.Text) != -1)
                {
                    _bonho = new Bonho();
                    _bonho.Id = sp.selectBonho(txt_boNho.Text);
                }
                else
                {
                    _bonho = new Bonho();

                    _bonho.Name = txt_boNho.Text;
                    sp.AddBN(_bonho);
                }
                if (sp.selectDoPhanGiai(txt_doPhanGiai.Text) != -1)
                {
                    _doPhanGiai = new DoPhanGiai();
                    _doPhanGiai.Id = sp.selectDoPhanGiai(txt_doPhanGiai.Text);
                }
                else
                {
                    _doPhanGiai = new DoPhanGiai();

                    _doPhanGiai.Name = txt_doPhanGiai.Text;
                    sp.AddDPG(_doPhanGiai);
                }

                if (sp.selecthHedieuhanh(txt_heDieuHanh.Text) != -1)
                {
                    _hedieuhanh = new Hedieuhanh();
                    _hedieuhanh.Id = sp.selecthHedieuhanh(txt_heDieuHanh.Text);
                }
                else
                {
                    _hedieuhanh = new Hedieuhanh();

                    _hedieuhanh.Name = txt_heDieuHanh.Text;
                    sp.AddHDH(_hedieuhanh);
                }
                if (sp.selectHangDt(txt_hangĐT.Text) != -1)
                {
                    _hangDt = new HangDT();
                    _hangDt.Id = sp.selectHangDt(txt_hangĐT.Text);
                }
                else
                {

                    _hangDt = new HangDT();

                    _hangDt.Name = txt_hangĐT.Text;

                    sp.AddHangDT(_hangDt);
                }
                if (sp.selectsSanpham(txt_nameSP.Text) != -1)
                {
                    _sanpham = new Sanpham();
                    _sanpham.Id = sp.selectsSanpham(txt_nameSP.Text);
                }
                else
                {

                    _sanpham = new Sanpham();

                    _sanpham.Name = txt_nameSP.Text;
                    _sanpham.Mota = txt_MotaSP.Text;
                    _sanpham.Hinhanh = ChuyenFile(path);
                    _sanpham.Imei = uni.RandomSO(15);
                    _sanpham.IdHang = _hangDt.Id;
                    sp.AddSP(_sanpham);
                }

                _chitietsanpham = new Chitietsanpham();
                if (sp.getlstSP().Count == 0)
                {
                    _chitietsanpham.IDChitietsp = 0;
                }
                else
                {
                    _chitietsanpham.IDChitietsp = sp.getlstSP().Max(c => c.Chitietsanpham.IDChitietsp) + 1;

                }
                _chitietsanpham.IDSanPham = _sanpham.Id;
                _chitietsanpham.IDBonho = _bonho.Id;
                _chitietsanpham.IDDophangiai = _doPhanGiai.Id;
                _chitietsanpham.IDHedieuhanh = _hedieuhanh.Id;
                _chitietsanpham.IDMausac = _mausac.Id;
                _chitietsanpham.IDQuocgia = _quocgia.Id;
                _chitietsanpham.Gia = Convert.ToInt32(txt_gia.Text);
                _chitietsanpham.Soluong = Convert.ToInt32(txt_soLuong.Text);

                MessageBox.Show(sp.AddCTSP(_chitietsanpham), mess);
                // MessageBox.Show(sp.AddCTSP( _quocgia, _mausac, _hedieuhanh, _doPhanGiai, _bonho, _sanpham, _chitietsanpham), mess);
                LoadDataBase();
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string path1 = File();
            _arrImg = ChuyenFile(path1);
            pic_hinhAnh.Image = Image.FromFile(path1);
        }

       

        private void dgrid_sanpham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.ColumnIndex;
            int rowindex = e.RowIndex;

            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[0].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[1].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[2].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[3].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[4].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[5].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[6].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[7].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[8].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[9].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[10].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dgrid_sanpham.Rows[e.RowIndex].Cells[11].Value?.ToString()))
            {
                return;
            }
            if (rowindex == sp.getlstSP().Count || rowindex == -1) return;
            _IDctsp = Convert.ToInt32(dgrid_sanpham.Rows[rowindex].Cells[12].Value.ToString());
            _IDhdt = sp.selectHangDt(dgrid_sanpham.Rows[rowindex].Cells[0].Value.ToString());
            _IDsp = sp.selectsSanpham(dgrid_sanpham.Rows[rowindex].Cells[1].Value.ToString());
            _IDqg = sp.selectQuocgia(dgrid_sanpham.Rows[rowindex].Cells[2].Value.ToString());
            _IDms = sp.selectMausac(dgrid_sanpham.Rows[rowindex].Cells[3].Value.ToString());
            _IDbn = sp.selectBonho(dgrid_sanpham.Rows[rowindex].Cells[4].Value.ToString());
            _IDdpg = sp.selectDoPhanGiai(dgrid_sanpham.Rows[rowindex].Cells[5].Value.ToString());
            _IDhdh = sp.selecthHedieuhanh(dgrid_sanpham.Rows[rowindex].Cells[6].Value.ToString());

           

            //var check1 = sp.getlstSP().Where(c => c.hang.MaHang == MaHangwhenClick).Select(c => c.MaNv).FirstOrDefault();
            //if (check1 != _manvlogin)
            //{
            //    btn_update.Enabled = false;
            //    btn_delete.Enabled = false;
            //    btn_add.Enabled = false;
            //    btn_save.Enabled = false;
            //    dgrid_sanpham.Columns["cmb_dgv"].Visible = false;
            //    dgrid_sanpham.Columns["btn_dgv"].Visible = false;
            //}
            //if (check1 == _manvlogin)
            //{
            //    btn_update.Enabled = true;
            //    btn_delete.Enabled = true;
            //    btn_add.Enabled = true;
            //    btn_save.Enabled = true;
            //    dgrid_sanpham.Columns["cmb_dgv"].Visible = true;
            //    dgrid_sanpham.Columns["btn_dgv"].Visible = true;
            //}

            txt_hangĐT.Text = dgrid_sanpham.Rows[rowindex].Cells[0].Value.ToString();
            txt_nameSP.Text = dgrid_sanpham.Rows[rowindex].Cells[1].Value.ToString();

            txt_quocGia.Text = dgrid_sanpham.Rows[rowindex].Cells[2].Value.ToString();
            txt_mauSac.Text = dgrid_sanpham.Rows[rowindex].Cells[3].Value.ToString();
            txt_boNho.Text = dgrid_sanpham.Rows[rowindex].Cells[4].Value.ToString();
            txt_doPhanGiai.Text = dgrid_sanpham.Rows[rowindex].Cells[5].Value.ToString();
            txt_heDieuHanh.Text = dgrid_sanpham.Rows[rowindex].Cells[6].Value.ToString();
            txt_MotaSP.Text = dgrid_sanpham.Rows[rowindex].Cells[7].Value.ToString();
            txt_gia.Text = dgrid_sanpham.Rows[rowindex].Cells[8].Value.ToString();
            txt_soLuong.Text = dgrid_sanpham.Rows[rowindex].Cells[9].Value.ToString();
            byte[] b = (byte[])dgrid_sanpham.Rows[rowindex].Cells[10].Value;
            _arrImg = (byte[])dgrid_sanpham.Rows[rowindex].Cells[10].Value;
            pic_hinhAnh.Image = ChuyenAnh(b);
            txt_fullName.Text = dgrid_sanpham.Rows[rowindex].Cells[13].Value.ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc sửa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                var _quocgia = sp.selectQuocgiaUP(_IDqg);

                _quocgia.Name = txt_quocGia.Text;

                sp.UpdateQG(_quocgia);


                var _mausac = sp.selectMausacUP(_IDms);

                _mausac.Color = txt_mauSac.Text;

                sp.UpdateMS(_mausac);


                var _bonho = sp.selectBonhoUP(_IDbn);

                _bonho.Name = txt_boNho.Text;
                sp.UpdateBN(_bonho);


                var _doPhanGiai = sp.selectDoPhanGiaiUP(_IDdpg);

                _doPhanGiai.Name = txt_doPhanGiai.Text;
                sp.UpdateDPG(_doPhanGiai);



                var _hedieuhanh = sp.selecthHedieuhanhUP(_IDhdh);

                _hedieuhanh.Name = txt_heDieuHanh.Text;
                sp.UpdateHDH(_hedieuhanh);


                var _hangDt = sp.selectHangDtUP(_IDhdt);

                _hangDt.Name = txt_hangĐT.Text;

                sp.UpdateHangDT(_hangDt);


                var _sanpham = sp.selectsSanphamUP(_IDsp);

                _sanpham.Name = txt_nameSP.Text;
                _sanpham.Mota = txt_MotaSP.Text;
                _sanpham.Hinhanh = ChuyenFile(path);
                if (path == "")
                {
                    _sanpham.Hinhanh = _arrImg;
                }
                _sanpham.IdHang = _hangDt.Id;
                sp.UpdateSP(_sanpham);

                var _chitietsanpham = sp.selectChitietsanphamUP(_IDctsp);

                _chitietsanpham.IDSanPham = _sanpham.Id;
                _chitietsanpham.IDBonho = _bonho.Id;
                _chitietsanpham.IDDophangiai = _doPhanGiai.Id;
                _chitietsanpham.IDHedieuhanh = _hedieuhanh.Id;
                _chitietsanpham.IDMausac = _mausac.Id;
                _chitietsanpham.IDQuocgia = _quocgia.Id;
                _chitietsanpham.Gia = Convert.ToInt32(txt_gia.Text);
                _chitietsanpham.Soluong = Convert.ToInt32(txt_soLuong.Text);

                MessageBox.Show(sp.UpdateCTSP(_chitietsanpham), mess);
                LoadDataBase();
            }
            //}
            LoadDataBase();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(sp.DeleteCTSP(_IDctsp), mess);
                LoadDataBase();
            }
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            dgrid_sanpham.Rows.Clear();
            foreach (var x in sp.FindSP(txt_find.Text))
            {
                dgrid_sanpham.Rows.Add(x.TenHangDT, x.Sanpham.Name, x.TenQuocGia, x.TenMau, x.TenBoNho, x.TenDoPhanGiai,
                    x.TenHeDieuHanh, x.Sanpham.Mota, x.Chitietsanpham.Gia, x.Chitietsanpham.Soluong,
                    (x.Sanpham.Hinhanh), ChuyenAnh(x.Sanpham.Hinhanh), x.Chitietsanpham.IDChitietsp, x.TenCTSP);
            }
        }

        private void cmb_LoaiLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLoc();
        }

        private void cmb_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgrid_sanpham.Rows.Clear();
            foreach (var x in sp.Find(cmb_Loc.Text))
            {
                dgrid_sanpham.Rows.Add(x.TenHangDT, x.Sanpham.Name, x.TenQuocGia, x.TenMau, x.TenBoNho, x.TenDoPhanGiai,
                    x.TenHeDieuHanh, x.Sanpham.Mota, x.Chitietsanpham.Gia, x.Chitietsanpham.Soluong,
                    (x.Sanpham.Hinhanh), ChuyenAnh(x.Sanpham.Hinhanh), x.Chitietsanpham.IDChitietsp);
            }
        }

        private void pic_sp_Click(object sender, EventArgs e)
        { frmSanPham frm = new frmSanPham();
            frm.Show();

        }

        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {

        }

        private void pic_hangDT_Click(object sender, EventArgs e)
        {
            frmHangDT frm = new frmHangDT();
            frm.Show();
        }

        private void pic_qg_Click(object sender, EventArgs e)
        {
            frmQuocGia frm = new frmQuocGia();
            frm.Show();
        }

        private void pic_ms_Click(object sender, EventArgs e)
        {
            frmMauSac frm = new frmMauSac();
            frm.Show();
        }

        private void pic_bn_Click(object sender, EventArgs e)
        {
            frmBoNho frm = new frmBoNho();
            frm.Show();
        }

        private void pic_dpg_Click(object sender, EventArgs e)
        {
            frmDoPhanGỉai frm = new frmDoPhanGỉai();
            frm.Show();
        }

        private void pic_hdh_Click(object sender, EventArgs e)
        {
            frmHeDieuHanh frm = new frmHeDieuHanh();
            frm.Show();
        }
    }
}
