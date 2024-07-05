namespace Api.Models
{
    public class Curso
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime FechaCreacion { get; set; }
        public string Horarios { get; set; } 
        public Guid CarreraId { get; set; }
        public Carrera Carrera { get; set;  }

        public ICollection<DocenteXCurso> DocentesXCursos { get; set; }

    }
}
