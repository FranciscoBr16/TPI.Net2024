using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public class Profesor : Persona
    {
        public string cargo {  get; set; }

        public Profesor(string cargo)
        {
            this.cargo = cargo;
        }
    }

}

