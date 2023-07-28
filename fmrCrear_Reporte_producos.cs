using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using iTextSharp.tool.xml;
using System.Runtime.InteropServices;
using System.Linq.Expressions;

namespace pjL_Matter
{
    public partial class fmrCrear_Reporte_producos : Form
    {
        public fmrCrear_Reporte_producos()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);

        private void btndescargar_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtnombres.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtdocumento.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;

            try
            {
                foreach (DataGridViewRow row in dgvproductos.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Precio Unitario"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                    filas += "</tr>";
                    total += decimal.Parse(row.Cells["Importe"].Value.ToString());
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Elementos agregados...!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logoPDF, System.Drawing.Imaging.ImageFormat.Jpeg);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);


                        //pdfDoc.Add(new Phrase("Hola Mundo"));
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }


                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Elemento guardado", "Guardado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void fmrCrear_Reporte_producos_Load(object sender, EventArgs e)
        {
            dgvproductos.Columns.Add("Cantidad", "Cantidad");
            dgvproductos.Columns.Add("Descripcion", "Descripcion");
            dgvproductos.Columns.Add("Precio Unitario", "Precio Unitario");
            dgvproductos.Columns.Add("Importe", "Importe");

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            {
               
                int indice_fila = dgvproductos.Rows.Add();
                DataGridViewRow row = dgvproductos.Rows[indice_fila];

                row.Cells["Cantidad"].Value = txtcantidad.Text;
                row.Cells["Descripcion"].Value = txtdescripcion.Text;
                row.Cells["Precio Unitario"].Value = txtprecio.Text;
                row.Cells["Importe"].Value = decimal.Parse(txtcantidad.Text) * decimal.Parse(txtprecio.Text);
              
            }

        }

        #region Botones

        private void BtnCerrar_Click(object sender, EventArgs e)
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

        private void fmrCrear_Reporte_producos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //validacion
        private string Valida()
        {
            if (txtdocumento.Text.Trim().Length == 0)
            {
                txtdocumento.Focus();
                return "Numero del doc.";
            }
            else if (txtnombres.Text.Trim().Length == 0)
            {
                txtnombres.Focus();
                return "Nombres";
            }
            else if (txtdescripcion.Text.Trim().Length == 0)
            {
                txtdescripcion.Focus();
                return "Descipcion";
            }
            else if (txtcantidad.Text.Trim().Length == 0)
            {
                txtcantidad.Focus();
                return "Cantidad";
            }
            else if (txtprecio.Text.Trim().Length == 0)
            {
                txtprecio.Focus();
                return "Precio";
            }

            return "";
        }

    }
}
