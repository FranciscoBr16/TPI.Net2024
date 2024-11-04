namespace Presentacion
{
    partial class FormNuevoPlan
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
            lblNuevoUsuario = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblDescripcion = new Label();
            txbDescripcion = new TextBox();
            lblEspecialidad = new Label();
            cbEspecialidades = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel3.Location = new Point(0, 347);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(809, 39);
            tableLayoutPanel3.TabIndex = 47;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(256, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(458, 5);
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
            tableLayoutPanel1.Controls.Add(lblNuevoUsuario, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(810, 63);
            tableLayoutPanel1.TabIndex = 45;
            // 
            // lblNuevoUsuario
            // 
            lblNuevoUsuario.Anchor = AnchorStyles.Bottom;
            lblNuevoUsuario.AutoSize = true;
            lblNuevoUsuario.Font = new Font("Segoe UI", 14F);
            lblNuevoUsuario.Location = new Point(336, 31);
            lblNuevoUsuario.Name = "lblNuevoUsuario";
            lblNuevoUsuario.Size = new Size(137, 32);
            lblNuevoUsuario.TabIndex = 0;
            lblNuevoUsuario.Text = "Nuevo Plan";
            lblNuevoUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.52632F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.1578941F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.5263157F));
            tableLayoutPanel2.Controls.Add(lblDescripcion, 1, 0);
            tableLayoutPanel2.Controls.Add(txbDescripcion, 2, 0);
            tableLayoutPanel2.Controls.Add(lblEspecialidad, 1, 1);
            tableLayoutPanel2.Controls.Add(cbEspecialidades, 2, 1);
            tableLayoutPanel2.Controls.Add(lblFecha, 1, 2);
            tableLayoutPanel2.Controls.Add(dtpFecha, 2, 2);
            tableLayoutPanel2.Location = new Point(0, 117);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(809, 182);
            tableLayoutPanel2.TabIndex = 46;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(105, 20);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripcion";
            // 
            // txbDescripcion
            // 
            txbDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbDescripcion.Location = new Point(215, 16);
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(504, 27);
            txbDescripcion.TabIndex = 1;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.Anchor = AnchorStyles.None;
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(102, 80);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(93, 20);
            lblEspecialidad.TabIndex = 11;
            lblEspecialidad.Text = "Especialidad";
            // 
            // cbEspecialidades
            // 
            cbEspecialidades.Anchor = AnchorStyles.Left;
            cbEspecialidades.FormattingEnabled = true;
            cbEspecialidades.Location = new Point(215, 76);
            cbEspecialidades.Name = "cbEspecialidades";
            cbEspecialidades.Size = new Size(217, 28);
            cbEspecialidades.TabIndex = 48;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(125, 141);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 49;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Left;
            dtpFecha.Location = new Point(215, 137);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 50;
            // 
            // FormNuevoPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 455);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "FormNuevoPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Plan";
            Load += FormNuevoPlan_Load;
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
        private Label lblNuevoUsuario;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblDescripcion;
        private TextBox txbDescripcion;
        private Label lblEspecialidad;
        private ComboBox cbEspecialidades;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
    }
}