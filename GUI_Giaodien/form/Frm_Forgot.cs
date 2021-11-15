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

namespace GUI_Giaodien.form
{
    public partial class Frm_Forgot : Form
    {
        private IserviceQuanLiNhanVien _iQLyNhanVienService;
        private IForgotService _iForgotService;
        private string _code;
        private int _count=0;
        public Frm_Forgot()
        {
            InitializeComponent();
            _iQLyNhanVienService = new ServiceQuanLiNhanVien();
            _iQLyNhanVienService.getlistNV();
            _iForgotService = new ForgotService();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text)==false)
            {
                if (_iQLyNhanVienService.getlistNV().Any(c=>c.Email==txt_Email.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(_iForgotService.RandomString(4, true));
                    builder.Append(_iForgotService.randomNumber(100, 999));
                    builder.Append(_iForgotService.RandomString(2, false));
                    _code = builder.ToString();
                    try
                    {
                        _iForgotService.SendMail(txt_Email.Text, builder.ToString());
                        MessageBox.Show("Gửi email thành công");
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        txt_Code.Visible = true;
                        txt_NewPass.Visible = true;
                        txt_RenewPass.Visible = true;
                        btn_PassChange.Visible = true;
                        btn_Send.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại email");
                }
            }
        }

        private void btn_PassChange_Click(object sender, EventArgs e)
        {
            if (_count==5)
            {
                MessageBox.Show("Bạn đã nhập mã sai 5 lần, vui lòng gửi lại email");
                _count = 0;
            }
            var email = _iQLyNhanVienService.getlistNV().Where(c => c.Email == txt_Email.Text)
                .Select(c => c.Email).FirstOrDefault();
            if (txt_Code.Text==_code)
            {
                if (string.IsNullOrWhiteSpace(txt_NewPass.Text) || string.IsNullOrWhiteSpace(txt_RenewPass.Text))
                {
                    MessageBox.Show("Mật khẩu không được trống");
                    return;
                }
                if (txt_NewPass.Text==txt_NewPass.Text)
                {
                    _iForgotService.updatePass(email,txt_NewPass.Text);
                    _code = null;
                    MessageBox.Show("Đổi mật khẩu thành công");
                    Frm_Login m = new Frm_Login();
                    this.Hide();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải trùng nhau");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại mã xác nhận");
                _count++;
                return;
            }
        }

        private void Frm_Forgot_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txt_Code.Visible = false;
            txt_NewPass.Visible = false;
            txt_RenewPass.Visible = false;
            btn_PassChange.Visible = false;
        }
    }
}
