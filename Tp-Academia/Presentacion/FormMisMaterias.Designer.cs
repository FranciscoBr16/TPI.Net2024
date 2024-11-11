namespace Presentacion
{
    partial class FormMisMaterias
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
            dgvCursos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            cupo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            IdMateria = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Comision = new DataGridViewTextBoxColumn();
            Contador = new DataGridViewTextBoxColumn();
            colBtnAlumnos = new DataGridViewButtonColumn();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblCursos = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(dgvCursos, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 151);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1152, 499);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // dgvCursos
            // 
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Columns.AddRange(new DataGridViewColumn[] { Id, cupo, Fecha, IdMateria, Materia, Comision, Contador, colBtnAlumnos });
            dgvCursos.Dock = DockStyle.Top;
            dgvCursos.Location = new Point(60, 3);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.Size = new Size(1030, 456);
            dgvCursos.TabIndex = 8;
            dgvCursos.CellMouseClick += dgvCursos_CellMouseClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            // 
            // cupo
            // 
            cupo.DataPropertyName = "Cupo";
            cupo.HeaderText = "Cupo";
            cupo.MinimumWidth = 6;
            cupo.Name = "cupo";
            cupo.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha_Vencimiento_Inscripcion";
            Fecha.HeaderText = "Fecha Vencimiento";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // IdMateria
            // 
            IdMateria.DataPropertyName = "MateriaId";
            IdMateria.HeaderText = "Id Materia";
            IdMateria.MinimumWidth = 6;
            IdMateria.Name = "IdMateria";
            IdMateria.ReadOnly = true;
            // 
            // Materia
            // 
            Materia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Materia.DataPropertyName = "MateriaDescripcion";
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 6;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            Materia.Width = 89;
            // 
            // Comision
            // 
            Comision.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Comision.DataPropertyName = "ComisionDescripcion";
            Comision.HeaderText = "Comision";
            Comision.MinimumWidth = 6;
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // Contador
            // 
            Contador.DataPropertyName = "contador";
            Contador.HeaderText = "Cantidad de Alumnos Inscriptos";
            Contador.MinimumWidth = 6;
            Contador.Name = "Contador";
            Contador.ReadOnly = true;
            // 
            // colBtnAlumnos
            // 
            colBtnAlumnos.HeaderText = "";
            colBtnAlumnos.MinimumWidth = 6;
            colBtnAlumnos.Name = "colBtnAlumnos";
            colBtnAlumnos.ReadOnly = true;
            colBtnAlumnos.Text = "Ver Alumnos";
            colBtnAlumnos.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(lblCursos, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1152, 151);
            tableLayoutPanel5.TabIndex = 12;
            // 
            // lblCursos
            // 
            lblCursos.Anchor = AnchorStyles.None;
            lblCursos.AutoSize = true;
            lblCursos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCursos.Location = new Point(511, 21);
            lblCursos.Name = "lblCursos";
            lblCursos.Size = new Size(130, 32);
            lblCursos.TabIndex = 0;
            lblCursos.Text = "Mis Cursos";
            // 
            // FormMisMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 908);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMisMaterias";
            Text = "Mis Materias";
            WindowState = FormWindowState.Maximized;
            Load += FormMisMaterias_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvCursos;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblCursos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn cupo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn IdMateria;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Comision;
        private DataGridViewTextBoxColumn Contador;
        private DataGridViewButtonColumn colBtnAlumnos;
    }
}