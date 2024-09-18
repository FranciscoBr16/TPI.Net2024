namespace Presentacion
{
    partial class FormListadoComisiones
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
            btnNuevaComision = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvComisiones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            colBtnModificarCom = new DataGridViewButtonColumn();
            colBtnEliminarCom = new DataGridViewButtonColumn();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel5.Controls.Add(btnNuevaComision, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1405, 143);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(633, 19);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 0;
            label1.Text = "Comisiones";
            // 
            // btnNuevaComision
            // 
            btnNuevaComision.Anchor = AnchorStyles.Bottom;
            btnNuevaComision.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaComision.Location = new Point(610, 103);
            btnNuevaComision.Margin = new Padding(3, 4, 3, 4);
            btnNuevaComision.Name = "btnNuevaComision";
            btnNuevaComision.Size = new Size(183, 36);
            btnNuevaComision.TabIndex = 1;
            btnNuevaComision.Text = "Agregar Comision";
            btnNuevaComision.UseVisualStyleBackColor = true;
            btnNuevaComision.Click += btnNuevaComision_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(dgvComisiones, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 143);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1405, 453);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // dgvComisiones
            // 
            dgvComisiones.Anchor = AnchorStyles.Top;
            dgvComisiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComisiones.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Turno, colBtnModificarCom, colBtnEliminarCom });
            dgvComisiones.Location = new Point(224, 3);
            dgvComisiones.Name = "dgvComisiones";
            dgvComisiones.RowHeadersWidth = 51;
            dgvComisiones.Size = new Size(955, 408);
            dgvComisiones.TabIndex = 8;
            dgvComisiones.CellMouseClick += dgvComisiones_CellMouseClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id Comision";
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
            // Turno
            // 
            Turno.DataPropertyName = "Turno";
            Turno.HeaderText = "Turno";
            Turno.MinimumWidth = 6;
            Turno.Name = "Turno";
            Turno.ReadOnly = true;
            Turno.Width = 125;
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
            // FormListadoComisiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 888);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Name = "FormListadoComisiones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comisiones";
            WindowState = FormWindowState.Maximized;
            Load += FormListadoComisiones_Load;
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private Button btnNuevaComision;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvComisiones;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewButtonColumn colBtnModificarCom;
        private DataGridViewButtonColumn colBtnEliminarCom;
    }
}