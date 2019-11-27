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
    public partial class PesosCanastas : Pesos
    {


        public PesosCanastas()
        {
            InitializeComponent();
        }

        public PesosCanastas(SqlConnection conexion, int tipoPeso)
        {
            InitializeComponent();
            this.conexion = conexion;

            switch (tipoPeso)
            {
                case 1:
                    this.lblTitle.Text = "PesoCaliente";
                    this.tipoPeso = tipoPeso;
                    this.txtNumeroCanal.Visible = false;
                    break;

                case 2:
                    this.lblTitle.Text = "Peso frio";
                    this.tipoPeso = tipoPeso;
                    this.txtNumeroCanal.Visible = true;
                    break;

                case 3:
                    this.lblTitle.Text = "Peso en canastas";
                    this.tipoPeso = tipoPeso;
                    this.txtNumeroCanal.Visible = false;
                    this.label3.Visible = false;
                    this.lblNumeroCanal.Visible = false;

                    this.cmbCortes.Items.Insert(0, "1.- Pierna (D100)");
                    this.cmbCortes.Items.Insert(0, "2.- Brazo (B200)");
                    this.cmbCortes.Items.Insert(0, "3.- Costilla (C300)");
                    this.cmbCortes.Items.Insert(0, "4.- Lomo (D400)");
                    break;
            }

            validarProduccion();

        }

        private void PesosCanastas_Load(object sender, EventArgs e)
        {

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
                    this.nombreCorte = this.cmbCortes.Text;
                    guardarPesoCanastas();
                    break;
            }
        }

        public void guardarPesoCanastas()
        {
            try
            {
                if (this.tipoPeso == 3)
                {
                    this.numeroCanal = 0;
                }

                this.command = new SqlCommand("SELECT ISNULL(MAX(idLoteDetalle), 0) AS idLoteDetalle FROM LotesDetalle", this.conexion);
                int ultimoId = Convert.ToInt32(this.command.ExecuteScalar());

                this.command = new SqlCommand("INSERT INTO LotesDetalle VALUES (" + (ultimoId + 1) + ", " +
                    this.idLote + ", " +
                    this.tipoPeso + ", " +
                    this.numeroCanal + ", " +
                    this.txtPeso.Text + ", '" +
                    this.nombreCorte + "')", this.conexion);
                this.command.ExecuteNonQuery();

                if (this.tipoPeso == 3)
                {
                    VisorDeReportes visor = new VisorDeReportes(this.conexion);
                    visor.EtiquetaCanasta((ultimoId + 1));
                }


                limpiar();
                MessageBox.Show("Peso digitalizado");
                validarProduccion();
                this.bttGuardar.Focus();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
