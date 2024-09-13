namespace Presentacion
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            panelppal = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnIniciarSesion = new Button();
            btnRegistrarse = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblTextoInicioLargo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            imgUTN = new PictureBox();
            lblBienvenida = new Label();
            panelppal.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUTN).BeginInit();
            SuspendLayout();
            // 
            // panelppal
            // 
            panelppal.Controls.Add(tableLayoutPanel2);
            panelppal.Controls.Add(tableLayoutPanel3);
            panelppal.Controls.Add(tableLayoutPanel1);
            panelppal.Dock = DockStyle.Fill;
            panelppal.Location = new Point(0, 0);
            panelppal.Margin = new Padding(3, 2, 3, 2);
            panelppal.Name = "panelppal";
            panelppal.Size = new Size(1104, 505);
            panelppal.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnIniciarSesion, 2, 0);
            tableLayoutPanel2.Controls.Add(btnRegistrarse, 1, 0);
            tableLayoutPanel2.Location = new Point(5, 374);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.4F));
            tableLayoutPanel2.Size = new Size(1102, 49);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Anchor = AnchorStyles.Top;
            btnIniciarSesion.Location = new Point(626, 2);
            btnIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(122, 26);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += button2_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Anchor = AnchorStyles.Top;
            btnRegistrarse.Location = new Point(351, 2);
            btnRegistrarse.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(122, 26);
            btnRegistrarse.TabIndex = 0;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(lblTextoInicioLargo, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 200);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1104, 155);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // lblTextoInicioLargo
            // 
            lblTextoInicioLargo.Anchor = AnchorStyles.Top;
            lblTextoInicioLargo.AutoSize = true;
            lblTextoInicioLargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoInicioLargo.Location = new Point(239, 0);
            lblTextoInicioLargo.Name = "lblTextoInicioLargo";
            lblTextoInicioLargo.Size = new Size(623, 126);
            lblTextoInicioLargo.TabIndex = 0;
            lblTextoInicioLargo.Text = resources.GetString("lblTextoInicioLargo.Text");
            lblTextoInicioLargo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(imgUTN, 1, 0);
            tableLayoutPanel1.Controls.Add(lblBienvenida, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1104, 182);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // imgUTN
            // 
            imgUTN.Anchor = AnchorStyles.None;
            imgUTN.Image = Properties.Resources.image;
            imgUTN.Location = new Point(471, 18);
            imgUTN.Margin = new Padding(3, 2, 3, 2);
            imgUTN.Name = "imgUTN";
            imgUTN.Size = new Size(162, 54);
            imgUTN.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUTN.TabIndex = 0;
            imgUTN.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(429, 111);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(246, 51);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "¡Bienvenidos!";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(panelppal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInicio";
            Text = "UTN | Sistema de la academia";
            panelppal.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUTN).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelppal;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnIniciarSesion;
        private Button btnRegistrarse;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblTextoInicioLargo;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox imgUTN;
        private Label lblBienvenida;
    }
}