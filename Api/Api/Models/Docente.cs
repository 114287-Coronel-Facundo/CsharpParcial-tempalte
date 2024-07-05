namespace Api.Models
{
    public class Docente
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Legajo { get; set; }
        public Guid RolId { get; set; }
        public Rol Rol { get; set; }

        public ICollection<DocenteXCurso> DocentesXCursos { get; set; }
    }
}
