namespace Presentacion
{
    partial class FormAlumnosDelCurso
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
            dgvAlumnos = new DataGridView();
            IdInscripcion = new DataGridViewTextBoxColumn();
            colLegajo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            Condicion = new DataGridViewTextBoxColumn();
            colBtnModificar = new DataGridViewButtonColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblAlumnos = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.Controls.Add(dgvAlumnos, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 139);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1152, 533);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.Anchor = AnchorStyles.Top;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { IdInscripcion, colLegajo, colNombre, colApellido, Correo, Nota, Condicion, colBtnModificar });
            dgvAlumnos.Location = new Point(26, 3);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(1098, 527);
            dgvAlumnos.TabIndex = 3;
            dgvAlumnos.CellClick += dgvAlumnos_CellClick;
            // 
            // IdInscripcion
            // 
            IdInscripcion.DataPropertyName = "Id";
            IdInscripcion.HeaderText = "Id Inscripcion";
            IdInscripcion.MinimumWidth = 6;
            IdInscripcion.Name = "IdInscripcion";
            IdInscripcion.ReadOnly = true;
            IdInscripcion.Width = 125;
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
            // Correo
            // 
            Correo.DataPropertyName = "Mail";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 125;
            // 
            // Nota
            // 
            Nota.DataPropertyName = "Nota";
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 6;
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
            Nota.Width = 125;
            // 
            // Condicion
            // 
            Condicion.DataPropertyName = "Condicion";
            Condicion.HeaderText = "Condicion";
            Condicion.MinimumWidth = 6;
            Condicion.Name = "Condicion";
            Condicion.ReadOnly = true;
            Condicion.Width = 125;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblAlumnos, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel4.Size = new Size(1152, 139);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // lblAlumnos
            // 
            lblAlumnos.Anchor = AnchorStyles.None;
            lblAlumnos.AutoSize = true;
            lblAlumnos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlumnos.Location = new Point(522, 40);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(108, 32);
            lblAlumnos.TabIndex = 0;
            lblAlumnos.Text = "Alumnos";
            // 
            // FormAlumnosDelCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 908);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAlumnosDelCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumnos";
            Load += FormAlumnosDelCurso_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvAlumnos;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblAlumnos;
        private DataGridViewTextBoxColumn IdInscripcion;
        private DataGridViewTextBoxColumn colLegajo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Nota;
        private DataGridViewTextBoxColumn Condicion;
        private DataGridViewButtonColumn colBtnModificar;
    }
}