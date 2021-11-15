using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Dienthoai.IServices;
using BUS_Dienthoai.Services;
using GUI_Giaodien;
using GUI_Giaodien.form;
using Solution.Data.Entities;
using ZXing;

namespace ScanQR
{
    public partial class frmDangNhapQR : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private Nhanvien _nhanvien;
        private IserviceQuanLiNhanVien _iQLyNhanVienService;
        private ILoginService _iloginService;
        private IserviceQLLS _serviceQlls;
        public static string email;
        public frmDangNhapQR()
        {
            InitializeComponent();
            _iQLyNhanVienService = new ServiceQuanLiNhanVien();
            _iloginService = new LoginService();
            _nhanvien = new Nhanvien();
            _serviceQlls = new ServiceQuanLiLichSu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cboCamera.Items.Add(Device.Name);
            if (cboCamera.Items.Count > 0)
            {
                cboCamera.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }
           
        }
        CancellationTokenSource cancellationToken;
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Bắt đầu")
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
                videoCaptureDevice.Start();
                cancellationToken = new CancellationTokenSource();
                var sourcetoken = cancellationToken.Token;
                onStartScan(sourcetoken);
                button1.Text = "Dừng lại!";
            }
            else
            {
                button1.Text = "Bắt đầu";
                cancellationToken.Cancel();
                if (videoCaptureDevice != null)
                    if (videoCaptureDevice.IsRunning == true)
                        videoCaptureDevice.Stop();
            }

           
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void onStartScan(CancellationToken sourcetoken)
        {
            Task.Factory.StartNew(new Action(() =>
            {
                while (true)
                {
                    if (sourcetoken.IsCancellationRequested)
                    {
                        return;
                    }
                    Thread.Sleep(50);
                    BarcodeReader Reader = new BarcodeReader();                   
                    pictureBox1.BeginInvoke(new Action(() =>
                    {
                        if (pictureBox1.Image != null)
                        {
                            try
                            {
                                var results = Reader.DecodeMultiple((Bitmap)pictureBox1.Image);
                                if (results != null)
                                {
                                    foreach (Result result in results)
                                    {
                                        lbl_result.Text = result.ToString();//+ $"- Type: { result.BarcodeFormat.ToString()}";
                                        
                                        SystemSounds.Beep.Play();
                                        if (result.ResultPoints.Length > 0)
                                        {
                                            var offsetX = pictureBox1.SizeMode == PictureBoxSizeMode.Zoom
                                               ? (pictureBox1.Width - pictureBox1.Image.Width) / 2 :
                                               0;
                                            var offsetY = pictureBox1.SizeMode == PictureBoxSizeMode.Zoom
                                               ? (pictureBox1.Height - pictureBox1.Image.Height) / 2 :
                                               0;
                                            var rect = new Rectangle((int)result.ResultPoints[0].X + offsetX, (int)result.ResultPoints[0].Y + offsetY, 1, 1);
                                            foreach (var point in result.ResultPoints)
                                            {
                                                if (point.X + offsetX < rect.Left)
                                                    rect = new Rectangle((int)point.X + offsetX, rect.Y, rect.Width + rect.X - (int)point.X - offsetX, rect.Height);
                                                if (point.X + offsetX > rect.Right)
                                                    rect = new Rectangle(rect.X, rect.Y, rect.Width + (int)point.X - (rect.X - offsetX), rect.Height);
                                                if (point.Y + offsetY < rect.Top)
                                                    rect = new Rectangle(rect.X, (int)point.Y + offsetY, rect.Width, rect.Height + rect.Y - (int)point.Y - offsetY);
                                                if (point.Y + offsetY > rect.Bottom)
                                                    rect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height + (int)point.Y - (rect.Y - offsetY));
                                            }
                                            using (var g = lbl_result.CreateGraphics())
                                            {
                                                using (Pen pen = new Pen(Color.Green, 5))
                                                {                                                  
                                                    g.DrawRectangle(pen, rect);

                                                    pen.Color = Color.Yellow;
                                                    pen.DashPattern = new float[] { 5, 5 };
                                                    g.DrawRectangle(pen, rect);
                                                }
                                                g.DrawString(result.ToString(), new Font("Tahoma", 16f), Brushes.Blue, new Point(rect.X - 60, rect.Y - 50));
                                            }
                                        }


                                    }

                                }
                            }
                            catch (Exception)
                            {                               
                            }
                        }

                    }));
                   
                }
            }), sourcetoken);
        }
      

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null)
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

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

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
