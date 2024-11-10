using ApiClients;
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
    public partial class FormModificarMateria : Form
    {
        public Materia Materia { get; set; }

        public FormModificarMateria()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbPlanes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un plan.");
                return;
            }


            Materia materiaNueva = new Materia { Anio = txbAnio.Text, CantHorasSemanales = int.Parse(txbCantHoras.Text), Descripcion = txbDescripcion.Text, Id = Materia.Id, Nombre = txbNombre.Text, PlanId = (int)cbPlanes.SelectedValue };
            

            await MateriaApiClient.UpdateAsync(materiaNueva);
            MessageBox.Show("Cambios guardados exitosamente.");
            this.Close();
        }

        private async void FormModificarMateria_Load(object sender, EventArgs e)
        {
            txbNombre.Text = Materia.Nombre;
            txbCantHoras.Text = Materia.CantHorasSemanales.ToString();
            txbDescripcion.Text = Materia.Descripcion;
            txbAnio.Text = Materia.Anio;


            List<Plan> planes = (List<Plan>)await PlanApiClient.GetAllAsync();


            if (planes == null || planes.Count == 0)
            {
                MessageBox.Show("No se encontraron planes disponibles.");
                return;
            }


            cbPlanes.DataSource = planes;
            cbPlanes.DisplayMember = "Descripcion";
            cbPlanes.ValueMember = "Id";
        }
    }
}
