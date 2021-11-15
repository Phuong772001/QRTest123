using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Dienthoai.IServices;
using BUS_Dienthoai.Services;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace GUI_Giaodien.form
{
    public partial class Frm_Login : Form
    {
        private Nhanvien _nhanvien;
        private IserviceQuanLiNhanVien _iQLyNhanVienService;
        private ILoginService _iloginService;
        private IserviceQLLS _serviceQlls;
        public static string email;
        public Frm_Login()
        {

            InitializeComponent();
            _iQLyNhanVienService = new ServiceQuanLiNhanVien();
            _iloginService = new LoginService();
            _nhanvien = new Nhanvien();
            _serviceQlls = new ServiceQuanLiLichSu();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (_iloginService.login(txt_Email.Text, txt_Pass.Text) == true)
            {
                Lichsu nv = new Lichsu();
                nv.MaNV = _iQLyNhanVienService.getlistNV().Where(c => c.Email == txt_Email.Text).Select(c => c.MaNV)
                    .FirstOrDefault();
                nv.Email = txt_Email.Text;
                nv.tenNV = _iQLyNhanVienService.getlistNV().Where(c => c.Email == txt_Email.Text).Select(c => c.FullName)
                    .FirstOrDefault();
                nv.ThoigianBatdau = DateTime.Now;
                _serviceQlls.ThemNV(nv);
                _serviceQlls.getlistDB();
                email = txt_Email.Text;
                MessageBox.Show("Đăng nhập thành công");
                Menu frmMenu = new Menu();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tài khoản và mật khẩu");
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Forgot m = new Frm_Forgot();
            this.Hide();
            m.Show();
        }
    }
}
