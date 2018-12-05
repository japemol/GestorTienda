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
    public partial class NuevaIncidencia : Form
    {
        string dni;
        public NuevaIncidencia(string dni)
        {
            InitializeComponent();

            this.dni = dni;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controlador_Empleado controlador = new Controlador_Empleado();

            DateTime fecha = DateTime.Today;

            string incidencia = text_incidencia.Text;

            if (!incidencia.Equals(""))
            {
                controlador.NuevaIncidencia(dni, fecha, incidencia);
            }

            this.Close();
        }
    }
}
