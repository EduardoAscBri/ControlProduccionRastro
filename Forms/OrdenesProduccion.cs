using FYRASA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYRASA.Forms
{
    public partial class OrdenesProduccion : Form
    {

        SqlConnection conexion;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable dataTable = new DataTable();
        DataRow dataRow;
        int idOrdenProduccion;
        Usuario usuarioActivo;
        public OrdenesProduccion()
        {
            InitializeComponent();
        }

        public OrdenesProduccion(SqlConnection conexion, Usuario usuarioActivo)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.usuarioActivo = usuarioActivo;
        }


        private void OrdenesProduccion_Load(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }

        private void TxtNuevo_Click(object sender, EventArgs e)
        {
            OrdenesProduccionCaptura captura = new OrdenesProduccionCaptura(this.conexion, this.usuarioActivo);
            captura.Show();
        }

        private void BttCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void actualizarDataGridView()
        {
            try
            {
                this.command = new SqlCommand("SELECT OrdenesProduccion.idOrdenProduccion, " +
                    "OrdenesProduccion.idBoleta, " +
                    "OrdenesProduccion.Serie, " +
                    "OrdenesProduccion.Folio, " +
                    "OrdenesProduccion.idUsuario, " +
                    "OrdenesProduccion.Usuario, " +
                    "OrdenesProduccion.Fecha, " +
                    "IIF(OrdenesProduccion.Status = 0, 'Autorizada', 'Concluida') AS Status, " +
                    "Boletas.Granja, " +
                    "Boletas.CantidadCerdos " +
                    "FROM OrdenesProduccion LEFT JOIN " +
                    "Boletas ON OrdenesProduccion.idBoleta = Boletas.idBoleta " +
                    "ORDER BY Fecha DESC", this.conexion);

                    this.dataAdapter = new SqlDataAdapter(this.command);
                    this.dataAdapter.Fill(this.dataTable);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            dgvOrdenesProduccion.AutoGenerateColumns = false;
            dgvOrdenesProduccion.DataSource = this.dataTable;

        }

        private void BttSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.dataTable.Clear();
            actualizarDataGridView();
        }

        private void DgvOrdenesProduccion_DoubleClick(object sender, EventArgs e)
        {
            int currentRow = this.dgvOrdenesProduccion.CurrentRow.Index;
            this.dataRow = this.dataTable.Rows[currentRow];
            this.idOrdenProduccion = Convert.ToInt32(this.dataRow["idOrdenProduccion"]);

            OrdenesProduccionCaptura captura = new OrdenesProduccionCaptura(this.conexion, this.usuarioActivo, idOrdenProduccion);
            captura.Show();

        }
    }
}
