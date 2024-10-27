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
    public partial class FormListadoMaterias : MiFormBase
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

        private void FormListadoMaterias_Load(object sender, EventArgs e)
        {
            ListarMaterias();
            if (Usuario != null && Usuario.Rol == "Admin") 
            {
                dgvMaterias.Columns["colBtnModificar"].Visible = true;
                dgvMaterias.Columns["colBtnEliminar"].Visible = true;
            }
            else
            {
                dgvMaterias.Columns["colBtnModificar"].Visible = false;
                dgvMaterias.Columns["colBtnEliminar"].Visible = false;
            }
        }

        public void ListarMaterias()
        {

            DataMateria dataMaterias = new DataMateria();

            List<Materia> listaMaterias = dataMaterias.GetMaterias();

            dgvMaterias.AutoGenerateColumns = false;

            dgvMaterias.DataSource = listaMaterias;


        }
    }
}
