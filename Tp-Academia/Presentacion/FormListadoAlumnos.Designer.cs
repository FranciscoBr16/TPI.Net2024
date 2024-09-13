namespace Presentacion
{
    partial class FormListadoAlumnos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1330, 62);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // lblAlumnos
            // 
            lblAlumnos.Anchor = AnchorStyles.None;
            lblAlumnos.AutoSize = true;
            lblAlumnos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlumnos.Location = new Point(621, 18);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(86, 25);
            lblAlumnos.TabIndex = 0;
            lblAlumnos.Text = "Alumnos";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.Anchor = AnchorStyles.Top;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { colLegajo, colNombre, colApellido, colUsuario, colDireccion, colCorreo, colAnioIngreso, colBtnModificar, colBtnEliminar });
            dgvAlumnos.Location = new Point(57, 2);
            dgvAlumnos.Margin = new Padding(3, 2, 3, 2);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(1176, 396);
            dgvAlumnos.TabIndex = 3;
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
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            colAnioIngreso.DefaultCellStyle = dataGridViewCellStyle1;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.Controls.Add(dgvAlumnos, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 69);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1293, 400);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // FormListadoAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 710);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormListadoAlumnos";
            Text = "FormListadoAlumnos";
            Load += FormListadoAlumnos_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private Label lblAlumnos;
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}