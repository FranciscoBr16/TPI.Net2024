namespace Presentacion
{
    partial class FormMisCursos
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
            IdMateria = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            Comision = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Condicion = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblCursos = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnBaja = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(0, 123);
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
            dgvCursos.Columns.AddRange(new DataGridViewColumn[] { IdMateria, Materia, Profesor, Comision, Fecha, Condicion, Nota });
            dgvCursos.Dock = DockStyle.Top;
            dgvCursos.Location = new Point(60, 3);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.Size = new Size(1030, 456);
            dgvCursos.TabIndex = 8;
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
            // Profesor
            // 
            Profesor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Profesor.DataPropertyName = "NombreProfesor";
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
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha de Inscripcion";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Condicion
            // 
            Condicion.DataPropertyName = "Condicion";
            Condicion.HeaderText = "Condicion";
            Condicion.MinimumWidth = 6;
            Condicion.Name = "Condicion";
            Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            Nota.DataPropertyName = "Nota";
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 6;
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
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
            tableLayoutPanel5.Size = new Size(1152, 123);
            tableLayoutPanel5.TabIndex = 12;
            // 
            // lblCursos
            // 
            lblCursos.Anchor = AnchorStyles.None;
            lblCursos.AutoSize = true;
            lblCursos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCursos.Location = new Point(511, 14);
            lblCursos.Name = "lblCursos";
            lblCursos.Size = new Size(130, 32);
            lblCursos.TabIndex = 0;
            lblCursos.Text = "Mis Cursos";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnBaja, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 622);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1152, 133);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(771, 4);
            btnBaja.Margin = new Padding(3, 4, 3, 4);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(174, 37);
            btnBaja.TabIndex = 0;
            btnBaja.Text = "Darse de Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // FormMisCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 908);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMisCursos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mis Cursos";
            WindowState = FormWindowState.Maximized;
            Load += FormMisCursos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvCursos;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblCursos;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnBaja;
        private DataGridViewTextBoxColumn IdMateria;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Profesor;
        private DataGridViewTextBoxColumn Comision;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Condicion;
        private DataGridViewTextBoxColumn Nota;
    }
}