namespace Presentacion
{
    partial class FormModificarPlan
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
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblDescripcion = new Label();
            txbDescripcion = new TextBox();
            lblEspecialidad = new Label();
            cbEspecialidades = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(914, 89);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(362, 26);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 0;
            label1.Text = "Modificar Plan";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(lblDescripcion, 1, 0);
            tableLayoutPanel2.Controls.Add(txbDescripcion, 2, 0);
            tableLayoutPanel2.Controls.Add(lblEspecialidad, 1, 1);
            tableLayoutPanel2.Controls.Add(cbEspecialidades, 2, 1);
            tableLayoutPanel2.Controls.Add(dtpFecha, 2, 2);
            tableLayoutPanel2.Controls.Add(lblFecha, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 89);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(914, 219);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(184, 26);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Descripcion";
            // 
            // txbDescripcion
            // 
            txbDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbDescripcion.Location = new Point(368, 22);
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(451, 27);
            txbDescripcion.TabIndex = 49;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.Anchor = AnchorStyles.None;
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(181, 98);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(93, 20);
            lblEspecialidad.TabIndex = 1;
            lblEspecialidad.Text = "Especialidad";
            // 
            // cbEspecialidades
            // 
            cbEspecialidades.Anchor = AnchorStyles.Left;
            cbEspecialidades.FormattingEnabled = true;
            cbEspecialidades.Location = new Point(368, 94);
            cbEspecialidades.Name = "cbEspecialidades";
            cbEspecialidades.Size = new Size(217, 28);
            cbEspecialidades.TabIndex = 50;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Left;
            dtpFecha.Location = new Point(368, 168);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 52;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(204, 171);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 51;
            lblFecha.Text = "Fecha";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnCancelar, 1, 0);
            tableLayoutPanel3.Controls.Add(btnAceptar, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 308);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(914, 94);
            tableLayoutPanel3.TabIndex = 42;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(295, 32);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(523, 32);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormModificarPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 474);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormModificarPlan";
            Text = "Modificar Plan";
            Load += FormModificarPlan_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblDescripcion;
        private Label lblEspecialidad;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txbDescripcion;
        private ComboBox cbEspecialidades;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
    }
}