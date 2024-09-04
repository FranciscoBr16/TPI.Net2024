using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevaPersona formNuevo = new FormNuevaPersona();
            formNuevo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
