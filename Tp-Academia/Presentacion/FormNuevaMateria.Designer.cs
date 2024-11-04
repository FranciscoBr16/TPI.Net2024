namespace Presentacion
{
    partial class FormNuevaMateria
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
            tableLayoutPanel3 = new TableLayoutPanel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblNuevaMateria = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblNombre = new Label();
            txbNombre = new TextBox();
            lblCantHoras = new Label();
            txbCantHoras = new TextBox();
            lblDescripcion = new Label();
            txbDescripcion = new TextBox();
            lblPlanId = new Label();
            textBox4 = new TextBox();
            lblAnio = new Label();
            cbEspecialidades = new ComboBox();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.ControlDark;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnCancelar, 1, 0);
            tableLayoutPanel3.Controls.Add(btnAceptar, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 515);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(914, 85);
            tableLayoutPanel3.TabIndex = 50;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(295, 28);
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
            btnAceptar.Location = new Point(523, 28);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblNuevaMateria, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(914, 63);
            tableLayoutPanel1.TabIndex = 48;
            // 
            // lblNuevaMateria
            // 
            lblNuevaMateria.Anchor = AnchorStyles.Bottom;
            lblNuevaMateria.AutoSize = true;
            lblNuevaMateria.Font = new Font("Segoe UI", 14F);
            lblNuevaMateria.Location = new Point(370, 31);
            lblNuevaMateria.Name = "lblNuevaMateria";
            lblNuevaMateria.Size = new Size(171, 32);
            lblNuevaMateria.TabIndex = 0;
            lblNuevaMateria.Text = "Nueva Materia";
            lblNuevaMateria.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.52632F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.1578941F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.5263157F));
            tableLayoutPanel2.Controls.Add(lblNombre, 1, 0);
            tableLayoutPanel2.Controls.Add(txbNombre, 2, 0);
            tableLayoutPanel2.Controls.Add(lblCantHoras, 1, 1);
            tableLayoutPanel2.Controls.Add(txbCantHoras, 2, 1);
            tableLayoutPanel2.Controls.Add(lblDescripcion, 1, 2);
            tableLayoutPanel2.Controls.Add(txbDescripcion, 2, 2);
            tableLayoutPanel2.Controls.Add(lblPlanId, 1, 3);
            tableLayoutPanel2.Controls.Add(textBox4, 2, 4);
            tableLayoutPanel2.Controls.Add(lblAnio, 1, 4);
            tableLayoutPanel2.Controls.Add(cbEspecialidades, 2, 3);
            tableLayoutPanel2.Location = new Point(0, 129);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(914, 345);
            tableLayoutPanel2.TabIndex = 49;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(136, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            txbNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbNombre.Location = new Point(243, 21);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(571, 27);
            txbNombre.TabIndex = 1;
            // 
            // lblCantHoras
            // 
            lblCantHoras.Anchor = AnchorStyles.None;
            lblCantHoras.AutoSize = true;
            lblCantHoras.Location = new Point(103, 83);
            lblCantHoras.Name = "lblCantHoras";
            lblCantHoras.Size = new Size(130, 40);
            lblCantHoras.TabIndex = 10;
            lblCantHoras.Text = "Cantidad de horas semanales";
            lblCantHoras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbCantHoras
            // 
            txbCantHoras.Anchor = AnchorStyles.Left;
            txbCantHoras.Location = new Point(243, 90);
            txbCantHoras.Name = "txbCantHoras";
            txbCantHoras.Size = new Size(191, 27);
            txbCantHoras.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(124, 162);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "Descripcion";
            // 
            // txbDescripcion
            // 
            txbDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbDescripcion.Location = new Point(243, 159);
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(571, 27);
            txbDescripcion.TabIndex = 13;
            // 
            // lblPlanId
            // 
            lblPlanId.Anchor = AnchorStyles.None;
            lblPlanId.AutoSize = true;
            lblPlanId.Location = new Point(141, 231);
            lblPlanId.Name = "lblPlanId";
            lblPlanId.Size = new Size(54, 20);
            lblPlanId.TabIndex = 14;
            lblPlanId.Text = "Plan Id";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(243, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(571, 27);
            textBox4.TabIndex = 16;
            // 
            // lblAnio
            // 
            lblAnio.Anchor = AnchorStyles.None;
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(150, 300);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(36, 20);
            lblAnio.TabIndex = 17;
            lblAnio.Text = "Año";
            // 
            // cbEspecialidades
            // 
            cbEspecialidades.Anchor = AnchorStyles.Left;
            cbEspecialidades.FormattingEnabled = true;
            cbEspecialidades.Location = new Point(243, 227);
            cbEspecialidades.Name = "cbEspecialidades";
            cbEspecialidades.Size = new Size(217, 28);
            cbEspecialidades.TabIndex = 49;
            // 
            // FormNuevaMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNuevaMateria";
            Text = "Form1";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCancelar;
        private Button btnAceptar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNuevaMateria;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblNombre;
        private TextBox txbNombre;
        private Label lblCantHoras;
        private TextBox txbCantHoras;
        private Label lblDescripcion;
        private TextBox txbDescripcion;
        private Label lblPlanId;
        private TextBox textBox4;
        private Label lblAnio;
        private ComboBox cbEspecialidades;
    }
}