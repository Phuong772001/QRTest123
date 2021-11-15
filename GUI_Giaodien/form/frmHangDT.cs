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
    public partial class frmHangDT : Form
    {
        private IServiceChiTietSanPham sp = new ServiceChiTietChiTietSanPham();
        private string mess = "Thông báo";
        private HangDT _hangDt;
        private int IDwhenClick;
        public frmHangDT()
        {
            InitializeComponent(); _hangDt = new HangDT();
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
            foreach (var x in sp.GetlistHangDts())
            {
                dataGrid.Rows.Add(x.Id, x.Name);
            }
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            foreach (var x in sp.GetlistHangDts().Where(c => c.Name.Contains(txt_find.Text)))
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
                            _hangDt = new HangDT();

                            _hangDt.Name = dataGrid.Rows[rowindex].Cells[1].Value.ToString();

                            MessageBox.Show(sp.AddHangDT(_hangDt), mess);
                            loadDB();
                        }
                    }
                    if (a == "Update")
                    {
                        if (sp.selectHangDtUP(IDwhenClick) == null) return;
                        else
                        {

                            HangDT sprs = sp.selectHangDtUP(IDwhenClick);
                            sprs.Name = dataGrid.Rows[rowindex].Cells[1].Value.ToString();


                            if (MessageBox.Show("Bạn có chắc sửa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                MessageBox.Show(sp.UpdateHangDT(sprs), mess);
                                loadDB();
                            }
                        }
                    }
                    if (a == "Delete")
                    {
                        if (MessageBox.Show("Bạn có chắc xóa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            MessageBox.Show(sp.DeleteHangDT(IDwhenClick), mess);
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

            if (rowindex == sp.GetlistHangDts().Count || rowindex == -1) return;
            IDwhenClick = Convert.ToInt32(dataGrid.Rows[rowindex].Cells[0].Value.ToString());
            MessageBox.Show(IDwhenClick + " ");

        }
    }
    }
