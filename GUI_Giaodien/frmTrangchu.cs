using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace GUI_Giaodien
{
    public partial class frmTrangchu : Form
    {
        private Button currenButton;
        private Panel lesPanel;
        private Form currenChiderenlForm;
        public frmTrangchu()
        {
            InitializeComponent();
            panelthanhdo.Height = button9.Height;
            panelthanhdo.Top = button9.Top;
            panel4.BringToFront();
            lesPanel = new Panel();
            lesPanel.Size = new Size(7, 67);
            //panelMenu.Controls.Add(lesPanel);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelthanhdo.Height = button1.Height;
            panelthanhdo.Top = button1.Top;
            panel4.BringToFront();
            active(sender,RGBColors.Color1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelthanhdo.Height = button9.Height;
            panelthanhdo.Top = button9.Top;
            panel4.BringToFront();
            active(sender, RGBColors.Color2);
            
        }

        private void Reset(Form Chidren)
        {
            if (Iconchidren!=null)
            {
                currenChiderenlForm.Close();
            }

            currenChiderenlForm = Chidren;
            Chidren.TopLevel = false;
            Chidren.FormBorderStyle = FormBorderStyle.None;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            panelthanhdo.Height = button2.Height;
            panelthanhdo.Top = button2.Top;
            panel4.BringToFront();
            active(sender, RGBColors.Color3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelthanhdo.Height = button3.Height;
            panelthanhdo.Top = button3.Top;
            panel4.BringToFront();
            active(sender, RGBColors.Color4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelthanhdo.Height = button4.Height;
            panelthanhdo.Top = button4.Top;
            panel4.BringToFront();
            active(sender, RGBColors.Color5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelthanhdo.Height = button5.Height;
            panelthanhdo.Top = button5.Top;
            panel4.BringToFront();
            active(sender, RGBColors.Color1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelthanhdo.Height = button6.Height;
            panelthanhdo.Top = button6.Top;
            panel4.BringToFront();
            active(sender, RGBColors.Color2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelthanhdo.Height = button7.Height;
            panelthanhdo.Top = button7.Top;
            panel4.BringToFront();
            active(sender, RGBColors.Color3);
        }
        private struct  RGBColors
        {
            public static Color Color1 = Color.FromArgb(255 ,250 ,240);
            public static Color Color2 = Color.FromArgb(255, 228 ,181);
            public static Color Color3 = Color.FromArgb(176 ,226 ,255);
            public static Color Color4 = Color.FromArgb(255 ,193 ,193);
            public static Color Color5 = Color.FromArgb(255 ,187 ,255);
        }
        private void active(object Sender,Color color)
        {
            if (Sender!=null)
            {
                Disbase();
                currenButton = (Button) Sender;
                currenButton.BackColor = Color.FromArgb(41, 39, 40);
                currenButton.ForeColor = color;
                currenButton.TextAlign = ContentAlignment.MiddleCenter;
                currenButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenButton.ImageAlign = ContentAlignment.MiddleRight;
                lesPanel.BackColor = color;
                lesPanel.Location = new Point(0, currenButton.Location.Y);
                lesPanel.Visible = true;
                lesPanel.BringToFront();
            }
        }
        private void Disbase()
        {
            if (currenButton != null)
            {
                currenButton.BackColor = Color.FromArgb(31, 30, 68);
                currenButton.ForeColor = Color.Gainsboro;
                currenButton.TextAlign = ContentAlignment.MiddleLeft;
                currenButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wMsg,int wparam,int lparam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
    }
}
