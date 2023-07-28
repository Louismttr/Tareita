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
    public partial class fmrBienvenida : Form
    {
        public fmrBienvenida()
        {
            InitializeComponent();
        }

        #region Progressbar

        private void temporizador_uno_Tick(object sender, EventArgs e)
        {
            cProgress.Value += 1;
            if (Opacity < 1)
            {
                Opacity += 0.05;
                cProgress.Value +=1;
                           
            }
            if(cProgress.Value == 100)
            {
                temporizador_uno.Stop();
                temporizador_Dos.Start();
            }

        }
        private void temporizador_Dos_Tick(object sender, EventArgs e)
        {
            Opacity = -1;
            if(Opacity==0)
            {
                temporizador_Dos.Stop();
                fmrBienvenida bienvenida = new fmrBienvenida();
                bienvenida.Hide();
                bienvenida.Close();

                fmrInicio inicio = new fmrInicio();
                inicio.ShowDialog();

            }
        }

        private void fmrBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            cProgress.Value = 0;
            cProgress.Minimum = 0;
            cProgress.Maximum = 100;
            temporizador_uno.Start();

        }



        #endregion

    }
}
