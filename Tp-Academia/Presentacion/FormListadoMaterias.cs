﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormListadoMaterias : Form
    {
        public FormListadoMaterias()
        {
            InitializeComponent();
        }

        private void btnNuevaMateria_Click(object sender, EventArgs e)
        {
            FormNuevaMateria formNuevo = new FormNuevaMateria();
            formNuevo.ShowDialog();
        }
    }
}
