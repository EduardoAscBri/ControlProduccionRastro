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
    }
}
