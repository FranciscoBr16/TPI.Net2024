namespace Presentacion
{
    partial class FormModificarCurso
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
            btnAgregarProfesor = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblMateria = new Label();
            lblComision = new Label();
            cbMateria = new ComboBox();
            lblCupo = new Label();
            lblFecha = new Label();
            tbCupo = new TextBox();
            dtpFecha = new DateTimePicker();
            cbComision = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.Controls.Add(btnAgregarProfesor, 2, 1);
            tableLayoutPanel3.Controls.Add(btnAceptar, 3, 3);
            tableLayoutPanel3.Controls.Add(btnCancelar, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 404);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Size = new Size(914, 141);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // btnAgregarProfesor
            // 
            btnAgregarProfesor.Anchor = AnchorStyles.None;
            btnAgregarProfesor.Location = new Point(381, 18);
            btnAgregarProfesor.Margin = new Padding(3, 4, 3, 4);
            btnAgregarProfesor.Name = "btnAgregarProfesor";
            btnAgregarProfesor.Size = new Size(150, 33);
            btnAgregarProfesor.TabIndex = 0;
            btnAgregarProfesor.Text = "Modificar Profesores";
            btnAgregarProfesor.UseVisualStyleBackColor = true;
            btnAgregarProfesor.Click += btnAgregarProfesor_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Left;
            btnAceptar.Location = new Point(596, 103);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 33);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Right;
            btnCancelar.Location = new Point(222, 103);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 33);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(lblMateria, 4, 2);
            tableLayoutPanel2.Controls.Add(lblComision, 1, 2);
            tableLayoutPanel2.Controls.Add(cbMateria, 5, 2);
            tableLayoutPanel2.Controls.Add(lblCupo, 1, 1);
            tableLayoutPanel2.Controls.Add(lblFecha, 4, 1);
            tableLayoutPanel2.Controls.Add(tbCupo, 2, 1);
            tableLayoutPanel2.Controls.Add(dtpFecha, 5, 1);
            tableLayoutPanel2.Controls.Add(cbComision, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 133);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(914, 271);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // lblMateria
            // 
            lblMateria.Anchor = AnchorStyles.None;
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 10F);
            lblMateria.Location = new Point(535, 205);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(68, 23);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "Materia";
            // 
            // lblComision
            // 
            lblComision.Anchor = AnchorStyles.None;
            lblComision.AutoSize = true;
            lblComision.Font = new Font("Segoe UI", 10F);
            lblComision.Location = new Point(73, 205);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(81, 23);
            lblComision.TabIndex = 2;
            lblComision.Text = "Comision";
            // 
            // cbMateria
            // 
            cbMateria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbMateria.Font = new Font("Segoe UI", 10F);
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(641, 201);
            cbMateria.Margin = new Padding(3, 4, 3, 4);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(222, 31);
            cbMateria.TabIndex = 5;
            // 
            // lblCupo
            // 
            lblCupo.Anchor = AnchorStyles.None;
            lblCupo.AutoSize = true;
            lblCupo.Font = new Font("Segoe UI", 10F);
            lblCupo.Location = new Point(88, 96);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(51, 23);
            lblCupo.TabIndex = 0;
            lblCupo.Text = "Cupo";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(517, 85);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(105, 46);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha de Vencimiento";
            // 
            // tbCupo
            // 
            tbCupo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbCupo.Font = new Font("Segoe UI", 10F);
            tbCupo.Location = new Point(185, 93);
            tbCupo.Margin = new Padding(3, 4, 3, 4);
            tbCupo.Name = "tbCupo";
            tbCupo.Size = new Size(222, 30);
            tbCupo.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.CalendarFont = new Font("Segoe UI", 10F);
            dtpFecha.Location = new Point(641, 94);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(221, 27);
            dtpFecha.TabIndex = 3;
            // 
            // cbComision
            // 
            cbComision.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbComision.Font = new Font("Segoe UI", 10F);
            cbComision.FormattingEnabled = true;
            cbComision.Location = new Point(185, 201);
            cbComision.Margin = new Padding(3, 4, 3, 4);
            cbComision.Name = "cbComision";
            cbComision.Size = new Size(222, 31);
            cbComision.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(914, 133);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(353, 66);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 0;
            label1.Text = "Modificar Curso";
            // 
            // FormModificarCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormModificarCurso";
            Text = "Modificar Curso";
            Load += FormModificarCurso_Load;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button btnAgregarProfesor;
        private Button btnAceptar;
        private Button btnCancelar;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblMateria;
        private Label lblComision;
        private ComboBox cbMateria;
        private Label lblCupo;
        private Label lblFecha;
        private TextBox tbCupo;
        private DateTimePicker dtpFecha;
        private ComboBox cbComision;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}