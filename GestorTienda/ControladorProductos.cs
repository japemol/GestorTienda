using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTienda
{
    class ControladorProductos
    {
        public string[,] Select(int offset)
        {

            MySqlConnection conexion = Conexion.Conectar();
            try
            {


                MySqlCommand comando = conexion.CreateCommand();

                string query = "Select id_articulo, nombre_articulo, count(nombre_articulo) as stock, fecha_recepcion, precio, seccion From productos group by nombre_articulo order by nombre_articulo LIMIT 12 OFFSET @offset";

                comando.CommandText = query;
                comando.Parameters.AddWithValue("@offset", offset);

                MySqlDataReader reader = comando.ExecuteReader();

                string[,] registro = new string[12, 6];

                int i = 0;
                int x = 0;

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
                string[,] error = { };
                return error;
            }

        }



        public void NuevoProducto(string articulo, string seccion, int cantidad, DateTime fecha_recepcion,float precio)
        {

            MySqlConnection conexion = Conexion.Conectar();

            MySqlCommand comando = conexion.CreateCommand();

            string query =
           "INSERT INTO productos (nombre_articulo, seccion, fecha_recepcion, precio) Values (@articulo,@seccion,@fecha_recepcion,@precio)";


            try
            {
                comando.CommandText = query;

                comando.Parameters.AddWithValue("@articulo", articulo);
                comando.Parameters.AddWithValue("@seccion", seccion);
                comando.Parameters.AddWithValue("@fecha_recepcion", fecha_recepcion);
                comando.Parameters.AddWithValue("@precio", precio);

                while (!(cantidad == 0)) { comando.ExecuteNonQuery(); cantidad--; }
                

                conexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.GetBaseException().ToString());
                conexion.Close();
            }




        }

        public void DeleteByID(string nombre, int cantidad)
        {
            MySqlConnection conexion = Conexion.Conectar();

            MySqlCommand comando = conexion.CreateCommand();

            string query = "DELETE FROM productos where nombre_articulo=@nombre Limit @cantidad";

            try
            {
                comando.CommandText = query;

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@cantidad", cantidad);


                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.GetBaseException().ToString());
                conexion.Close();
            }
        }

        public string[,] GetByName(string name, int pagina)
        {
            MySqlConnection conexion = Conexion.Conectar();

            try
            {


                MySqlCommand comando = conexion.CreateCommand();

                string query = "Select id_articulo, nombre_articulo, count(nombre_articulo) as stock, fecha_recepcion, precio, seccion From productos  where nombre_articulo LIKE @name group by nombre_articulo order by nombre_articulo Limit 12 Offset " + pagina;

                comando.Parameters.AddWithValue("@name","%"+name +"%" );

                comando.CommandText = query;


                MySqlDataReader reader = comando.ExecuteReader();

                string[,] registro = new string[12,6];

                int i = 0; int x=0;
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
                
                return null;
            }
        }

    }
}
