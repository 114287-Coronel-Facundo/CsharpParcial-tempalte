namespace Api.Models
{
    public class DocenteXCurso
    {
        public Guid Id { get; set; }
        public DateTime FechaAlta { get; set; }
        public Guid DocenteId { get; set; }
        public Docente Docentes { get; set; }
        public Guid CursoId { get; set; }
        public Curso Cursos { get; set; }
    }
}
