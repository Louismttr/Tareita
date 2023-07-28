using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjL_Matter
{
    public partial class fmrPerzonalizar : Form
    {
        Bitmap bm;
        Graphics gr;
        Point px, py;
        Pen p = new Pen(Color.White, 1);
        Pen erraser = new Pen(Color.Black, 10);
        int index;
        bool Paint;
        Color color;
        ColorDialog cd = new ColorDialog();

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);

        public fmrPerzonalizar()
        {
            InitializeComponent();
            bm = new Bitmap(pic.Width, pic.Height);
            gr = Graphics.FromImage(bm);
            gr.Clear(Color.Black);
            pic.Image = bm;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            Paint = true;
            py= e.Location;

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(Paint)
            {
                if(index==1)
                {
                    px = e.Location;
                    gr.DrawLine(p, px, py);
                    py = px;

                }
                if (index == 2)
                {
                    px = e.Location;
                    gr.DrawLine(erraser, px, py);
                    py = px;

                }
            }
            pic.Refresh();
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            Paint = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            index = 2;
        }


        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.Black);
            pic.Image = bm;
            index = 0;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            color = cd.Color;
            pic.BackColor=cd.Color;
        }

        private void guardareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var std = new SaveFileDialog();
            std.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if(std.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                bmp.Save(std.FileName, ImageFormat.Jpeg);
            }
  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            index = 1;
        }
    }
}
