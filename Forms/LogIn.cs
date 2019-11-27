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
    public partial class LogIn : Form
    {
        private Usuario usuario;
        private string rutaLocal;
        private SqlConnection conexion;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable = new DataTable();
        private DataRow dataRow;
        private string cifrado = "fgrg3tyr78juwu";
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.rutaLocal = Application.StartupPath;
            InnerDatabaseManager dbManager = new InnerDatabaseManager();
            this.conexion = dbManager.createConnectionFromIniFile(this.rutaLocal);

            try
            {
                this.conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BttSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BttEntrar_Click(object sender, EventArgs e)
        {
            string lUsuario = this.txtUsuario.Text;
            string lContraseña = this.txtContraseña.Text;

            string comando = "SELECT idUsuario, " +
                "Usuario, " +
                "CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('" + this.cifrado + "', Contraseña)) AS Contraseña, " +
                "Archivo, " +
                "Boletas, " +
                "Pesos, " +
                "Reportes, " +
                "OrdenesProduccion" +
                " FROM Usuarios" +
                " WHERE Usuario = '" + lUsuario + "'";

            this.command = new SqlCommand(comando, this.conexion);
            this.command.ExecuteNonQuery();
            this.dataAdapter = new SqlDataAdapter(this.command);
            this.dataTable.Clear();
            this.dataAdapter.Fill(this.dataTable);

            int registros = this.dataTable.Rows.Count;

            if(registros == 1)
            {
                this.dataRow = dataTable.Rows[0];
                if (lUsuario == this.dataRow["Usuario"].ToString() && lContraseña == this.dataRow["Contraseña"].ToString())
                {
                    this.usuario = new Usuario();
                    usuario.idUsuario = Convert.ToInt32(this.dataRow["idUsuario"]);
                    usuario.usuario = this.dataRow["Usuario"].ToString();
                    usuario.archivo = Convert.ToInt32(this.dataRow["Archivo"]);
                    usuario.boletas = Convert.ToInt32(this.dataRow["Boletas"]);
                    usuario.pesos = Convert.ToInt32(this.dataRow["Pesos"]);
                    usuario.reportes = Convert.ToInt32(this.dataRow["Reportes"]);
                    usuario.produccion = Convert.ToInt32(this.dataRow["OrdenesProduccion"]);

                    MenuPrincipal menuPrincipal = new MenuPrincipal(this.conexion, this.usuario);
                    menuPrincipal.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }
        }
    }
}
