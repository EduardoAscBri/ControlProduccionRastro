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
    public partial class ControlProduccion : Form
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable dataTable = new DataTable();
        Usuario usuarioActivo;
        DataRow dataRow;
        int idOrdenProduccion = 0;
        bool produccion = false;

        public ControlProduccion()
        {
            InitializeComponent();
        }

        public ControlProduccion(SqlConnection conexion, Usuario usuarioActivo)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.usuarioActivo = usuarioActivo;
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

        private void ControlProduccion_Load(object sender, EventArgs e)
        {
            produccion = cargarOrdenActual();
            if(produccion == true)
            {
                this.bttIniciar.Enabled = false;
                this.bttConcluir.Enabled = true;
            }
            else
            {
                this.bttIniciar.Enabled = true;
                this.bttConcluir.Enabled = false;
            }
            actualizarDataGridView();
        }

        private void DgvOrdenesProduccion_DoubleClick(object sender, EventArgs e)
        {
            int currentRow = this.dgvOrdenesProduccion.CurrentRow.Index;
            this.dataRow = this.dataTable.Rows[currentRow];

            this.txtSerieOrden.Text = this.dataRow["Serie"].ToString();
            this.txtFolioOrden.Text = this.dataRow["Folio"].ToString();
            this.txtGranjaOrden.Text = this.dataRow["Granja"].ToString();
            this.txtCerdosOrden.Text = this.dataRow["CantidadCerdos"].ToString();
            this.dtpFecha.Value = Convert.ToDateTime(this.dataRow["Fecha"]);
        }

        public bool cargarOrdenActual()
        {
            try
            {
                this.command = new SqlCommand("SELECT Produccion.idOrdenProduccion, " +
                    "OrdenesProduccion.Serie, OrdenesProduccion.Folio, OrdenesProduccion.Status, " +
                    "Boletas.Granja, Boletas.CantidadCerdos, Boletas.Canalizacion, " +
                    "Lotes.Lote " +
                    "FROM Produccion " +
                    "LEFT JOIN OrdenesProduccion " +
                    "ON Produccion.idOrdenProduccion = OrdenesProduccion.idOrdenProduccion " +
                    "LEFT JOIN Boletas " +
                    "ON OrdenesProduccion.idBoleta = Boletas.idBoleta " +
                    "LEFT JOIN Lotes " +
                    "ON Lotes.idOrdenProduccion = OrdenesProduccion.idOrdenProduccion " +
                    "WHERE Produccion.Status = 0", this.conexion);

                this.command.ExecuteNonQuery();

                DataTable dataTable = new DataTable();
                this.dataAdapter = new SqlDataAdapter(this.command);
                this.dataAdapter.Fill(dataTable);
                int registros = dataTable.Rows.Count;

                if (registros == 1)
                {
                    this.dataRow = dataTable.Rows[0];
                    this.idOrdenProduccion = Convert.ToInt32(this.dataRow["idOrdenProduccion"]);

                    this.txtSerieOrden.Text = this.dataRow["Serie"].ToString();
                    this.txtFolioOrden.Text = this.dataRow["Folio"].ToString();
                    this.txtStatus.Text = Convert.ToInt32(this.dataRow["Status"]) == 0 ? "Autorizada" : "Concluida";
                    this.txtGranjaOrden.Text = this.dataRow["Granja"].ToString();
                    this.txtCerdosOrden.Text = this.dataRow["CantidadCerdos"].ToString();
                    this.txtCanalizacion.Text = this.dataRow["Canalizacion"].ToString();
                    this.txtLote.Text = this.dataRow["Lote"].ToString();

                    return true;
                }
                else if(registros > 1)
                {
                    MessageBox.Show("Error: Varios registros (" + registros + ")");
                    return false;
                }
                else if (registros == 0)
                {
                    MessageBox.Show("No hay produccion actual");
                    return false;
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }

        public void actualizarDataGridView()
        {
            this.dataTable.Clear();
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
                    "WHERE OrdenesProduccion.Status = 0" +
                    "ORDER BY Fecha DESC", this.conexion);

                this.dataAdapter = new SqlDataAdapter(this.command);
                this.dataAdapter.Fill(this.dataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            dgvOrdenesProduccion.AutoGenerateColumns = false;
            dgvOrdenesProduccion.DataSource = this.dataTable;

        }

        private void BttNuevo_Click(object sender, EventArgs e)
        {
            iniciarProduccion();
        }

        private void DgvOrdenesProduccion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.produccion != true)
            {
                int currentRow = this.dgvOrdenesProduccion.CurrentRow.Index;
                this.dataRow = this.dataTable.Rows[currentRow];
                int idOrdenProduccion = Convert.ToInt32(this.dataRow["idOrdenProduccion"]);
                MessageBox.Show("Orden de produccion seleccionada: " + idOrdenProduccion);

                if (idOrdenProduccion != 0)
                {
                    try
                    {
                        this.command = new SqlCommand("SELECT OrdenesProduccion.idOrdenProduccion, " +
                            "OrdenesProduccion.Serie, " +
                            "OrdenesProduccion.Folio, " +
                            "OrdenesProduccion.Status, " +
                            "Boletas.Granja, " +
                            "Boletas.Canalizacion, " +
                            "Boletas.CantidadCerdos, " +
                            "Lotes.Lote " +
                            "FROM OrdenesProduccion " +
                            "LEFT JOIN Boletas " +
                            "ON OrdenesProduccion.idBoleta = Boletas.idBoleta " +
                            "LEFT JOIN Lotes " +
                            "ON OrdenesProduccion.idOrdenProduccion = Lotes.idOrdenProduccion " +
                            "WHERE OrdenesProduccion.idOrdenProduccion = " + idOrdenProduccion, this.conexion);

                        this.dataAdapter = new SqlDataAdapter(this.command);
                        DataTable lDataTable = new DataTable();
                        this.dataAdapter.Fill(lDataTable);
                        this.dataRow = lDataTable.Rows[0];


                        this.txtSerieOrden.Text = this.dataRow["Serie"].ToString();
                        this.txtFolioOrden.Text = this.dataRow["Folio"].ToString();
                        this.txtStatus.Text = Convert.ToInt32(this.dataRow["Status"]) == 0 ? "Autorizada" : "Concluida";
                        this.txtGranjaOrden.Text = this.dataRow["Granja"].ToString();
                        this.txtCerdosOrden.Text = this.dataRow["CantidadCerdos"].ToString();
                        this.txtCanalizacion.Text = this.dataRow["Canalizacion"].ToString();
                        this.txtLote.Text = this.dataRow["Lote"].ToString();
                        this.idOrdenProduccion = Convert.ToInt32(this.dataRow["idOrdenProduccion"]);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Produccion sin concluir");
                }
            }
            else
            {
                MessageBox.Show("Es necesario concluir la orden de producción previa antes de seleccionar una orde nueva");
            }
        }

        private void BttSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iniciarProduccion()
        {
            try
            {
                this.command = new SqlCommand("DELETE FROM Produccion", this.conexion);
                this.command.ExecuteNonQuery();

                this.command = new SqlCommand("INSERT INTO Produccion VALUES (" + this.idOrdenProduccion + ", " + 0 + ")", this.conexion);
                this.command.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Orden cargada en producción");
            produccion = cargarOrdenActual();
            if (produccion == true)
            {
                this.bttIniciar.Enabled = false;
                this.bttConcluir.Enabled = true;
            }
            else
            {
                this.bttIniciar.Enabled = true;
                this.bttConcluir.Enabled = false;
            }
            actualizarDataGridView();
        }

        private void concluirProduccion()
        {
            try
            {
                this.command = new SqlCommand("UPDATE Produccion SET Status = 1", this.conexion);
                this.command.ExecuteNonQuery();

                this.command = new SqlCommand("UPDATE OrdenesProduccion SET Status = 1 WHERE idOrdenProduccion = " + this.idOrdenProduccion, this.conexion);
                this.command.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Orden de producción concluida ");
            limpiar();
            produccion = cargarOrdenActual();
            if (produccion == true)
            {
                this.bttIniciar.Enabled = false;
                this.bttConcluir.Enabled = true;
            }
            else
            {
                this.bttIniciar.Enabled = true;
                this.bttConcluir.Enabled = false;
            }
            actualizarDataGridView();
        }

        private void limpiar()
        {
            this.txtSerieOrden.Text = "";
            this.txtFolioOrden.Text = "";
            this.txtStatus.Text = "";
            this.txtGranjaOrden.Text = "";
            this.txtCerdosOrden.Text = "";
            this.txtCanalizacion.Text = "";
            this.txtLote.Text = "";
            this.idOrdenProduccion = 0;
        }

        private void BttConcluir_Click(object sender, EventArgs e)
        {
            concluirProduccion();
        }
    }
}
