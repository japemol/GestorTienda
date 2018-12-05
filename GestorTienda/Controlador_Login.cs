using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTienda
{
    class Controlador_Login
    {
        public bool Login(string usr, string pass)
        {
            bool entrar = false;
            if(!(usr.Equals("") || pass.Equals("")))
            {

           

            MySqlConnection conexion = Conexion.Conectar();

           
                MySqlCommand comando = conexion.CreateCommand();

                string sql = "Select usuario, password from empleados where usuario = @usuario" ;

                comando.CommandText =sql;

                comando.Parameters.AddWithValue("@usuario", usr);

                MySqlDataReader reader = comando.ExecuteReader();

                 if (reader.Read())
                 {
                string usuario = reader.GetString(0);
                string password = reader.GetString(1);
                



                if (usuario.Equals(usr)&&password.Equals(pass))
                    {
                        entrar = true;
                    }

               }
            }
            return entrar;
            
        }

        public string GetPrivilegios(string usuario)
        {
            string privilegios = "";

            MySqlConnection conexion = Conexion.Conectar();


            MySqlCommand comando = conexion.CreateCommand();

            string sql = "Select privilegios from empleados where usuario = @usuario";

            comando.CommandText = sql;

            comando.Parameters.AddWithValue("@usuario", usuario);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                privilegios = reader.GetString(0);
            }
            return privilegios;
        }
    }
}
