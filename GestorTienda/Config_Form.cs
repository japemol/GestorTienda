using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Xml;
using System.IO;

namespace GestorTienda
{
    public partial class Config_Form : Form
    {
        public Config_Form()
        {
            InitializeComponent();
            
        }

        private void CrearTablas(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.Conectar();
            try
            {
                MySqlCommand comando = conexion.CreateCommand();

                string sql1 = "CREATE TABLE `empleados` (  `dni` varchar(20) NOT NULL,  `nombre` varchar(50) NOT NULL,  `apellido1` varchar(50) NOT NULL,  `apellido2` varchar(50) DEFAULT NULL,  `e - mail` varchar(50) NOT NULL,    `usuario` varchar(20) NOT NULL,    `password` varchar(50) NOT NULL,    `telefono` varchar(15) NOT NULL,    `cp` int(6) NOT NULL,    `direccion` varchar(50) DEFAULT NULL,    `privilegios` varchar(15) NOT NULL,    PRIMARY KEY(`dni`)) ENGINE = MyISAM DEFAULT CHARSET = latin1; ";
                string sql2 = "CREATE TABLE `incidencias` (  `id` int(50) NOT NULL AUTO_INCREMENT,  `dni_empleado` varchar(20) NOT NULL,  `fecha` date NOT NULL,  `incidencia` varchar(255) NOT NULL,  PRIMARY KEY(`id`)) ENGINE = MyISAM AUTO_INCREMENT = 7 DEFAULT CHARSET = latin1; ";
                string sql3 = "CREATE TABLE `productos` (  `id_articulo` int(50) NOT NULL AUTO_INCREMENT,  `nombre_articulo` varchar(50) NOT NULL,  `seccion` varchar(20) NOT NULL,  `fecha_recepcion` date DEFAULT NULL,  `precio` double DEFAULT NULL,  PRIMARY KEY(`id_articulo`)) ENGINE = MyISAM AUTO_INCREMENT = 223598 DEFAULT CHARSET = latin1; ";
                string sql4 = "CREATE TABLE `ventas` (  `id` int(50) NOT NULL AUTO_INCREMENT,  `dni_empleado` varchar(15) NOT NULL,  `precio` double(15, 2) NOT NULL,   `producto` varchar(25) NOT NULL,   `fecha` date NOT NULL,  PRIMARY KEY(`id`)) ENGINE = MyISAM AUTO_INCREMENT = 6 DEFAULT CHARSET = latin1; ";

                comando.CommandText = sql1 + sql2 + sql3 + sql4;

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EncryptAndDecrypt encrypt = new EncryptAndDecrypt();

            if (!File.Exists("key.key"))
            {
                encrypt.GenerarKey();
            }

            if (!(usuario_text.Text.Equals("") || nombredb_text.Equals("")))
            {

            
            XmlTextWriter escribir = new XmlTextWriter(@"ConfiguracionDB.xml", Encoding.UTF8);
            escribir.Formatting = Formatting.Indented;
            escribir.WriteStartDocument();
//Abrir etiqueta raiz: configuracion
            escribir.WriteStartElement("configuracion");

//Abrir etiqueta: usuario
            escribir.WriteStartElement("usuario");
            escribir.WriteString(usuario_text.Text);
            escribir.WriteEndElement(); //Cierra etiqueta

            //Abrir etiqueta:password
            
            string pass = encrypt.Encrypt(passwd_text.Text);
            escribir.WriteStartElement("password");
            escribir.WriteString(pass);
            escribir.WriteEndElement(); //Cierra etiqueta

//Abrir etiqueta: nombreDB
            escribir.WriteStartElement("nombreDB");
            escribir.WriteString(nombredb_text.Text);
            escribir.WriteEndElement(); //Cierra etiqueta

            escribir.WriteEndElement();//Cierra etiqueta raiz configuracion

            escribir.Close(); //Cerrar conexion con archivo

            Form admin = new ConfirmacionAdmin();
            admin.Show();


            this.Close();

            Tablas();
            }
            else
            {
                MessageBox.Show("Los campos Usuario y Nombre DB no pueden estar vacios");
            }

        }

        private void Tablas()
        {
            ControladorPrincipal controlador = new ControladorPrincipal();
            bool tablas = controlador.ComprobarTablas();

            if (!tablas) controlador.CrearTablas();
        }


        private void admin_Click(object sender, EventArgs e)
        {
            Form empleado = new EmpleadoNuevo();
            empleado.Show();
        }
    }
}
