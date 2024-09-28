using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MiFormBase : Form
    {
        public Persona? Usuario { get; set; } = null;

        public virtual void ActualizarVisibilidad()
        {

        }
    }
}
