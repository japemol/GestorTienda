using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GestorTienda
{
    public partial class Login : Form
    {



        public Login()
        {
            InitializeComponent();

            bool configuracion = ComprobarConfiguracion();

            if (!configuracion)
            {
                Form config = new Config_Form();
                config.Show();
            }
            else
            {
                Tablas();
            }
            
        }

        private bool ComprobarConfiguracion()
        {

            XmlDocument xDoc = new XmlDocument();


            try { xDoc.Load(@"ConfiguracionDB.xml"); } catch (Exception e) { e.GetBaseException(); return false; };


            
           
           
            XmlNodeList nodo = xDoc.GetElementsByTagName("usuario");
            XmlNodeList nodo1 = xDoc.GetElementsByTagName("password");
            XmlNodeList nodo2 = xDoc.GetElementsByTagName("nombreDB");


            string usuario = nodo[0].InnerText;
            string passwd = nodo1[0].InnerText;
            string nombreDB = nodo2[0].InnerText;

            if (usuario.Equals("") || nombreDB.Equals(""))
            {
                return false;


            }
            else
            {
                return true;
            }

        }

        private void Tablas()
        {
            ControladorPrincipal controlador = new ControladorPrincipal();
            bool tablas = controlador.ComprobarTablas();

            if (!tablas) controlador.CrearTablas();
        }


       
        private void Button1_Click(object sender, EventArgs e)
        {
            Controlador_Login logear= new Controlador_Login();

            string usuario = textBoxUser.Text.ToString();
            string password = textBoxPassword.Text.ToString();

          bool entrar = logear.Login(usuario, password);

            if (entrar)
            {

                string privilegios = logear.GetPrivilegios(usuario);
                Home home = new Home(privilegios);
               
                this.Hide();
                home.Show();
            
            }

        }

        private void Config_Click(object sender, EventArgs e)
        {

            Form config = new Config_Form();
            config.Show();

        }
    }
}
