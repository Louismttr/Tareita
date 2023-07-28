using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace pjL_Matter
{
    public partial class fmrConvertidor_WORD : Form
    {
        FolderBrowserDialog carpeta_Salida;
        bool convertir = false;
        string ruta_Archivo_Origen;
        string nombre_Archivo_Origen;
        string ruta_Archivo_Destino;

        public fmrConvertidor_WORD()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);

        private void btnArchivoOrigen_Click(object sender, EventArgs e)
        {
            OpenFileDialog cajaDialogo=new OpenFileDialog();
            cajaDialogo.Filter = "Archivo PDF(.pdf)|*.pdf";
            DialogResult resultado=cajaDialogo.ShowDialog();
            if(resultado==DialogResult.OK)
            {
                ruta_Archivo_Origen=cajaDialogo.FileName;
                nombre_Archivo_Origen = Path.GetFileNameWithoutExtension(ruta_Archivo_Origen);
                ruta_Archivo_Destino = Path.GetDirectoryName(ruta_Archivo_Origen);

                txtCarpetaDestino.Text = ruta_Archivo_Destino;
                txtArchivoOrigen.Text = ruta_Archivo_Origen.ToString();
                convertir = true;
            }
        }

        private void btnCarpetaDestino_Click(object sender, EventArgs e)
        {
            carpeta_Salida = new FolderBrowserDialog();
            if(carpeta_Salida.ShowDialog()==DialogResult.OK)
            {
                txtCarpetaDestino.Text = carpeta_Salida.SelectedPath;
                ruta_Archivo_Destino = txtCarpetaDestino.Text;
                convertir = true;
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try { 
            if(convertir)
            {
                SautinSoft.PdfFocus ArchivoPDF=new SautinSoft.PdfFocus();
                ArchivoPDF.OpenPdf(ruta_Archivo_Origen);
                ArchivoPDF.ToWord(ruta_Archivo_Destino + "\\" + nombre_Archivo_Origen + ".docx");
                System.Diagnostics.Process.Start(ruta_Archivo_Destino);
            }
            }catch(Exception ex)

            { MessageBox.Show("Archivo convertido...", "Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        #region Botones

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void fmrConvertidor_WORD_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void paneContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
