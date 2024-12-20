﻿namespace Presentacion
{
    partial class FormListadoCursos
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
            tableLayoutPanel5 = new TableLayoutPanel();
            lblCursos = new Label();
            btnNuevoCurso = new Button();
            Id = new DataGridViewTextBoxColumn();
            cupo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            IdMateria = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            Comision = new DataGridViewTextBoxColumn();
            colBtnModificar = new DataGridViewButtonColumn();
            colBtnEliminar = new DataGridViewButtonColumn();
            ColBtnInscripcion = new DataGridViewButtonColumn();
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
            tableLayoutPanel1.TabIndex = 11;
            // 
            // dgvCursos
            // 
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Columns.AddRange(new DataGridViewColumn[] { Id, cupo, Fecha, IdMateria, Materia, Profesor, Comision, colBtnModificar, colBtnEliminar, ColBtnInscripcion });
            dgvCursos.Dock = DockStyle.Top;
            dgvCursos.Location = new Point(60, 3);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.Size = new Size(1030, 456);
            dgvCursos.TabIndex = 8;
            dgvCursos.CellClick += dgvCursos_CellClick;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(lblCursos, 1, 0);
            tableLayoutPanel5.Controls.Add(btnNuevoCurso, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1152, 151);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // lblCursos
            // 
            lblCursos.Anchor = AnchorStyles.None;
            lblCursos.AutoSize = true;
            lblCursos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCursos.Location = new Point(533, 21);
            lblCursos.Name = "lblCursos";
            lblCursos.Size = new Size(85, 32);
            lblCursos.TabIndex = 0;
            lblCursos.Text = "Cursos";
            // 
            // btnNuevoCurso
            // 
            btnNuevoCurso.Anchor = AnchorStyles.None;
            btnNuevoCurso.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoCurso.Location = new Point(484, 95);
            btnNuevoCurso.Margin = new Padding(3, 4, 3, 4);
            btnNuevoCurso.Name = "btnNuevoCurso";
            btnNuevoCurso.Size = new Size(183, 36);
            btnNuevoCurso.TabIndex = 1;
            btnNuevoCurso.Text = "Agregar Curso";
            btnNuevoCurso.UseVisualStyleBackColor = true;
            btnNuevoCurso.Click += btnNuevoCurso_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            Id.Width = 51;
            // 
            // cupo
            // 
            cupo.DataPropertyName = "Cupo";
            cupo.HeaderText = "Cupo";
            cupo.MinimumWidth = 6;
            cupo.Name = "cupo";
            cupo.ReadOnly = true;
            cupo.Width = 73;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha_Vencimiento_Inscripcion";
            Fecha.HeaderText = "Fecha Vencimiento";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 148;
            // 
            // IdMateria
            // 
            IdMateria.DataPropertyName = "MateriaId";
            IdMateria.HeaderText = "Id Materia";
            IdMateria.MinimumWidth = 6;
            IdMateria.Name = "IdMateria";
            IdMateria.ReadOnly = true;
            IdMateria.Width = 98;
            // 
            // Materia
            // 
            Materia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Materia.DataPropertyName = "MateriaDescripcion";
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 6;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Profesor
            // 
            Profesor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Profesor.DataPropertyName = "NombreProfesorTeoria";
            Profesor.HeaderText = "Profesor";
            Profesor.MinimumWidth = 6;
            Profesor.Name = "Profesor";
            Profesor.ReadOnly = true;
            Profesor.Width = 93;
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
            // ColBtnInscripcion
            // 
            ColBtnInscripcion.HeaderText = "";
            ColBtnInscripcion.MinimumWidth = 6;
            ColBtnInscripcion.Name = "ColBtnInscripcion";
            ColBtnInscripcion.ReadOnly = true;
            ColBtnInscripcion.Text = "Inscribirse";
            ColBtnInscripcion.UseColumnTextForButtonValue = true;
            ColBtnInscripcion.Width = 24;
            // 
            // FormListadoCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 908);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormListadoCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cursos";
            WindowState = FormWindowState.Maximized;
            Load += FormListadoCursos_Load;
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
        private Button btnNuevoCurso;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn cupo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn IdMateria;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Profesor;
        private DataGridViewTextBoxColumn Comision;
        private DataGridViewButtonColumn colBtnModificar;
        private DataGridViewButtonColumn colBtnEliminar;
        private DataGridViewButtonColumn ColBtnInscripcion;
    }
}