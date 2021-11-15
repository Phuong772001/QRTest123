
using System.Windows.Forms;

namespace GUI_Giaodien.form
{
    partial class frmSanPhamShow
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
            this.dgrid_sanpham = new System.Windows.Forms.DataGridView();
            this.FullNameSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaShow = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_find = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_sanpham
            // 
            this.dgrid_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullNameSP,
            this.Name,
            this.QG,
            this.Ha,
            this.HaShow});
            this.dgrid_sanpham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_sanpham.Location = new System.Drawing.Point(0, 59);
            this.dgrid_sanpham.Name = "dgrid_sanpham";
            this.dgrid_sanpham.RowHeadersWidth = 51;
            this.dgrid_sanpham.RowTemplate.Height = 80;
            this.dgrid_sanpham.Size = new System.Drawing.Size(1008, 533);
            this.dgrid_sanpham.TabIndex = 0;
            this.dgrid_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_sanpham_CellClick);
            // 
            // FullNameSP
            // 
            this.FullNameSP.HeaderText = "Tên sản phẩm";
            this.FullNameSP.MinimumWidth = 6;
            this.FullNameSP.Name = "FullNameSP";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Visible = false;
            // 
            // QG
            // 
            this.QG.HeaderText = "Quốc gia";
            this.QG.MinimumWidth = 6;
            this.QG.Name = "QG";
            // 
            // Ha
            // 
            this.Ha.HeaderText = "Hinhf ảnh";
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
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(547, 12);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(418, 27);
            this.txt_find.TabIndex = 1;
            this.txt_find.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmSanPhamShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 592);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.dgrid_sanpham);
            this.Name = new DataGridViewTextBoxColumn();
            this.Text = "frmSanPhamShow";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_sanpham;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn QG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ha;
        private System.Windows.Forms.DataGridViewImageColumn HaShow;
    }
}