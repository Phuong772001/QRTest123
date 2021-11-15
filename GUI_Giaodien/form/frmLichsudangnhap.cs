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
    public partial class frmLichsudangnhap : Form
    {
        private IserviceQLLS _serviceQlls;
        private int rowIndex;
        private int temp;

        public frmLichsudangnhap()
        {
            InitializeComponent();
            _serviceQlls = new ServiceQuanLiLichSu();
            load();
            _serviceQlls.getlistDB();
        }

        public void load()
        {
            dataGridView1.Rows.Clear();
            if (_serviceQlls.getlistLS().Count < 0) return;
            foreach (var x in _serviceQlls.getlistLS())
            {
                dataGridView1.Rows.Add(x.MaNV,x.tenNV,x.Email,x.ThoigianBatdau,x.ThoigianketT,x.id);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex == -1) return;

            if (string.IsNullOrEmpty(dataGridView1.Rows[rowIndex].Cells[6].Value?.ToString()))
            {
                return;
            }
            temp = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());
        }
    }
}
