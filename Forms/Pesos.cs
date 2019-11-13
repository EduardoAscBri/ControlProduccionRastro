using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYRASA.Forms
{
    public partial class Pesos : Form
    {
        public Pesos()
        {
            InitializeComponent();
        }

        public Pesos(int tipo)
        {
            InitializeComponent();

            switch (tipo)
            {
                //Peso Caliente
                case 1:
                    this.lblTitle.Text = "Peso caliente";
                    break;

                //Peso frio
                case 2:
                    this.lblTitle.Text = "Peso frio";
                    break;

                //Peso en canastas
                case 3:
                    this.lblTitle.Text = "Peso en canastas";
                    break;
            }

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BttCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Pesos_Load(object sender, EventArgs e)
        {

        }
    }
}
