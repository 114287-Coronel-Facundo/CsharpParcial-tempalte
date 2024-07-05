namespace Api.Models
{
    public class Carrera
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Curso> Cursos { get; set; }  
    }
}
