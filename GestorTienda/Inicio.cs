using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace GestorTienda
{
    public partial class Home : Form
    {

        string privilegios;

        public Home(string privilegios)
        {
            InitializeComponent();
            this.privilegios = privilegios;
            
        }

      

       
       
        private void AbrirFormulario(object formNuevo)
        {
           if(this.panel_contenedor.Controls.Count > 0)
            {
                 this.panel_contenedor.Controls.RemoveAt(0);
            }
            Form form = formNuevo as Form;

                form.TopLevel = false;

                form.Dock = DockStyle.Fill;

                this.panel_contenedor.Controls.Add(form);
                this.panel_contenedor.Tag = form;

                form.Show();
           
        }
       

     

                     

       
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {  
            Application.Exit();
        }

       
      

        private void panel3_Click(object sender, EventArgs e)
        {
            if (privilegios.Equals("gerente")) { AbrirFormulario(new Empleados()); }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (privilegios.Equals("gerente") || privilegios.Equals("vendedor")) { AbrirFormulario(new Productos()); }
        }
    }
}
