
using Application.UseCases.Tareas.Commands.CreateTarea;
using Application.UseCases.Tareas.Commands.UpdateTarea;
using Application.UseCases.Tareas.Queries.GetTareaPorId;
using Application.UseCases.Tareas.Queries.GetTareas;
using Microsoft.AspNetCore.Mvc;

namespace BillZuletaReto01.Controllers
{
    public class TareaController : BaseController
    {
        [HttpGet]
        [Route("ListarTodos")]
        public async Task<IActionResult> ListarTodos()
        {
            var query = new GetTareasQuery();
            var result = await this.Mediator.Send(query);
            return this.FromResult(result);
        }

        [HttpGet]
        [Route("ObtenerPorId/{Id:Guid}")]
        public async Task<IActionResult> ObtenerPorId(Guid Id)
        {
            var query = new GetTareaPorIdQuery(Id);
            var result = await this.Mediator.Send(query);
            return this.FromResult(result);
        }

        [HttpPost]
        [Route("Crear")]
        public async Task<IActionResult> Crear(CreateTareaCommandModel model)
        {
            var command = this.Mapper.Map<CreateTareaCommand>(model);
            var result = await this.Mediator.Send(command);
            return this.FromResult(result);
        }

        [HttpPost]
        [Route("Actualizar")]
        public async Task<IActionResult> Actualizar(UpdateTareaCommandModel model)
        {
            var command = this.Mapper.Map<UpdateTareaCommand>(model);
            var result = await this.Mediator.Send(command);
            return this.FromResult(result);
        }
    }
}
