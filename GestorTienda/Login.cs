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

namespace GestorTienda
{
    public partial class Login : Form
    {



        public Login()
        {
            InitializeComponent();

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
