using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AcademiaContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Comision> Comisiones { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ver el tema de la cadena de conexion
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-B66J2B1\SQLEXPRESS01;Initial Catalog=Academia;Integrated Security=true;TrustServerCertificate=True");
        }

        public AcademiaContext()
        {
            this.Database.EnsureCreated();
        }


    }
}
