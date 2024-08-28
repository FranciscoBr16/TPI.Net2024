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

       

        public void Listar()
        {
           
            DataPersona dataAlumnos = new DataPersona();

            List<Persona> listaAlumnos = dataAlumnos.getAlumnos();

            dgvAlumnos.AutoGenerateColumns = false;

            dgvAlumnos.DataSource = listaAlumnos;
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
