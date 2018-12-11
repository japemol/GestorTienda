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

                EncryptAndDecrypt decrypt = new EncryptAndDecrypt();

                string pass = decrypt.Decrypt(passwd);

                if(pass == null)
                {
                    pass = "";
                }
                

                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database="+ nombreDB +"; Uid="+usuario+"; pwd="+pass+";");

                    conectar.Open();
                    return conectar;
                





            }catch(Exception e)
            {
                e.GetBaseException();
                MessageBox.Show("Imposible conectar con la base de datos \nCompruebe que el servidor que contiene la base de datos de MySql sea accesible, de lo contrario, contacte con un administrador.\nSi no sabe lo que esta haciendo no cambie la configuración simplemente cierre la ventana");

                Form conf = new Config_Form();
                conf.Show();
                
                return null;
            } 
        }

    }
}
