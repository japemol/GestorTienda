using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GestorTienda
{
    public partial class Personalizar : Form
    {
        public Personalizar()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();

            this.Close();           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog carpeta = new OpenFileDialog();

            if (carpeta.ShowDialog() == DialogResult.OK)
            {
                ruta.Text = carpeta.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color1 = new ColorDialog();

            if(color1.ShowDialog() == DialogResult.OK)
            {
                colorText.Text = Convert.ToString(color1.Color.ToArgb());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog color2 = new ColorDialog();

            if (color2.ShowDialog() == DialogResult.OK)
            {
                color2Text.Text = Convert.ToString(color2.Color.ToArgb());
            }
        }

        private void GuardarConfiguracion()
        {

            XmlTextWriter escribir = new XmlTextWriter(@"personalizar.xml", Encoding.UTF8);
            escribir.Formatting = Formatting.Indented;
            escribir.WriteStartDocument();
            //Abrir etiqueta raiz: configuracion
            escribir.WriteStartElement("configuracion");

            //Abrir etiqueta: usuario
            escribir.WriteStartElement("logo");
            escribir.WriteString(ruta.Text);
            escribir.WriteEndElement(); //Cierra etiqueta

            //Abrir etiqueta:password

            
            escribir.WriteStartElement("color1");
            escribir.WriteString(colorText.Text);
            escribir.WriteEndElement(); //Cierra etiqueta

            //Abrir etiqueta: nombreDB
            escribir.WriteStartElement("color2");
            escribir.WriteString(color2Text.Text);
            escribir.WriteEndElement(); //Cierra etiqueta

            escribir.WriteEndElement();//Cierra etiqueta raiz configuracion

            escribir.Close(); //Cerrar conexion con archivo
        }

       
    }
}
