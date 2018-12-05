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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            VerProductos(pagina);
        }

        int pagina = 0;
        private void InitializeComponent()
        {
            this.apellido2_label = new System.Windows.Forms.Label();
            this.apellido1_label = new System.Windows.Forms.Label();
            this.nombre_label = new System.Windows.Forms.Label();
            this.textBoxArt = new System.Windows.Forms.TextBox();
            this.registrar_producto = new System.Windows.Forms.Button();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.backpage = new System.Windows.Forms.Button();
            this.nextpage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSeccion = new System.Windows.Forms.MaskedTextBox();
            this.textBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPrecio = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search_Name = new System.Windows.Forms.TextBox();
            this.p1_precio = new System.Windows.Forms.TextBox();
            this.p1_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p1_stock = new System.Windows.Forms.MaskedTextBox();
            this.p1_nombre = new System.Windows.Forms.TextBox();
            this.p1_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.p2_id = new System.Windows.Forms.TextBox();
            this.p2_precio = new System.Windows.Forms.MaskedTextBox();
            this.p2_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p2_stock = new System.Windows.Forms.MaskedTextBox();
            this.p2_nombre = new System.Windows.Forms.TextBox();
            this.p3_id = new System.Windows.Forms.TextBox();
            this.p3_precio = new System.Windows.Forms.MaskedTextBox();
            this.p3_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p3_stock = new System.Windows.Forms.MaskedTextBox();
            this.p3_nombre = new System.Windows.Forms.TextBox();
            this.p6_id = new System.Windows.Forms.TextBox();
            this.p6_precio = new System.Windows.Forms.MaskedTextBox();
            this.p6_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p6_stock = new System.Windows.Forms.MaskedTextBox();
            this.p6_nombre = new System.Windows.Forms.TextBox();
            this.p5_id = new System.Windows.Forms.TextBox();
            this.p5_precio = new System.Windows.Forms.MaskedTextBox();
            this.p5_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p5_stock = new System.Windows.Forms.MaskedTextBox();
            this.p5_nombre = new System.Windows.Forms.TextBox();
            this.p4_id = new System.Windows.Forms.TextBox();
            this.p4_precio = new System.Windows.Forms.MaskedTextBox();
            this.p4_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p4_stock = new System.Windows.Forms.MaskedTextBox();
            this.p4_nombre = new System.Windows.Forms.TextBox();
            this.p12_id = new System.Windows.Forms.TextBox();
            this.p12_precio = new System.Windows.Forms.MaskedTextBox();
            this.p12_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p12_stock = new System.Windows.Forms.MaskedTextBox();
            this.p12_nombre = new System.Windows.Forms.TextBox();
            this.p11_id = new System.Windows.Forms.TextBox();
            this.p11_precio = new System.Windows.Forms.MaskedTextBox();
            this.p11_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p11_stock = new System.Windows.Forms.MaskedTextBox();
            this.p11_nombre = new System.Windows.Forms.TextBox();
            this.p10_id = new System.Windows.Forms.TextBox();
            this.p10_precio = new System.Windows.Forms.MaskedTextBox();
            this.p10_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p10_stock = new System.Windows.Forms.MaskedTextBox();
            this.p10_nombre = new System.Windows.Forms.TextBox();
            this.p9_id = new System.Windows.Forms.TextBox();
            this.p9_precio = new System.Windows.Forms.MaskedTextBox();
            this.p9_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p9_stock = new System.Windows.Forms.MaskedTextBox();
            this.p9_nombre = new System.Windows.Forms.TextBox();
            this.p8_id = new System.Windows.Forms.TextBox();
            this.p8_precio = new System.Windows.Forms.MaskedTextBox();
            this.p8_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p8_stock = new System.Windows.Forms.MaskedTextBox();
            this.p8_nombre = new System.Windows.Forms.TextBox();
            this.p7_id = new System.Windows.Forms.TextBox();
            this.p7_precio = new System.Windows.Forms.MaskedTextBox();
            this.p7_fecha = new System.Windows.Forms.MaskedTextBox();
            this.p7_stock = new System.Windows.Forms.MaskedTextBox();
            this.p7_nombre = new System.Windows.Forms.TextBox();
            this.p12_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p11_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p10_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p9_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p8_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p7_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p6_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p5_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p4_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p3_seccion = new System.Windows.Forms.MaskedTextBox();
            this.p2_seccion = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.p1_seccion = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.MaskedTextBox();
            this.cantidad_Eliminar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // apellido2_label
            // 
            this.apellido2_label.AutoSize = true;
            this.apellido2_label.Location = new System.Drawing.Point(370, 19);
            this.apellido2_label.Name = "apellido2_label";
            this.apellido2_label.Size = new System.Drawing.Size(92, 13);
            this.apellido2_label.TabIndex = 15;
            this.apellido2_label.Text = "Fecha Recepción";
            // 
            // apellido1_label
            // 
            this.apellido1_label.AutoSize = true;
            this.apellido1_label.Location = new System.Drawing.Point(289, 19);
            this.apellido1_label.Name = "apellido1_label";
            this.apellido1_label.Size = new System.Drawing.Size(46, 13);
            this.apellido1_label.TabIndex = 13;
            this.apellido1_label.Text = "Seccion";
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Location = new System.Drawing.Point(178, 19);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(42, 13);
            this.nombre_label.TabIndex = 11;
            this.nombre_label.Text = "Articulo";
            // 
            // textBoxArt
            // 
            this.textBoxArt.Location = new System.Drawing.Point(148, 35);
            this.textBoxArt.Name = "textBoxArt";
            this.textBoxArt.Size = new System.Drawing.Size(100, 20);
            this.textBoxArt.TabIndex = 10;
            // 
            // registrar_producto
            // 
            this.registrar_producto.Location = new System.Drawing.Point(574, 35);
            this.registrar_producto.Name = "registrar_producto";
            this.registrar_producto.Size = new System.Drawing.Size(98, 23);
            this.registrar_producto.TabIndex = 16;
            this.registrar_producto.Text = "Registrar";
            this.registrar_producto.UseVisualStyleBackColor = true;
            this.registrar_producto.Click += new System.EventHandler(this.registrar_p_Click);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(20, 370);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(15, 14);
            this.checkBox11.TabIndex = 65;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(20, 344);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 64;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(21, 320);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 63;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(20, 294);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 62;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(20, 269);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 61;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(20, 244);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 60;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(21, 216);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 59;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(21, 191);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 58;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 166);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 57;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 142);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 56;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(21, 92);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(15, 14);
            this.checkBox0.TabIndex = 54;
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(286, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 32);
            this.button4.TabIndex = 66;
            this.button4.Text = "Eliminar Registros";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // backpage
            // 
            this.backpage.Location = new System.Drawing.Point(558, 407);
            this.backpage.Name = "backpage";
            this.backpage.Size = new System.Drawing.Size(21, 23);
            this.backpage.TabIndex = 68;
            this.backpage.Text = "<";
            this.backpage.UseVisualStyleBackColor = true;
            this.backpage.Click += new System.EventHandler(this.backpage_Click);
            // 
            // nextpage
            // 
            this.nextpage.Location = new System.Drawing.Point(586, 407);
            this.nextpage.Name = "nextpage";
            this.nextpage.Size = new System.Drawing.Size(21, 23);
            this.nextpage.TabIndex = 67;
            this.nextpage.Text = ">";
            this.nextpage.UseVisualStyleBackColor = true;
            this.nextpage.Click += new System.EventHandler(this.nextpage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Precio";
            // 
            // textBoxSeccion
            // 
            this.textBoxSeccion.Location = new System.Drawing.Point(254, 35);
            this.textBoxSeccion.Name = "textBoxSeccion";
            this.textBoxSeccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeccion.TabIndex = 71;
            this.textBoxSeccion.ValidatingType = typeof(int);
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(361, 35);
            this.textBoxFecha.Mask = "00/00/0000";
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.textBoxFecha.TabIndex = 72;
            this.textBoxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(467, 35);
            this.textBoxPrecio.Mask = "99999.99";
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 76;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nombre";
            // 
            // search_Name
            // 
            this.search_Name.Location = new System.Drawing.Point(74, 466);
            this.search_Name.Name = "search_Name";
            this.search_Name.Size = new System.Drawing.Size(115, 20);
            this.search_Name.TabIndex = 74;
            // 
            // p1_precio
            // 
            this.p1_precio.BackColor = System.Drawing.Color.White;
            this.p1_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1_precio.Enabled = false;
            this.p1_precio.Location = new System.Drawing.Point(573, 88);
            this.p1_precio.Name = "p1_precio";
            this.p1_precio.Size = new System.Drawing.Size(100, 13);
            this.p1_precio.TabIndex = 92;
            // 
            // p1_fecha
            // 
            this.p1_fecha.BackColor = System.Drawing.Color.White;
            this.p1_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1_fecha.Enabled = false;
            this.p1_fecha.Location = new System.Drawing.Point(467, 88);
            this.p1_fecha.Mask = "00/00/0000";
            this.p1_fecha.Name = "p1_fecha";
            this.p1_fecha.Size = new System.Drawing.Size(100, 13);
            this.p1_fecha.TabIndex = 91;
            this.p1_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p1_stock
            // 
            this.p1_stock.BackColor = System.Drawing.Color.White;
            this.p1_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1_stock.Enabled = false;
            this.p1_stock.Location = new System.Drawing.Point(410, 88);
            this.p1_stock.Name = "p1_stock";
            this.p1_stock.Size = new System.Drawing.Size(50, 13);
            this.p1_stock.TabIndex = 90;
            this.p1_stock.ValidatingType = typeof(int);
            // 
            // p1_nombre
            // 
            this.p1_nombre.BackColor = System.Drawing.Color.White;
            this.p1_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1_nombre.Enabled = false;
            this.p1_nombre.Location = new System.Drawing.Point(117, 92);
            this.p1_nombre.Name = "p1_nombre";
            this.p1_nombre.Size = new System.Drawing.Size(176, 13);
            this.p1_nombre.TabIndex = 89;
            // 
            // p1_id
            // 
            this.p1_id.BackColor = System.Drawing.Color.White;
            this.p1_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1_id.Enabled = false;
            this.p1_id.Location = new System.Drawing.Point(42, 92);
            this.p1_id.Name = "p1_id";
            this.p1_id.Size = new System.Drawing.Size(69, 13);
            this.p1_id.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Fecha Recepción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Articulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "ID";
            // 
            // p2_id
            // 
            this.p2_id.BackColor = System.Drawing.Color.White;
            this.p2_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2_id.Enabled = false;
            this.p2_id.Location = new System.Drawing.Point(42, 116);
            this.p2_id.Name = "p2_id";
            this.p2_id.Size = new System.Drawing.Size(69, 13);
            this.p2_id.TabIndex = 103;
            // 
            // p2_precio
            // 
            this.p2_precio.BackColor = System.Drawing.Color.White;
            this.p2_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2_precio.Enabled = false;
            this.p2_precio.Location = new System.Drawing.Point(573, 112);
            this.p2_precio.Name = "p2_precio";
            this.p2_precio.Size = new System.Drawing.Size(100, 13);
            this.p2_precio.TabIndex = 102;
            // 
            // p2_fecha
            // 
            this.p2_fecha.BackColor = System.Drawing.Color.White;
            this.p2_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2_fecha.Enabled = false;
            this.p2_fecha.Location = new System.Drawing.Point(467, 112);
            this.p2_fecha.Mask = "00/00/0000";
            this.p2_fecha.Name = "p2_fecha";
            this.p2_fecha.Size = new System.Drawing.Size(100, 13);
            this.p2_fecha.TabIndex = 101;
            this.p2_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p2_stock
            // 
            this.p2_stock.BackColor = System.Drawing.Color.White;
            this.p2_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2_stock.Enabled = false;
            this.p2_stock.Location = new System.Drawing.Point(410, 112);
            this.p2_stock.Name = "p2_stock";
            this.p2_stock.Size = new System.Drawing.Size(50, 13);
            this.p2_stock.TabIndex = 100;
            this.p2_stock.ValidatingType = typeof(int);
            // 
            // p2_nombre
            // 
            this.p2_nombre.BackColor = System.Drawing.Color.White;
            this.p2_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2_nombre.Enabled = false;
            this.p2_nombre.Location = new System.Drawing.Point(117, 116);
            this.p2_nombre.Name = "p2_nombre";
            this.p2_nombre.Size = new System.Drawing.Size(176, 13);
            this.p2_nombre.TabIndex = 99;
            // 
            // p3_id
            // 
            this.p3_id.BackColor = System.Drawing.Color.White;
            this.p3_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3_id.Enabled = false;
            this.p3_id.Location = new System.Drawing.Point(42, 142);
            this.p3_id.Name = "p3_id";
            this.p3_id.Size = new System.Drawing.Size(69, 13);
            this.p3_id.TabIndex = 108;
            // 
            // p3_precio
            // 
            this.p3_precio.BackColor = System.Drawing.Color.White;
            this.p3_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3_precio.Enabled = false;
            this.p3_precio.Location = new System.Drawing.Point(573, 138);
            this.p3_precio.Name = "p3_precio";
            this.p3_precio.Size = new System.Drawing.Size(100, 13);
            this.p3_precio.TabIndex = 107;
            // 
            // p3_fecha
            // 
            this.p3_fecha.BackColor = System.Drawing.Color.White;
            this.p3_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3_fecha.Enabled = false;
            this.p3_fecha.Location = new System.Drawing.Point(467, 138);
            this.p3_fecha.Mask = "00/00/0000";
            this.p3_fecha.Name = "p3_fecha";
            this.p3_fecha.Size = new System.Drawing.Size(100, 13);
            this.p3_fecha.TabIndex = 106;
            this.p3_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p3_stock
            // 
            this.p3_stock.BackColor = System.Drawing.Color.White;
            this.p3_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3_stock.Enabled = false;
            this.p3_stock.Location = new System.Drawing.Point(410, 138);
            this.p3_stock.Name = "p3_stock";
            this.p3_stock.Size = new System.Drawing.Size(50, 13);
            this.p3_stock.TabIndex = 105;
            this.p3_stock.ValidatingType = typeof(int);
            // 
            // p3_nombre
            // 
            this.p3_nombre.BackColor = System.Drawing.Color.White;
            this.p3_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3_nombre.Enabled = false;
            this.p3_nombre.Location = new System.Drawing.Point(117, 142);
            this.p3_nombre.Name = "p3_nombre";
            this.p3_nombre.Size = new System.Drawing.Size(176, 13);
            this.p3_nombre.TabIndex = 104;
            // 
            // p6_id
            // 
            this.p6_id.BackColor = System.Drawing.Color.White;
            this.p6_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p6_id.Enabled = false;
            this.p6_id.Location = new System.Drawing.Point(42, 217);
            this.p6_id.Name = "p6_id";
            this.p6_id.Size = new System.Drawing.Size(69, 13);
            this.p6_id.TabIndex = 123;
            // 
            // p6_precio
            // 
            this.p6_precio.BackColor = System.Drawing.Color.White;
            this.p6_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p6_precio.Enabled = false;
            this.p6_precio.Location = new System.Drawing.Point(573, 213);
            this.p6_precio.Name = "p6_precio";
            this.p6_precio.Size = new System.Drawing.Size(100, 13);
            this.p6_precio.TabIndex = 122;
            // 
            // p6_fecha
            // 
            this.p6_fecha.BackColor = System.Drawing.Color.White;
            this.p6_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p6_fecha.Enabled = false;
            this.p6_fecha.Location = new System.Drawing.Point(467, 213);
            this.p6_fecha.Mask = "00/00/0000";
            this.p6_fecha.Name = "p6_fecha";
            this.p6_fecha.Size = new System.Drawing.Size(100, 13);
            this.p6_fecha.TabIndex = 121;
            this.p6_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p6_stock
            // 
            this.p6_stock.BackColor = System.Drawing.Color.White;
            this.p6_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p6_stock.Enabled = false;
            this.p6_stock.Location = new System.Drawing.Point(410, 213);
            this.p6_stock.Name = "p6_stock";
            this.p6_stock.Size = new System.Drawing.Size(50, 13);
            this.p6_stock.TabIndex = 120;
            this.p6_stock.ValidatingType = typeof(int);
            // 
            // p6_nombre
            // 
            this.p6_nombre.BackColor = System.Drawing.Color.White;
            this.p6_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p6_nombre.Enabled = false;
            this.p6_nombre.Location = new System.Drawing.Point(117, 217);
            this.p6_nombre.Name = "p6_nombre";
            this.p6_nombre.Size = new System.Drawing.Size(176, 13);
            this.p6_nombre.TabIndex = 119;
            // 
            // p5_id
            // 
            this.p5_id.BackColor = System.Drawing.Color.White;
            this.p5_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p5_id.Enabled = false;
            this.p5_id.Location = new System.Drawing.Point(42, 191);
            this.p5_id.Name = "p5_id";
            this.p5_id.Size = new System.Drawing.Size(69, 13);
            this.p5_id.TabIndex = 118;
            // 
            // p5_precio
            // 
            this.p5_precio.BackColor = System.Drawing.Color.White;
            this.p5_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p5_precio.Enabled = false;
            this.p5_precio.Location = new System.Drawing.Point(573, 187);
            this.p5_precio.Name = "p5_precio";
            this.p5_precio.Size = new System.Drawing.Size(100, 13);
            this.p5_precio.TabIndex = 117;
            // 
            // p5_fecha
            // 
            this.p5_fecha.BackColor = System.Drawing.Color.White;
            this.p5_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p5_fecha.Enabled = false;
            this.p5_fecha.Location = new System.Drawing.Point(467, 187);
            this.p5_fecha.Mask = "00/00/0000";
            this.p5_fecha.Name = "p5_fecha";
            this.p5_fecha.Size = new System.Drawing.Size(100, 13);
            this.p5_fecha.TabIndex = 116;
            this.p5_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p5_stock
            // 
            this.p5_stock.BackColor = System.Drawing.Color.White;
            this.p5_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p5_stock.Enabled = false;
            this.p5_stock.Location = new System.Drawing.Point(410, 187);
            this.p5_stock.Name = "p5_stock";
            this.p5_stock.Size = new System.Drawing.Size(50, 13);
            this.p5_stock.TabIndex = 115;
            this.p5_stock.ValidatingType = typeof(int);
            // 
            // p5_nombre
            // 
            this.p5_nombre.BackColor = System.Drawing.Color.White;
            this.p5_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p5_nombre.Enabled = false;
            this.p5_nombre.Location = new System.Drawing.Point(117, 191);
            this.p5_nombre.Name = "p5_nombre";
            this.p5_nombre.Size = new System.Drawing.Size(176, 13);
            this.p5_nombre.TabIndex = 114;
            // 
            // p4_id
            // 
            this.p4_id.BackColor = System.Drawing.Color.White;
            this.p4_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4_id.Enabled = false;
            this.p4_id.Location = new System.Drawing.Point(42, 167);
            this.p4_id.Name = "p4_id";
            this.p4_id.Size = new System.Drawing.Size(69, 13);
            this.p4_id.TabIndex = 113;
            // 
            // p4_precio
            // 
            this.p4_precio.BackColor = System.Drawing.Color.White;
            this.p4_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4_precio.Enabled = false;
            this.p4_precio.Location = new System.Drawing.Point(573, 163);
            this.p4_precio.Name = "p4_precio";
            this.p4_precio.Size = new System.Drawing.Size(100, 13);
            this.p4_precio.TabIndex = 112;
            // 
            // p4_fecha
            // 
            this.p4_fecha.BackColor = System.Drawing.Color.White;
            this.p4_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4_fecha.Enabled = false;
            this.p4_fecha.Location = new System.Drawing.Point(467, 163);
            this.p4_fecha.Mask = "00/00/0000";
            this.p4_fecha.Name = "p4_fecha";
            this.p4_fecha.Size = new System.Drawing.Size(100, 13);
            this.p4_fecha.TabIndex = 111;
            this.p4_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p4_stock
            // 
            this.p4_stock.BackColor = System.Drawing.Color.White;
            this.p4_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4_stock.Enabled = false;
            this.p4_stock.Location = new System.Drawing.Point(410, 163);
            this.p4_stock.Name = "p4_stock";
            this.p4_stock.Size = new System.Drawing.Size(50, 13);
            this.p4_stock.TabIndex = 110;
            this.p4_stock.ValidatingType = typeof(int);
            // 
            // p4_nombre
            // 
            this.p4_nombre.BackColor = System.Drawing.Color.White;
            this.p4_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4_nombre.Enabled = false;
            this.p4_nombre.Location = new System.Drawing.Point(117, 167);
            this.p4_nombre.Name = "p4_nombre";
            this.p4_nombre.Size = new System.Drawing.Size(176, 13);
            this.p4_nombre.TabIndex = 109;
            // 
            // p12_id
            // 
            this.p12_id.BackColor = System.Drawing.Color.White;
            this.p12_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p12_id.Enabled = false;
            this.p12_id.Location = new System.Drawing.Point(42, 370);
            this.p12_id.Name = "p12_id";
            this.p12_id.Size = new System.Drawing.Size(69, 13);
            this.p12_id.TabIndex = 153;
            // 
            // p12_precio
            // 
            this.p12_precio.BackColor = System.Drawing.Color.White;
            this.p12_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p12_precio.Enabled = false;
            this.p12_precio.Location = new System.Drawing.Point(573, 366);
            this.p12_precio.Name = "p12_precio";
            this.p12_precio.Size = new System.Drawing.Size(100, 13);
            this.p12_precio.TabIndex = 152;
            // 
            // p12_fecha
            // 
            this.p12_fecha.BackColor = System.Drawing.Color.White;
            this.p12_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p12_fecha.Enabled = false;
            this.p12_fecha.Location = new System.Drawing.Point(467, 366);
            this.p12_fecha.Mask = "00/00/0000";
            this.p12_fecha.Name = "p12_fecha";
            this.p12_fecha.Size = new System.Drawing.Size(100, 13);
            this.p12_fecha.TabIndex = 151;
            this.p12_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p12_stock
            // 
            this.p12_stock.BackColor = System.Drawing.Color.White;
            this.p12_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p12_stock.Enabled = false;
            this.p12_stock.Location = new System.Drawing.Point(410, 366);
            this.p12_stock.Name = "p12_stock";
            this.p12_stock.Size = new System.Drawing.Size(50, 13);
            this.p12_stock.TabIndex = 150;
            this.p12_stock.ValidatingType = typeof(int);
            // 
            // p12_nombre
            // 
            this.p12_nombre.BackColor = System.Drawing.Color.White;
            this.p12_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p12_nombre.Enabled = false;
            this.p12_nombre.Location = new System.Drawing.Point(117, 370);
            this.p12_nombre.Name = "p12_nombre";
            this.p12_nombre.Size = new System.Drawing.Size(176, 13);
            this.p12_nombre.TabIndex = 149;
            // 
            // p11_id
            // 
            this.p11_id.BackColor = System.Drawing.Color.White;
            this.p11_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p11_id.Enabled = false;
            this.p11_id.Location = new System.Drawing.Point(42, 344);
            this.p11_id.Name = "p11_id";
            this.p11_id.Size = new System.Drawing.Size(69, 13);
            this.p11_id.TabIndex = 148;
            // 
            // p11_precio
            // 
            this.p11_precio.BackColor = System.Drawing.Color.White;
            this.p11_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p11_precio.Enabled = false;
            this.p11_precio.Location = new System.Drawing.Point(573, 340);
            this.p11_precio.Name = "p11_precio";
            this.p11_precio.Size = new System.Drawing.Size(100, 13);
            this.p11_precio.TabIndex = 147;
            // 
            // p11_fecha
            // 
            this.p11_fecha.BackColor = System.Drawing.Color.White;
            this.p11_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p11_fecha.Enabled = false;
            this.p11_fecha.Location = new System.Drawing.Point(467, 340);
            this.p11_fecha.Mask = "00/00/0000";
            this.p11_fecha.Name = "p11_fecha";
            this.p11_fecha.Size = new System.Drawing.Size(100, 13);
            this.p11_fecha.TabIndex = 146;
            this.p11_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p11_stock
            // 
            this.p11_stock.BackColor = System.Drawing.Color.White;
            this.p11_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p11_stock.Enabled = false;
            this.p11_stock.Location = new System.Drawing.Point(410, 340);
            this.p11_stock.Name = "p11_stock";
            this.p11_stock.Size = new System.Drawing.Size(50, 13);
            this.p11_stock.TabIndex = 145;
            this.p11_stock.ValidatingType = typeof(int);
            // 
            // p11_nombre
            // 
            this.p11_nombre.BackColor = System.Drawing.Color.White;
            this.p11_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p11_nombre.Enabled = false;
            this.p11_nombre.Location = new System.Drawing.Point(117, 344);
            this.p11_nombre.Name = "p11_nombre";
            this.p11_nombre.Size = new System.Drawing.Size(176, 13);
            this.p11_nombre.TabIndex = 144;
            // 
            // p10_id
            // 
            this.p10_id.BackColor = System.Drawing.Color.White;
            this.p10_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p10_id.Enabled = false;
            this.p10_id.Location = new System.Drawing.Point(42, 320);
            this.p10_id.Name = "p10_id";
            this.p10_id.Size = new System.Drawing.Size(69, 13);
            this.p10_id.TabIndex = 143;
            // 
            // p10_precio
            // 
            this.p10_precio.BackColor = System.Drawing.Color.White;
            this.p10_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p10_precio.Enabled = false;
            this.p10_precio.Location = new System.Drawing.Point(573, 316);
            this.p10_precio.Name = "p10_precio";
            this.p10_precio.Size = new System.Drawing.Size(100, 13);
            this.p10_precio.TabIndex = 142;
            // 
            // p10_fecha
            // 
            this.p10_fecha.BackColor = System.Drawing.Color.White;
            this.p10_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p10_fecha.Enabled = false;
            this.p10_fecha.Location = new System.Drawing.Point(467, 316);
            this.p10_fecha.Mask = "00/00/0000";
            this.p10_fecha.Name = "p10_fecha";
            this.p10_fecha.Size = new System.Drawing.Size(100, 13);
            this.p10_fecha.TabIndex = 141;
            this.p10_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p10_stock
            // 
            this.p10_stock.BackColor = System.Drawing.Color.White;
            this.p10_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p10_stock.Enabled = false;
            this.p10_stock.Location = new System.Drawing.Point(410, 316);
            this.p10_stock.Name = "p10_stock";
            this.p10_stock.Size = new System.Drawing.Size(50, 13);
            this.p10_stock.TabIndex = 140;
            this.p10_stock.ValidatingType = typeof(int);
            // 
            // p10_nombre
            // 
            this.p10_nombre.BackColor = System.Drawing.Color.White;
            this.p10_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p10_nombre.Enabled = false;
            this.p10_nombre.Location = new System.Drawing.Point(117, 320);
            this.p10_nombre.Name = "p10_nombre";
            this.p10_nombre.Size = new System.Drawing.Size(176, 13);
            this.p10_nombre.TabIndex = 139;
            // 
            // p9_id
            // 
            this.p9_id.BackColor = System.Drawing.Color.White;
            this.p9_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p9_id.Enabled = false;
            this.p9_id.Location = new System.Drawing.Point(42, 295);
            this.p9_id.Name = "p9_id";
            this.p9_id.Size = new System.Drawing.Size(69, 13);
            this.p9_id.TabIndex = 138;
            // 
            // p9_precio
            // 
            this.p9_precio.BackColor = System.Drawing.Color.White;
            this.p9_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p9_precio.Enabled = false;
            this.p9_precio.Location = new System.Drawing.Point(573, 291);
            this.p9_precio.Name = "p9_precio";
            this.p9_precio.Size = new System.Drawing.Size(100, 13);
            this.p9_precio.TabIndex = 137;
            // 
            // p9_fecha
            // 
            this.p9_fecha.BackColor = System.Drawing.Color.White;
            this.p9_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p9_fecha.Enabled = false;
            this.p9_fecha.Location = new System.Drawing.Point(467, 291);
            this.p9_fecha.Mask = "00/00/0000";
            this.p9_fecha.Name = "p9_fecha";
            this.p9_fecha.Size = new System.Drawing.Size(100, 13);
            this.p9_fecha.TabIndex = 136;
            this.p9_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p9_stock
            // 
            this.p9_stock.BackColor = System.Drawing.Color.White;
            this.p9_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p9_stock.Enabled = false;
            this.p9_stock.Location = new System.Drawing.Point(410, 291);
            this.p9_stock.Name = "p9_stock";
            this.p9_stock.Size = new System.Drawing.Size(50, 13);
            this.p9_stock.TabIndex = 135;
            this.p9_stock.ValidatingType = typeof(int);
            // 
            // p9_nombre
            // 
            this.p9_nombre.BackColor = System.Drawing.Color.White;
            this.p9_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p9_nombre.Enabled = false;
            this.p9_nombre.Location = new System.Drawing.Point(117, 295);
            this.p9_nombre.Name = "p9_nombre";
            this.p9_nombre.Size = new System.Drawing.Size(176, 13);
            this.p9_nombre.TabIndex = 134;
            // 
            // p8_id
            // 
            this.p8_id.BackColor = System.Drawing.Color.White;
            this.p8_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p8_id.Enabled = false;
            this.p8_id.Location = new System.Drawing.Point(42, 269);
            this.p8_id.Name = "p8_id";
            this.p8_id.Size = new System.Drawing.Size(69, 13);
            this.p8_id.TabIndex = 133;
            // 
            // p8_precio
            // 
            this.p8_precio.BackColor = System.Drawing.Color.White;
            this.p8_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p8_precio.Enabled = false;
            this.p8_precio.Location = new System.Drawing.Point(573, 265);
            this.p8_precio.Name = "p8_precio";
            this.p8_precio.Size = new System.Drawing.Size(100, 13);
            this.p8_precio.TabIndex = 132;
            // 
            // p8_fecha
            // 
            this.p8_fecha.BackColor = System.Drawing.Color.White;
            this.p8_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p8_fecha.Enabled = false;
            this.p8_fecha.Location = new System.Drawing.Point(467, 265);
            this.p8_fecha.Mask = "00/00/0000";
            this.p8_fecha.Name = "p8_fecha";
            this.p8_fecha.Size = new System.Drawing.Size(100, 13);
            this.p8_fecha.TabIndex = 131;
            this.p8_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p8_stock
            // 
            this.p8_stock.BackColor = System.Drawing.Color.White;
            this.p8_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p8_stock.Enabled = false;
            this.p8_stock.Location = new System.Drawing.Point(410, 265);
            this.p8_stock.Name = "p8_stock";
            this.p8_stock.Size = new System.Drawing.Size(50, 13);
            this.p8_stock.TabIndex = 130;
            this.p8_stock.ValidatingType = typeof(int);
            // 
            // p8_nombre
            // 
            this.p8_nombre.BackColor = System.Drawing.Color.White;
            this.p8_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p8_nombre.Enabled = false;
            this.p8_nombre.Location = new System.Drawing.Point(117, 269);
            this.p8_nombre.Name = "p8_nombre";
            this.p8_nombre.Size = new System.Drawing.Size(176, 13);
            this.p8_nombre.TabIndex = 129;
            // 
            // p7_id
            // 
            this.p7_id.BackColor = System.Drawing.Color.White;
            this.p7_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p7_id.Enabled = false;
            this.p7_id.Location = new System.Drawing.Point(42, 245);
            this.p7_id.Name = "p7_id";
            this.p7_id.Size = new System.Drawing.Size(69, 13);
            this.p7_id.TabIndex = 128;
            // 
            // p7_precio
            // 
            this.p7_precio.BackColor = System.Drawing.Color.White;
            this.p7_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p7_precio.Enabled = false;
            this.p7_precio.Location = new System.Drawing.Point(573, 241);
            this.p7_precio.Name = "p7_precio";
            this.p7_precio.Size = new System.Drawing.Size(100, 13);
            this.p7_precio.TabIndex = 127;
            // 
            // p7_fecha
            // 
            this.p7_fecha.BackColor = System.Drawing.Color.White;
            this.p7_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p7_fecha.Enabled = false;
            this.p7_fecha.Location = new System.Drawing.Point(467, 241);
            this.p7_fecha.Mask = "00/00/0000";
            this.p7_fecha.Name = "p7_fecha";
            this.p7_fecha.Size = new System.Drawing.Size(100, 13);
            this.p7_fecha.TabIndex = 126;
            this.p7_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // p7_stock
            // 
            this.p7_stock.BackColor = System.Drawing.Color.White;
            this.p7_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p7_stock.Enabled = false;
            this.p7_stock.Location = new System.Drawing.Point(410, 241);
            this.p7_stock.Name = "p7_stock";
            this.p7_stock.Size = new System.Drawing.Size(50, 13);
            this.p7_stock.TabIndex = 125;
            this.p7_stock.ValidatingType = typeof(int);
            // 
            // p7_nombre
            // 
            this.p7_nombre.BackColor = System.Drawing.Color.White;
            this.p7_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p7_nombre.Enabled = false;
            this.p7_nombre.Location = new System.Drawing.Point(117, 245);
            this.p7_nombre.Name = "p7_nombre";
            this.p7_nombre.Size = new System.Drawing.Size(176, 13);
            this.p7_nombre.TabIndex = 124;
            // 
            // p12_seccion
            // 
            this.p12_seccion.BackColor = System.Drawing.Color.White;
            this.p12_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p12_seccion.Enabled = false;
            this.p12_seccion.Location = new System.Drawing.Point(323, 370);
            this.p12_seccion.Name = "p12_seccion";
            this.p12_seccion.Size = new System.Drawing.Size(81, 13);
            this.p12_seccion.TabIndex = 166;
            this.p12_seccion.ValidatingType = typeof(int);
            // 
            // p11_seccion
            // 
            this.p11_seccion.BackColor = System.Drawing.Color.White;
            this.p11_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p11_seccion.Enabled = false;
            this.p11_seccion.Location = new System.Drawing.Point(323, 344);
            this.p11_seccion.Name = "p11_seccion";
            this.p11_seccion.Size = new System.Drawing.Size(81, 13);
            this.p11_seccion.TabIndex = 165;
            this.p11_seccion.ValidatingType = typeof(int);
            // 
            // p10_seccion
            // 
            this.p10_seccion.BackColor = System.Drawing.Color.White;
            this.p10_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p10_seccion.Enabled = false;
            this.p10_seccion.Location = new System.Drawing.Point(323, 320);
            this.p10_seccion.Name = "p10_seccion";
            this.p10_seccion.Size = new System.Drawing.Size(81, 13);
            this.p10_seccion.TabIndex = 164;
            this.p10_seccion.ValidatingType = typeof(int);
            // 
            // p9_seccion
            // 
            this.p9_seccion.BackColor = System.Drawing.Color.White;
            this.p9_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p9_seccion.Enabled = false;
            this.p9_seccion.Location = new System.Drawing.Point(323, 295);
            this.p9_seccion.Name = "p9_seccion";
            this.p9_seccion.Size = new System.Drawing.Size(81, 13);
            this.p9_seccion.TabIndex = 163;
            this.p9_seccion.ValidatingType = typeof(int);
            // 
            // p8_seccion
            // 
            this.p8_seccion.BackColor = System.Drawing.Color.White;
            this.p8_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p8_seccion.Enabled = false;
            this.p8_seccion.Location = new System.Drawing.Point(323, 269);
            this.p8_seccion.Name = "p8_seccion";
            this.p8_seccion.Size = new System.Drawing.Size(81, 13);
            this.p8_seccion.TabIndex = 162;
            this.p8_seccion.ValidatingType = typeof(int);
            // 
            // p7_seccion
            // 
            this.p7_seccion.BackColor = System.Drawing.Color.White;
            this.p7_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p7_seccion.Enabled = false;
            this.p7_seccion.Location = new System.Drawing.Point(323, 245);
            this.p7_seccion.Name = "p7_seccion";
            this.p7_seccion.Size = new System.Drawing.Size(81, 13);
            this.p7_seccion.TabIndex = 161;
            this.p7_seccion.ValidatingType = typeof(int);
            // 
            // p6_seccion
            // 
            this.p6_seccion.BackColor = System.Drawing.Color.White;
            this.p6_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p6_seccion.Enabled = false;
            this.p6_seccion.Location = new System.Drawing.Point(323, 217);
            this.p6_seccion.Name = "p6_seccion";
            this.p6_seccion.Size = new System.Drawing.Size(81, 13);
            this.p6_seccion.TabIndex = 160;
            this.p6_seccion.ValidatingType = typeof(int);
            // 
            // p5_seccion
            // 
            this.p5_seccion.BackColor = System.Drawing.Color.White;
            this.p5_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p5_seccion.Enabled = false;
            this.p5_seccion.Location = new System.Drawing.Point(323, 191);
            this.p5_seccion.Name = "p5_seccion";
            this.p5_seccion.Size = new System.Drawing.Size(81, 13);
            this.p5_seccion.TabIndex = 159;
            this.p5_seccion.ValidatingType = typeof(int);
            // 
            // p4_seccion
            // 
            this.p4_seccion.BackColor = System.Drawing.Color.White;
            this.p4_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4_seccion.Enabled = false;
            this.p4_seccion.Location = new System.Drawing.Point(323, 167);
            this.p4_seccion.Name = "p4_seccion";
            this.p4_seccion.Size = new System.Drawing.Size(81, 13);
            this.p4_seccion.TabIndex = 158;
            this.p4_seccion.ValidatingType = typeof(int);
            // 
            // p3_seccion
            // 
            this.p3_seccion.BackColor = System.Drawing.Color.White;
            this.p3_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3_seccion.Enabled = false;
            this.p3_seccion.Location = new System.Drawing.Point(323, 142);
            this.p3_seccion.Name = "p3_seccion";
            this.p3_seccion.Size = new System.Drawing.Size(81, 13);
            this.p3_seccion.TabIndex = 157;
            this.p3_seccion.ValidatingType = typeof(int);
            // 
            // p2_seccion
            // 
            this.p2_seccion.BackColor = System.Drawing.Color.White;
            this.p2_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2_seccion.Enabled = false;
            this.p2_seccion.Location = new System.Drawing.Point(323, 116);
            this.p2_seccion.Name = "p2_seccion";
            this.p2_seccion.Size = new System.Drawing.Size(81, 13);
            this.p2_seccion.TabIndex = 156;
            this.p2_seccion.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 155;
            this.label8.Text = "Sección";
            // 
            // p1_seccion
            // 
            this.p1_seccion.BackColor = System.Drawing.Color.White;
            this.p1_seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1_seccion.Enabled = false;
            this.p1_seccion.Location = new System.Drawing.Point(323, 92);
            this.p1_seccion.Name = "p1_seccion";
            this.p1_seccion.Size = new System.Drawing.Size(81, 13);
            this.p1_seccion.TabIndex = 154;
            this.p1_seccion.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 168;
            this.label9.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(42, 35);
            this.textBoxCantidad.Mask = "99999";
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 169;
            this.textBoxCantidad.ValidatingType = typeof(int);
            // 
            // cantidad_Eliminar
            // 
            this.cantidad_Eliminar.Location = new System.Drawing.Point(404, 405);
            this.cantidad_Eliminar.Mask = "99999";
            this.cantidad_Eliminar.Name = "cantidad_Eliminar";
            this.cantidad_Eliminar.Size = new System.Drawing.Size(56, 20);
            this.cantidad_Eliminar.TabIndex = 170;
            this.cantidad_Eliminar.ValidatingType = typeof(int);
            // 
            // Productos
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 541);
            this.Controls.Add(this.cantidad_Eliminar);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.p12_seccion);
            this.Controls.Add(this.p11_seccion);
            this.Controls.Add(this.p10_seccion);
            this.Controls.Add(this.p9_seccion);
            this.Controls.Add(this.p8_seccion);
            this.Controls.Add(this.p7_seccion);
            this.Controls.Add(this.p6_seccion);
            this.Controls.Add(this.p5_seccion);
            this.Controls.Add(this.p4_seccion);
            this.Controls.Add(this.p3_seccion);
            this.Controls.Add(this.p2_seccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.p1_seccion);
            this.Controls.Add(this.p12_id);
            this.Controls.Add(this.p12_precio);
            this.Controls.Add(this.p12_fecha);
            this.Controls.Add(this.p12_stock);
            this.Controls.Add(this.p12_nombre);
            this.Controls.Add(this.p11_id);
            this.Controls.Add(this.p11_precio);
            this.Controls.Add(this.p11_fecha);
            this.Controls.Add(this.p11_stock);
            this.Controls.Add(this.p11_nombre);
            this.Controls.Add(this.p10_id);
            this.Controls.Add(this.p10_precio);
            this.Controls.Add(this.p10_fecha);
            this.Controls.Add(this.p10_stock);
            this.Controls.Add(this.p10_nombre);
            this.Controls.Add(this.p9_id);
            this.Controls.Add(this.p9_precio);
            this.Controls.Add(this.p9_fecha);
            this.Controls.Add(this.p9_stock);
            this.Controls.Add(this.p9_nombre);
            this.Controls.Add(this.p8_id);
            this.Controls.Add(this.p8_precio);
            this.Controls.Add(this.p8_fecha);
            this.Controls.Add(this.p8_stock);
            this.Controls.Add(this.p8_nombre);
            this.Controls.Add(this.p7_id);
            this.Controls.Add(this.p7_precio);
            this.Controls.Add(this.p7_fecha);
            this.Controls.Add(this.p7_stock);
            this.Controls.Add(this.p7_nombre);
            this.Controls.Add(this.p6_id);
            this.Controls.Add(this.p6_precio);
            this.Controls.Add(this.p6_fecha);
            this.Controls.Add(this.p6_stock);
            this.Controls.Add(this.p6_nombre);
            this.Controls.Add(this.p5_id);
            this.Controls.Add(this.p5_precio);
            this.Controls.Add(this.p5_fecha);
            this.Controls.Add(this.p5_stock);
            this.Controls.Add(this.p5_nombre);
            this.Controls.Add(this.p4_id);
            this.Controls.Add(this.p4_precio);
            this.Controls.Add(this.p4_fecha);
            this.Controls.Add(this.p4_stock);
            this.Controls.Add(this.p4_nombre);
            this.Controls.Add(this.p3_id);
            this.Controls.Add(this.p3_precio);
            this.Controls.Add(this.p3_fecha);
            this.Controls.Add(this.p3_stock);
            this.Controls.Add(this.p3_nombre);
            this.Controls.Add(this.p2_id);
            this.Controls.Add(this.p2_precio);
            this.Controls.Add(this.p2_fecha);
            this.Controls.Add(this.p2_stock);
            this.Controls.Add(this.p2_nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.p1_id);
            this.Controls.Add(this.p1_precio);
            this.Controls.Add(this.p1_fecha);
            this.Controls.Add(this.p1_stock);
            this.Controls.Add(this.p1_nombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_Name);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxSeccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backpage);
            this.Controls.Add(this.nextpage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox0);
            this.Controls.Add(this.registrar_producto);
            this.Controls.Add(this.apellido2_label);
            this.Controls.Add(this.apellido1_label);
            this.Controls.Add(this.nombre_label);
            this.Controls.Add(this.textBoxArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Limpiar()
        {
            textBoxArt.Text = "";
            textBoxSeccion.Text = "";
            textBoxFecha.Text = "";
            textBoxCantidad.Text = "";
            textBoxPrecio.Text = "";
            cantidad_Eliminar.Text = "";
            search_Name.Text = "";
           
        }

        private void registrar_p_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorProductos controlador = new ControladorProductos();

            string nombre = textBoxArt.Text.ToString();
            int cantidad = Int32.Parse(textBoxCantidad.Text.ToString());
            string seccion = textBoxSeccion.Text.ToString();

                DateTime fecha = Convert.ToDateTime(textBoxFecha.Text.ToString());
            
            float precio = float.Parse(textBoxPrecio.Text.ToString());
            

            controlador.NuevoProducto(nombre, seccion, cantidad, fecha, precio);
                Limpiar();
                VerProductos(0);
            }
            catch (Exception i)
            {
                Console.WriteLine(i.GetBaseException());
                MessageBox.Show("Error al insertar registro, comprueba los campos");
            }
        }

        private void VerProductos(int offset)
        {
            ControladorProductos controlador = new ControladorProductos();

            string[,] registro;
            registro = controlador.Select(offset);
            CambiarValores(registro);
         
        }

        private void CambiarValores(string[,] registro)
        {
            p1_id.Text = registro[0, 0]; p1_nombre.Text= registro[0, 1]; p1_stock.Text = registro[0, 2]; p1_fecha.Text = registro[0, 3]; p1_precio.Text=registro[0, 4]; p1_seccion.Text = registro[0, 5];
            p2_id.Text = registro[1, 0]; p2_nombre.Text = registro[1, 1]; p2_stock.Text = registro[1, 2]; p2_fecha.Text = registro[1, 3]; p2_precio.Text=registro[1, 4]; p2_seccion.Text = registro[1, 5];
            p3_id.Text = registro[2, 0]; p3_nombre.Text = registro[2, 1]; p3_stock.Text = registro[2, 2]; p3_fecha.Text = registro[2, 3]; p3_precio.Text=registro[2, 4]; p3_seccion.Text = registro[2, 5];
            p4_id.Text = registro[3, 0]; p4_nombre.Text = registro[3, 1]; p4_stock.Text = registro[3, 2]; p4_fecha.Text = registro[3, 3]; p4_precio.Text=registro[3, 4]; p4_seccion.Text = registro[3, 5];
            p5_id.Text = registro[4, 0]; p5_nombre.Text = registro[4, 1]; p5_stock.Text = registro[4, 2]; p5_fecha.Text = registro[4, 3]; p5_precio.Text=registro[4, 4]; p5_seccion.Text = registro[4, 5];
            p6_id.Text = registro[5, 0]; p6_nombre.Text = registro[5, 1]; p6_stock.Text = registro[5, 2]; p6_fecha.Text = registro[5, 3]; p6_precio.Text=registro[5, 4]; p6_seccion.Text = registro[5, 5];
            p7_id.Text = registro[6, 0]; p7_nombre.Text = registro[6, 1]; p7_stock.Text = registro[6, 2]; p7_fecha.Text = registro[6, 3]; p7_precio.Text=registro[6, 4]; p7_seccion.Text = registro[6, 5];
            p8_id.Text = registro[7, 0]; p8_nombre.Text = registro[7, 1]; p8_stock.Text = registro[7, 2]; p8_fecha.Text = registro[7, 3]; p8_precio.Text=registro[7, 4]; p8_seccion.Text = registro[7, 5];
            p9_id.Text = registro[8, 0]; p9_nombre.Text = registro[8, 1]; p9_stock.Text = registro[8, 2]; p9_fecha.Text = registro[8, 3]; p9_precio.Text=registro[8, 4]; p9_seccion.Text = registro[8, 5];
            p10_id.Text = registro[9, 0]; p10_nombre.Text = registro[9, 1]; p10_stock.Text = registro[9, 2]; p10_fecha.Text = registro[9, 3]; p10_precio.Text=registro[9, 4]; p10_seccion.Text = registro[9, 5];
            p11_id.Text = registro[10, 0]; p11_nombre.Text = registro[10, 1]; p11_stock.Text = registro[10, 2]; p11_fecha.Text = registro[10, 3]; p11_precio.Text=registro[10, 4]; p11_seccion.Text = registro[10, 5];
            p12_id.Text = registro[11, 0]; p12_nombre.Text = registro[11, 1]; p12_stock.Text = registro[11, 2]; p12_fecha.Text = registro[11, 3]; p12_precio.Text=registro[11, 4]; p12_seccion.Text = registro[11, 5];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox0.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p1_nombre.Text.ToString();
                int cantidad;
                
                  bool sucess = Int32.TryParse(cantidad_Eliminar.Text.ToString(), out cantidad);

                if (!sucess) { cantidad = 1; }

                controlador.DeleteByID(nombre,cantidad);
                checkBox0.Checked = false;
            }
            if (checkBox1.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p2_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox1.Checked = false;

            }
            if (checkBox2.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p3_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox2.Checked = false;

            }
            if (checkBox3.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p4_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox3.Checked = false;

            }
            if (checkBox4.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p5_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox4.Checked = false;

            }
            if (checkBox5.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p6_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox5.Checked = false;

            }
            if (checkBox6.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p7_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox6.Checked = false;

            }
            if (checkBox7.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p8_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox7.Checked = false;

            }
            if (checkBox8.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p9_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox8.Checked = false;

            }
            if (checkBox9.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p10_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox9.Checked = false;

            }
            if (checkBox10.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p11_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                controlador.DeleteByID(nombre, cantidad);
                checkBox10.Checked = false;

            }
            if (checkBox11.Checked)
            {
                ControladorProductos controlador = new ControladorProductos();


                string nombre = p12_nombre.Text.ToString();
                int cantidad = Int32.Parse(cantidad_Eliminar.Text.ToString());
                if (cantidad == 0)
                {
                    cantidad = 1;
                }

                controlador.DeleteByID(nombre, cantidad);

                checkBox11.Checked = false;

            }

            Limpiar();
            VerProductos(pagina);
        }

        private void backpage_Click(object sender, EventArgs e)
        {
            if(pagina>0)
            pagina -= 12;
            VerProductos(pagina);
        }

        private void nextpage_Click(object sender, EventArgs e)
        {
            pagina += 12;
            VerProductos(pagina);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorProductos controlador = new ControladorProductos();

            string[,] registro;
            if (!search_Name.Text.ToString().Equals(""))
            {

                pagina = 0;
                registro = controlador.GetByName(search_Name.Text.ToString(), pagina);

                CambiarValores(registro);
                

            }
            else
            {
                VerProductos(pagina);
            }
        }

        
    }
}
