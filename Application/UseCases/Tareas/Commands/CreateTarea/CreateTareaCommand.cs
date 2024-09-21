

using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Tareas.Commands.CreateTarea
{
    public class CreateTareaCommand : CreateTareaCommandModel, IRequest<Result<CreateTareaCommandDto>>
    {
        public class CreateTareaCommandHandler(IRepository<Tarea> repository) : UseCaseHandler, IRequestHandler<CreateTareaCommand, Result<CreateTareaCommandDto>>
        {
            public async Task<Result<CreateTareaCommandDto>> Handle(CreateTareaCommand request, CancellationToken cancellationToken)
            {
                var tarea = new Tarea()
                {
                    Id = request.Id,
                    Titulo = request.Titulo,
                    Descripcion = request.Descripcion,
                    Estado = request.Estado
                };

                await repository.AgregarAsync(tarea);

                var response = new CreateTareaCommandDto()
                {
                    Success = true
                };

                return Succeded(response);
            }
        }
    }
}
