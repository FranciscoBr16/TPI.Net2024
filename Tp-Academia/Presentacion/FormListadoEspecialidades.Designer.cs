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
            dgvComisiones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Planes = new DataGridViewTextBoxColumn();
            colBtnModificarCom = new DataGridViewButtonColumn();
            colBtnEliminarCom = new DataGridViewButtonColumn();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).BeginInit();
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
            // btnNuevaComision
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
            // dgvComisiones
            // 
            dgvComisiones.Anchor = AnchorStyles.Top;
            dgvComisiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComisiones.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Planes, colBtnModificarCom, colBtnEliminarCom });
            dgvComisiones.Location = new Point(120, 112);
            dgvComisiones.Margin = new Padding(3, 2, 3, 2);
            dgvComisiones.Name = "dgvComisiones";
            dgvComisiones.RowHeadersWidth = 51;
            dgvComisiones.Size = new Size(847, 245);
            dgvComisiones.TabIndex = 8;
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
            // Planes
            // 
            Planes.DataPropertyName = "Planes";
            Planes.HeaderText = "Turno";
            Planes.MinimumWidth = 6;
            Planes.Name = "Planes";
            Planes.ReadOnly = true;
            Planes.Width = 125;
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
            // FormListadoEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1066, 383);
            Controls.Add(dgvComisiones);
            Controls.Add(tableLayoutPanel5);
            Name = "FormListadoEspecialidades";
            Text = "Listado especialidades";
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private Button btnNuevaEspecialidad;
        private DataGridView dgvComisiones;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Planes;
        private DataGridViewButtonColumn colBtnModificarCom;
        private DataGridViewButtonColumn colBtnEliminarCom;
    }
}