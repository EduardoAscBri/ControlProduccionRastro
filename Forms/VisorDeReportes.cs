using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        DataRow dataRow;
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

        //Metodos por reporte
        public void Boleta(int idBoleta)
        {
            this.rvVisorReportes.LocalReport.DataSources.Clear();
            this.dataSet.Clear();
            this.dataTable.Clear();

            this.command = new SqlCommand("TraerBoleta", this.conexion);
            this.command.Parameters.AddWithValue("@idBoleta", idBoleta);
            this.command.CommandType = CommandType.StoredProcedure;

            this.dataAdapter = new SqlDataAdapter(this.command);
            this.dataAdapter.Fill(this.dataTable);

            this.dataTable.TableName = "TraerBoleta";
            this.dataSet.Tables.Add(this.dataTable);

            this.reportDataSource = new ReportDataSource("TraerBoleta", this.dataTable);
            this.rvVisorReportes.LocalReport.DataSources.Add(this.reportDataSource);

            this.rvVisorReportes.LocalReport.ReportEmbeddedResource = "FYRASA.Informes.Boleta.rdlc";

            this.rvVisorReportes.RefreshReport();
            this.ShowDialog();
        }

        public void Pulsera(string loteCanal, int numeroCanal)
        {
            
            string lString = loteCanal + ":::" + numeroCanal.ToString();
            string lRuta = Path.GetTempPath().ToString() + loteCanal + numeroCanal + "qrCode.bmp";

            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode lQrCode = encoder.Encode(lString);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);

            FileStream fileStream = new FileStream(lRuta, FileMode.Create);
            renderer.WriteToStream(lQrCode.Matrix, ImageFormat.Bmp, fileStream);
            fileStream.Close();

            Image imageQRCode = Image.FromFile(lRuta);

            //FIN

            this.rvVisorReportes.LocalReport.DataSources.Clear();
            this.dataSet.Clear();
            this.dataTable.Clear();

            this.dataTable = new DataTable("Pulsera");

            DataColumn colLote = new DataColumn();
            colLote.DataType = System.Type.GetType("System.String");
            colLote.ColumnName = "lote";

            DataColumn colNumeroCanal = new DataColumn();
            colNumeroCanal.DataType = System.Type.GetType("System.Int32");
            colNumeroCanal.ColumnName = "numeroCanal";

            DataColumn colQRCode = new DataColumn();
            colQRCode.DataType = System.Type.GetType("System.Byte[]");
            colQRCode.ColumnName = "qrCode";

            this.dataTable.Columns.Add(colLote);
            this.dataTable.Columns.Add(colNumeroCanal);
            this.dataTable.Columns.Add(colQRCode);

            this.dataRow = this.dataTable.NewRow();

            this.dataRow["lote"] = loteCanal;
            this.dataRow["numeroCanal"] = numeroCanal;
            this.dataRow["qrCode"] = GetBytes(imageQRCode);
            this.dataTable.Rows.Add(this.dataRow);
            this.dataSet.Tables.Add(this.dataTable);

            this.reportDataSource = new ReportDataSource("Pulsera", this.dataTable);
            this.rvVisorReportes.LocalReport.DataSources.Add(this.reportDataSource);

            this.rvVisorReportes.LocalReport.ReportEmbeddedResource = "FYRASA.Informes.Pulsera.rdlc";

            this.rvVisorReportes.RefreshReport();
            this.ShowDialog();


        }

        private byte[] GetBytes(Image imageInput)
        {
            MemoryStream memoryStream = new MemoryStream();
            imageInput.Save(memoryStream, ImageFormat.Bmp);

            return memoryStream.ToArray();
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

        public void OrdenesHistorico()
        {
            this.rvVisorReportes.LocalReport.DataSources.Clear();
            this.dataSet.Clear();
            this.dataTable.Clear();

            this.command = new SqlCommand("OrdenesHistorico", this.conexion);
            this.command.CommandType = CommandType.StoredProcedure;

            this.dataAdapter = new SqlDataAdapter(this.command);
            this.dataAdapter.Fill(this.dataTable);

            this.dataTable.TableName = "OrdenesHistorico";
            this.dataSet.Tables.Add(this.dataTable);

            this.reportDataSource = new ReportDataSource("OrdenesHistorico", this.dataTable);
            this.rvVisorReportes.LocalReport.DataSources.Add(this.reportDataSource);

            this.rvVisorReportes.LocalReport.ReportEmbeddedResource = "FYRASA.Informes.OrdenesHistorico.rdlc";

            this.rvVisorReportes.RefreshReport();
            this.ShowDialog();
        }
    }
}
