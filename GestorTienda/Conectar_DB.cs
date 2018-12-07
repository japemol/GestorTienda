using System;
using System.Windows.Forms;
using System.Xml;

using MySql.Data.MySqlClient;

namespace GestorTienda
{
    public class Conexion{

        public static MySqlConnection Conectar()
        {
           
            try
            {

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"ConfiguracionDB.xml");

                XmlNodeList nodo = xDoc.GetElementsByTagName("usuario");
                XmlNodeList nodo1 = xDoc.GetElementsByTagName("password");
                XmlNodeList nodo2 = xDoc.GetElementsByTagName("nombreDB");


                string usuario = nodo[0].InnerText;
                string passwd = nodo1[0].InnerText;
                string nombreDB = nodo2[0].InnerText;

               
                

                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database="+ nombreDB +"; Uid="+usuario+"; pwd="+passwd+";");

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
