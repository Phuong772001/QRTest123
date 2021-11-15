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

namespace GUI_Giaodien.form
{
    public partial class frmDoPhanGỉai : Form
    {
        private IServiceChiTietSanPham sp = new ServiceChiTietChiTietSanPham();
        private string mess = "Thông báo";
        private DoPhanGiai _doPhanGiai;
        private int IDwhenClick;
        public frmDoPhanGỉai()
        {
            InitializeComponent(); _doPhanGiai = new DoPhanGiai();
            loadCRUD();
            loadDB();
        }
        void loadCRUD()
        {
            CRUD.Items.Add("Add");
            CRUD.Items.Add("Update");
            CRUD.Items.Add("Delete");
        }
        void loadDB()
        {
            dataGrid.Rows.Clear();
            foreach (var x in sp.GetlistDoPhanGiais())
            {
                dataGrid.Rows.Add(x.Id, x.Name);
            }
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            foreach (var x in sp.GetlistDoPhanGiais().Where(c => c.Name.Contains(txt_find.Text)))
            {
                dataGrid.Rows.Add(x.Id, x.Name);
            }
        }

        private void dataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                var row = e.ColumnIndex;
                int rowindex = e.RowIndex;


                if (row == dataGrid.Columns["Ok"].Index)
                {
                    if (dataGrid.Rows[rowindex].Cells[dataGrid.Columns["CRUD"].Index].Value
                        == null || dataGrid.Rows[rowindex].Cells[dataGrid.Columns["CRUD"].Index].Value == "") return;
                    string a = dataGrid.Rows[rowindex].Cells[dataGrid.Columns["CRUD"].Index].Value.ToString();

                    if (a == "Add")
                    {

                        if (MessageBox.Show("Bạn có chắc thêm không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            _doPhanGiai = new DoPhanGiai();

                            _doPhanGiai.Name = dataGrid.Rows[rowindex].Cells[1].Value.ToString();

                            MessageBox.Show(sp.AddDPG(_doPhanGiai), mess);
                            loadDB();
                        }
                    }
                    if (a == "Update")
                    {
                        if (sp.selectDoPhanGiaiUP(IDwhenClick) == null) return;
                        else
                        {

                            DoPhanGiai sprs = sp.selectDoPhanGiaiUP(IDwhenClick);
                            sprs.Name = dataGrid.Rows[rowindex].Cells[1].Value.ToString();


                            if (MessageBox.Show("Bạn có chắc sửa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                MessageBox.Show(sp.UpdateDPG(sprs), mess);
                                loadDB();
                            }
                        }
                    }
                    if (a == "Delete")
                    {
                        if (MessageBox.Show("Bạn có chắc xóa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            MessageBox.Show(sp.DeleteDPG(IDwhenClick), mess);
                            loadDB();
                        }
                    }
                }

            }
        }

        private void dataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.ColumnIndex;
            int rowindex = e.RowIndex;
            if (row == dataGrid.Columns["Ok"].Index || row == dataGrid.Columns["CRUD"].Index)
            {
                return;
            }
            if (string.IsNullOrEmpty(dataGrid.Rows[e.RowIndex].Cells[0].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dataGrid.Rows[e.RowIndex].Cells[1].Value?.ToString()))
            {
                return;
            }

            if (rowindex == sp.GetlistDoPhanGiais().Count || rowindex == -1) return;
            IDwhenClick = Convert.ToInt32(dataGrid.Rows[rowindex].Cells[0].Value.ToString());
            MessageBox.Show(IDwhenClick + " ");


        }
    }
    }
