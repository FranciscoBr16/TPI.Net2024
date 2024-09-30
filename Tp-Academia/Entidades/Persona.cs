
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
        public List<Inscripcion> Inscripcioens { get; set; }
        
        public Persona(int legajo, string nombre, string apellido, string mail, string tel, string clave, string rol, string usuario, string direccion, string dNI, DateTime fecha_nac, DateTime fecha_ingreso, Plan plan, List<Inscripcion> inscripcioens)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Tel = tel;
            Clave = clave;
            Rol = rol;
            Usuario = usuario;
            Direccion = direccion;
            DNI = dNI;
            Fecha_nac = fecha_nac;
            Fecha_ingreso = fecha_ingreso;
            Plan = plan;
            Inscripcioens = inscripcioens;
        }
        public Persona(string nombre, string apellido, string mail, string tel, string clave, string rol, string usuario, string direccion, string dni, DateTime fecha_nac, DateTime fecha_ingreso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Tel = tel;
            Clave = clave;
            Rol = rol;
            Usuario = usuario;
            Direccion = direccion;
            DNI = dni;
            Fecha_nac = fecha_nac;
            Fecha_ingreso = fecha_ingreso;
            
        }
        public Persona(int legajo, string nombre, string apellido, string mail, string tel, string clave, string rol, string usuario, string direccion, string dNI, DateTime fecha_nac, DateTime fecha_ingreso)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Tel = tel;
            Clave = clave;
            Rol = rol;
            Usuario = usuario;
            Direccion = direccion;
            DNI = dNI;
            Fecha_nac = fecha_nac;
            Fecha_ingreso = fecha_ingreso;
            
        }

        public Persona(int legajo, string nombre, string apellido, string correo, string tel, string clave, string usuario, string direccion, string dni, DateTime fecha_nac)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Mail = correo;
            Tel = tel;
            Clave = clave;
            Usuario = usuario;
            Direccion = direccion;
            DNI = dni;
            Fecha_nac = fecha_nac;
        }
    }

}



