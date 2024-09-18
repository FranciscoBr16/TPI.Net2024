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
            colBtnModificarCom = new DataGridViewButtonColumn();
            colBtnEliminarCom = new DataGridViewButtonColumn();
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
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1218, 143);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(525, 19);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 0;
            label1.Text = "Especialidades";
            // 
            // btnNuevaEspecialidad
            // 
            btnNuevaEspecialidad.Anchor = AnchorStyles.Bottom;
            btnNuevaEspecialidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaEspecialidad.Location = new Point(517, 103);
            btnNuevaEspecialidad.Margin = new Padding(3, 4, 3, 4);
            btnNuevaEspecialidad.Name = "btnNuevaEspecialidad";
            btnNuevaEspecialidad.Size = new Size(183, 36);
            btnNuevaEspecialidad.TabIndex = 1;
            btnNuevaEspecialidad.Text = "Agregar Especialidad";
            btnNuevaEspecialidad.UseVisualStyleBackColor = true;
            btnNuevaEspecialidad.Click += btnNuevaEspecialidad_Click;
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.Anchor = AnchorStyles.Top;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, colBtnModificarCom, colBtnEliminarCom });
            dgvEspecialidades.Location = new Point(124, 3);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.Size = new Size(968, 327);
            dgvEspecialidades.TabIndex = 8;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(dgvEspecialidades, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 143);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1218, 355);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // FormListadoEspecialidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1218, 511);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Margin = new Padding(3, 4, 3, 4);
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewButtonColumn colBtnModificarCom;
        private DataGridViewButtonColumn colBtnEliminarCom;
        private TableLayoutPanel tableLayoutPanel1;
    }
}