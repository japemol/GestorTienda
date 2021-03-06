﻿using MySql.Data.MySqlClient;
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
            try
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
                EncryptAndDecrypt decrypt = new EncryptAndDecrypt();

                 if (reader.Read())
                 {
                string usuario = reader.GetString(0);
                string password = reader.GetString(1);

                    password = decrypt.Decrypt(password);


                if (usuario.Equals(usr)&&password.Equals(pass))
                    {
                        entrar = true;
                    }

               }
            }
            return entrar;
            }catch(Exception e)
            {
                e.GetBaseException();
                MessageBox.Show("ERROR FATAL: \n Consulta con el administrador del sistema");

                return false;
            }

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
