using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjL_Matter
{
    public partial class fmrInformacionAPP : Form
    {
        public fmrInformacionAPP()
        {
            InitializeComponent();
        }

        private void fmrInformacionAPP_Load(object sender, EventArgs e)
        {
            ConfigurarTrackBar();
            MostrarPresentacion();
        }

        private void ConfigurarTrackBar()
        {
            tBControl.Minimum = 01;
            tBControl.Maximum = 04;

            lblUno.Text = "01";
            lblDos.Text = "02";
            lblTres.Text = "03";
            lblCuatro.Text = "04";

        }

        private void tBControl_ValueChanged(object sender, EventArgs e)
        {
            MostrarPresentacion();
        }

        private void MostrarPresentacion()
        {
            lblTitulo.Text = tBControl.Value.ToString();

            switch(tBControl.Value)
            {
                case 01:
                    { 
                    txtTexto.Text ="Objetivo_#1: " +
                            "-Aplicar los conocimientos aprendidos con los componenetes dados. " +
                            " :)";
                    }
                    break;
                case 02:
                    {
                        txtTexto.Text = "Objetivo_#2: " +
                            "-Utilizar los diferentes componenetes de manera creativa y así, demostrar los conocimientos adquiridos. "
                        + " :D";
                    }break;

                case 03:
                    {
                        txtTexto.Text = "Descripción_#1: " +
                            " En el menú |Otros|, se presenta de manera sintetizada algunos de los componenete.";
                    }break;

                case 04:
                    {
                        txtTexto.Text = "Descripción_#1: " +
                            "Para concluir con la presentación de la APP..., espero que está halla logrado reponder a los obejectivos de dicho sistemático.!"
                        +  " :D";

                    }
                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void fmrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
 