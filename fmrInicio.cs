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


namespace pjL_Matter
{
    public partial class fmrInicio : Form
    {
        public fmrInicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);

        #region Botones

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        //private void AbrirFormulario(object formulariohijo)
        //{
        //    if(panelContenedor.Controls.Count>0)
        //    {
        //        this.panelContenedor.Controls.RemoveAt(0);
        //        Form fH = formulariohijo as Form;
        //        fH.TopLevel = false;
        //        fH.Dock = DockStyle.Fill;
        //        this.panelContenedor.Controls.Add(fH);
        //        this.panelContenedor.Tag = fH;
        //        fH.Show();
        //    }
        //}

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new fmrInformacionAPP());
            fmrInformacionAPP inf = new fmrInformacionAPP();
            inf.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            fmrCrear_Reporte_producos reo = new fmrCrear_Reporte_producos();
            reo.ShowDialog();
        }

        private void btnConvertidor_Click(object sender, EventArgs e)
        {
            fmrConvertidor_WORD conWordd = new fmrConvertidor_WORD();
            conWordd.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            fmrPerzonalizar editar = new fmrPerzonalizar();
            editar.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fmrInicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
