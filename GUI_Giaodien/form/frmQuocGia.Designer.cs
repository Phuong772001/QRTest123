
using System.Windows.Forms;

namespace GUI_Giaodien.form
{
    partial class frmQuocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRUD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ok = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(465, 9);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(321, 27);
            this.txt_find.TabIndex = 5;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.CRUD,
            this.Ok});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid.Location = new System.Drawing.Point(0, 63);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.Size = new System.Drawing.Size(800, 387);
            this.dataGrid.TabIndex = 4;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Name
            // 
            this.Name.FillWeight = 15F;
            this.Name.HeaderText = "Tên Quốc Gia";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // CRUD
            // 
            this.CRUD.FillWeight = 10F;
            this.CRUD.HeaderText = "Chức năng";
            this.CRUD.MinimumWidth = 6;
            this.CRUD.Name = "CRUD";
            // 
            // Ok
            // 
            this.Ok.FillWeight = 5F;
            this.Ok.HeaderText = "OK";
            this.Ok.MinimumWidth = 6;
            this.Ok.Name = "Ok";
            this.Ok.Text = "âsd";
            // 
            // frmQuocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.dataGrid);
            this.Text = "frmQuocGia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_find;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewComboBoxColumn CRUD;
        private DataGridViewButtonColumn Ok;
    }
}