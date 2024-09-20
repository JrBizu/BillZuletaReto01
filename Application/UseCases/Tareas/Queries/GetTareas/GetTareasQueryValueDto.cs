

namespace Application.UseCases.Tareas.Queries.GetTareas
{
    public class GetTareasQueryValueDto
    {

        public Guid Id { get; set; }

        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
    }
}
