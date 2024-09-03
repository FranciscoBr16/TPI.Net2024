namespace Presentacion
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelppal = new Panel();
            tabControl1 = new TabControl();
            tabInicio = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            btnRegistrarse = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblTextoInicioLargo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            imgUTN = new PictureBox();
            lblBienvenida = new Label();
            tabAlumnos = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblAlumnos = new Label();
            dgvAlumnos = new DataGridView();
            colLegajo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colAnioIngreso = new DataGridViewTextBoxColumn();
            colBtnModificar = new DataGridViewButtonColumn();
            colBtnEliminar = new DataGridViewButtonColumn();
            tabProfesores = new TabPage();
            tabEspecialidades = new TabPage();
            tabPlanes = new TabPage();
            tabMaterias = new TabPage();
            tabComisiones = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            dgvComisiones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            colBtnModificarCom = new DataGridViewButtonColumn();
            colBtnEliminarCom = new DataGridViewButtonColumn();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            btnNuevaComision = new Button();
            tabCursos = new TabPage();
            tabPerfil = new TabPage();
            panelppal.SuspendLayout();
            tabControl1.SuspendLayout();
            tabInicio.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUTN).BeginInit();
            tabAlumnos.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            tabComisiones.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panelppal
            // 
            panelppal.Controls.Add(tabControl1);
            panelppal.Dock = DockStyle.Fill;
            panelppal.Location = new Point(0, 0);
            panelppal.Margin = new Padding(3, 2, 3, 2);
            panelppal.Name = "panelppal";
            panelppal.Size = new Size(1264, 681);
            panelppal.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInicio);
            tabControl1.Controls.Add(tabAlumnos);
            tabControl1.Controls.Add(tabProfesores);
            tabControl1.Controls.Add(tabEspecialidades);
            tabControl1.Controls.Add(tabPlanes);
            tabControl1.Controls.Add(tabMaterias);
            tabControl1.Controls.Add(tabComisiones);
            tabControl1.Controls.Add(tabCursos);
            tabControl1.Controls.Add(tabPerfil);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1264, 681);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabInicio
            // 
            tabInicio.Controls.Add(tableLayoutPanel2);
            tabInicio.Controls.Add(tableLayoutPanel3);
            tabInicio.Controls.Add(tableLayoutPanel1);
            tabInicio.Location = new Point(4, 24);
            tabInicio.Name = "tabInicio";
            tabInicio.Padding = new Padding(3);
            tabInicio.Size = new Size(1256, 653);
            tabInicio.TabIndex = 0;
            tabInicio.Text = "Inicio";
            tabInicio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button2, 2, 0);
            tableLayoutPanel2.Controls.Add(btnRegistrarse, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 371);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.4F));
            tableLayoutPanel2.Size = new Size(1262, 49);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(726, 2);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(122, 26);
            button2.TabIndex = 1;
            button2.Text = "Iniciar Sesión";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Anchor = AnchorStyles.Top;
            btnRegistrarse.Location = new Point(411, 2);
            btnRegistrarse.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(122, 26);
            btnRegistrarse.TabIndex = 0;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += button1_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(lblTextoInicioLargo, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 197);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1258, 155);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // lblTextoInicioLargo
            // 
            lblTextoInicioLargo.Anchor = AnchorStyles.Top;
            lblTextoInicioLargo.AutoSize = true;
            lblTextoInicioLargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoInicioLargo.Location = new Point(260, 0);
            lblTextoInicioLargo.Name = "lblTextoInicioLargo";
            lblTextoInicioLargo.Size = new Size(735, 105);
            lblTextoInicioLargo.TabIndex = 0;
            lblTextoInicioLargo.Text = resources.GetString("lblTextoInicioLargo.Text");
            lblTextoInicioLargo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(imgUTN, 1, 0);
            tableLayoutPanel1.Controls.Add(lblBienvenida, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1262, 182);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // imgUTN
            // 
            imgUTN.Anchor = AnchorStyles.None;
            imgUTN.Image = Properties.Resources.image;
            imgUTN.Location = new Point(549, 18);
            imgUTN.Margin = new Padding(3, 2, 3, 2);
            imgUTN.Name = "imgUTN";
            imgUTN.Size = new Size(162, 54);
            imgUTN.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUTN.TabIndex = 0;
            imgUTN.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(507, 111);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(246, 51);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "¡Bienvenidos!";
            // 
            // tabAlumnos
            // 
            tabAlumnos.Controls.Add(tableLayoutPanel4);
            tabAlumnos.Controls.Add(dgvAlumnos);
            tabAlumnos.Location = new Point(4, 24);
            tabAlumnos.Name = "tabAlumnos";
            tabAlumnos.Padding = new Padding(3);
            tabAlumnos.Size = new Size(1256, 653);
            tabAlumnos.TabIndex = 1;
            tabAlumnos.Text = "Alumnos";
            tabAlumnos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblAlumnos, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1250, 62);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // lblAlumnos
            // 
            lblAlumnos.Anchor = AnchorStyles.None;
            lblAlumnos.AutoSize = true;
            lblAlumnos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlumnos.Location = new Point(581, 18);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(86, 25);
            lblAlumnos.TabIndex = 0;
            lblAlumnos.Text = "Alumnos";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { colLegajo, colNombre, colApellido, colUsuario, colDireccion, colCorreo, colAnioIngreso, colBtnModificar, colBtnEliminar });
            dgvAlumnos.Location = new Point(2, 70);
            dgvAlumnos.Margin = new Padding(3, 2, 3, 2);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(1254, 470);
            dgvAlumnos.TabIndex = 1;
            dgvAlumnos.CellMouseClick += dgvAlumnos_CellMouseClick;
            // 
            // colLegajo
            // 
            colLegajo.DataPropertyName = "Legajo";
            colLegajo.HeaderText = "Legajo";
            colLegajo.MinimumWidth = 6;
            colLegajo.Name = "colLegajo";
            colLegajo.ReadOnly = true;
            colLegajo.Width = 125;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 125;
            // 
            // colApellido
            // 
            colApellido.DataPropertyName = "Apellido";
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            colApellido.Width = 125;
            // 
            // colUsuario
            // 
            colUsuario.DataPropertyName = "Usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            colUsuario.Width = 125;
            // 
            // colDireccion
            // 
            colDireccion.DataPropertyName = "Direccion";
            colDireccion.HeaderText = "Direccion";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            colDireccion.Width = 125;
            // 
            // colCorreo
            // 
            colCorreo.DataPropertyName = "Mail";
            colCorreo.HeaderText = "Correo";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            colCorreo.Width = 125;
            // 
            // colAnioIngreso
            // 
            colAnioIngreso.DataPropertyName = "Fecha_ingreso";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            colAnioIngreso.DefaultCellStyle = dataGridViewCellStyle2;
            colAnioIngreso.HeaderText = "Año Ingreso";
            colAnioIngreso.MinimumWidth = 6;
            colAnioIngreso.Name = "colAnioIngreso";
            colAnioIngreso.Width = 125;
            // 
            // colBtnModificar
            // 
            colBtnModificar.HeaderText = "";
            colBtnModificar.MinimumWidth = 6;
            colBtnModificar.Name = "colBtnModificar";
            colBtnModificar.ReadOnly = true;
            colBtnModificar.Text = "Modificar";
            colBtnModificar.UseColumnTextForButtonValue = true;
            colBtnModificar.Width = 125;
            // 
            // colBtnEliminar
            // 
            colBtnEliminar.HeaderText = "";
            colBtnEliminar.MinimumWidth = 6;
            colBtnEliminar.Name = "colBtnEliminar";
            colBtnEliminar.ReadOnly = true;
            colBtnEliminar.Text = "Eliminar";
            colBtnEliminar.UseColumnTextForButtonValue = true;
            colBtnEliminar.Width = 125;
            // 
            // tabProfesores
            // 
            tabProfesores.Location = new Point(4, 24);
            tabProfesores.Name = "tabProfesores";
            tabProfesores.Padding = new Padding(3);
            tabProfesores.Size = new Size(1256, 653);
            tabProfesores.TabIndex = 2;
            tabProfesores.Text = "Profesores";
            tabProfesores.UseVisualStyleBackColor = true;
            // 
            // tabEspecialidades
            // 
            tabEspecialidades.Location = new Point(4, 24);
            tabEspecialidades.Name = "tabEspecialidades";
            tabEspecialidades.Padding = new Padding(3);
            tabEspecialidades.Size = new Size(1256, 653);
            tabEspecialidades.TabIndex = 3;
            tabEspecialidades.Text = "Especialidades";
            tabEspecialidades.UseVisualStyleBackColor = true;
            // 
            // tabPlanes
            // 
            tabPlanes.Location = new Point(4, 24);
            tabPlanes.Name = "tabPlanes";
            tabPlanes.Padding = new Padding(3);
            tabPlanes.Size = new Size(1256, 653);
            tabPlanes.TabIndex = 4;
            tabPlanes.Text = "Planes";
            tabPlanes.UseVisualStyleBackColor = true;
            // 
            // tabMaterias
            // 
            tabMaterias.Location = new Point(4, 24);
            tabMaterias.Name = "tabMaterias";
            tabMaterias.Size = new Size(1256, 653);
            tabMaterias.TabIndex = 5;
            tabMaterias.Text = "Materias";
            tabMaterias.UseVisualStyleBackColor = true;
            // 
            // tabComisiones
            // 
            tabComisiones.Controls.Add(tableLayoutPanel6);
            tabComisiones.Controls.Add(tableLayoutPanel5);
            tabComisiones.Location = new Point(4, 24);
            tabComisiones.Name = "tabComisiones";
            tabComisiones.Size = new Size(1256, 653);
            tabComisiones.TabIndex = 6;
            tabComisiones.Text = "Comisiones";
            tabComisiones.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel6.Controls.Add(dgvComisiones, 1, 0);
            tableLayoutPanel6.Location = new Point(0, 163);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1256, 490);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // dgvComisiones
            // 
            dgvComisiones.Anchor = AnchorStyles.Top;
            dgvComisiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComisiones.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Turno, colBtnModificarCom, colBtnEliminarCom });
            dgvComisiones.Location = new Point(205, 2);
            dgvComisiones.Margin = new Padding(3, 2, 3, 2);
            dgvComisiones.Name = "dgvComisiones";
            dgvComisiones.RowHeadersWidth = 51;
            dgvComisiones.Size = new Size(845, 370);
            dgvComisiones.TabIndex = 3;
            dgvComisiones.CellContentClick += dgvComisiones_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id Comision";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Turno
            // 
            Turno.DataPropertyName = "Turno";
            Turno.HeaderText = "Turno";
            Turno.MinimumWidth = 6;
            Turno.Name = "Turno";
            Turno.ReadOnly = true;
            Turno.Width = 125;
            // 
            // colBtnModificarCom
            // 
            colBtnModificarCom.HeaderText = "";
            colBtnModificarCom.MinimumWidth = 6;
            colBtnModificarCom.Name = "colBtnModificarCom";
            colBtnModificarCom.ReadOnly = true;
            colBtnModificarCom.Text = "Modificar";
            colBtnModificarCom.UseColumnTextForButtonValue = true;
            colBtnModificarCom.Width = 125;
            // 
            // colBtnEliminarCom
            // 
            colBtnEliminarCom.HeaderText = "";
            colBtnEliminarCom.MinimumWidth = 6;
            colBtnEliminarCom.Name = "colBtnEliminarCom";
            colBtnEliminarCom.ReadOnly = true;
            colBtnEliminarCom.Text = "Eliminar";
            colBtnEliminarCom.UseColumnTextForButtonValue = true;
            colBtnEliminarCom.Width = 125;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label1, 1, 0);
            tableLayoutPanel5.Controls.Add(btnNuevaComision, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1256, 136);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(572, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Comisiones";
            // 
            // btnNuevaComision
            // 
            btnNuevaComision.Anchor = AnchorStyles.Bottom;
            btnNuevaComision.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaComision.Location = new Point(547, 106);
            btnNuevaComision.Name = "btnNuevaComision";
            btnNuevaComision.Size = new Size(160, 27);
            btnNuevaComision.TabIndex = 1;
            btnNuevaComision.Text = "Agregar Comision";
            btnNuevaComision.UseVisualStyleBackColor = true;
            btnNuevaComision.Click += btnNuevaComision_Click;
            // 
            // tabCursos
            // 
            tabCursos.Location = new Point(4, 24);
            tabCursos.Name = "tabCursos";
            tabCursos.Size = new Size(1256, 653);
            tabCursos.TabIndex = 7;
            tabCursos.Text = "Cursos";
            tabCursos.UseVisualStyleBackColor = true;
            // 
            // tabPerfil
            // 
            tabPerfil.Location = new Point(4, 24);
            tabPerfil.Name = "tabPerfil";
            tabPerfil.Size = new Size(1256, 653);
            tabPerfil.TabIndex = 8;
            tabPerfil.Text = "Perfil";
            tabPerfil.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelppal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInicio";
            Text = "UTN | Sistema de la academia";
            panelppal.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUTN).EndInit();
            tabAlumnos.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            tabComisiones.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelppal;
        private Label lblBienvenida;
        private PictureBox imgUTN;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTextoInicioLargo;
        private Button button2;
        private Button btnRegistrarse;
        private TabControl tabControl1;
        private TabPage tabInicio;
        private TabPage tabAlumnos;
        private TabPage tabProfesores;
        private TabPage tabEspecialidades;
        private TabPage tabPlanes;
        private TabPage tabMaterias;
        private TabPage tabComisiones;
        private TabPage tabCursos;
        private TabPage tabPerfil;
        private DataGridView dgvAlumnos;
        private DataGridViewTextBoxColumn colLegajo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colAnioIngreso;
        private DataGridViewButtonColumn colBtnModificar;
        private DataGridViewButtonColumn colBtnEliminar;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblAlumnos;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private DataGridView dgvComisiones;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewButtonColumn colBtnModificarCom;
        private DataGridViewButtonColumn colBtnEliminarCom;
        private Button btnNuevaComision;
    }
}