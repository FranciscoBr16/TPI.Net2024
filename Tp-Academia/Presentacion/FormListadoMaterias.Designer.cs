namespace Presentacion
{
    partial class FormListadoMaterias
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
            dgvMaterias = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblMaterias = new Label();
            btnNuevaMateria = new Button();
            Id_materia = new DataGridViewTextBoxColumn();
            Horas_semanales = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Id_Plan = new DataGridViewTextBoxColumn();
            colBtnModificarCom = new DataGridViewButtonColumn();
            colBtnEliminarCom = new DataGridViewButtonColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(dgvMaterias, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 107);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(996, 340);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvMaterias
            // 
            dgvMaterias.Anchor = AnchorStyles.Top;
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Columns.AddRange(new DataGridViewColumn[] { Id_materia, Horas_semanales, Nombre, Descripcion, Id_Plan, colBtnModificarCom, colBtnEliminarCom });
            dgvMaterias.Location = new Point(79, 2);
            dgvMaterias.Margin = new Padding(3, 2, 3, 2);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.RowHeadersWidth = 51;
            dgvMaterias.Size = new Size(836, 306);
            dgvMaterias.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(lblMaterias, 1, 0);
            tableLayoutPanel5.Controls.Add(btnNuevaMateria, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(996, 107);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // lblMaterias
            // 
            lblMaterias.Anchor = AnchorStyles.None;
            lblMaterias.AutoSize = true;
            lblMaterias.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaterias.Location = new Point(455, 14);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new Size(85, 25);
            lblMaterias.TabIndex = 0;
            lblMaterias.Text = "Materias";
            // 
            // btnNuevaMateria
            // 
            btnNuevaMateria.Anchor = AnchorStyles.Bottom;
            btnNuevaMateria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaMateria.Location = new Point(418, 77);
            btnNuevaMateria.Name = "btnNuevaMateria";
            btnNuevaMateria.Size = new Size(160, 27);
            btnNuevaMateria.TabIndex = 1;
            btnNuevaMateria.Text = "Agregar Materia";
            btnNuevaMateria.UseVisualStyleBackColor = true;
            // 
            // Id_materia
            // 
            Id_materia.DataPropertyName = "Id";
            Id_materia.HeaderText = "Id";
            Id_materia.Name = "Id_materia";
            Id_materia.ReadOnly = true;
            // 
            // Horas_semanales
            // 
            Horas_semanales.DataPropertyName = "CantHorasSemanales";
            Horas_semanales.HeaderText = "Horas semanales";
            Horas_semanales.Name = "Horas_semanales";
            Horas_semanales.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Id_Plan
            // 
            Id_Plan.DataPropertyName = "PlanId";
            Id_Plan.HeaderText = "Id Plan";
            Id_Plan.Name = "Id_Plan";
            Id_Plan.ReadOnly = true;
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
            // FormListadoMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 590);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Name = "FormListadoMaterias";
            Text = "FormListadoMaterias";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvMaterias;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblMaterias;
        private Button btnNuevaMateria;
        private DataGridViewTextBoxColumn Id_materia;
        private DataGridViewTextBoxColumn Horas_semanales;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Id_Plan;
        private DataGridViewButtonColumn colBtnModificarCom;
        private DataGridViewButtonColumn colBtnEliminarCom;
    }
}