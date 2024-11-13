namespace Presentacion
{
    partial class FormListadoPlanes
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
            button1 = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvPlanes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            IdEspecialidad = new DataGridViewTextBoxColumn();
            colBtnModificarPlan = new DataGridViewButtonColumn();
            colBtnEliminarPlan = new DataGridViewButtonColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1262, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(560, 87);
            button1.Name = "button1";
            button1.Size = new Size(139, 35);
            button1.TabIndex = 2;
            button1.Text = "Agregar Plan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(566, 12);
            label1.Name = "label1";
            label1.Size = new Size(127, 50);
            label1.TabIndex = 1;
            label1.Text = "Planes";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(dgvPlanes, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 125);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1262, 496);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvPlanes
            // 
            dgvPlanes.Anchor = AnchorStyles.Top;
            dgvPlanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Columns.AddRange(new DataGridViewColumn[] { colId, colDescripcion, IdEspecialidad, colBtnModificarPlan, colBtnEliminarPlan });
            dgvPlanes.Location = new Point(225, 3);
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.RowHeadersWidth = 51;
            dgvPlanes.Size = new Size(811, 490);
            dgvPlanes.TabIndex = 0;
            dgvPlanes.CellMouseClick += dgvPlanes_CellMouseClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "id";
            colId.HeaderText = "Id Plan";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 83;
            // 
            // colDescripcion
            // 
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcion.DataPropertyName = "descripcion";
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // IdEspecialidad
            // 
            IdEspecialidad.DataPropertyName = "EspecialidadId";
            IdEspecialidad.HeaderText = "Id Especialidad";
            IdEspecialidad.MinimumWidth = 6;
            IdEspecialidad.Name = "IdEspecialidad";
            IdEspecialidad.ReadOnly = true;
            IdEspecialidad.Width = 139;
            // 
            // colBtnModificarPlan
            // 
            colBtnModificarPlan.HeaderText = "";
            colBtnModificarPlan.MinimumWidth = 6;
            colBtnModificarPlan.Name = "colBtnModificarPlan";
            colBtnModificarPlan.ReadOnly = true;
            colBtnModificarPlan.Text = "Modificar";
            colBtnModificarPlan.UseColumnTextForButtonValue = true;
            colBtnModificarPlan.Width = 24;
            // 
            // colBtnEliminarPlan
            // 
            colBtnEliminarPlan.HeaderText = "";
            colBtnEliminarPlan.MinimumWidth = 6;
            colBtnEliminarPlan.Name = "colBtnEliminarPlan";
            colBtnEliminarPlan.ReadOnly = true;
            colBtnEliminarPlan.Text = "Eliminar";
            colBtnEliminarPlan.UseColumnTextForButtonValue = true;
            colBtnEliminarPlan.Width = 24;
            // 
            // FormListadoPlanes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "FormListadoPlanes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Planes";
            WindowState = FormWindowState.Maximized;
            Load += FormListadoPlanes_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvPlanes;
        private Button button1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn IdEspecialidad;
        private DataGridViewButtonColumn colBtnModificarPlan;
        private DataGridViewButtonColumn colBtnEliminarPlan;
    }
}