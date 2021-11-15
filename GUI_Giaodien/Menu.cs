using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Dienthoai.IServices;
using BUS_Dienthoai.Services;
using GUI_Giaodien.form;

namespace GUI_Giaodien
{
    public partial class Menu : Form
    {
        //fields
        private Button curentbutButton;
        private Random random;
        private int tempindex;
        private Form activeform;
        private string email = Frm_Login.email;
        private IserviceQuanLiNhanVien _serviceQuanLiNhanVien;
        private IserviceQLLS _serviceQlls;
        public Menu()
        {
            InitializeComponent();
            random = new Random();
            _serviceQuanLiNhanVien = new ServiceQuanLiNhanVien();
            _serviceQlls = new ServiceQuanLiLichSu();
            Loadanh();
        }
        private Color Them()
        {
            int index = random.Next(ThemColor.colorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemColor.colorList.Count);
            }

            tempindex = index;
            string color = ThemColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        
        public void Loadanh()
        {
           label3.Text = _serviceQuanLiNhanVien.getlistNV().Where(c => c.Email == email).Select(c => c.FullName)
                .FirstOrDefault();
          var  a=_serviceQuanLiNhanVien.getlistNV().Where(c => c.Email == email).Select(c => c.Hinhanh)
               .FirstOrDefault();
         // HA.Image =bytesangimge(a);
        }
        //public Image bytesangimge(byte[] b)
        //{
        //    MemoryStream a = new MemoryStream(b);
        //    return Image.FromStream(a);

        //}
        private void ActivateButton(object btnsenderr)
        {
            if (btnsenderr != null)
            {
                if (curentbutButton != (Button)btnsenderr)
                {
                    Disablebutton();
                    Color color = Them();
                    curentbutButton = (Button)btnsenderr;
                    curentbutButton.BackColor = color;
                    curentbutButton.ForeColor = Color.White;
                    curentbutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelmeiii.BackColor = color;
                    panelmenu.BackColor = ThemColor.ChangcolorBrightness(color, -0.3);
                    picturethoat.Visible = true;
                }
            }
        }

        private void openchiderent(Form chidren, object btnsender)
        {
            //if (activeform != null)
            //{
            //    activeform.Close();
            //}
            ActivateButton(btnsender);
            activeform = chidren;
            chidren.TopLevel = false;
            chidren.FormBorderStyle = FormBorderStyle.None;
            chidren.Dock = DockStyle.Fill;
            this.paneldektop.Controls.Add(chidren);
            this.paneldektop.Tag = chidren;
            chidren.BringToFront();
            chidren.Show();
            lbltitle.Text = chidren.Text;

        }
        private void Disablebutton()
        {
            foreach (Control preControlbtn in panelmenu.Controls)
            {
                if (preControlbtn.GetType() == typeof(Button))
                {
                    preControlbtn.BackColor = Color.FromArgb(112, 128, 144);
                    preControlbtn.ForeColor = Color.Gainsboro;
                    preControlbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchiderent(new frmSanPham(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchiderent(new Nhân_Viên(), sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            openchiderent(new FrmQuanLyKhachHang(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openchiderent(new frmLichsudangnhap(), sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
       


        private void picturethoat_Click(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
            reset();
        }
        private void reset()
        {
            Disablebutton();
            lbltitle.Text = "Smartphone store";
            panelmeiii.BackColor = Color.FromArgb(95, 158, 160);
            panelmenu.BackColor = Color.FromArgb(0, 134, 139);
            curentbutButton = null;
            picturethoat.Visible = false;
        }

       
        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            var time = DateTime.Now;
            var email2 = _serviceQlls.getlistLS().Where(c => c.id == _serviceQlls.getlistLS().Max(c => c.id)).Select(c => c.Email).First();
            var idFirst = _serviceQlls.getlistLS().Where(c => c.id == _serviceQlls.getlistLS().Max(c => c.id)).Select(c => c.id).First();
            var ls = _serviceQlls.getlistLS().Where(c => c.Email == email2 && c.id == idFirst).FirstOrDefault();
            ls.ThoigianketT=time;
            _serviceQlls.Sua(ls);
            Frm_Login m = new Frm_Login();
            this.Hide();
            m.Show();
        }

    }
}
