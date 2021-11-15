
namespace GUI_Giaodien.form
{
    partial class Frm_Forgot
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.txt_RenewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_PassChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên mật khẩu";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(203, 93);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(211, 27);
            this.txt_Email.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(203, 170);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(94, 36);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "Gửi email";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Location = new System.Drawing.Point(203, 180);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(211, 27);
            this.txt_NewPass.TabIndex = 2;
            // 
            // txt_RenewPass
            // 
            this.txt_RenewPass.Location = new System.Drawing.Point(203, 230);
            this.txt_RenewPass.Name = "txt_RenewPass";
            this.txt_RenewPass.Size = new System.Drawing.Size(211, 27);
            this.txt_RenewPass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(203, 137);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(211, 27);
            this.txt_Code.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã xác nhận:";
            // 
            // btn_PassChange
            // 
            this.btn_PassChange.Location = new System.Drawing.Point(289, 286);
            this.btn_PassChange.Name = "btn_PassChange";
            this.btn_PassChange.Size = new System.Drawing.Size(125, 38);
            this.btn_PassChange.TabIndex = 6;
            this.btn_PassChange.Text = "Đổi mật khẩu";
            this.btn_PassChange.UseVisualStyleBackColor = true;
            this.btn_PassChange.Click += new System.EventHandler(this.btn_PassChange_Click);
            // 
            // Frm_Forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 344);
            this.Controls.Add(this.btn_PassChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_RenewPass);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Forgot";
            this.Text = "Quên mật khẩu";
            this.Load += new System.EventHandler(this.Frm_Forgot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.TextBox txt_RenewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_PassChange;
    }
}