using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTienda
{
   public class ControladorEmpleados{

        public void NuevoEmpleado(string dni, string nombre, string apellido1, string apellido2, string telefono, string direccion,string cp, string usuario, string password,string correo, string privilegios)
        {

           MySqlConnection conexion = Conexion.Conectar();

            MySqlCommand comando = conexion.CreateCommand();

            string query =
           "INSERT INTO empleados (dni, nombre, apellido1, apellido2,`e-mail`,usuario,password,telefono,cp,direccion,privilegios) Values (@dni,@nombre,@apellido1,@apellido2,@correo,@usuario,@password,@telefono,@cp,@direccion, @privilegios)";
            

            try
            {
                comando.CommandText = query;

                comando.Parameters.AddWithValue("@dni" , dni);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido1", apellido1);
                comando.Parameters.AddWithValue("@apellido2", apellido2);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@cp", cp);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@password",password);
                comando.Parameters.AddWithValue("@privilegios", privilegios);

                comando.ExecuteNonQuery();

                conexion.Close();

            }catch(Exception e)
            {
                MessageBox.Show(e.GetBaseException().ToString());
                conexion.Close();
            }               

            
            
           
        }

        

        public string[,] Select(int offset)
        {

            MySqlConnection conexion = Conexion.Conectar();
            try
            {
                

                MySqlCommand comando = conexion.CreateCommand();

                string query = "Select dni, nombre, apellido1, apellido2,usuario, telefono From empleados LIMIT 12 OFFSET @offset";

                comando.CommandText = query;
                comando.Parameters.AddWithValue("@offset" , offset);
                
                MySqlDataReader reader = comando.ExecuteReader();

                string[,] registro = new string[12,6];

                int i = 0;
                int x = 0;
                
                while (reader.Read())
                {
                   
                    registro[i,x] = reader.GetString(0);
                    x++;
                    registro[i,x] = reader.GetString(1);
                    x++;
                    registro[i,x] = reader.GetString(2);
                    x++;
                    registro[i,x] = reader.GetString(3);
                    x++;
                    registro[i,x] = reader.GetString(4);
                    x++;
                    registro[i,x] = reader.GetString(5);
                    
                    x = 0;


                    i++;

                }
                i = 0;
                conexion.Close();
                return registro;
                



            }
            catch(Exception e)
            {
                MessageBox.Show(e.GetBaseException().ToString());
                conexion.Close();
                string[,] error = { };
                return error;
            }
            
        }

        public string[,] GetByDNI(string dni)
        {
            MySqlConnection conexion = Conexion.Conectar();

            try
            {
                

                MySqlCommand comando = conexion.CreateCommand();

                string query = "Select dni, nombre, apellido1, apellido2,usuario, telefono From empleados where dni = @dni";

                comando.Parameters.AddWithValue("@dni", dni);

                comando.CommandText = query;
                

                MySqlDataReader reader = comando.ExecuteReader();

                string[,] registro = new string[12,6];

                int i = 0; int x = 0;

                while (reader.Read())
                {

                    registro[i, x] = reader.GetString(0);
                    x++;
                    registro[i, x] = reader.GetString(1);
                    x++;
                    registro[i, x] = reader.GetString(2);
                    x++;
                    registro[i, x] = reader.GetString(3);
                    x++;
                    registro[i, x] = reader.GetString(4);
                    x++;
                    registro[i, x] = reader.GetString(5);
                    x = 0;


                    i++;

                }
                conexion.Close();
                return registro;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.GetBaseException().ToString());
                conexion.Close();
                string[,] registro= { };
                return registro;
            }
        }

       

        public void DeleteByDNI(string dni)
        {
            if (!dni.Equals("")) { 
                    MySqlConnection conexion = Conexion.Conectar();

                    MySqlCommand comando = conexion.CreateCommand();

                    string query = "DELETE FROM clientes where dni=@dni";

                    try
                    {
                        comando.CommandText = query;

                        comando.Parameters.AddWithValue("@dni", dni);


                        comando.ExecuteNonQuery();

                        conexion.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.GetBaseException().ToString());
                        conexion.Close();
                    }
            }
        }
    }
}
