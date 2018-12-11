using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorTienda
{
    class Controlador_Empleado
    {

        public string[] DatosEmpleado(string dni)
        {
            string[] datos = new string[9];

            MySqlConnection conexion =Conexion.Conectar();
            
            MySqlCommand comando = conexion.CreateCommand();

            string sql = "Select dni, nombre, apellido1, apellido2, `e - mail`, usuario, telefono, cp, direccion  from empleados where dni = @dni";
            comando.CommandText= sql;
            comando.Parameters.AddWithValue("@dni", dni);

            MySqlDataReader reader = comando.ExecuteReader();

            
            while (reader.Read())
            {
                datos[0] = reader.GetString(0);
                datos[1] = reader.GetString(1);
                datos[2] = reader.GetString(2);
                try { datos[3] = reader.GetString(3); } catch (Exception e) { e.GetBaseException(); datos[3] = ""; }
                datos[4] = reader.GetString(4);
                datos[5] = reader.GetString(5);
                datos[6] = reader.GetString(6);
                try { datos[7] = reader.GetString(7); } catch (Exception e) { e.GetBaseException(); datos[7] = ""; }
                datos[8] = reader.GetString(8);
                
            }

            return datos;
        }

        public void NuevaIncidencia(string dni, DateTime fecha, string incidencia)
        {
           
            MySqlConnection conexion = Conexion.Conectar();

            MySqlCommand comando = conexion.CreateCommand();

            string sql = "INSERT INTO incidencias (dni_empleado, fecha, incidencia) VALUES (@dni, @fecha,@incidencia)";
            comando.CommandText = sql;
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@incidencia", incidencia);

            comando.ExecuteNonQuery();
        }

        public string[] VerIncidencias(string dni,int pagina)
        {
            string[] incidencia = new string[2];

            MySqlConnection conexion = Conexion.Conectar();

            MySqlCommand comando = conexion.CreateCommand();

            string sql = "Select fecha , incidencia from incidencias where dni_empleado = @dni Limit 1 offset @pagina";
            comando.CommandText = sql;
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@pagina", pagina);

            MySqlDataReader reader = comando.ExecuteReader();


            if (reader.Read())
            {
                incidencia[0] = reader.GetString(0);
                incidencia[1] = reader.GetString(1);
            }

                return incidencia;
        }

       

    }
}
