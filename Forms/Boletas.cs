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
    public partial class Boletas : Form
    {
        private SqlConnection conexion;
        private SqlConnection conexionComercial;
        private SqlDataAdapter dataAdapter;
        private SqlCommand command;
        private DataTable dataTable = new DataTable();
        private string rutaLocal;
        private int idBoleta;
        public Boletas()
        {
            InitializeComponent();
        }

        public Boletas(SqlConnection conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void Boletas_Load(object sender, EventArgs e)
        {
            limpiar();
            this.rutaLocal = Application.StartupPath;
            InnerDatabaseManager comercialDBM = new InnerDatabaseManager();
            this.conexionComercial = comercialDBM.createConnectionFromIniComercialFile(this.rutaLocal);

            try
            {
                this.conexionComercial.Open();
                command = new SqlCommand("SELECT CIDCLIENTEPROVEEDOR, " +
                    "CCODIGOCLIENTE, " +
                    "CRAZONSOCIAL " +
                    "FROM admClientes " +
                    "WHERE CESTATUS = 1 " +
                    "ORDER BY CIDCLIENTEPROVEEDOR ASC", this.conexionComercial);
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.DataSource = dataTable;

            this.cmbCanalizacion.Items.Insert(0, "Canal completo");
            this.cmbCanalizacion.Items.Insert(0, "Cortes - Obrador");
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
            this.Dispose();
        }

        private void BttSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo, razonSocial;

            codigo = this.dgvClientes.CurrentRow.Cells["CCODIGOCLIENTE"].Value.ToString();
            razonSocial = this.dgvClientes.CurrentRow.Cells["CRAZONSOCIAL"].Value.ToString();

            this.txtCodigoCli.Text = codigo;
            this.txtRazonSocial.Text = razonSocial;
            this.txtGranja.Focus();
        }

        private void TxtRazonSocial_KeyUp(object sender, KeyEventArgs e)
        {
            if(this.txtRazonSocial.Text != "")
            {
                string filterString = "CRAZONSOCIAL LIKE '%" + this.txtRazonSocial.Text + "%'";
                this.dataTable.DefaultView.RowFilter = filterString;
            }
            else
            {
                this.dataTable.DefaultView.RowFilter = null;
            }
        }

        private void TxtNuevo_Click(object sender, EventArgs e)
        {
            nuevaBoleta();
        }

        private void TxtGuardar_Click(object sender, EventArgs e)
        {
            guardarBoleta();
        }

        private void TxtFolio_Leave(object sender, EventArgs e)
        {
            validaFolio();
        }

        private void recargarBoleta(DataTable dataTable)
        {
            PopUpForm popUp = new PopUpForm("Recargar boleta", "¿Quieres cargar la boleta " + this.txtSerie.Text + " " + this.txtFolio.Text + "?", 1);
            popUp.ShowDialog();

            if (popUp.DialogResult == DialogResult.OK)
            {
                DataRow dr = dataTable.Rows[0];

                this.txtCodigoCli.Text = dr["codigoCli"].ToString();
                this.txtRazonSocial.Text = dr["nombreCli"].ToString();
                this.dataTable.DefaultView.RowFilter = null;
                this.txtSerie.Text = dr["Serie"].ToString();
                this.txtFolio.Text = dr["Folio"].ToString();
                this.dtpFecha.Value = Convert.ToDateTime(dr["Fecha"]);
                this.txtNombreConductor.Text = dr["NombreConductor"].ToString();
                this.txtCantidadCerdos.Text = dr["CantidadCerdos"].ToString();
                this.txtPesoPromedio.Text = dr["PesoPromedio"].ToString();
                this.txtGranja.Text = dr["Granja"].ToString();
                this.idBoleta = Convert.ToInt32(dr["idBoleta"]);
            }
            else
            {
                nuevaBoleta();
            }
        }

        private void limpiar()
        {
            this.txtCodigoCli.Text = "";
            this.txtRazonSocial.Text = "";
            this.dataTable.DefaultView.RowFilter = null;
            this.txtSerie.Text = "";
            this.txtFolio.Text = "";
            this.dtpFecha.Value = DateTime.Now;
            this.txtNombreConductor.Text = "";
            this.txtCantidadCerdos.Text = "";
            this.txtPesoPromedio.Text = "";
            this.txtGranja.Text = "";
            this.idBoleta = 0;

        }

        private void nuevaBoleta()
        {
            limpiar();

            PopUpForm dialogSerie = new PopUpForm("Serie nueva boleta", "¿Cual es la serie asumida?", 0);
            dialogSerie.ShowDialog();
            string lSerie = dialogSerie.Answer.ToString();
            this.txtSerie.Text = lSerie;

            SqlCommand comandoNuevaBoleta = new SqlCommand("SELECT ISNULL(MAX(Folio), 0) AS Folio FROM Boletas WHERE Serie = '" + lSerie + "'", this.conexion);
            int ultimaBoleta = Convert.ToInt32(comandoNuevaBoleta.ExecuteScalar());
            ultimaBoleta = ultimaBoleta + 1;

            this.txtFolio.Text = ultimaBoleta.ToString();
            this.txtRazonSocial.Focus();
        }

        private void guardarBoleta()
        {
            SqlCommand lCommand = new SqlCommand("SELECT ISNULL(MAX(idBoleta), 0) AS idBoleta FROM Boletas", this.conexion);
            int ultimoid = Convert.ToInt32(lCommand.ExecuteScalar());
            string lInsert = "INSERT INTO Boletas VALUES (" +
                (ultimoid + 1) + ", " +
                "'" + this.txtCodigoCli.Text + "', " +
                "'" + this.txtRazonSocial.Text + "', " +
                "'" + this.txtSerie.Text + "', " +
                this.txtFolio.Text + ", " +
                "'" + this.dtpFecha.Value.ToString() + "', " +
                "'" + this.txtNombreConductor.Text + "', " +
                this.txtCantidadCerdos.Text + ", " +
                this.txtPesoPromedio.Text + ", " +
                "'" + this.cmbCanalizacion.Text + "'" +
                ", '" + this.txtGranja.Text + "', " +
                "0)";

            this.idBoleta = (ultimoid + 1);

            lCommand = null;
            lCommand = new SqlCommand(lInsert, this.conexion);
            lCommand.ExecuteNonQuery();

            imprimirBoleta();
            limpiar();
            MessageBox.Show("Boleta guardada");
        }

        public void validaFolio()
        {
            try
            {
                SqlCommand validaFolio = new SqlCommand("SELECT * FROM Boletas " +
                    "WHERE Serie = '" + this.txtSerie.Text + "' " +
                    "AND Folio = " + this.txtFolio.Text, this.conexion);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(validaFolio);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    recargarBoleta(dataTable);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttImprimir_Click(object sender, EventArgs e)
        {
            imprimirBoleta();
        }

        private void imprimirBoleta()
        {
            VisorDeReportes visor = new VisorDeReportes(this.conexion);
            visor.Boleta(this.idBoleta);
        }
    }
}
