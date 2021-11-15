using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Dienthoai.IServices;
using BUS_Dienthoai.Services;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace QR_2
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            _serviceQlnv = new ServiceQuanLiNhanVien();
           
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }

           
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            nv.Password = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            nv.Email = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            var MyData = QG.CreateQrCode(nv.ToString(), QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);
        }
    }
}
