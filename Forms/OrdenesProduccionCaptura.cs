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
    public partial class OrdenesProduccionCaptura : Form
    {

        SqlConnection conexion;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable dataTable = new DataTable();
        DataRow dataRow;
        Usuario usuarioActivo;
        int idOrdenProduccion;
        int idBoleta;
        public OrdenesProduccionCaptura()
        {
            InitializeComponent();
        }

        public OrdenesProduccionCaptura(SqlConnection conexion, Usuario usuarioActivo)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.usuarioActivo = usuarioActivo;
            this.bttGuardar.Enabled = false;
            this.txtSerieOrden.Focus();
        }

        public OrdenesProduccionCaptura(SqlConnection conexion, Usuario usuarioActivo, int idOrdenProduccion)
        {
            InitializeComponent();
            limpiar();
            this.conexion = conexion;
            this.usuarioActivo = usuarioActivo;
            this.idOrdenProduccion = idOrdenProduccion;
            this.bttGuardar.Enabled = false;
            cargarOrdenProduccion(this.idOrdenProduccion);
            this.bttSalir.Focus();

        }

        private void BttCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void OrdenesProduccionCaptura_Load(object sender, EventArgs e)
        {
            cargarBoletas();
        }

        private void BttSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            cargarBoletas();
            nuevaOrdenProduccion();
        }

        private void BttBorrar_Click(object sender, EventArgs e)
        {
            borrarOrdenProduccion();
        }

        private void ChkAutorizar_CheckedChanged(object sender, EventArgs e)
        {
            this.bttGuardar.Enabled = this.chkAutorizar.Checked ? true : false;
        }

        private void DgvBoletas_DoubleClick(object sender, EventArgs e)
        {
            int currentRow = this.dgvBoletas.CurrentRow.Index;
            this.dataRow = this.dataTable.Rows[currentRow];

            this.txtSerie.Text = this.dataRow["Serie"].ToString();
            this.txtFolio.Text = this.dataRow["Folio"].ToString();
            this.txtNombreCli.Text = this.dataRow["NombreCli"].ToString();
            this.idBoleta = Convert.ToInt32(this.dataRow["idBoleta"]);

        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {

            guardarOrdenProduccion();
            limpiar();
            cargarBoletas();
        }

        private void TxtFolioOrden_Leave(object sender, EventArgs e)
        {
            try
            {
                SqlCommand validaFolio = new SqlCommand("SELECT * FROM OrdenesProduccion WHERE Serie = '" + this.txtSerieOrden.Text + "' AND Folio = " + this.txtFolioOrden.Text, this.conexion);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(validaFolio);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    recargarOrdenProduccion(dataTable);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarBoletas()
        {
            this.dataTable.Clear();
            try
            {
                this.command = new SqlCommand("SELECT * FROM Boletas WHERE Status = 0 ORDER BY Fecha DESC", this.conexion);
                this.dataAdapter = new SqlDataAdapter(this.command);
                this.dataAdapter.Fill(this.dataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            int lPendientes = this.dataTable.Rows.Count;
            this.txtBoletasPendientes.Text = lPendientes.ToString();

            this.dgvBoletas.AutoGenerateColumns = false;
            this.dgvBoletas.DataSource = this.dataTable;
        }

        private void limpiar()
        {
            this.txtSerie.Text = "";
            this.txtFolio.Text = "";
            this.txtNombreCli.Text = "";
            this.txtSerieOrden.Text = "";
            this.txtFolioOrden.Text = "";
            this.dtpFecha.Value = DateTime.Now;
        }

        //REVISAR METODOS, IMPLEMENTAR SOBRECARGA
        private void recargarOrdenProduccion(DataTable dataTable)
        {
            PopUpForm popUp = new PopUpForm("Recargar orden de producción", "¿Quieres cargar la orden de producción " + this.txtSerie.Text + " " + this.txtFolio.Text + "?", 1);
            popUp.ShowDialog();

            if (popUp.DialogResult == DialogResult.OK)
            {
                this.command = new SqlCommand("SELECT OrdenesProduccion.idOrdenProduccion, " +
                    "OrdenesProduccion.idBoleta, " +
                    "OrdenesProduccion.Serie, " +
                    "OrdenesProduccion.Folio, " +
                    "OrdenesProduccion.idUsuario, " +
                    "OrdenesProduccion.Usuario, " +
                    "OrdenesProduccion.Fecha, " +
                    "OrdenesProduccion.Status, " +
                    "Boletas.codigoCli, " +
                    "Boletas.nombreCli, " +
                    "Boletas.Serie AS SerieBoleta, " +
                    "Boletas.Folio AS FolioBoleta, " +
                    "Boletas.Status AS StatisBoleta " +
                    "FROM OrdenesProduccion " +
                    "LEFT JOIN Boletas " +
                    "ON OrdenesProduccion.idBoleta = Boletas.idBoleta " +
                    "WHERE (OrdenesProduccion.Serie = '" + this.txtSerieOrden.Text + "') AND (OrdenesProduccion.Folio = " + this.txtFolioOrden.Text + ")" , this.conexion);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(this.command);
                da.Fill(dt);
                DataRow dr = dt.Rows[0];


                this.txtSerieOrden.Text = dr["Serie"].ToString();
                this.txtFolioOrden.Text = dr["Folio"].ToString();
                this.dtpFecha.Value = Convert.ToDateTime(dr["Fecha"]);
                this.txtSerie.Text = dr["SerieBoleta"].ToString();
                this.txtFolio.Text = dr["FolioBoleta"].ToString();
                this.txtNombreCli.Text = dr["nombreCli"].ToString();
                this.chkAutorizar.Checked = Convert.ToInt32(dr["Status"]) == 0 ? true : false;
                this.idBoleta = Convert.ToInt32(dr["idBoleta"]);

            }
            else
            {
                nuevaOrdenProduccion();
            }
        }

        public void cargarOrdenProduccion(int idOrdenProduccion)
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
                    "OrdenesProduccion.Status, " +
                    "Boletas.codigoCli, " +
                    "Boletas.nombreCli, " +
                    "Boletas.Serie AS SerieBoleta, " +
                    "Boletas.Folio AS FolioBoleta, " +
                    "Boletas.Status AS StatusBoleta " +
                    "FROM OrdenesProduccion " +
                    "LEFT JOIN Boletas " +
                    "ON OrdenesProduccion.idBoleta = Boletas.idBoleta " +
                    "WHERE OrdenesProduccion.idOrdenProduccion = " + idOrdenProduccion, this.conexion);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(this.command);
                da.Fill(dt);
                DataRow dr = dt.Rows[0];

                this.txtSerieOrden.Text = dr["Serie"].ToString();
                this.txtFolioOrden.Text = dr["Folio"].ToString();
                this.dtpFecha.Value = Convert.ToDateTime(dr["Fecha"]);
                this.txtSerie.Text = dr["SerieBoleta"].ToString();
                this.txtFolio.Text = dr["FolioBoleta"].ToString();
                this.txtNombreCli.Text = dr["nombreCli"].ToString();
                this.chkAutorizar.Checked = Convert.ToInt32(dr["Status"]) == 0 ? true : false;
                this.idBoleta = Convert.ToInt32(dr["idBoleta"]);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //REVISAR METODOS

        private void nuevaOrdenProduccion()
        {
            limpiar();

            PopUpForm dialogSerie = new PopUpForm("Serie nueva orden de produccion", "¿Cual es la serie asumida?", 0);
            dialogSerie.ShowDialog();
            string lSerie = dialogSerie.Answer.ToString();
            this.txtSerieOrden.Text = lSerie;

            SqlCommand comandoNuevaBoleta = new SqlCommand("SELECT ISNULL(MAX(Folio), 0) AS Folio FROM OrdenesProduccion WHERE Serie = '" + lSerie + "'", this.conexion);
            int ultimaBoleta = Convert.ToInt32(comandoNuevaBoleta.ExecuteScalar());
            ultimaBoleta = ultimaBoleta + 1;

            this.txtFolioOrden.Text = ultimaBoleta.ToString();
        }

        private void guardarOrdenProduccion()
        {
            try
            {
                int ultimoIdOrdenProduccion = 0;
                int ultimoIdLote = 0;
                string lote = this.txtSerieOrden.Text + this.txtFolioOrden.Text + this.dtpFecha.Value.Day + this.dtpFecha.Value.Month + this.dtpFecha.Value.Year;

                this.command = new SqlCommand("SELECT ISNULL(MAX(idOrdenProduccion), 0) AS idOrdenProduccion FROM OrdenesProduccion", this.conexion);
                ultimoIdOrdenProduccion = Convert.ToInt32(this.command.ExecuteScalar());

                this.command = new SqlCommand("SELECT ISNULL(MAX(idLote), 0) AS idLote FROM Lotes", this.conexion);
                ultimoIdLote = Convert.ToInt32(this.command.ExecuteScalar());

                this.command = new SqlCommand("INSERT INTO OrdenesProduccion VALUES (" + (ultimoIdOrdenProduccion + 1) + ", " + this.idBoleta + ", '" + this.txtSerieOrden.Text + "', " + this.txtFolioOrden.Text + ", " + this.usuarioActivo.idUsuario + ", '" + this.usuarioActivo.usuario + "', '" + this.dtpFecha.Value.ToString() + "', 0)", this.conexion);
                this.command.ExecuteNonQuery();

                this.command = new SqlCommand("UPDATE Boletas SET Status = 1 WHERE idBoleta = " + this.idBoleta, this.conexion);
                this.command.ExecuteNonQuery();

                this.command = new SqlCommand("INSERT INTO Lotes VALUES (" + (ultimoIdLote + 1) + ", " + (ultimoIdOrdenProduccion + 1) + ", '" + lote + "')", this.conexion);
                this.command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Se ha creado la orden de produccion");
        }

        private void borrarOrdenProduccion()
        {
            try
            {
                this.command = new SqlCommand("UPDATE Boletas SET Status = 0 WHERE idBoleta = " + this.idBoleta, this.conexion);
                this.command.ExecuteNonQuery();

                this.command = new SqlCommand("DELETE FROM Lotes WHERE idOrdenProduccion = " + this.idOrdenProduccion, this.conexion);
                this.command.ExecuteNonQuery();

                this.command = new SqlCommand("DELETE FROM OrdenesProduccion WHERE idOrdenProduccion = " + this.idOrdenProduccion, this.conexion);
                this.command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            limpiar();
            MessageBox.Show("Se ha borrado la orden de producción");
        }
    }
}
