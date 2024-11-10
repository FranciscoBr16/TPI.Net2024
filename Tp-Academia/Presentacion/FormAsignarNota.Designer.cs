namespace Presentacion
{
    partial class FormAsignarNota
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
            tableLayoutPanel2 = new TableLayoutPanel();
            lblNota = new Label();
            lblCondicion = new Label();
            tbNota = new TextBox();
            tbCondicion = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 321);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(800, 47);
            tableLayoutPanel3.TabIndex = 51;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(259, 12);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(459, 12);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(lblNota, 1, 1);
            tableLayoutPanel2.Controls.Add(lblCondicion, 1, 2);
            tableLayoutPanel2.Controls.Add(tbNota, 2, 1);
            tableLayoutPanel2.Controls.Add(tbCondicion, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 106);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(800, 215);
            tableLayoutPanel2.TabIndex = 50;
            // 
            // lblNota
            // 
            lblNota.Anchor = AnchorStyles.None;
            lblNota.AutoSize = true;
            lblNota.Location = new Point(123, 57);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(33, 15);
            lblNota.TabIndex = 0;
            lblNota.Text = "Nota";
            // 
            // lblCondicion
            // 
            lblCondicion.Anchor = AnchorStyles.None;
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(109, 157);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(62, 15);
            lblCondicion.TabIndex = 1;
            lblCondicion.Text = "Condicion";
            // 
            // tbNota
            // 
            tbNota.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbNota.Location = new Point(203, 53);
            tbNota.Margin = new Padding(3, 2, 3, 2);
            tbNota.Name = "tbNota";
            tbNota.Size = new Size(514, 23);
            tbNota.TabIndex = 2;
            // 
            // tbCondicion
            // 
            tbCondicion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbCondicion.Location = new Point(203, 153);
            tbCondicion.Margin = new Padding(3, 2, 3, 2);
            tbCondicion.Name = "tbCondicion";
            tbCondicion.Size = new Size(514, 23);
            tbCondicion.TabIndex = 3;
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
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 106);
            tableLayoutPanel1.TabIndex = 49;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 24);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 0;
            label1.Text = "Asignar la Nota";
            // 
            // FormAsignarNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "FormAsignarNota";
            Text = "FormAsignarNota";
            Load += FormAsignarNota_Load;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCancelar;
        private Button btnAceptar;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblNota;
        private Label lblCondicion;
        private TextBox tbNota;
        private TextBox tbCondicion;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}