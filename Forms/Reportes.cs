using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYRASA.Forms
{
    public partial class Reportes : Form
    {
        SqlConnection conexion;
        public Reportes()
        {
            InitializeComponent();
        }

        public Reportes(SqlConnection conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void bttBoletasHistorico_Click(object sender, EventArgs e)
        {
            VisorDeReportes visor = new VisorDeReportes(this.conexion);
            visor.BoletasHistorico();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void bttCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bttOrdenesHistorico_Click(object sender, EventArgs e)
        {
            VisorDeReportes visor = new VisorDeReportes(this.conexion);
            visor.OrdenesHistorico();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void bttResumenProduccion_Click(object sender, EventArgs e)
        {

            PopUpForm popUp = new PopUpForm("Lote", "Esccriba el lote a consultar", 0);
            popUp.ShowDialog();
            if(popUp.DialogResult == DialogResult.OK)
            {
                string lote = popUp.Answer;
                VisorDeReportes visor = new VisorDeReportes(this.conexion);
                visor.LoteDetalle(lote);
            }
            else
            {
                MessageBox.Show("Necesita capturar un lote");
            }





        }
    }
}
