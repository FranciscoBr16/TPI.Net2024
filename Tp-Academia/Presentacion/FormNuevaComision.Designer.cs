namespace Presentacion
{
    partial class FormNuevaComision
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
            lblTurno = new Label();
            txbTurno = new TextBox();
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
            tableLayoutPanel3.Location = new Point(0, 351);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(865, 39);
            tableLayoutPanel3.TabIndex = 44;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(277, 5);
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
            btnAceptar.Location = new Point(493, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.MouseClick += btnAceptar_MouseClick;
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
            tableLayoutPanel1.Size = new Size(865, 63);
            tableLayoutPanel1.TabIndex = 42;
            // 
            // lblNuevoUsuario
            // 
            lblNuevoUsuario.Anchor = AnchorStyles.Bottom;
            lblNuevoUsuario.AutoSize = true;
            lblNuevoUsuario.Font = new Font("Segoe UI", 14F);
            lblNuevoUsuario.Location = new Point(337, 31);
            lblNuevoUsuario.Name = "lblNuevoUsuario";
            lblNuevoUsuario.Size = new Size(190, 32);
            lblNuevoUsuario.TabIndex = 0;
            lblNuevoUsuario.Text = "Nueva Comision";
            lblNuevoUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.5263157F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.1578941F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.5263157F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.Controls.Add(lblDescripcion, 1, 0);
            tableLayoutPanel2.Controls.Add(txbDescripcion, 2, 0);
            tableLayoutPanel2.Controls.Add(lblTurno, 1, 1);
            tableLayoutPanel2.Controls.Add(txbTurno, 2, 1);
            tableLayoutPanel2.Location = new Point(0, 123);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(865, 156);
            tableLayoutPanel2.TabIndex = 43;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(115, 29);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripcion";
            // 
            // txbDescripcion
            // 
            txbDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbDescripcion.Location = new Point(230, 25);
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(540, 27);
            txbDescripcion.TabIndex = 1;
            // 
            // lblTurno
            // 
            lblTurno.Anchor = AnchorStyles.None;
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(135, 107);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(47, 20);
            lblTurno.TabIndex = 11;
            lblTurno.Text = "Turno";
            // 
            // txbTurno
            // 
            txbTurno.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbTurno.Location = new Point(230, 103);
            txbTurno.Name = "txbTurno";
            txbTurno.Size = new Size(540, 27);
            txbTurno.TabIndex = 3;
            // 
            // FormNuevaComision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 416);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNuevaComision";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Comision";
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
        private Label lblTurno;
        private TextBox txbTurno;
    }
}