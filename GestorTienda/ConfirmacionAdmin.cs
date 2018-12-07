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
    public partial class ConfirmacionAdmin : Form
    {
        public ConfirmacionAdmin()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Form empleado = new EmpleadoNuevo();
            empleado.Show();

            this.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
