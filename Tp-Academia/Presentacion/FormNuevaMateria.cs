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
    public partial class FormNuevaMateria : Form
    {
        public FormNuevaMateria()
        {
            InitializeComponent();
        }

        private async void FormNuevaMateria_Load(object sender, EventArgs e)
        {
            
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

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (cbPlanes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un plan.");
                return;
            }

            
            Materia materiaNueva = new Materia
            {
                Nombre = txbNombre.Text,
                CantHorasSemanales = Convert.ToInt32(txbCantHoras.Text),
                Descripcion = txbDescripcion.Text,
                Anio = txbAnio.Text,
                PlanId = Convert.ToInt32(cbPlanes.SelectedValue)
            };

            
            await MateriaApiClient.AddAsync(materiaNueva);
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

