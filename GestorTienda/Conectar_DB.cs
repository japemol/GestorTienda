using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorTienda
{
    public class Conexion{

        public static MySqlConnection Conectar()
        {
           
            try
            {
               /* DB config = new DB();
                string database = config.NombreDB;
                string usuario =config.UsuarioDB;
                string passwd = config.Passwd;*/
           
           MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=gestordb; Uid=root; pwd=;");

            conectar.Open();
            return conectar;

            }catch(Exception e)
            {
                MessageBox.Show("Imposible conectar con la base de datos \n" + e.Message.ToString());
                Application.Exit();
                return null;
            } 
        }

    }
}
