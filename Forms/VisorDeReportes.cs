using Microsoft.Reporting.WinForms;
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
    public partial class VisorDeReportes : Form
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataSet dataSet = new DataSet();
        DataTable dataTable = new DataTable();
        ReportDataSource reportDataSource;




        public VisorDeReportes()
        {
            InitializeComponent();
        }

        public VisorDeReportes(SqlConnection conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void VisorDeReportes_Load(object sender, EventArgs e)
        {

            
        }

        public void BoletasHistorico()
        {
            this.rvVisorReportes.LocalReport.DataSources.Clear();
            this.dataSet.Clear();
            this.dataTable.Clear();

            this.command = new SqlCommand("BoletasHistorico", this.conexion);
            this.command.CommandType = CommandType.StoredProcedure;

            this.dataAdapter = new SqlDataAdapter(this.command);
            this.dataAdapter.Fill(this.dataTable);

            this.dataTable.TableName = "Boletas";
            this.dataSet.Tables.Add(this.dataTable);

            this.reportDataSource = new ReportDataSource("Boletas", this.dataTable);
            this.rvVisorReportes.LocalReport.DataSources.Add(this.reportDataSource);

            this.rvVisorReportes.LocalReport.ReportEmbeddedResource = "FYRASA.Informes.BoletasHistorico.rdlc";

            this.rvVisorReportes.RefreshReport();
            this.ShowDialog();
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
    }
}
