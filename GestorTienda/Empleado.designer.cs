namespace GestorTienda
{
    partial class Empleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.text_fecha = new System.Windows.Forms.MaskedTextBox();
            this.text_incidencia = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.apellido2 = new System.Windows.Forms.TextBox();
            this.apellido1 = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Incidencias";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.text_fecha);
            this.panel1.Controls.Add(this.text_incidencia);
            this.panel1.Location = new System.Drawing.Point(429, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 368);
            this.panel1.TabIndex = 18;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(160, 8);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(31, 23);
            this.Next.TabIndex = 20;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(123, 8);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(31, 23);
            this.Back.TabIndex = 19;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // text_fecha
            // 
            this.text_fecha.Location = new System.Drawing.Point(17, 10);
            this.text_fecha.Mask = "00/00/0000";
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(100, 20);
            this.text_fecha.TabIndex = 1;
            this.text_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // text_incidencia
            // 
            this.text_incidencia.BackColor = System.Drawing.Color.White;
            this.text_incidencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_incidencia.Enabled = false;
            this.text_incidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_incidencia.ForeColor = System.Drawing.Color.Black;
            this.text_incidencia.Location = new System.Drawing.Point(3, 57);
            this.text_incidencia.Name = "text_incidencia";
            this.text_incidencia.Size = new System.Drawing.Size(353, 308);
            this.text_incidencia.TabIndex = 0;
            this.text_incidencia.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nueva Incidencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dni);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.usuario);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.correo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.telefono);
            this.panel2.Controls.Add(this.cp);
            this.panel2.Controls.Add(this.direccion);
            this.panel2.Controls.Add(this.apellido2);
            this.panel2.Controls.Add(this.apellido1);
            this.panel2.Controls.Add(this.nombre);
            this.panel2.Location = new System.Drawing.Point(12, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 368);
            this.panel2.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "DNI";
            // 
            // dni
            // 
            this.dni.BackColor = System.Drawing.Color.White;
            this.dni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dni.Enabled = false;
            this.dni.Location = new System.Drawing.Point(105, 25);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(118, 13);
            this.dni.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Usuario";
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.White;
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.Enabled = false;
            this.usuario.Location = new System.Drawing.Point(105, 233);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(118, 13);
            this.usuario.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "E-Mail";
            // 
            // correo
            // 
            this.correo.BackColor = System.Drawing.Color.White;
            this.correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correo.Enabled = false;
            this.correo.Location = new System.Drawing.Point(105, 207);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(189, 13);
            this.correo.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Código Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Segundo Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Primer Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.Color.White;
            this.telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefono.Enabled = false;
            this.telefono.Location = new System.Drawing.Point(105, 181);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(118, 13);
            this.telefono.TabIndex = 21;
            // 
            // cp
            // 
            this.cp.BackColor = System.Drawing.Color.White;
            this.cp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cp.Enabled = false;
            this.cp.Location = new System.Drawing.Point(105, 155);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(118, 13);
            this.cp.TabIndex = 20;
            // 
            // direccion
            // 
            this.direccion.BackColor = System.Drawing.Color.White;
            this.direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direccion.Enabled = false;
            this.direccion.Location = new System.Drawing.Point(105, 129);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(189, 13);
            this.direccion.TabIndex = 19;
            // 
            // apellido2
            // 
            this.apellido2.BackColor = System.Drawing.Color.White;
            this.apellido2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apellido2.Enabled = false;
            this.apellido2.Location = new System.Drawing.Point(105, 103);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(189, 13);
            this.apellido2.TabIndex = 18;
            // 
            // apellido1
            // 
            this.apellido1.BackColor = System.Drawing.Color.White;
            this.apellido1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apellido1.Enabled = false;
            this.apellido1.Location = new System.Drawing.Point(105, 77);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(189, 13);
            this.apellido1.TabIndex = 17;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.White;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(105, 51);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(118, 13);
            this.nombre.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Datos";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Empleado";
            this.ShowIcon = false;
            this.Text = "Empleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.MaskedTextBox text_fecha;
        private System.Windows.Forms.RichTextBox text_incidencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox apellido2;
        private System.Windows.Forms.TextBox apellido1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dni;
    }
}