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
            tableLayoutPanel3.Location = new Point(0, 428);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(914, 63);
            tableLayoutPanel3.TabIndex = 51;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(295, 17);
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
            btnAceptar.Location = new Point(523, 17);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
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
            tableLayoutPanel2.Location = new Point(0, 141);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(914, 287);
            tableLayoutPanel2.TabIndex = 50;
            // 
            // lblNota
            // 
            lblNota.Anchor = AnchorStyles.None;
            lblNota.AutoSize = true;
            lblNota.Location = new Point(138, 76);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(42, 20);
            lblNota.TabIndex = 0;
            lblNota.Text = "Nota";
            // 
            // lblCondicion
            // 
            lblCondicion.Anchor = AnchorStyles.None;
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(121, 210);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(76, 20);
            lblCondicion.TabIndex = 1;
            lblCondicion.Text = "Condicion";
            // 
            // tbNota
            // 
            tbNota.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbNota.Location = new Point(231, 73);
            tbNota.Name = "tbNota";
            tbNota.Size = new Size(588, 27);
            tbNota.TabIndex = 2;
            // 
            // tbCondicion
            // 
            tbCondicion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbCondicion.Location = new Point(231, 206);
            tbCondicion.Name = "tbCondicion";
            tbCondicion.Size = new Size(588, 27);
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(914, 141);
            tableLayoutPanel1.TabIndex = 49;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 34);
            label1.Name = "label1";
            label1.Size = new Size(249, 46);
            label1.TabIndex = 0;
            label1.Text = "Asignar la Nota";
            // 
            // FormAsignarNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAsignarNota";
            Text = "Asignar Nota";
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