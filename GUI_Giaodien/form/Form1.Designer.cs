
namespace QR_2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(65, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 150);
            this.dataGridView1.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 545);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(464, 213);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1333, 776);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
      

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

