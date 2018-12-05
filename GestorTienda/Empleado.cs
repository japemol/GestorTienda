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
    public partial class Empleado : Form
    {
        int __pagina;
        string __dni;

        public Empleado(string dni)
        {
            InitializeComponent();
            this.__dni = dni;
            Actualizar(__dni);
        }

        private void Actualizar(string _dni)
        {

            Controlador_Empleado controlador = new Controlador_Empleado();
            string[] datos;
            datos = controlador.DatosEmpleado(_dni);

            dni.Text = datos[0];
            nombre.Text = datos[1];
            apellido1.Text = datos[2];
            apellido2.Text = datos[3];
            correo.Text = datos[4];
            usuario.Text = datos[5];
            telefono.Text = datos[6];
            cp.Text = datos[7];
            direccion.Text = datos[8];

            string[] incidencia = controlador.VerIncidencias(_dni, __pagina);

            text_fecha.Text = incidencia[0];
            text_incidencia.Text = incidencia[1];


            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string dniEmpleado = dni.Text.ToString();

            Form ver = new NuevaIncidencia(dniEmpleado);

            ver.Show();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            if(__pagina != 0)
            {
                __pagina--;
                Actualizar(__dni);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            __pagina++;
            Actualizar(__dni);
        }
    }
}
