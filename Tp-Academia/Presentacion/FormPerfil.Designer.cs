﻿namespace Presentacion
{
    partial class FormPerfil
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblNombre = new Label();
            lblApellido = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txbFechaNac = new TextBox();
            txbPlan = new TextBox();
            lblDireccion = new Label();
            txbDireccion = new TextBox();
            label4 = new Label();
            lblDni = new Label();
            txbDni = new TextBox();
            lblPlan = new Label();
            lblCorreo = new Label();
            txbCorreo = new TextBox();
            lblUsuario = new Label();
            txbUsuario = new TextBox();
            label3 = new Label();
            txbTelefono = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnModificar = new Button();
            btnCerrarSesion = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lblNombre, 1, 1);
            tableLayoutPanel1.Controls.Add(lblApellido, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1262, 213);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 16F);
            lblNombre.Location = new Point(512, 86);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(115, 37);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Left;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 16F);
            lblApellido.Location = new Point(633, 86);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(117, 37);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.29166651F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.354166F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.04166663F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.29166651F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.354166F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel2.Controls.Add(txbFechaNac, 2, 1);
            tableLayoutPanel2.Controls.Add(txbPlan, 5, 1);
            tableLayoutPanel2.Controls.Add(lblDireccion, 1, 0);
            tableLayoutPanel2.Controls.Add(txbDireccion, 2, 0);
            tableLayoutPanel2.Controls.Add(label4, 1, 1);
            tableLayoutPanel2.Controls.Add(lblDni, 4, 0);
            tableLayoutPanel2.Controls.Add(txbDni, 5, 0);
            tableLayoutPanel2.Controls.Add(lblPlan, 4, 1);
            tableLayoutPanel2.Controls.Add(lblCorreo, 1, 2);
            tableLayoutPanel2.Controls.Add(txbCorreo, 2, 2);
            tableLayoutPanel2.Controls.Add(lblUsuario, 1, 3);
            tableLayoutPanel2.Controls.Add(txbUsuario, 2, 3);
            tableLayoutPanel2.Controls.Add(label3, 4, 2);
            tableLayoutPanel2.Controls.Add(txbTelefono, 5, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 213);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1262, 283);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // txbFechaNac
            // 
            txbFechaNac.Anchor = AnchorStyles.Left;
            txbFechaNac.Location = new Point(357, 70);
            txbFechaNac.Name = "txbFechaNac";
            txbFechaNac.ReadOnly = true;
            txbFechaNac.Size = new Size(244, 27);
            txbFechaNac.TabIndex = 38;
            // 
            // txbPlan
            // 
            txbPlan.Anchor = AnchorStyles.Left;
            txbPlan.Location = new Point(731, 70);
            txbPlan.Name = "txbPlan";
            txbPlan.ReadOnly = true;
            txbPlan.Size = new Size(244, 27);
            txbPlan.TabIndex = 38;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(279, 18);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Direccion";
            // 
            // txbDireccion
            // 
            txbDireccion.Anchor = AnchorStyles.Left;
            txbDireccion.Location = new Point(357, 14);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.ReadOnly = true;
            txbDireccion.Size = new Size(244, 27);
            txbDireccion.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(277, 67);
            label4.Name = "label4";
            label4.Size = new Size(74, 34);
            label4.TabIndex = 29;
            label4.Text = "Fecha de Nacimiento";
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(693, 18);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 20);
            lblDni.TabIndex = 27;
            lblDni.Text = "Dni";
            // 
            // txbDni
            // 
            txbDni.Anchor = AnchorStyles.Left;
            txbDni.Location = new Point(731, 14);
            txbDni.Name = "txbDni";
            txbDni.ReadOnly = true;
            txbDni.Size = new Size(244, 27);
            txbDni.TabIndex = 26;
            // 
            // lblPlan
            // 
            lblPlan.Anchor = AnchorStyles.Right;
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(688, 74);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(37, 20);
            lblPlan.TabIndex = 31;
            lblPlan.Text = "Plan";
            // 
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.Right;
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(297, 130);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 17;
            lblCorreo.Text = "Correo";
            // 
            // txbCorreo
            // 
            txbCorreo.Anchor = AnchorStyles.Left;
            txbCorreo.Location = new Point(357, 126);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.ReadOnly = true;
            txbCorreo.Size = new Size(244, 27);
            txbCorreo.TabIndex = 14;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(292, 186);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 15;
            lblUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            txbUsuario.Anchor = AnchorStyles.Left;
            txbUsuario.Location = new Point(357, 182);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.ReadOnly = true;
            txbUsuario.Size = new Size(244, 27);
            txbUsuario.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(697, 130);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 25;
            label3.Text = "Tel";
            // 
            // txbTelefono
            // 
            txbTelefono.Anchor = AnchorStyles.Left;
            txbTelefono.Location = new Point(731, 126);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.ReadOnly = true;
            txbTelefono.Size = new Size(244, 27);
            txbTelefono.TabIndex = 24;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Controls.Add(btnModificar, 1, 1);
            tableLayoutPanel3.Controls.Add(btnCerrarSesion, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 496);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992046F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0032F));
            tableLayoutPanel3.Size = new Size(1262, 241);
            tableLayoutPanel3.TabIndex = 38;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.Location = new Point(540, 53);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(179, 37);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar Perfil";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.None;
            btnCerrarSesion.Location = new Point(540, 101);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(179, 37);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 768);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
            WindowState = FormWindowState.Maximized;
            Load += FormPerfil_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNombre;
        private Label lblApellido;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txbTelefono;
        private TextBox txbDni;
        private TextBox txbUsuario;
        private Label lblDni;
        private Label label3;
        private Label lblDireccion;
        private Label lblUsuario;
        private Label lblCorreo;
        private TextBox txbDireccion;
        private Label label4;
        private Label lblPlan;
        private TextBox txbCorreo;
        private TextBox txbFechaNac;
        private TextBox txbPlan;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCerrarSesion;
        private Button btnModificar;
    }
}