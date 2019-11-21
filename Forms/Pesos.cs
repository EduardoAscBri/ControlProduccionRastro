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
    public partial class Pesos : Form
    {
        public SqlConnection conexion;
        public SqlCommand command;
        public SqlDataAdapter dataAdapter;
        public DataSet dataSet = new DataSet();
        public DataTable dataTable = new DataTable();
        public DataRow dataRow;

        public int tipoPeso;
        public int idOrdenProduccion;
        public int status;
        public int idLote;
        public string lote;
        public string canalizacion;
        public int numeroCanal;


        public Pesos()
        {
            InitializeComponent();
        }

        public Pesos(SqlConnection conexion, int tipoPeso)
        {
            InitializeComponent();
            this.conexion = conexion;

            switch (tipoPeso)
            {
                case 1:
                    this.lblTitle.Text = "PesoCaliente";
                    this.tipoPeso = tipoPeso;
                    break;

                case 2:
                    this.lblTitle.Text = "Peso frio";
                    this.tipoPeso = tipoPeso;
                    break;
            }

            validarProduccion();

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

        private void bttSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void validarProduccion()
        {
            try
            {
                this.dataTable.Clear();

                this.command = new SqlCommand("SELECT ISNULL(idOrdenProduccion, 0) AS idOrdenProduccion, " +
                    "ISNULL(Status, 0) AS Status " +
                    "FROM Produccion ", this.conexion);
                this.dataAdapter = new SqlDataAdapter(this.command);
                this.dataAdapter.Fill(this.dataTable);

                int registros = this.dataTable.Rows.Count;
                
                if(registros == 1)
                {
                    this.dataRow = this.dataTable.Rows[0];

                    this.idOrdenProduccion = Convert.ToInt32(this.dataRow["idOrdenProduccion"]);
                    this.status = Convert.ToInt32(this.dataRow["Status"]);

                    if(this.idOrdenProduccion != 0 && this.status != 1)
                    {
                        //Produccion actual
                        this.dataTable.Clear();
                        this.command = new SqlCommand("SELECT Lotes.Lote, Lotes.idLote, Boletas.Canalizacion " +
                            "FROM Lotes " + 
                            "LEFT JOIN OrdenesProduccion " +
                            "ON Lotes.idOrdenProduccion = OrdenesProduccion.idOrdenProduccion " +
                            "LEFT JOIN Boletas " +
                            "ON OrdenesProduccion.idBoleta = Boletas.idBoleta " +
                            "WHERE Lotes.idOrdenProduccion = " + this.idOrdenProduccion, this.conexion);
                        this.dataAdapter = new SqlDataAdapter(this.command);
                        this.dataAdapter.Fill(this.dataTable);
                        this.dataRow = this.dataTable.Rows[0];

                        this.idLote = Convert.ToInt32(this.dataRow["idLote"]);
                        this.lote = this.dataRow["Lote"].ToString();
                        this.canalizacion = this.dataRow["Canalizacion"].ToString();

                        this.lblLote.Text = this.lote;
                        this.lblCanalizacion.Text = this.canalizacion;

                        nuevoPeso();
                    }
                    else if (this.idOrdenProduccion != 0 && this.status == 1)
                    {
                        //Produccion concluida
                        this.bttGuardar.Enabled = false;
                        MessageBox.Show("La orden de producción ha sido concluida");
                    }

                }
                else if(registros == 0)
                {
                    MessageBox.Show("No hay un lote de produccion actual para capturar");
                    this.bttGuardar.Enabled = false;
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        public void nuevoPeso()
        {
            try
            {
                this.command = new SqlCommand("SELECT ISNULL(MAX(numeroCanal), 0) AS numeroCanal " +
                    "FROM LotesDetalle " +
                    "WHERE tipoPeso = " + this.tipoPeso, this.conexion);
                int ultimoDetalle = Convert.ToInt32(this.command.ExecuteScalar());
                this.numeroCanal = ultimoDetalle + 1;

                this.lblNumeroCanal.Text = this.numeroCanal.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            switch (this.tipoPeso)
            {
                case 1:
                    guardarPeso();
                    break;

                case 2:
                    guardarPeso();
                    break;

                case 3:
                    guardarPesoCanastas();
                    break;
            }
        }

        public void guardarPeso()
        {
            try
            {
                this.command = new SqlCommand("SELECT ISNULL(MAX(idLoteDetalle), 0) AS idLoteDetalle FROM LotesDetalle", this.conexion);
                int ultimoId = Convert.ToInt32(this.command.ExecuteScalar());

                this.command = new SqlCommand("INSERT INTO LotesDetalle VALUES (" + (ultimoId + 1) + ", " +
                    this.idLote + ", " +
                    this.tipoPeso + ", " +
                    this.numeroCanal + ", " +
                    this.txtPeso.Text + ", " +
                    "null)", this.conexion);
                this.command.ExecuteNonQuery();

                if(this.tipoPeso == 1)
                {
                    VisorDeReportes visor = new VisorDeReportes(this.conexion);
                    visor.Pulsera(this.lote, this.numeroCanal);
                }


                limpiar();
                MessageBox.Show("Peso digitalizado");
                validarProduccion();
                this.bttGuardar.Focus();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void guardarPesoCanastas()
        {

        }

        private void limpiar()
        {
            this.lblLote.Text = "...";
            this.lblNumeroCanal.Text = "...";
            this.lblCanalizacion.Text = "...";
            this.txtPeso.Text = "";
        }

        
    }
}
