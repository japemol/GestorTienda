using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTienda
{
    public partial class EmpleadoNuevo : Form
    {
        public EmpleadoNuevo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string dni = textBox_DNI.Text.ToString();
                string nombre = textBox_nombre.Text.ToString();
                string apellido1 = textBox_apellido1.Text.ToString();
                string apellido2 = textBox_apellido2.Text.ToString();
                string correo = textBox_correo.Text.ToString();
                string usuario = textBox_usuario.Text.ToString();
                string password = textBox_password.Text.ToString();
                string password2 = textBox_password2.Text.ToString();
                string telefono = textBox_telefono.Text.ToString();                
                string cp = textBox_cp.Text.ToString();
                string direccion = textBox_direccion.Text.ToString();
                string privilegios = comboPrivilegios.Text.ToString();



            if (!(dni.Equals("") || nombre.Equals("") || apellido1.Equals("") || correo.Equals("") || usuario.Equals("") || password.Equals("") || password2.Equals("") || privilegios.Equals("") ))
            {

                if (password.Equals(password2))
                {

                
                    ControladorEmpleados controlador = new ControladorEmpleados();

                    controlador.NuevoEmpleado(dni,nombre,apellido1,apellido2,telefono,direccion,cp,usuario,password,correo,privilegios);
                }
                else
                {
                    MessageBox.Show("Los campos de contraseña han de ser identicos");
                }
            }
            else
            {
                    MessageBox.Show("Los campos marcados con un * son obligatorios");
            }


            


        }
    }
}
