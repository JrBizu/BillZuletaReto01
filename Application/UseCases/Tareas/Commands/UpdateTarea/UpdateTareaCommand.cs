using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Application.UseCases.Tareas.Commands.CreateTarea;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Tareas.Commands.UpdateTarea
{
    public class UpdateTareaCommand : UpdateTareaCommandModel, IRequest<Result<UpdateTareaCommandDto>>
    {
        public class UpdateTareaCommandHandler(IRepository<Tarea> repository) : UseCaseHandler, IRequestHandler<UpdateTareaCommand, Result<UpdateTareaCommandDto>>
        {
            public async Task<Result<UpdateTareaCommandDto>> Handle(UpdateTareaCommand request, CancellationToken cancellationToken)
            {
                var tarea = new Tarea()
                {
                    Id = request.Id,
                    Titulo = request.Titulo,
                    Descripcion = request.Descripcion,
                    Estado = request.Estado
                };

                await repository.ActualizarAsync(tarea);

                var response = new UpdateTareaCommandDto()
                {
                    Success = true
                };

                return Succeded(response);
            }
        }
    }
}
