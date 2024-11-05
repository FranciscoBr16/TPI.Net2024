namespace Presentacion
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
            btnInscripciones = new Button();
            btnNotas = new Button();
            btnCursos = new Button();
            btnCerrarSesion = new Button();
            btnModificar = new Button();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1104, 160);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 16F);
            lblNombre.Location = new Point(455, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 30);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Left;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 16F);
            lblApellido.Location = new Point(555, 64);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(93, 30);
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
            tableLayoutPanel2.Location = new Point(0, 160);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1104, 212);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // txbFechaNac
            // 
            txbFechaNac.Anchor = AnchorStyles.Left;
            txbFechaNac.Location = new Point(313, 51);
            txbFechaNac.Margin = new Padding(3, 2, 3, 2);
            txbFechaNac.Name = "txbFechaNac";
            txbFechaNac.ReadOnly = true;
            txbFechaNac.Size = new Size(214, 23);
            txbFechaNac.TabIndex = 38;
            // 
            // txbPlan
            // 
            txbPlan.Anchor = AnchorStyles.Left;
            txbPlan.Location = new Point(639, 51);
            txbPlan.Margin = new Padding(3, 2, 3, 2);
            txbPlan.Name = "txbPlan";
            txbPlan.ReadOnly = true;
            txbPlan.Size = new Size(214, 23);
            txbPlan.TabIndex = 38;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(250, 13);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Direccion";
            // 
            // txbDireccion
            // 
            txbDireccion.Anchor = AnchorStyles.Left;
            txbDireccion.Location = new Point(313, 9);
            txbDireccion.Margin = new Padding(3, 2, 3, 2);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.ReadOnly = true;
            txbDireccion.Size = new Size(214, 23);
            txbDireccion.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(242, 50);
            label4.Name = "label4";
            label4.Size = new Size(65, 26);
            label4.TabIndex = 29;
            label4.Text = "Fecha de Nacimiento";
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(608, 13);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(25, 15);
            lblDni.TabIndex = 27;
            lblDni.Text = "Dni";
            // 
            // txbDni
            // 
            txbDni.Anchor = AnchorStyles.Left;
            txbDni.Location = new Point(639, 9);
            txbDni.Margin = new Padding(3, 2, 3, 2);
            txbDni.Name = "txbDni";
            txbDni.ReadOnly = true;
            txbDni.Size = new Size(214, 23);
            txbDni.TabIndex = 26;
            // 
            // lblPlan
            // 
            lblPlan.Anchor = AnchorStyles.Right;
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(603, 55);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 31;
            lblPlan.Text = "Plan";
            // 
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.Right;
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(264, 97);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 17;
            lblCorreo.Text = "Correo";
            // 
            // txbCorreo
            // 
            txbCorreo.Anchor = AnchorStyles.Left;
            txbCorreo.Location = new Point(313, 93);
            txbCorreo.Margin = new Padding(3, 2, 3, 2);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.ReadOnly = true;
            txbCorreo.Size = new Size(214, 23);
            txbCorreo.TabIndex = 14;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(260, 139);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 15;
            lblUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            txbUsuario.Anchor = AnchorStyles.Left;
            txbUsuario.Location = new Point(313, 135);
            txbUsuario.Margin = new Padding(3, 2, 3, 2);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.ReadOnly = true;
            txbUsuario.Size = new Size(214, 23);
            txbUsuario.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(612, 97);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 25;
            label3.Text = "Tel";
            // 
            // txbTelefono
            // 
            txbTelefono.Anchor = AnchorStyles.Left;
            txbTelefono.Location = new Point(639, 93);
            txbTelefono.Margin = new Padding(3, 2, 3, 2);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.ReadOnly = true;
            txbTelefono.Size = new Size(214, 23);
            txbTelefono.TabIndex = 24;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Controls.Add(btnInscripciones, 1, 0);
            tableLayoutPanel3.Controls.Add(btnNotas, 1, 1);
            tableLayoutPanel3.Controls.Add(btnCursos, 1, 2);
            tableLayoutPanel3.Controls.Add(btnCerrarSesion, 1, 4);
            tableLayoutPanel3.Controls.Add(btnModificar, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 372);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992046F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0032F));
            tableLayoutPanel3.Size = new Size(1104, 181);
            tableLayoutPanel3.TabIndex = 38;
            // 
            // btnInscripciones
            // 
            btnInscripciones.Anchor = AnchorStyles.None;
            btnInscripciones.Location = new Point(472, 4);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(157, 28);
            btnInscripciones.TabIndex = 0;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.UseVisualStyleBackColor = true;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // btnNotas
            // 
            btnNotas.Anchor = AnchorStyles.None;
            btnNotas.Location = new Point(472, 40);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(157, 28);
            btnNotas.TabIndex = 1;
            btnNotas.Text = "Mis Notas";
            btnNotas.UseVisualStyleBackColor = true;
            // 
            // btnCursos
            // 
            btnCursos.Anchor = AnchorStyles.None;
            btnCursos.Location = new Point(472, 76);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(157, 28);
            btnCursos.TabIndex = 2;
            btnCursos.Text = "Mis Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.None;
            btnCerrarSesion.Location = new Point(472, 148);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(157, 28);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.Location = new Point(472, 112);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(157, 28);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar Perfil";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 576);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
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
        private Button btnInscripciones;
        private Button btnNotas;
        private Button btnCursos;
        private Button btnCerrarSesion;
        private Button btnModificar;
    }
}