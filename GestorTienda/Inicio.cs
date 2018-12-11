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
using System.Xml;

namespace GestorTienda
{
    public partial class Home : Form
    {

        string privilegios;
        Color color1;
        Color color2;
        string ruta;

        public Home(string privilegios)
        {

            ComprobarPersonalizacion();
            
            InitializeComponent();
            this.privilegios = privilegios;

            if(!(color1 == null || color2 == null || ruta.Equals("") || ruta.Equals(null)))
            {
                CambiarApariencia();
            }
            
        }

        private void CambiarApariencia()
        {
            panel1.BackColor = color1;
            panel2.BackColor = color1;
            panel3.BackColor = color1;
            panel4.BackColor = color1;
            
            textBox1.ForeColor = color2;
            textBox1.BackColor = color1;
            empleados.ForeColor = color2;
            empleados.BackColor = color1;

            pictureBox2.Image = Image.FromFile(ruta);
            

        }

        private void ComprobarPersonalizacion()
        {
            XmlDocument xDoc = new XmlDocument();


            try { xDoc.Load(@"personalizar.xml"); } catch (Exception e) { e.GetBaseException(); };





            XmlNodeList nodo = xDoc.GetElementsByTagName("logo");
            XmlNodeList nodo1 = xDoc.GetElementsByTagName("color1");
            XmlNodeList nodo2 = xDoc.GetElementsByTagName("color2");



            
            try
            {
                ruta = nodo[0].InnerText;
                color1 = Color.FromArgb(Int32.Parse(nodo1[0].InnerText));
                color2 = Color.FromArgb(Int32.Parse(nodo2[0].InnerText));

                
            }
            catch (Exception e)
            {
                color1 = Color.FromArgb((int)(byte)(64), (int)(byte)(64), (int)(byte)64);
                e.GetBaseException();
            }
                      
             

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
