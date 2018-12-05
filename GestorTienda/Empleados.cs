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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();

            VerEmpleados(pagina);
        }

        private void VerEmpleados(int offset)
        {
            ControladorEmpleados controlador = new ControladorEmpleados();

            string[,] registro;
            registro = controlador.Select(offset);
            CambiarValores(registro);

           }

        private void CambiarValores(string[,] registro)
        {
            c1_dni.Text = registro[0, 0]; c1_nombre.Text = registro[0, 1]; c1_apellido1.Text = registro[0, 2]; c1_apellido2.Text = registro[0, 3]; c1_telefono.Text = registro[0, 4]; c1_direccion.Text = registro[0, 5];
            c2_dni.Text = registro[1, 0]; c2_nombre.Text = registro[1, 1]; c2_apellido1.Text = registro[1, 2]; c2_apellido2.Text = registro[1, 3]; c2_telefono.Text = registro[1, 4]; c2_direccion.Text = registro[1, 5];
            c3_dni.Text = registro[2, 0]; c3_nombre.Text = registro[2, 1]; c3_apellido1.Text = registro[2, 2]; c3_apellido2.Text = registro[2, 3]; c3_telefono.Text = registro[2, 4]; c3_direccion.Text = registro[2, 5];
            c4_dni.Text = registro[3, 0]; c4_nombre.Text = registro[3, 1]; c4_apellido1.Text = registro[3, 2]; c4_apellido2.Text = registro[3, 3]; c4_telefono.Text = registro[3, 4]; c4_direccion.Text = registro[3, 5];
            c5_dni.Text = registro[4, 0]; c5_nombre.Text = registro[4, 1]; c5_apellido1.Text = registro[4, 2]; c5_apellido2.Text = registro[4, 3]; c5_telefono.Text = registro[4, 4]; c5_direccion.Text = registro[4, 5];
            c6_dni.Text = registro[5, 0]; c6_nombre.Text = registro[5, 1]; c6_apellido1.Text = registro[5, 2]; c6_apellido2.Text = registro[5, 3]; c6_telefono.Text = registro[5, 4]; c6_direccion.Text = registro[5, 5];
            c7_dni.Text = registro[6, 0]; c7_nombre.Text = registro[6, 1]; c7_apellido1.Text = registro[6, 2]; c7_apellido2.Text = registro[6, 3]; c7_telefono.Text = registro[6, 4]; c7_direccion.Text = registro[6, 5];
            c8_dni.Text = registro[7, 0]; c8_nombre.Text = registro[7, 1]; c8_apellido1.Text = registro[7, 2]; c8_apellido2.Text = registro[7, 3]; c8_telefono.Text = registro[7, 4]; c8_direccion.Text = registro[7, 5];
            c9_dni.Text = registro[8, 0]; c9_nombre.Text = registro[8, 1]; c9_apellido1.Text = registro[8, 2]; c9_apellido2.Text = registro[8, 3]; c9_telefono.Text = registro[8, 4]; c9_direccion.Text = registro[8, 5];
            c10_dni.Text = registro[9, 0]; c10_nombre.Text = registro[9, 1]; c10_apellido1.Text = registro[9, 2]; c10_apellido2.Text = registro[9, 3]; c10_telefono.Text = registro[9, 4]; c10_direccion.Text = registro[9, 4];
            c11_dni.Text = registro[10, 0]; c11_nombre.Text = registro[10, 1]; c11_apellido1.Text = registro[10, 2]; c11_apellido2.Text = registro[10, 3]; c11_telefono.Text = registro[10, 4]; c11_direccion.Text = registro[10, 4];
            c12_dni.Text = registro[11, 0]; c12_nombre.Text = registro[11, 1]; c12_apellido1.Text = registro[11, 2]; c12_apellido2.Text = registro[11, 3]; c12_telefono.Text = registro[11, 4]; c12_direccion.Text = registro[10, 4];
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorEmpleados controlador = new ControladorEmpleados();

            string[,] registro;
            if (!search_DNI.Text.ToString().Equals(""))
            {

            
           registro = controlador.GetByDNI(search_DNI.Text.ToString());

                CambiarValores(registro);
            
            }
            else
            {
                VerEmpleados(pagina);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

           if(checkBox0.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();
               

                string[] dni = c1_dni.Text.ToString().Split('\t');
                controlador.DeleteByDNI(dni[0]);
                checkBox0.Checked = false;
            }
            if (checkBox1.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                string dni = c2_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox1.Checked = false;

            }
            if (checkBox2.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                string dni = c3_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox2.Checked = false;

            }
            if (checkBox3.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                 string dni = c4_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox3.Checked = false;

            }
            if (checkBox4.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                 string dni = c5_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox4.Checked = false;

            }
            if (checkBox5.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                 string dni = c6_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox5.Checked = false;

            }
            if (checkBox6.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                 string dni = c7_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox6.Checked = false;

            }
            if (checkBox7.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                 string dni = c8_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox7.Checked = false;

            }
            if (checkBox8.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                 string dni = c9_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox8.Checked = false;

            }
            if (checkBox9.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                 string dni = c10_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox9.Checked = false;

            }
            if (checkBox10.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                 string dni = c11_dni.Text.ToString();
                controlador.DeleteByDNI(dni);
                checkBox10.Checked = false;

            }
            if (checkBox11.Checked)
            {
                ControladorEmpleados controlador = new ControladorEmpleados();


                 string dni = c12_dni.Text.ToString();
                controlador.DeleteByDNI(dni);

                checkBox11.Checked = false;

            }


            VerEmpleados(pagina);

        }

       int pagina = 0;

        private void nextpage_Click(object sender, EventArgs e)
        {
            
            pagina += 12;
            VerEmpleados(pagina);

        }

        private void backpage_Click(object sender, EventArgs e)
        {
            if(pagina>0)
            pagina -= 12;

            VerEmpleados(pagina);
        }

        private void ver1_Click(object sender, EventArgs e)
        {
            string dni = c1_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }

        }

        private void ver2_Click(object sender, EventArgs e)
        {
            
            string dni = c2_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
           
        }

        private void empleado_nuevo_Click(object sender, EventArgs e)
        {
            Form ver = new EmpleadoNuevo();
            ver.Show();
        }

        private void ver3_Click(object sender, EventArgs e)
        {
            string dni = c3_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }

        private void ver4_Click(object sender, EventArgs e)
        {
            string dni = c4_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }

        private void ver5_Click(object sender, EventArgs e)
        {
            string dni = c5_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }

        private void ver6_Click(object sender, EventArgs e)
        {
            string dni = c6_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }

        private void ver7_Click(object sender, EventArgs e)
        {
            string dni = c7_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }

        private void ver8_Click(object sender, EventArgs e)
        {
            string dni = c8_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }

        private void ver9_Click(object sender, EventArgs e)
        {
            string dni = c9_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }

        private void ver10_Click(object sender, EventArgs e)
        {
            string dni = c10_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }

        private void ver11_Click(object sender, EventArgs e)
        {
            string dni = c11_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }

        private void ver12_Click(object sender, EventArgs e)
        {
            string dni = c12_dni.Text.ToString();
            if (!dni.Equals(""))
            {
                Form ver = new Empleado(dni);
                ver.Show();
            }
        }
    }
}
