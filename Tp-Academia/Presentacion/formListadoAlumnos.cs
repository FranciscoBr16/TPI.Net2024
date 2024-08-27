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
    public partial class formListadoAlumnos : Form
    {
        public formListadoAlumnos()
        {
            InitializeComponent();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Listar()
        {
           
            DataAlumnos dataAlumnos = new DataAlumnos();

            List<Alumno> listaAlumnos = dataAlumnos.getAlumnos();

            dgvAlumnos.DataSource = listaAlumnos;
            // Todavia no se que hacer aca

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
