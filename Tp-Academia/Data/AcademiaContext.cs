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
        public DbSet<Comision> Comisiones { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Plan> Planes { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ver el tema de la cadena de conexion
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-GCJ3VNP2\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=true;TrustServerCertificate=True");
        }

        public AcademiaContext()
        {
            this.Database.EnsureCreated();
        }


    }
}
