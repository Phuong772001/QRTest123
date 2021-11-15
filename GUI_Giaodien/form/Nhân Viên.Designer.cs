
namespace GUI_Giaodien.form
{
    partial class Nhân_Viên
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sđt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Vt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HA = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnthongbao = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.lbltimkiem = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.lblnoidung = new System.Windows.Forms.Label();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.txt_nd = new System.Windows.Forms.TextBox();
            this.btnchonfilegui = new System.Windows.Forms.Button();
            this.btnguimail = new System.Windows.Forms.Button();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.btndanhsach = new System.Windows.Forms.Button();
            this.bttxoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbbloc = new System.Windows.Forms.ComboBox();
            this.cbbgt = new System.Windows.Forms.ComboBox();
            this.cbb_VT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(231)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hoten,
            this.mk,
            this.sđt,
            this.gt,
            this.Vt,
            this.email,
            this.manv,
            this.diachi,
            this.idnv,
            this.HA});
            this.dataGridView1.Location = new System.Drawing.Point(69, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 501);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // Hoten
            // 
            this.Hoten.HeaderText = "Họ Và Tên ";
            this.Hoten.MinimumWidth = 6;
            this.Hoten.Name = "Hoten";
            // 
            // mk
            // 
            this.mk.HeaderText = "Mật Khẩu ";
            this.mk.MinimumWidth = 6;
            this.mk.Name = "mk";
            // 
            // sđt
            // 
            this.sđt.HeaderText = "Số điện thoại ";
            this.sđt.MinimumWidth = 6;
            this.sđt.Name = "sđt";
            // 
            // gt
            // 
            this.gt.HeaderText = "Giới Tính";
            this.gt.MinimumWidth = 6;
            this.gt.Name = "gt";
            this.gt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Vt
            // 
            this.Vt.HeaderText = "Vai Trò ";
            this.Vt.MinimumWidth = 6;
            this.Vt.Name = "Vt";
            this.Vt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Vt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // manv
            // 
            this.manv.HeaderText = "MANV";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Visible = false;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa Chỉ ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            // 
            // idnv
            // 
            this.idnv.HeaderText = "Id";
            this.idnv.MinimumWidth = 6;
            this.idnv.Name = "idnv";
            this.idnv.Visible = false;
            // 
            // HA
            // 
            this.HA.HeaderText = "Hình Ảnh";
            this.HA.MinimumWidth = 6;
            this.HA.Name = "HA";
            // 
            // btnthongbao
            // 
            this.btnthongbao.BackColor = System.Drawing.Color.Cornsilk;
            this.btnthongbao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnthongbao.Location = new System.Drawing.Point(69, 54);
            this.btnthongbao.Name = "btnthongbao";
            this.btnthongbao.Size = new System.Drawing.Size(145, 38);
            this.btnthongbao.TabIndex = 2;
            this.btnthongbao.Text = "Thông Báo ";
            this.btnthongbao.UseVisualStyleBackColor = false;
            this.btnthongbao.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(1094, 65);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(202, 27);
            this.txt_timkiem.TabIndex = 3;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // lbltimkiem
            // 
            this.lbltimkiem.AutoSize = true;
            this.lbltimkiem.Location = new System.Drawing.Point(1012, 72);
            this.lbltimkiem.Name = "lbltimkiem";
            this.lbltimkiem.Size = new System.Drawing.Size(76, 20);
            this.lbltimkiem.TabIndex = 4;
            this.lbltimkiem.Text = "Tìm Kiếm ";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Cornsilk;
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnthoat.Location = new System.Drawing.Point(717, 538);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(143, 43);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lblnoidung
            // 
            this.lblnoidung.AutoSize = true;
            this.lblnoidung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnoidung.Location = new System.Drawing.Point(161, 256);
            this.lblnoidung.Name = "lblnoidung";
            this.lblnoidung.Size = new System.Drawing.Size(105, 28);
            this.lblnoidung.TabIndex = 12;
            this.lblnoidung.Text = "Nội dung:";
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(401, 20);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(396, 27);
            this.txt_file.TabIndex = 11;
            // 
            // txt_nd
            // 
            this.txt_nd.Location = new System.Drawing.Point(161, 306);
            this.txt_nd.Multiline = true;
            this.txt_nd.Name = "txt_nd";
            this.txt_nd.Size = new System.Drawing.Size(407, 207);
            this.txt_nd.TabIndex = 10;
            // 
            // btnchonfilegui
            // 
            this.btnchonfilegui.BackColor = System.Drawing.Color.Cornsilk;
            this.btnchonfilegui.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnchonfilegui.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnchonfilegui.Location = new System.Drawing.Point(249, 20);
            this.btnchonfilegui.Name = "btnchonfilegui";
            this.btnchonfilegui.Size = new System.Drawing.Size(146, 34);
            this.btnchonfilegui.TabIndex = 8;
            this.btnchonfilegui.Text = "Chọn file Gửi ";
            this.btnchonfilegui.UseVisualStyleBackColor = false;
            this.btnchonfilegui.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnguimail
            // 
            this.btnguimail.BackColor = System.Drawing.Color.Cornsilk;
            this.btnguimail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnguimail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnguimail.Location = new System.Drawing.Point(385, 538);
            this.btnguimail.Name = "btnguimail";
            this.btnguimail.Size = new System.Drawing.Size(146, 43);
            this.btnguimail.TabIndex = 9;
            this.btnguimail.Text = "Gửi Mail";
            this.btnguimail.UseVisualStyleBackColor = false;
            this.btnguimail.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblthongbao.Location = new System.Drawing.Point(588, 50);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(159, 38);
            this.lblthongbao.TabIndex = 7;
            this.lblthongbao.Text = "Thông Báo";
            // 
            // btndanhsach
            // 
            this.btndanhsach.BackColor = System.Drawing.Color.Cornsilk;
            this.btndanhsach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndanhsach.Location = new System.Drawing.Point(690, 254);
            this.btndanhsach.Name = "btndanhsach";
            this.btndanhsach.Size = new System.Drawing.Size(137, 29);
            this.btndanhsach.TabIndex = 17;
            this.btndanhsach.Text = "Danh Sách ";
            this.btndanhsach.UseVisualStyleBackColor = false;
            this.btndanhsach.Click += new System.EventHandler(this.button6_Click);
            // 
            // bttxoa
            // 
            this.bttxoa.BackColor = System.Drawing.Color.Cornsilk;
            this.bttxoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttxoa.Location = new System.Drawing.Point(1065, 255);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(94, 29);
            this.bttxoa.TabIndex = 18;
            this.bttxoa.Text = "Xóa";
            this.bttxoa.UseVisualStyleBackColor = false;
            this.bttxoa.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(690, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(469, 204);
            this.listBox1.TabIndex = 19;
            // 
            // cbbloc
            // 
            this.cbbloc.FormattingEnabled = true;
            this.cbbloc.Location = new System.Drawing.Point(1145, 115);
            this.cbbloc.Name = "cbbloc";
            this.cbbloc.Size = new System.Drawing.Size(151, 28);
            this.cbbloc.TabIndex = 20;
            this.cbbloc.Text = "lọc";
            this.cbbloc.SelectedIndexChanged += new System.EventHandler(this.cbbloc_SelectedIndexChanged);
            // 
            // cbbgt
            // 
            this.cbbgt.FormattingEnabled = true;
            this.cbbgt.Location = new System.Drawing.Point(979, 115);
            this.cbbgt.Name = "cbbgt";
            this.cbbgt.Size = new System.Drawing.Size(151, 28);
            this.cbbgt.TabIndex = 20;
            this.cbbgt.Text = "Lọc Giới Tính";
            this.cbbgt.SelectedIndexChanged += new System.EventHandler(this.cbbgt_SelectedIndexChanged);
            // 
            // cbb_VT
            // 
            this.cbb_VT.FormattingEnabled = true;
            this.cbb_VT.Location = new System.Drawing.Point(979, 115);
            this.cbb_VT.Name = "cbb_VT";
            this.cbb_VT.Size = new System.Drawing.Size(151, 28);
            this.cbb_VT.TabIndex = 21;
            this.cbb_VT.Text = "Lọc Vai Trò ";
            this.cbb_VT.SelectedIndexChanged += new System.EventHandler(this.cbb_VT_SelectedIndexChanged);
            // 
            // Nhân_Viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1343, 716);
            this.Controls.Add(this.cbb_VT);
            this.Controls.Add(this.cbbgt);
            this.Controls.Add(this.cbbloc);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bttxoa);
            this.Controls.Add(this.btndanhsach);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.lblnoidung);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.txt_nd);
            this.Controls.Add(this.btnchonfilegui);
            this.Controls.Add(this.btnguimail);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.lbltimkiem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btnthongbao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Nhân_Viên";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân_Viên";
            this.Load += new System.EventHandler(this.Nhân_Viên_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthongbao;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label lbltimkiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label lblnoidung;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.TextBox txt_nd;
        private System.Windows.Forms.Button btnchonfilegui;
        private System.Windows.Forms.Button btnguimail;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn mk;
        private System.Windows.Forms.DataGridViewTextBoxColumn sđt;
        private System.Windows.Forms.DataGridViewComboBoxColumn gt;
        private System.Windows.Forms.DataGridViewComboBoxColumn Vt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnv;
        private System.Windows.Forms.DataGridViewImageColumn HA;
        private System.Windows.Forms.Button btndanhsach;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbbloc;
        private System.Windows.Forms.ComboBox cbbgt;
        private System.Windows.Forms.ComboBox cbb_VT;
    }
}