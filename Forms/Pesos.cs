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

        public int idOrdenProduccion;
        public int status;
        public int idLote;
        public string lote;
        public string canalizacion;


        public Pesos()
        {
            InitializeComponent();
        }

        public Pesos(SqlConnection conexion, int tipoPeso)
        {
            InitializeComponent();
            this.conexion = conexion;
            validarProduccion();

            switch (tipoPeso)
            {
                case 1:
                    this.lblTitle.Text = "PesoCaliente";
                    pesoCaliente();
                    break;

                case 2:
                    this.lblTitle.Text = "Peso frio";
                    pesoFrio();
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


        public void pesoCaliente()
        {

        }

        public void pesoFrio()
        {

        }
    }
}
