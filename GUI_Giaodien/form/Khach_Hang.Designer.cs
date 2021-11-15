
namespace GUI_Giaodien
{
    partial class FrmQuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyKhachHang));
            this.rtxt_diachi = new System.Windows.Forms.RichTextBox();
            this.btn_nakh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tkkh = new System.Windows.Forms.TextBox();
            this.dgrv_ttkhachhang = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_ttkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxt_diachi
            // 
            this.rtxt_diachi.Location = new System.Drawing.Point(661, 69);
            this.rtxt_diachi.Name = "rtxt_diachi";
            this.rtxt_diachi.Size = new System.Drawing.Size(313, 51);
            this.rtxt_diachi.TabIndex = 45;
            this.rtxt_diachi.Text = "";
            // 
            // btn_nakh
            // 
            this.btn_nakh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_nakh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nakh.Image = ((System.Drawing.Image)(resources.GetObject("btn_nakh.Image")));
            this.btn_nakh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nakh.Location = new System.Drawing.Point(858, 184);
            this.btn_nakh.Name = "btn_nakh";
            this.btn_nakh.Size = new System.Drawing.Size(116, 37);
            this.btn_nakh.TabIndex = 40;
            this.btn_nakh.Text = "Tìm kiếm";
            this.btn_nakh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nakh.UseVisualStyleBackColor = false;
            this.btn_nakh.Click += new System.EventHandler(this.btn_nakh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(572, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Địa chỉ:";
            // 
            // txt_tkkh
            // 
            this.txt_tkkh.Location = new System.Drawing.Point(542, 194);
            this.txt_tkkh.Name = "txt_tkkh";
            this.txt_tkkh.Size = new System.Drawing.Size(295, 27);
            this.txt_tkkh.TabIndex = 36;
            // 
            // dgrv_ttkhachhang
            // 
            this.dgrv_ttkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrv_ttkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_ttkhachhang.Location = new System.Drawing.Point(131, 239);
            this.dgrv_ttkhachhang.Name = "dgrv_ttkhachhang";
            this.dgrv_ttkhachhang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgrv_ttkhachhang.RowTemplate.Height = 29;
            this.dgrv_ttkhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrv_ttkhachhang.Size = new System.Drawing.Size(843, 307);
            this.dgrv_ttkhachhang.TabIndex = 35;
            this.dgrv_ttkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_ttkhachhang_CellClick);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(166, 123);
            this.txt_name.Name = "txt_name";
            this.txt_name.PlaceholderText = "Input";
            this.txt_name.Size = new System.Drawing.Size(231, 27);
            this.txt_name.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên khách hàng:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(166, 69);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PlaceholderText = "Input";
            this.txt_sdt.Size = new System.Drawing.Size(231, 27);
            this.txt_sdt.TabIndex = 32;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.Location = new System.Drawing.Point(27, 69);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(85, 20);
            this.lbl_email.TabIndex = 30;
            this.lbl_email.Text = "Điện thoại:";
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_danhsach.Image = ((System.Drawing.Image)(resources.GetObject("btn_danhsach.Image")));
            this.btn_danhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danhsach.Location = new System.Drawing.Point(12, 502);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(113, 39);
            this.btn_danhsach.TabIndex = 50;
            this.btn_danhsach.Text = "Danh sách";
            this.btn_danhsach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_danhsach.UseVisualStyleBackColor = false;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(12, 427);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 42);
            this.btn_save.TabIndex = 49;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_del.Location = new System.Drawing.Point(12, 359);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(113, 42);
            this.btn_del.TabIndex = 48;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(12, 297);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(113, 42);
            this.btn_edit.TabIndex = 47;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(12, 239);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 40);
            this.btn_add.TabIndex = 46;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FrmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 583);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rtxt_diachi);
            this.Controls.Add(this.btn_nakh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tkkh);
            this.Controls.Add(this.dgrv_ttkhachhang);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.lbl_email);
            this.Name = "FrmQuanLyKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_QuanLyKhachHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_ttkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_diachi;
        private System.Windows.Forms.Button btn_nakh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tkkh;
        private System.Windows.Forms.DataGridView dgrv_ttkhachhang;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
    }
}