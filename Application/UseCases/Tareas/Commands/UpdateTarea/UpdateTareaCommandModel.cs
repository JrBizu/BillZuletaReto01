
namespace Application.UseCases.Tareas.Commands.UpdateTarea
{
    public class UpdateTareaCommandModel
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
