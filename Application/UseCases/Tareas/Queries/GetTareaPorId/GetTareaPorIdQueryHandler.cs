using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Tareas.Queries.GetTareaPorId
{

    public class GetTareaPorIdQueryHandler(IRepository<Tarea> repository) : UseCaseHandler, IRequestHandler<GetTareaPorIdQuery, Result<GetTareaPorIdQueryDto>>
    {

        public async Task<Result<GetTareaPorIdQueryDto>> Handle(GetTareaPorIdQuery request, CancellationToken cancellationToken)
        {
            var oModelo = new GetTareaPorIdQueryDto();
            var result = await repository.ObtenerPorIdAsync(request.Id);

            //if (result is null)
            //{
            //    return NotFound("Registro de Tarea No encontrada");
            //}

            if (result is not null)
            {
                oModelo.Id = result.Id;
                oModelo.Titulo = result.Titulo;
                oModelo.Descripcion = result.Descripcion;
                oModelo.Estado = result.Estado;
            }

            return Succeded(oModelo);
        }
    }
}
