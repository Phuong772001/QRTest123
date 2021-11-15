using System;
using System.Linq;
using System.Windows.Forms;
using BUS_Dienthoai.IServices;
using BUS_Dienthoai.Services;
using Solution.Data.Entities;

namespace GUI_Giaodien
{
    public partial class FrmQuanLyKhachHang : Form
    {
        private readonly IServicesQlKhachHang _iServicesQlKhachHang;
        private readonly int _id;
        private int _id2;
        private int temp;
        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
            _iServicesQlKhachHang = new ServicesQlKhachHang();
         //  _id=Guid.Parse();
            LoadData();
        }

        public void LoadData()
        {
            dgrv_ttkhachhang.ColumnCount = 4;
            dgrv_ttkhachhang.Columns[0].Name = "Điện thoại";
            dgrv_ttkhachhang.Columns[1].Name = "Tên KH";
            dgrv_ttkhachhang.Columns[2].Name = "Địa chỉ";
            dgrv_ttkhachhang.Columns[3].Name = "ID";
            dgrv_ttkhachhang.Columns["ID"].Visible=false;
            dgrv_ttkhachhang.Rows.Clear();
            if (_iServicesQlKhachHang.listkh().Count <= 0)
            {
                return;
            }
            foreach (var x in _iServicesQlKhachHang.listkh())
            {
                dgrv_ttkhachhang.Rows.Add(x.Sdt, x.Hoten, x.Diachi,x.MaKH);
            }
        }

        private void Frm_QuanLyKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

      

        private void dgrv_ttkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index ==-1  || index == _iServicesQlKhachHang.listkh().Count) return;
            txt_sdt.Text = dgrv_ttkhachhang.Rows[index].Cells[0].Value.ToString();
            txt_name.Text = dgrv_ttkhachhang.Rows[index].Cells[1].Value.ToString();
            rtxt_diachi.Text = dgrv_ttkhachhang.Rows[index].Cells[2].Value.ToString();
            temp = Convert.ToInt32(dgrv_ttkhachhang.Rows[index].Cells[3].Value.ToString());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = new Khachhang()
                {
                    Sdt = txt_sdt.Text,
                    Hoten = txt_name.Text,
                    Diachi = rtxt_diachi.Text,
                };
                MessageBox.Show(_iServicesQlKhachHang.ThemKh(kh), @"Thông báo");
                _iServicesQlKhachHang.getlisDb();
                LoadData();
            }
            catch (Exception)
            {
                Console.WriteLine(@"Lỗi");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = _iServicesQlKhachHang.listkh().FirstOrDefault(c => c.MaKH == temp);
                kh.Sdt = txt_sdt.Text;
                kh.Hoten = txt_name.Text;
                kh.Diachi = rtxt_diachi.Text;
                if (MessageBox.Show(@"Bạn có chắc muốn sửa không?", @"Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) != DialogResult.Yes) return;
                MessageBox.Show(_iServicesQlKhachHang.SuaKh(kh), @"Thông báo");
                _iServicesQlKhachHang.getlisDb();
                LoadData();
            }
            catch (Exception)
            {
                Console.WriteLine(@"Lỗi");
            }
        }

        
        private void btn_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iServicesQlKhachHang.LuuKh());
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(@"Bạn có chắc muốn xóa không?", @"Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) != DialogResult.Yes) return;
                var kh = _iServicesQlKhachHang.listkh().FirstOrDefault(c => c.MaKH == temp);
                MessageBox.Show(_iServicesQlKhachHang.XoaKh(kh), @"Thông báo");
                _iServicesQlKhachHang.getlisDb();
                LoadData();
            }
            catch (Exception)
            {
                Console.WriteLine(@"Lỗi");
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_sdt.Clear();
            txt_tkkh.Clear();
            rtxt_diachi.Clear();
            dgrv_ttkhachhang.Rows.Clear();
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
            _iServicesQlKhachHang.getlisDb();
            LoadData();
        }

        private void btn_nakh_Click(object sender, EventArgs e)
        {
            dgrv_ttkhachhang.ColumnCount = 4;
            dgrv_ttkhachhang.Columns[0].Name = "Điện thoại";
            dgrv_ttkhachhang.Columns[1].Name = "Tên KH";
            dgrv_ttkhachhang.Columns[2].Name = "Địa chỉ";
            dgrv_ttkhachhang.Columns[3].Name = "ID";
            dgrv_ttkhachhang.Columns["ID"].Visible = false;
            dgrv_ttkhachhang.Rows.Clear();
            if (_iServicesQlKhachHang.listkh().Count <= 0)
            {
                return;
            }
            foreach (var x in _iServicesQlKhachHang.listkh().Where(c=>c.Hoten==txt_tkkh.Text))
            {
                dgrv_ttkhachhang.Rows.Add(x.Sdt, x.Hoten, x.Diachi, x.MaKH);
            }
        }
    }
}
