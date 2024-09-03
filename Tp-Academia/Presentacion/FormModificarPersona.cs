﻿using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormModificarPersona : Form
    {


        public FormModificarPersona(Persona per)
        {
            InitializeComponent();
            this.PersonaForm = per;
        }

        private void CargarDatos()
        {
            txbTelefono.Text = PersonaForm.Tel;
            txbDni.Text = PersonaForm.DNI;
            txbClave.Text = PersonaForm.Clave;
            txbApellido.Text = PersonaForm.Apellido;
            dtpFechaNac.Value = PersonaForm.Fecha_nac;
            txbNombre.Text = PersonaForm.Nombre;
            txbCorreo.Text = PersonaForm.Mail;
            txbUsuario.Text = PersonaForm.Usuario;
            txbDireccion.Text = PersonaForm.Direccion;

        }

        private void InitializeComponent()
        {
            tableLayoutPanel4 = new TableLayoutPanel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblNuevoUsuario = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txbTelefono = new TextBox();
            txbDni = new TextBox();
            txbClave = new TextBox();
            lblDni = new Label();
            lblApellido = new Label();
            txbApellido = new TextBox();
            dtpFechaNac = new DateTimePicker();
            lblNombre = new Label();
            label2 = new Label();
            lblClave = new Label();
            txbNombre = new TextBox();
            lblDireccion = new Label();
            lblUsuario = new Label();
            txbCorreo = new TextBox();
            txbUsuario = new TextBox();
            lblCorreo = new Label();
            txbDireccion = new TextBox();
            label3 = new Label();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnCancelar, 1, 0);
            tableLayoutPanel4.Controls.Add(btnAceptar, 2, 0);
            tableLayoutPanel4.Location = new Point(0, 339);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(708, 29);
            tableLayoutPanel4.TabIndex = 38;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(224, 3);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(401, 3);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.MouseClick += btnAceptar_MouseClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblNuevoUsuario, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(708, 47);
            tableLayoutPanel1.TabIndex = 35;
            // 
            // lblNuevoUsuario
            // 
            lblNuevoUsuario.Anchor = AnchorStyles.Bottom;
            lblNuevoUsuario.AutoSize = true;
            lblNuevoUsuario.Font = new Font("Segoe UI", 14F);
            lblNuevoUsuario.Location = new Point(271, 22);
            lblNuevoUsuario.Name = "lblNuevoUsuario";
            lblNuevoUsuario.Size = new Size(165, 25);
            lblNuevoUsuario.TabIndex = 0;
            lblNuevoUsuario.Text = "Modificar Persona";
            lblNuevoUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.050505F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.32323F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.050505F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.32323F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.050505F));
            tableLayoutPanel2.Controls.Add(txbTelefono, 5, 4);
            tableLayoutPanel2.Controls.Add(txbDni, 5, 1);
            tableLayoutPanel2.Controls.Add(txbClave, 5, 3);
            tableLayoutPanel2.Controls.Add(lblDni, 4, 1);
            tableLayoutPanel2.Controls.Add(lblApellido, 4, 0);
            tableLayoutPanel2.Controls.Add(txbApellido, 5, 0);
            tableLayoutPanel2.Controls.Add(dtpFechaNac, 2, 2);
            tableLayoutPanel2.Controls.Add(lblNombre, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 4, 4);
            tableLayoutPanel2.Controls.Add(lblClave, 4, 3);
            tableLayoutPanel2.Controls.Add(txbNombre, 2, 0);
            tableLayoutPanel2.Controls.Add(lblDireccion, 1, 1);
            tableLayoutPanel2.Controls.Add(lblUsuario, 1, 4);
            tableLayoutPanel2.Controls.Add(txbCorreo, 2, 4);
            tableLayoutPanel2.Controls.Add(txbUsuario, 2, 3);
            tableLayoutPanel2.Controls.Add(lblCorreo, 1, 3);
            tableLayoutPanel2.Controls.Add(txbDireccion, 2, 1);
            tableLayoutPanel2.Controls.Add(label3, 1, 2);
            tableLayoutPanel2.Location = new Point(0, 106);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(708, 212);
            tableLayoutPanel2.TabIndex = 36;
            // 
            // txbTelefono
            // 
            txbTelefono.Anchor = AnchorStyles.None;
            txbTelefono.Location = new Point(445, 178);
            txbTelefono.Margin = new Padding(3, 2, 3, 2);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(217, 23);
            txbTelefono.TabIndex = 24;
            // 
            // txbDni
            // 
            txbDni.Anchor = AnchorStyles.None;
            txbDni.Location = new Point(445, 51);
            txbDni.Margin = new Padding(3, 2, 3, 2);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(217, 23);
            txbDni.TabIndex = 26;
            // 
            // txbClave
            // 
            txbClave.Anchor = AnchorStyles.None;
            txbClave.Location = new Point(445, 135);
            txbClave.Margin = new Padding(3, 2, 3, 2);
            txbClave.Name = "txbClave";
            txbClave.PasswordChar = '*';
            txbClave.Size = new Size(217, 23);
            txbClave.TabIndex = 18;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(392, 55);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(25, 15);
            lblDni.TabIndex = 27;
            lblDni.Text = "Dni";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(379, 13);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido";
            // 
            // txbApellido
            // 
            txbApellido.Anchor = AnchorStyles.None;
            txbApellido.Location = new Point(445, 9);
            txbApellido.Margin = new Padding(3, 2, 3, 2);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(217, 23);
            txbApellido.TabIndex = 12;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Anchor = AnchorStyles.None;
            dtpFechaNac.Location = new Point(109, 93);
            dtpFechaNac.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNac.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(222, 23);
            dtpFechaNac.TabIndex = 30;
            dtpFechaNac.Value = new DateTime(2024, 8, 29, 0, 0, 0, 0);
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(45, 13);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(394, 182);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 25;
            label2.Text = "Tel";
            // 
            // lblClave
            // 
            lblClave.Anchor = AnchorStyles.None;
            lblClave.AutoSize = true;
            lblClave.Location = new Point(386, 139);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 16;
            lblClave.Text = "Clave";
            // 
            // txbNombre
            // 
            txbNombre.Anchor = AnchorStyles.None;
            txbNombre.Location = new Point(111, 9);
            txbNombre.Margin = new Padding(3, 2, 3, 2);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(217, 23);
            txbNombre.TabIndex = 1;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.None;
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(42, 55);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Direccion";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(47, 182);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 15;
            lblUsuario.Text = "Usuario";
            // 
            // txbCorreo
            // 
            txbCorreo.Anchor = AnchorStyles.None;
            txbCorreo.Location = new Point(111, 178);
            txbCorreo.Margin = new Padding(3, 2, 3, 2);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(217, 23);
            txbCorreo.TabIndex = 14;
            // 
            // txbUsuario
            // 
            txbUsuario.Anchor = AnchorStyles.None;
            txbUsuario.Location = new Point(111, 135);
            txbUsuario.Margin = new Padding(3, 2, 3, 2);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(217, 23);
            txbUsuario.TabIndex = 13;
            // 
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.None;
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(49, 139);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 17;
            lblCorreo.Text = "Correo";
            // 
            // txbDireccion
            // 
            txbDireccion.Anchor = AnchorStyles.None;
            txbDireccion.Location = new Point(111, 51);
            txbDireccion.Margin = new Padding(3, 2, 3, 2);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(217, 23);
            txbDireccion.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 92);
            label3.Name = "label3";
            label3.Size = new Size(65, 26);
            label3.TabIndex = 29;
            label3.Text = "Fecha de Nacimiento";
            // 
            // FormModificarPersona
            // 
            ClientSize = new Size(708, 401);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "FormModificarPersona";
            Text = "Modificar Persona";
            Load += FormModificarPersona_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel4;
        private Button btnCancelar;
        private Button btnAceptar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNuevoUsuario;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txbTelefono;
        private TextBox txbDni;
        private TextBox txbClave;
        private Label lblDni;
        private Label lblApellido;
        private TextBox txbApellido;
        private DateTimePicker dtpFechaNac;
        private Label lblNombre;
        private Label label2;
        private Label lblClave;
        private TextBox txbNombre;
        private Label lblDireccion;
        private Label lblUsuario;
        private TextBox txbCorreo;
        private TextBox txbUsuario;
        private Label lblCorreo;
        private TextBox txbDireccion;
        private Label label3;

        private void btnAceptar_MouseClick(object sender, MouseEventArgs e)
        {
            //VALIDAR LOS CAMPOS

            Persona per = new Persona(PersonaForm.Legajo, txbNombre.Text, txbApellido.Text, txbCorreo.Text, txbTelefono.Text, txbClave.Text, txbUsuario.Text, txbDireccion.Text, txbDni.Text, dtpFechaNac.Value);
            DataPersona dp = new DataPersona();
            if (dp.ModificarPersona(per))
            {
                MessageBox.Show("Cambios guardados exitosamente.");
            }
            else { MessageBox.Show("Ups! Ocurrio un error"); }
        }

        private void FormModificarPersona_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Persona PersonaForm { get; set; }
    }
}