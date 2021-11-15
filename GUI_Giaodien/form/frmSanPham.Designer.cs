
using System.Windows.Forms;

namespace GUI_Giaodien.form
{
    partial class frmSanPham
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
            this.txt_find = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaShow = new System.Windows.Forms.DataGridViewImageColumn();
            this.imei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRUD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ok = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_find)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_find
            // 
            this.txt_find.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.txt_find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txt_find.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.HDT,
            this.Name,
            this.Mt,
            this.Ha,
            this.HaShow,
            this.imei,
            this.CRUD,
            this.Ok});
            this.txt_find.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_find.Location = new System.Drawing.Point(0, 64);
            this.txt_find.Name = "txt_find";
            this.txt_find.RowHeadersWidth = 51;
            this.txt_find.RowTemplate.Height = 80;
            this.txt_find.Size = new System.Drawing.Size(800, 386);
            this.txt_find.TabIndex = 2;
            this.txt_find.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.txt_find.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(524, 13);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(221, 27);
            this.txt.TabIndex = 4;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // HDT
            // 
            this.HDT.HeaderText = "Hãng ĐT";
            this.HDT.MinimumWidth = 6;
            this.HDT.Name = "HDT";
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên Sản Phẩm";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Mt
            // 
            this.Mt.HeaderText = "Mô tả";
            this.Mt.MinimumWidth = 6;
            this.Mt.Name = "Mt";
            // 
            // Ha
            // 
            this.Ha.HeaderText = "Hình ảnh hide";
            this.Ha.MinimumWidth = 6;
            this.Ha.Name = "Ha";
            this.Ha.Visible = false;
            // 
            // HaShow
            // 
            this.HaShow.HeaderText = "Hình Ảnh";
            this.HaShow.MinimumWidth = 6;
            this.HaShow.Name = "HaShow";
            // 
            // imei
            // 
            this.imei.HeaderText = "IMEI";
            this.imei.MinimumWidth = 6;
            this.imei.Name = "imei";
            this.imei.ReadOnly = true;
            // 
            // CRUD
            // 
            this.CRUD.HeaderText = "Chức Năng";
            this.CRUD.MinimumWidth = 6;
            this.CRUD.Name = "CRUD";
            // 
            // Ok
            // 
            this.Ok.HeaderText = "Ok";
            this.Ok.MinimumWidth = 6;
            this.Ok.Name = "Ok";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_find);
            this.Name = new DataGridViewTextBoxColumn();
            this.Text = "frmSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.txt_find)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView txt_find;
        private Label label1;
        private TextBox txt;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn HDT;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Mt;
        private DataGridViewTextBoxColumn Ha;
        private DataGridViewImageColumn HaShow;
        private DataGridViewTextBoxColumn imei;
        private DataGridViewComboBoxColumn CRUD;
        private DataGridViewButtonColumn Ok;
    }
}