namespace Presentacion
{
    partial class formNuevaPersona
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
            label1 = new Label();
            txbNombre = new TextBox();
            txbDireccion = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            txbApellido = new TextBox();
            txbClave = new TextBox();
            lblCorreo = new Label();
            lblClave = new Label();
            lblUsuario = new Label();
            txbCorreo = new TextBox();
            txbUsuario = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblSoy = new Label();
            radiobAlumno = new RadioButton();
            radiobProfesor = new RadioButton();
            label2 = new Label();
            txbTelefono = new TextBox();
            lblDni = new Label();
            txbDni = new TextBox();
            label3 = new Label();
            dtpFechaNac = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(317, 19);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Usuario";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(137, 94);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(247, 27);
            txbNombre.TabIndex = 1;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(137, 147);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(247, 27);
            txbDireccion.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(67, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(390, 98);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(59, 150);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Direccion";
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(462, 95);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(247, 27);
            txbApellido.TabIndex = 12;
            // 
            // txbClave
            // 
            txbClave.Location = new Point(462, 258);
            txbClave.Name = "txbClave";
            txbClave.PasswordChar = '*';
            txbClave.Size = new Size(247, 27);
            txbClave.TabIndex = 18;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(77, 313);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 17;
            lblCorreo.Text = "Correo";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(411, 260);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(45, 20);
            lblClave.TabIndex = 16;
            lblClave.Text = "Clave";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(72, 260);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 15;
            lblUsuario.Text = "Usuario";
            // 
            // txbCorreo
            // 
            txbCorreo.Location = new Point(137, 310);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(247, 27);
            txbCorreo.TabIndex = 14;
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(137, 257);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(247, 27);
            txbUsuario.TabIndex = 13;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(439, 425);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(275, 425);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblSoy
            // 
            lblSoy.AutoSize = true;
            lblSoy.Location = new Point(95, 366);
            lblSoy.Name = "lblSoy";
            lblSoy.Size = new Size(36, 20);
            lblSoy.TabIndex = 21;
            lblSoy.Text = "Soy:";
            // 
            // radiobAlumno
            // 
            radiobAlumno.AutoSize = true;
            radiobAlumno.Checked = true;
            radiobAlumno.Location = new Point(137, 367);
            radiobAlumno.Name = "radiobAlumno";
            radiobAlumno.Size = new Size(82, 24);
            radiobAlumno.TabIndex = 22;
            radiobAlumno.TabStop = true;
            radiobAlumno.Text = "Alumno";
            radiobAlumno.UseVisualStyleBackColor = true;
            // 
            // radiobProfesor
            // 
            radiobProfesor.AutoSize = true;
            radiobProfesor.Location = new Point(225, 367);
            radiobProfesor.Name = "radiobProfesor";
            radiobProfesor.Size = new Size(85, 24);
            radiobProfesor.TabIndex = 23;
            radiobProfesor.TabStop = true;
            radiobProfesor.Text = "Profesor";
            radiobProfesor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 316);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 25;
            label2.Text = "Tel";
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(462, 313);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(247, 27);
            txbTelefono.TabIndex = 24;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(424, 150);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 20);
            lblDni.TabIndex = 27;
            lblDni.Text = "Dni";
            // 
            // txbDni
            // 
            txbDni.Location = new Point(462, 150);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(247, 27);
            txbDni.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 205);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 29;
            label3.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(214, 200);
            dtpFechaNac.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(275, 27);
            dtpFechaNac.TabIndex = 30;
            dtpFechaNac.Value = new DateTime(2024, 8, 29, 0, 0, 0, 0);
            // 
            // formNuevaPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(dtpFechaNac);
            Controls.Add(label3);
            Controls.Add(lblDni);
            Controls.Add(txbDni);
            Controls.Add(label2);
            Controls.Add(txbTelefono);
            Controls.Add(radiobProfesor);
            Controls.Add(radiobAlumno);
            Controls.Add(lblSoy);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txbClave);
            Controls.Add(lblCorreo);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Controls.Add(txbCorreo);
            Controls.Add(txbUsuario);
            Controls.Add(txbApellido);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txbDireccion);
            Controls.Add(txbNombre);
            Controls.Add(label1);
            Name = "formNuevaPersona";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbNombre;
        private TextBox txbDireccion;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private TextBox txbApellido;
        private TextBox txbClave;
        private Label lblCorreo;
        private Label lblClave;
        private Label lblUsuario;
        private TextBox txbCorreo;
        private TextBox txbUsuario;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblSoy;
        private RadioButton radiobAlumno;
        private RadioButton radiobProfesor;
        private Label label2;
        private TextBox txbTelefono;
        private Label lblDni;
        private TextBox txbDni;
        private Label label3;
        private DateTimePicker dtpFechaNac;
    }
}