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

//Nombre de espacio donde se encuentran los Forms del proyecto
namespace FYRASA.Forms
{
    //Declaracion de la clase del Form ControlUsuarios
    public partial class ControlUsuarios : Form
    {
        //Declaracion de variables globales privadas que requiere el form
        //Bandera que indica si es o no un usuario nuevo
        private bool nuevo = false;
        //Propiedad que contiene la conexion a la base de datos
        private SqlConnection conexion;
        //Propiedad que contiene los comandos utilizados
        private SqlCommand command;
        //Propiedad que adapta la informacion consultada en la base de datos
        private SqlDataAdapter dataAdapter;
        //Propiedad que permite trabajar la informacion consultada en forma de tabla
        private DataTable dataTable = new DataTable();
        //Propiedad que permite trabajar la informacion consultada en forma de registro o fila
        private DataRow dataRow;
        //Propiedad que almacena la fila actual usada en el el combo box de usuarios
        private int currentRow;
        //Propiedad que contiene el idUsuario de la tabla de usuarios
        private int idUsuario;
        //Prpiedad que define la cadena usada para la encriptacion de las contraseñas de usuario
        private string cifrado = "fgrg3tyr78juwu";

        //Constructor del objeto
        public ControlUsuarios()
        {
            InitializeComponent();
        }

        //Constructor sobrecargado del objeto, recibe una conexion esterna proveniente del menu principal
        public ControlUsuarios(SqlConnection conexion)
        {
            InitializeComponent();                  //Inicializa los componentes del form
            this.conexion = conexion;               //Asiga la conexion externa como propiedad del form
            this.txtGuardar.Enabled = false;
        }

        //Evento de carga del form
        private void ControlUsuarios_Load(object sender, EventArgs e)
        {
            actualizarUsuarios();                   //Metodo que actualiza los usuarios de la base de datos y los carga
                                                    //al combo box de usuarios
        }

        //Evento de clic al boton cerrar
        private void BttCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;                   //Oculta el form
        }

        //Evento de clic al boton nuevo
        private void TxtNuevo_Click(object sender, EventArgs e)
        {
            limpiarVista();                         //Metodo que limpia la vista del form (limpia los controles de texto y check)
            this.txtGuardar.Enabled = true;         //Define el boton de guardar como habilitado
            this.txtUsuario.Focus();                //Envia el foco del formulario hacia el texto del nombre de usuario
        }

        //Evento de seleccion del combo box de usuarios
        private void CmbUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Optiene el id del usuario seleccionado
            idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
            //Optiene el index del usuario seleccionado en el combo box
            currentRow = cmbUsuarios.SelectedIndex;
            //Optiene los datos de la fila seleccionada como un objeto de datos de fila
            dataRow = dataTable.Rows[currentRow];

            //Asigna el valor del usuario seleccionado al texbox del nombre de usuario
            this.txtUsuario.Text = dataRow["Usuario"].ToString();
            //Asigna el valor oculto de contraseña al texbox de contraseña de usuario
            this.txtContraseña.Text = dataRow["Contraseña"].ToString();
            //Verifica si hay que checkear los checks del form segun los datos del usuario : Menu Archivo
            this.chkArchivo.Checked = Convert.ToInt32(dataRow["Archivo"]) == 1 ? true : false;
            //Verifica si hay que checkear los checks del form segun los datos del usuario : Menu Boletas
            this.chkBoletas.Checked = Convert.ToInt32(dataRow["Boletas"]) == 1 ? true : false;
            //Verifica si hay que checkear los checks del form segun los datos del usuario : Menu Pesos
            this.chkPesos.Checked = Convert.ToInt32(dataRow["Pesos"]) == 1 ? true : false;
            //Verifica si hay que checkear los checks del form segun los datos del usuario : Menu Reportes
            this.chkReportes.Checked = Convert.ToInt32(dataRow["Reportes"]) == 1 ? true : false;
            //Verifica si hay que checkear los checks del form segun los datos del usuario : Menu Ordenes de Produccion
            this.chkOrdenesProduccion.Checked = Convert.ToInt32(dataRow["OrdenesProduccion"]) == 1 ? true : false;
            //Define como falso la propiedad que indica si es un usuario nuevo o no
            this.nuevo = false;
            this.txtGuardar.Enabled = true;
        }

        //Evento clic del boton salir
        private void BttSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();                             //Cierra el formulario de forma definitiva
        }

        //Evento clic al boton guardar
        private void TxtGuardar_Click(object sender, EventArgs e)
        {
            //Define y asigna una variable local para trabajar el nombre del usuario
            string lUsuario = this.txtUsuario.Text;
            //Define y asigna una variable local para trabajar la contraseña del usuario
            string lContraseña = this.txtContraseña.Text;
            //Se define y asigna una variable local para trabajar el check del menu archivo
            int lArchivo = this.chkArchivo.Checked ? 1 : 0;
            //Se define y asigna una variable local para trabajar el check del menu boletas
            int lBoletas = this.chkBoletas.Checked ? 1 : 0;
            //Se define y asigna una variable local para trabajar el check del menu pesos
            int lPesos = this.chkPesos.Checked ? 1 : 0;
            //Se define y asigna una variable local para trabajar el check del menu reportes
            int lReportes = this.chkReportes.Checked ? 1 : 0;
            //Se define y asigna una variable local para trabajar el check de l menu ordenes de produccion
            int lOrdenesProduccion = this.chkOrdenesProduccion.Checked ? 1 : 0;

            //Valida si es o no un usuario nuevo
            if (this.nuevo == true)
            {
                //Si el usuario es un usuario nuevo...
                //Crea el comando que consulta por el id del ultimo usuario en la tabla de usuarios 
                command = new SqlCommand("SELECT MAX(idUsuario) AS idUsuario FROM Usuarios", this.conexion);
                //Define que es un comando que proviene de un texto
                command.CommandType = CommandType.Text;
                //Crea un lector de datos que contiene el resultado de la consulta
                SqlDataReader dataReader = command.ExecuteReader();                 //Ejecuta la consulta a base de datos
                dataReader.Read();                                                  //Lee el resultado de la consulta
                //Define y asigna una variable local que contiene el ultimo id de la tabla de usuarios
                int MAXidUsuario = Convert.ToInt32(dataReader[0]);
                dataReader.Close();                                                 //Cierra la consulta de datos

                //Crea el comando de insercion a la base de datos
                command = new SqlCommand("INSERT INTO Usuarios VALUES (" + (MAXidUsuario+1) + ",'" + lUsuario + "', " +
                    "ENCRYPTBYPASSPHRASE('" + cifrado + "', '" + lContraseña + "')," + lArchivo + "," + lBoletas + "," + 
                    lPesos + "," + lReportes + ", " + lOrdenesProduccion + ")", this.conexion);

                command.ExecuteNonQuery();                                          //Ejecuta el comando de insercion de nuevo usuario

                MessageBox.Show("El usuario ha sido guardado");                     //Envia un mensaje en pantalla
            }
            else
            {
                //Si es un usuario a editar
                //Crea el comando para actualizar la informacion en base de datos
                command = new SqlCommand("UPDATE Usuarios SET Usuario = '" + lUsuario + "', " +
                    "Contraseña = ENCRYPTBYPASSPHRASE('" + cifrado + "', '" + lContraseña + "'), " +
                    "Archivo = "+lArchivo+", " +
                    "Boletas = "+lBoletas+", " +
                    "Pesos = "+lPesos+", " +
                    "Reportes = "+lReportes+" , " +
                    "OrdenesProduccion = " + lOrdenesProduccion + " " +
                    "WHERE idUsuario = " + this.idUsuario, this.conexion);

                command.ExecuteNonQuery();                              //Ejecuta el comando de actualización
                MessageBox.Show("El usuario ha sido actualizado");      //Envia un mensaje a pantalla
            }

            actualizarUsuarios();                           //Ejecuta el metodo que actualizaa los usuarios en el form
            limpiarVista();                                 //Limpia la vista del form
            
        }

        //Metodo que actualiza los usuarios que hay en el combo box del form
        private void actualizarUsuarios()
        {
            dataTable.Clear();                  //Se invoca el metodo de limpieza del form
            //Se crea el comando que consulta por los usuarios en base de datos
            command = new SqlCommand("SELECT idUsuario, " +
                "Usuario, " +
                "CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('" + this.cifrado + "', Contraseña)) AS Contraseña, " +
                "Archivo, " +
                "Boletas, " +
                "Pesos, " +
                "Reportes, " +
                "OrdenesProduccion " +
                "FROM Usuarios ORDER BY idUsuario ASC", this.conexion);
            //Se asigna el resultado de la consulta a el adaptador de datos
            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);                    //El adaptador rellena en formato de tabla la informacion

            //Asigna el valor que se muestra en el combo desde el campo Usuarios
            cmbUsuarios.DisplayMember = "Usuario";
            //Asiga el valor que devuelve el combo desde el campo idUsuario
            cmbUsuarios.ValueMember = "idUsuario";
            //Define la fuente de datos desde el objeto dataTable que contiene la informacion consultada
            cmbUsuarios.DataSource = dataTable;
        }


        //Metodo que limpia los controles del form
        private void limpiarVista()
        {
            //Limpia el cuadro de texto Usuario
            this.txtUsuario.Text = "";
            //Limpia el cuadro de texto Contraseña
            this.txtContraseña.Text = "";
            //Define el check Archivo sin seleccionar
            this.chkArchivo.Checked = false;
            //Define el check boletas sin seleccionar
            this.chkBoletas.Checked = false;
            //Define el check pesos sin seleccionar
            this.chkPesos.Checked = false;
            //Define el check reportes sin seleccionar
            this.chkReportes.Checked = false;
            //Define el check Ordenes de Produccion sin seleccionar
            this.chkOrdenesProduccion.Checked = false;

            //Define que será un usuario nuevo
            this.nuevo = true;
        }

        //Evento de click en el boton para maximisar la ventana
        private void Button1_Click(object sender, EventArgs e)
        {
            
            if(this.WindowState == FormWindowState.Maximized)           //Valida si el estado actual de la ventana está maximisado
            {
                this.WindowState = FormWindowState.Normal;              //De estarlo define el estado en su forma normal
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;           //De no estarlo define su estado en su forma maximizada
            }

            
        }

        //Evento de clic en el boton para minizar la ventan
        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;               //Define el estado de la ventana como minimizado
        }

        private void TxtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            string lString = this.txtUsuario.Text;
            if (lString == "")
            {

                this.txtGuardar.Enabled = false;

                /*this.txtUsuario.Enabled = false;
                this.txtContraseña.Enabled = false;
                this.txtNuevo.Enabled = false;
                this.txtGuardar.Enabled = false;
                */
            }
            else if(lString.Length >= 15 || lString.Length <= 5)
            {
                MessageBox.Show("El usuario no debe ser mayor a 15 caracteres, o menor a 5 caracteres, ingrese nuevamente el usuario");
                this.txtUsuario.Text = "";
                this.txtUsuario.Focus();
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            string lString = this.txtContraseña.Text;
            if (lString == "")
            {

                this.txtGuardar.Enabled = false;

                /*this.txtUsuario.Enabled = false;
                this.txtContraseña.Enabled = false;
                this.txtNuevo.Enabled = false;
                this.txtGuardar.Enabled = false;
                */

            }
            else if(lString.Length >= 15 || lString.Length <= 5)
            {
                MessageBox.Show("La contraseña debe ser entre 5 y 15 caracteres, ingrese nuevamente la contraseña");
                this.txtUsuario.Text = "";
                this.txtUsuario.Focus();
            }
        }
    }
}
