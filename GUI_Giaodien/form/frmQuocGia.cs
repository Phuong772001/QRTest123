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
    public partial class frmQuocGia : Form
    {
        private IServiceChiTietSanPham sp = new ServiceChiTietChiTietSanPham();
        private string mess = "Thông báo";
        private Quocgia _quocgia;
        private int IDwhenClick;
        public frmQuocGia()
        {
            InitializeComponent(); _quocgia = new Quocgia();
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
            foreach (var x in sp.GetlistQuocgias())
            {
                dataGrid.Rows.Add(x.Id, x.Name);
            }
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            _quocgia = new Quocgia();

                            _quocgia.Name = dataGrid.Rows[rowindex].Cells[1].Value.ToString();

                            MessageBox.Show(sp.AddQG(_quocgia), mess);
                            loadDB();
                        }
                    }
                    if (a == "Update")
                    {
                        if (sp.selectQuocgiaUP(IDwhenClick) == null) return;
                        else
                        {

                            Quocgia sprs = sp.selectQuocgiaUP(IDwhenClick);
                            sprs.Name = dataGrid.Rows[rowindex].Cells[1].Value.ToString();


                            if (MessageBox.Show("Bạn có chắc sửa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                MessageBox.Show(sp.UpdateQG(sprs), mess);
                                loadDB();
                            }
                        }
                    }
                    if (a == "Delete")
                    {
                        if (MessageBox.Show("Bạn có chắc xóa không", mess, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            MessageBox.Show(sp.DeleteQG(IDwhenClick), mess);
                            loadDB();
                        }
                    }
                }

            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
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

            if (rowindex == sp.GetlistQuocgias().Count || rowindex == -1) return;
            IDwhenClick = Convert.ToInt32(dataGrid.Rows[rowindex].Cells[0].Value.ToString());
            MessageBox.Show(IDwhenClick + " ");


        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            foreach (var x in sp.GetlistQuocgias().Where(c => c.Name.Contains(txt_find.Text)))
            {
                dataGrid.Rows.Add(x.Id, x.Name);
            }
        }
    }
    }
