using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
            var configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("EFContext"));


            base.OnConfiguring(optionsBuilder);
        }   //facu -> DESKTOP-3OGAI9F\SQLEXPRESS

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Docente_curso>()
                .HasKey(dc => new { dc.DocenteId, dc.CursoId});


            modelBuilder.Entity<Docente_curso>()
                .HasOne(dc => dc.Docente)
                .WithMany()
                .HasForeignKey(dc => dc.DocenteId);

            modelBuilder.Entity<Docente_curso>()
                .HasOne(dc => dc.Curso)
                .WithMany()
                .HasForeignKey(dc => dc.CursoId);

            modelBuilder.Entity<Plan>()
                .HasOne(a => a.Especialidad)
                .WithMany(a => a.Planes)
                .HasForeignKey(a => a.EspecialidadId)
                .OnDelete(DeleteBehavior.Cascade)
                ;

            modelBuilder.Entity<Persona>()
               .HasOne(a => a.Plan)
               .WithMany(a => a.Alumnos)
               .HasForeignKey(a => a.PlanId)
               .OnDelete(DeleteBehavior.Cascade)
               ;

            modelBuilder.Entity<Curso>()
               .HasOne(c => c.Comision)
               .WithMany(c => c.Cursos)
               .HasForeignKey(c => c.ComisionId)
               .OnDelete(DeleteBehavior.Cascade)
               ;

            modelBuilder.Entity<Curso>()
               .HasOne(c => c.Materia)
               .WithMany(c => c.Cursos)
               .HasForeignKey(c => c.MateriaId)
               .OnDelete(DeleteBehavior.Cascade)
               ;

            modelBuilder.Entity<Inscripcion>()
               .HasOne(c => c.Alumno)
               .WithMany(c => c.Inscripciones)
               .HasForeignKey(c => c.AlumnoLegajo)
               .OnDelete(DeleteBehavior.Cascade)
               ;

            modelBuilder.Entity<Inscripcion>()
               .HasOne(c => c.Curso)
               .WithMany(c => c.Inscripciones)
               .HasForeignKey(c => c.CursoId)
               .OnDelete(DeleteBehavior.Cascade)
               ;
        }
        public AcademiaContext()
        {
            this.Database.EnsureCreated();
        }


    }
}