namespace Api.Models
{
    public class Alumno
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Legajo { get; set; } 
        public Guid RolId { get; set; }
        public Rol Rol { get; set; }

    }
}
