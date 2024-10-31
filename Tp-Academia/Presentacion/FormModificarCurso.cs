using Presentacion.ApiClients;
using System;
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
    public partial class FormModificarCurso : Form
    {
        internal Entidades.Curso Curso {  get; set; }
        public FormModificarCurso()
        {
            InitializeComponent();
        }


    }
}
