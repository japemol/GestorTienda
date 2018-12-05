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

namespace GestorTienda
{
    public partial class Config_Form : Form
    {
        public Config_Form()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
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
            /*DB config = new DB();

            config.NombreDB = nombredb_text.ToString();
            config.Passwd = passwd_text.ToString();
            config.UsuarioDB = usuario_text.ToString();*/
        }
    }
}
