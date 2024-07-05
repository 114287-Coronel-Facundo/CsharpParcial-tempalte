namespace Api.Models
{
    public class Rol
    {
        public Guid Id { get; set; }
        public string Name { get; set; }  
        public string Description { get; set; } 

        public ICollection<Alumno> Alumnos { get; set; }
        public ICollection<Docente> Docentes { get; set; }
    }
}
