
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public class Persona
    {
        [Key]
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
        public string Usuario { get; set; }
        public string Direccion { get; set; }
        public string DNI { get; set; }
        public DateTime Fecha_nac { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public Plan Plan { get; set; }

        public int PlanId {  get; set; }
        public List<Inscripcion> Inscripcioens { get; set; }
        
 
        public Persona() { }
    }

}



