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
    public partial class FormListadoPlanes : Form
    {
        public FormListadoPlanes()
        {
            InitializeComponent();
        }

        public void ListarPlanes()
        {

            DataPlan dataPlanes = new DataPlan();

            List<Plan> listaPlanes = dataPlanes.GetPlanes();

            dgvPlanes.AutoGenerateColumns = false;

            dgvPlanes.DataSource = listaPlanes;


        }

        private void FormListadoPlanes_Load(object sender, EventArgs e)
        {
            ListarPlanes();
        }
    }
}
