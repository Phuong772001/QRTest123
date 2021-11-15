using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Dienthoai.IServices;
using BUS_Dienthoai.Services;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace GUI_Giaodien.form
{
    public partial class Nhân_Viên : Form
    {
        private IserviceQuanLiNhanVien _serviceQlnv;
        private int temp;
        DataGridViewComboBoxColumn s = new DataGridViewComboBoxColumn();
        private int rowIndex;
        private string hemail = "binhktph16675@fpt.edu.vn";
        private string haha = "Gửi mail Từ Phần Mềm quản lí bán hàng";
        string hihi;
        private Attachment atrAttachment = null;
        private string t;
        public Nhân_Viên()
        {
            InitializeComponent();
            _serviceQlnv = new ServiceQuanLiNhanVien();
            LoadGridAccount();
            Loadroles();
            loadns();
            LoadMaGT();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }

            loadloc();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua;

        }

        public void loadloc()
        {
            cbbloc.Items.Add("Giới Tính");
            cbbloc.Items.Add("Vai Trò ");
            cbbgt.Items.Add("Nam");
            cbbgt.Items.Add("Nữ");
            cbb_VT.Items.Add("Nhân Viên");
            cbb_VT.Items.Add("Quản Lí");

        }
        void Loadroles()
        {
            foreach (var x in _serviceQlnv.GetlistRoles())
            {
                Vt.Items.Add(x.Name);
            }
        }

        void loadns()
        {
            s.Items.Add("Thêm");
            s.Items.Add("Sửa");
            s.Items.Add("Xóa");
        }

        void LoadMaGT()
        {
            gt.Items.Add("Nam");
            gt.Items.Add("Nữ");

        }

        void LoadGridAccount()
        {
            dataGridView1.Rows.Clear();
            if (_serviceQlnv.getlistNV().Count < 0) return;
            foreach (var x in _serviceQlnv.getlistNV())
            {
                dataGridView1.Rows.Add(x.FullName, x.Password, x.Phonenumber, x.Sex==false? "Nữ" : "Nam", x.IDRole==1?"NV":"QL", x.Email, x.MaNV, x.Diachi, x.IdNhanVien,x.Hinhanh);
            }

        }

        private void Nhân_Viên_Load(object sender, EventArgs e)
        {
            s.HeaderText = "Chức Năng";
            s.Name = "Thêm";
            dataGridView1.Columns.Add(s);
            DataGridViewButtonColumn n = new DataGridViewButtonColumn();
            n.HeaderText = "request";
            n.Text = "Thực Hiện";
            n.Name = "Thực Hiện";
            n.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(n);
            lblthongbao.Visible = false;
            btnchonfilegui.Visible = false;
            btndanhsach.Visible = false;
            btnguimail.Visible = false;
            btnthoat.Visible = false;
            listBox1.Visible = false;
            lblnoidung.Visible = false;
            txt_file.Visible = false;
            txt_nd.Visible = false;
            bttxoa.Visible = false;
            cbb_VT.Visible = false;
            cbbgt.Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex==-1)return;

            if (string.IsNullOrEmpty(dataGridView1.Rows[rowIndex].Cells[8].Value?.ToString()))
            {
                return;
            }
            temp = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[8].Value.ToString());
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridviewComboBoxCell value is not valid.")
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Hình Ảnh")
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    HA.Image = Image.FromFile(open.FileName);
                    this.Text = open.FileName;
                }
            }
            if (e.ColumnIndex == 11)
            {
                string Task = dataGridView1.Rows[e.RowIndex].Cells[10].Value?.ToString();
                if (_serviceQlnv.getlistNV().Count==rowIndex)
                {
                    if (Task == "Xóa" || Task == "Sửa")
                    {
                        MessageBox.Show("Bạn chọn sai chức năng", "thông báo");
                        return;
                    }
                   
                }
                if (Task == "Thêm")
                {
                    var a = _serviceQlnv.GetlistRoles()
                        .Where(c => c.Name == dataGridView1.Rows[rowIndex].Cells[4].Value.ToString())
                        .FirstOrDefault();
                    if (MessageBox.Show("Bạn có chắc chắm muốn Thêm không?", "Đang Sửa...", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        byte[] anh = Chuyenkieudulieuthanhbyte(HA.Image);
                        Nhanvien nv = new Nhanvien();
                        if (_serviceQlnv.getlistNV().Count==0)
                        {
                            nv.MaNV = "NV1";
                        }
                        else
                        {
                            var b = _serviceQlnv.getlistNV().Max(c => c.IdNhanVien) + 1;
                            nv.MaNV = "NV" + b;
                        }
                        nv.FullName = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                        nv.Password = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                        nv.Phonenumber = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                        nv.Sex = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString() == "Nữ" ? false : true;
                        nv.IDRole = a.Id;
                        nv.Email = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                        nv.Diachi = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                        nv.Hinhanh = anh;
                        _serviceQlnv.ThemNV(nv);
                        MessageBox.Show("Thêm Thành Công ", "thông báo");
                        LoadGridAccount();
                        var c = _serviceQlnv.getlistNV().Where(c => c.MaNV == "NV1").Select(c=>c.IdNhanVien).FirstOrDefault();
                        if (c>=0)
                        {
                            var nn = _serviceQlnv.getlistNV().Where(d => d.IdNhanVien == c).FirstOrDefault();
                            nn.MaNV = "NV" + c;
                            _serviceQlnv.Sua(nv);
                        }
                    }
                }
                else if (Task == "Sửa")
                {
                    var a = _serviceQlnv.GetlistRoles()
                        .Where(c => c.Name == dataGridView1.Rows[rowIndex].Cells[4].Value).Select(c => c.Id)
                        .FirstOrDefault();
                    if (MessageBox.Show("Bạn có chắc chắm muốn sửa không?", "Đang Sửa...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        byte[] anh = Chuyenkieudulieuthanhbyte(HA.Image);
                        var nv = _serviceQlnv.getlistNV().Where(c => c.IdNhanVien == temp).FirstOrDefault();
                        nv.FullName = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                        nv.Password = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                        nv.Phonenumber = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                        nv.Sex = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString() == "Nam" ? true : false;
                        nv.IDRole = a;
                        nv.Email = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                        nv.Diachi = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                        nv.Hinhanh = anh;
                        _serviceQlnv.Sua(nv);
                        MessageBox.Show("sửa Thành Công ", "thông báo");
                        _serviceQlnv.getlistDB();
                        LoadGridAccount();
                    }
                }else if (Task=="Xóa")
                {
                    if (MessageBox.Show("Bạn có chắc chắm muốn xóa không?", "Đang xóa...", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var t=_serviceQlnv.getlistNV().Where(c => c.IdNhanVien == temp).Select(c=>c.IdNhanVien).FirstOrDefault();
                        _serviceQlnv.Xoa(t);
                        MessageBox.Show("xoa Thành Công ", "thông báo");
                        _serviceQlnv.getlistDB();
                        LoadGridAccount();
                    }
                }
            }
        }

        public byte[] Chuyenkieudulieuthanhbyte(Image img)
        {
            MemoryStream a = new MemoryStream();
            img.Save(a, ImageFormat.Png);
            return a.ToArray();
        }

        public Image bytesangimge(byte[] b)
        {
            MemoryStream a = new MemoryStream(b);
            return Image.FromStream(a);

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (_serviceQlnv.getlistNV().Count < 0) return;
            foreach (var x in _serviceQlnv.TimKiem(txt_timkiem.Text))
            {
                dataGridView1.Rows.Add(x.FullName, x.Password, x.Phonenumber, x.Sex == false ? "Nữ" : "Nam", x.IDRole == 1 ? "NV" : "QL", x.Email, x.MaNV, x.Diachi, x.IdNhanVien, x.Hinhanh);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblthongbao.Visible = true;
            bttxoa.Visible = true;
            btnchonfilegui.Visible = true;
            btndanhsach.Visible = true;
            btnguimail.Visible = true;
            btnthoat.Visible = true;
            listBox1.Visible = true;
            lblnoidung.Visible = true;
            txt_file.Visible = true;
            txt_nd.Visible = true;
            btnthongbao.Visible = false;
            lbltimkiem.Visible = false;
            txt_timkiem.Visible = false;
            dataGridView1.Visible = false;
            cbb_VT.Visible = false;
            cbbgt.Visible = false;
            cbbloc.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_file.Text = open.FileName;
            }
        }
        void guimail(string email, string hihi, Attachment file)
        {
            MailMessage mess = new MailMessage(hemail, email, haha, hihi);
            if (atrAttachment != null)
            {
                mess.Attachments.Add(atrAttachment);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("binhktph16675@fpt.edu.vn", "08032002binh");
            client.Send(mess);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            hihi = txt_nd.Text;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                t = (string)listBox1.Items[i];
                atrAttachment = null;
                FileInfo m = new FileInfo(txt_file.Text);
                atrAttachment = new Attachment(txt_file.Text);
                guimail(t, hihi, atrAttachment);
            }
           
            MessageBox.Show("gửi mail Thành Công ", "thông báo");
            txt_file.Text = "";
            txt_nd.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _serviceQlnv.getlistNV().Count; i++)
            {
                t = (from x in _serviceQlnv.getlistNV()
                    select x.Email).ElementAt(i);
                listBox1.Items.Add(t);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            lblthongbao.Visible = false;
            btnchonfilegui.Visible = false;
            btndanhsach.Visible = false;
            btnguimail.Visible = false;
            btnthoat.Visible = false;
            listBox1.Visible = false;
            lblnoidung.Visible = false;
            txt_file.Visible = false;
            txt_nd.Visible = false;
            btnthongbao.Visible = true;
            lbltimkiem.Visible = true;
            txt_timkiem.Visible = true;
            dataGridView1.Visible = true;
            bttxoa.Visible = false;
            cbb_VT.Visible = false;
            cbbgt.Visible = false;
            cbbloc.Visible = true;
        }

        private void cbbloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloc.SelectedIndex == 0)
            {
                cbb_VT.Visible = false;
                cbbgt.Visible = true;
               
               
            }
            else
            {
                cbb_VT.Visible = true;
                cbbgt.Visible = false;
               
            }
        }

        private void cbb_VT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_VT.SelectedIndex == 0)
            {
                dataGridView1.Rows.Clear();
                if (_serviceQlnv.getlistNV().Count < 0) return;
                foreach (var x in _serviceQlnv.getlistNV().Where(c => c.IDRole == 1))
                {
                    dataGridView1.Rows.Add(x.FullName, x.Password, x.Phonenumber, x.Sex == false ? "Nữ" : "Nam", x.IDRole == 1 ? "NV" : "QL", x.Email, x.MaNV, x.Diachi, x.IdNhanVien, x.Hinhanh);
                }
            }
            else 
            {
                dataGridView1.Rows.Clear();
                if (_serviceQlnv.getlistNV().Count < 0) return;
                foreach (var x in _serviceQlnv.getlistNV().Where(c => c.IDRole == 2))
                {
                    dataGridView1.Rows.Add(x.FullName, x.Password, x.Phonenumber, x.Sex == false ? "Nữ" : "Nam", x.IDRole == 1 ? "NV" : "QL", x.Email, x.MaNV, x.Diachi, x.IdNhanVien, x.Hinhanh);
                }
            }
        }

        private void cbbgt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbgt.SelectedIndex == 1)
            {
                dataGridView1.Rows.Clear();
                if (_serviceQlnv.getlistNV().Count < 0) return;
                foreach (var x in _serviceQlnv.getlistNV().Where(c => c.Sex == false))
                {
                    dataGridView1.Rows.Add(x.FullName, x.Password, x.Phonenumber, x.Sex == false ? "Nữ" : "Nam", x.IDRole == 1 ? "NV" : "QL", x.Email, x.MaNV, x.Diachi, x.IdNhanVien, x.Hinhanh);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                if (_serviceQlnv.getlistNV().Count < 0) return;     
                foreach (var x in _serviceQlnv.getlistNV().Where(c => c.Sex==true))
                {
                    dataGridView1.Rows.Add(x.FullName, x.Password, x.Phonenumber, x.Sex == false ? "Nữ" : "Nam", x.IDRole == 1 ? "NV" : "QL", x.Email, x.MaNV, x.Diachi, x.IdNhanVien, x.Hinhanh);
                }
            }
        }
    }
}
