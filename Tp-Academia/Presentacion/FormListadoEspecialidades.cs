using Data;
using Entidades;
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
    public partial class FormListadoEspecialidades : Form
    {
        public FormListadoEspecialidades()
        {
            InitializeComponent();
        }

        private void btnNuevaEspecialidad_Click(object sender, EventArgs e)
        {
            FormNuevaEspecialidad formNuevo = new FormNuevaEspecialidad();
            formNuevo.ShowDialog();
        }

        private void FormListadoEspecialidades_Load(object sender, EventArgs e)
        {
            ListarEspecialidades();
        }

        public void ListarEspecialidades()
        {

            DataEspecialidad dataEsp = new DataEspecialidad();

            List<Especialidad> listaEsp = dataEsp.GetEspecialidades();

            dgvEspecialidades.AutoGenerateColumns = false;

            dgvEspecialidades.DataSource = listaEsp;


        }
    }
}
