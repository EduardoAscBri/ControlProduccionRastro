using FYRASA.Classes;
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
    public partial class MenuPrincipal : Form
    {
        private Usuario usuarioActivo;
        private string rutaLocal;
        private bool nuevo = false;
        private SqlConnection conexion;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable = new DataTable();
        private DataRow dataRow;
        private int currentRow;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(SqlConnection conexion, Usuario usuario)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.usuarioActivo = usuario;
            validarPermisos(this.usuarioActivo);
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MnMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BttCerrar_Click(object sender, EventArgs e)
        {
            this.conexion.Close();
            Application.Exit();
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

        private void MnControlUsuarios_Click(object sender, EventArgs e)
        {
            ControlUsuarios controlUsuarios = new ControlUsuarios(this.conexion);
            controlUsuarios.Show();
        }

        private void MnNuevaBoleta_Click(object sender, EventArgs e)
        {
            Boletas boletas = new Boletas(this.conexion);
            boletas.Show();
        }

        private void validarPermisos(Usuario usuarioActivo)
        {
            this.mnArchivo.Enabled = this.usuarioActivo.archivo == 1 ? true : false;
            this.mnBoletas.Enabled = this.usuarioActivo.boletas == 1 ? true : false;
            this.mnPesos.Enabled = this.usuarioActivo.pesos == 1 ? true : false;
            this.mnReportes.Enabled = this.usuarioActivo.reportes == 1 ? true : false;
            this.mnProduccion.Enabled = this.usuarioActivo.produccion == 1 ? true : false;
        }

        private void MnPesoCaliente_Click(object sender, EventArgs e)
        {
            Pesos pesoCaliente = new Pesos(this.conexion, 1);
            pesoCaliente.Show();
        }

        private void MnPesoFrio_Click(object sender, EventArgs e)
        {
            Pesos pesoFrio = new Pesos(this.conexion, 2);
            pesoFrio.Show();
        }

        private void MnPesoCanastas_Click(object sender, EventArgs e)
        {
            PesosCanastas pesoCanastas = new PesosCanastas(this.conexion, 3);
            pesoCanastas.Show();
        }

        private void MnControlProduccion_Click(object sender, EventArgs e)
        {
            ControlProduccion controlProduccion = new ControlProduccion(this.conexion, this.usuarioActivo);
            controlProduccion.Show();
        }

        private void MnOrdenProduccion_Click(object sender, EventArgs e)
        {
            OrdenesProduccion ordenesProduccion = new OrdenesProduccion(this.conexion, this.usuarioActivo);
            ordenesProduccion.Show();
        }

        private void MnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnReporteProduccion_Click(object sender, EventArgs e)
        {

        }

        private void mnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes(this.conexion);
            reportes.Show();
        }
    }
}
