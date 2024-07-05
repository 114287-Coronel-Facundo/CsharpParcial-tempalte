using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Docente> Docentes { get; set; }

        public DbSet<Carrera> Carreras { get; set; }

        public DbSet<Curso> Cursos { get; set; }  

        public DbSet<DocenteXCurso> DocentesXCursos { get; set; }
    }
}
