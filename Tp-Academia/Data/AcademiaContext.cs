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
        public DbSet<Docente_curso> Docente_curso { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Plan> Planes { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ver el tema de la cadena de conexion
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3OGAI9F\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=true;TrustServerCertificate=True");
        }   //facu -> DESKTOP-3OGAI9F\SQLEXPRESS

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<Docente_curso>()
                .HasKey(dc => new { dc.DocenteId, dc.CursoId, dc.Fecha });

          
            modelBuilder.Entity<Docente_curso>()
                .HasOne(dc => dc.Docente)
                .WithMany()
                .HasForeignKey(dc => dc.DocenteId);

            modelBuilder.Entity<Docente_curso>()
                .HasOne(dc => dc.Curso)
                .WithMany()
                .HasForeignKey(dc => dc.CursoId);
        }
        public AcademiaContext()
        {
            this.Database.EnsureCreated();
        }


    }
}
