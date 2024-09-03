using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Comision
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Turno { get; set; }
        public List<Curso> Cursos { get; set; }


        public Comision(int id, string descripcion, string turno)
        {
            Id = id;
            Descripcion = descripcion;
            Turno = turno;
        }

        public Comision(string dsc, string turno)
        {
            Descripcion = dsc;
            Turno = turno;
        }
    }
}
