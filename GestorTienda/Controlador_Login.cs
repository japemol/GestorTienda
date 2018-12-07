using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

                    password = Decrypt(password);


                if (usuario.Equals(usr)&&password.Equals(pass))
                    {
                        entrar = true;
                    }

               }
            }
            return entrar;
            
        }

        readonly string key = " gc % 3ñXap{g9KgDntSN@3";

        private string Decrypt( string password)
        {

            byte[] passByte = Convert.FromBase64String(password);
            byte[] keyByte;

                 MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

                keyByte = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                md5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyByte;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform transform = tdes.CreateDecryptor();

            byte[] passDecrypt = transform.TransformFinalBlock(passByte, 0, passByte.Length);

            tdes.Clear();

            password = UTF8Encoding.UTF8.GetString(passDecrypt, 0, passDecrypt.Length);

            return password;
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
