
namespace Domain.Entities
{
    public class Tarea : BaseEntity
    {
        public required string Titulo { get; set; }

        public string? Descripcion { get; set; }

        public string? Estado { get; set; }
    }
}
