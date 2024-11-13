namespace Presentacion
{
    partial class FormListadoProfesores
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
            tableLayoutPanel4 = new TableLayoutPanel();
            lblProfesor = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvProfesores = new DataGridView();
            colLegajo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colBtnModificar = new DataGridViewButtonColumn();
            colBtnEliminar = new DataGridViewButtonColumn();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblProfesor, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1341, 83);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // lblProfesor
            // 
            lblProfesor.Anchor = AnchorStyles.None;
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfesor.Location = new Point(608, 25);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(125, 32);
            lblProfesor.TabIndex = 0;
            lblProfesor.Text = "Profesores";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.Controls.Add(dgvProfesores, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1341, 532);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // dgvProfesores
            // 
            dgvProfesores.Anchor = AnchorStyles.Top;
            dgvProfesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Columns.AddRange(new DataGridViewColumn[] { colLegajo, colNombre, colApellido, colUsuario, colDireccion, colCorreo, colBtnModificar, colBtnEliminar });
            dgvProfesores.Location = new Point(68, 3);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.RowHeadersWidth = 51;
            dgvProfesores.Size = new Size(1203, 526);
            dgvProfesores.TabIndex = 3;
            dgvProfesores.CellContentClick += dgvProfesores_CellMouseClick;
            // 
            // colLegajo
            // 
            colLegajo.DataPropertyName = "Legajo";
            colLegajo.HeaderText = "Legajo";
            colLegajo.MinimumWidth = 6;
            colLegajo.Name = "colLegajo";
            colLegajo.ReadOnly = true;
            colLegajo.Width = 83;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colApellido.DataPropertyName = "Apellido";
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colUsuario
            // 
            colUsuario.DataPropertyName = "Usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            colUsuario.Width = 88;
            // 
            // colDireccion
            // 
            colDireccion.DataPropertyName = "Direccion";
            colDireccion.HeaderText = "Direccion";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            colDireccion.Width = 101;
            // 
            // colCorreo
            // 
            colCorreo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCorreo.DataPropertyName = "Mail";
            colCorreo.HeaderText = "Correo";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            // 
            // colBtnModificar
            // 
            colBtnModificar.HeaderText = "";
            colBtnModificar.MinimumWidth = 6;
            colBtnModificar.Name = "colBtnModificar";
            colBtnModificar.ReadOnly = true;
            colBtnModificar.Text = "Modificar";
            colBtnModificar.UseColumnTextForButtonValue = true;
            colBtnModificar.Width = 24;
            // 
            // colBtnEliminar
            // 
            colBtnEliminar.HeaderText = "";
            colBtnEliminar.MinimumWidth = 6;
            colBtnEliminar.Name = "colBtnEliminar";
            colBtnEliminar.ReadOnly = true;
            colBtnEliminar.Text = "Eliminar";
            colBtnEliminar.UseColumnTextForButtonValue = true;
            colBtnEliminar.Width = 24;
            // 
            // FormListadoProfesores
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1341, 619);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormListadoProfesores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profesores";
            WindowState = FormWindowState.Maximized;
            Load += FormListadoProfesores_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private Label lblProfesor;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvProfesores;
        private DataGridViewTextBoxColumn colLegajo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewButtonColumn colBtnModificar;
        private DataGridViewButtonColumn colBtnEliminar;
    }
}