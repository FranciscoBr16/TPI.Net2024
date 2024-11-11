namespace Presentacion
{
    partial class FormMdiContenedor
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
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            toolStripLabel4 = new ToolStripLabel();
            toolStripLabel5 = new ToolStripLabel();
            toolStripLabel6 = new ToolStripLabel();
            toolStripLabel7 = new ToolStripLabel();
            toolStripLabel8 = new ToolStripLabel();
            toolStripLabel10 = new ToolStripLabel();
            toolStripLabel12 = new ToolStripLabel();
            toolStripLabel11 = new ToolStripLabel();
            toolStripLabel9 = new ToolStripLabel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2, toolStripLabel3, toolStripLabel4, toolStripLabel5, toolStripLabel6, toolStripLabel7, toolStripLabel8, toolStripLabel10, toolStripLabel12, toolStripLabel11, toolStripLabel9 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1291, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(45, 22);
            toolStripLabel1.Text = "Inicio";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(67, 22);
            toolStripLabel2.Text = "Alumnos";
            toolStripLabel2.Click += toolStripLabel2_Click;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(78, 22);
            toolStripLabel3.Text = "Profesores";
            toolStripLabel3.Click += toolStripLabel3_Click;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(52, 22);
            toolStripLabel4.Text = "Cursos";
            toolStripLabel4.Click += toolStripLabel4_Click;
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(85, 22);
            toolStripLabel5.Text = "Comisiones";
            toolStripLabel5.Click += toolStripLabel5_Click;
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new Size(51, 22);
            toolStripLabel6.Text = "Planes";
            toolStripLabel6.Click += toolStripLabel6_Click;
            // 
            // toolStripLabel7
            // 
            toolStripLabel7.Name = "toolStripLabel7";
            toolStripLabel7.Size = new Size(107, 22);
            toolStripLabel7.Text = "Especialidades";
            toolStripLabel7.Click += toolStripLabel7_Click;
            // 
            // toolStripLabel8
            // 
            toolStripLabel8.Name = "toolStripLabel8";
            toolStripLabel8.Size = new Size(66, 22);
            toolStripLabel8.Text = "Materias";
            toolStripLabel8.Click += toolStripLabel8_Click;
            // 
            // toolStripLabel10
            // 
            toolStripLabel10.Name = "toolStripLabel10";
            toolStripLabel10.Size = new Size(93, 22);
            toolStripLabel10.Text = "Mis Materias";
            toolStripLabel10.Click += toolStripLabel10_Click;
            // 
            // toolStripLabel12
            // 
            toolStripLabel12.Name = "toolStripLabel12";
            toolStripLabel12.Size = new Size(94, 22);
            toolStripLabel12.Text = "Inscripciones";
            toolStripLabel12.Click += toolStripLabel12_Click;
            // 
            // toolStripLabel11
            // 
            toolStripLabel11.Name = "toolStripLabel11";
            toolStripLabel11.Size = new Size(79, 22);
            toolStripLabel11.Text = "Mis Cursos";
            toolStripLabel11.Click += toolStripLabel11_Click;
            // 
            // toolStripLabel9
            // 
            toolStripLabel9.Name = "toolStripLabel9";
            toolStripLabel9.Size = new Size(42, 22);
            toolStripLabel9.Text = "Perfil";
            toolStripLabel9.Click += toolStripLabel9_Click;
            // 
            // FormMdiContenedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 753);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            Name = "FormMdiContenedor";
            Text = "Contenedor";
            WindowState = FormWindowState.Maximized;
            Load += FormMdiContenedor_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel toolStripLabel5;
        private ToolStripLabel toolStripLabel6;
        private ToolStripLabel toolStripLabel7;
        private ToolStripLabel toolStripLabel8;
        private ToolStripLabel toolStripLabel9;
        private ToolStripLabel toolStripLabel4;
        private ToolStripLabel toolStripLabel10;
        private ToolStripLabel toolStripLabel11;
        private ToolStripLabel toolStripLabel12;
    }
}