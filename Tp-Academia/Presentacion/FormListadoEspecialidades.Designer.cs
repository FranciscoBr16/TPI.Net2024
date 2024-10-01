namespace Presentacion
{
    partial class FormListadoEspecialidades
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
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            btnNuevaEspecialidad = new Button();
            dgvEspecialidades = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            colBtnModificarEsp = new DataGridViewButtonColumn();
            colBtnEliminarEsp = new DataGridViewButtonColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label1, 1, 0);
            tableLayoutPanel5.Controls.Add(btnNuevaEspecialidad, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1066, 107);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(465, 14);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Especialidades";
            // 
            // btnNuevaEspecialidad
            // 
            btnNuevaEspecialidad.Anchor = AnchorStyles.Bottom;
            btnNuevaEspecialidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaEspecialidad.Location = new Point(452, 77);
            btnNuevaEspecialidad.Name = "btnNuevaEspecialidad";
            btnNuevaEspecialidad.Size = new Size(160, 27);
            btnNuevaEspecialidad.TabIndex = 1;
            btnNuevaEspecialidad.Text = "Agregar Especialidad";
            btnNuevaEspecialidad.UseVisualStyleBackColor = true;
            btnNuevaEspecialidad.Click += btnNuevaEspecialidad_Click;
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.Anchor = AnchorStyles.Top;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, colBtnModificarEsp, colBtnEliminarEsp });
            dgvEspecialidades.Location = new Point(109, 2);
            dgvEspecialidades.Margin = new Padding(3, 2, 3, 2);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.Size = new Size(846, 245);
            dgvEspecialidades.TabIndex = 8;
            dgvEspecialidades.CellMouseClick += dgvEspecialidades_CellMouseClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id Especialidad";
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
            // colBtnModificarEsp
            // 
            colBtnModificarEsp.HeaderText = "";
            colBtnModificarEsp.MinimumWidth = 6;
            colBtnModificarEsp.Name = "colBtnModificarEsp";
            colBtnModificarEsp.ReadOnly = true;
            colBtnModificarEsp.Text = "Modificar";
            colBtnModificarEsp.UseColumnTextForButtonValue = true;
            colBtnModificarEsp.Width = 125;
            // 
            // colBtnEliminarEsp
            // 
            colBtnEliminarEsp.HeaderText = "";
            colBtnEliminarEsp.MinimumWidth = 6;
            colBtnEliminarEsp.Name = "colBtnEliminarEsp";
            colBtnEliminarEsp.ReadOnly = true;
            colBtnEliminarEsp.Text = "Eliminar";
            colBtnEliminarEsp.UseColumnTextForButtonValue = true;
            colBtnEliminarEsp.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(dgvEspecialidades, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 107);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1066, 266);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // FormListadoEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1066, 383);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Name = "FormListadoEspecialidades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado especialidades";
            WindowState = FormWindowState.Maximized;
            Load += FormListadoEspecialidades_Load;
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private Button btnNuevaEspecialidad;
        private DataGridView dgvEspecialidades;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewButtonColumn colBtnModificarEsp;
        private DataGridViewButtonColumn colBtnEliminarEsp;
    }
}