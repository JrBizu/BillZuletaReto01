using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Application.UseCases.Tareas.Queries.GetTareas;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Tareas.Queries.GetTareaPorId
{
    public class GetTareaPorIdQuery : IRequest<Result<GetTareaPorIdQueryDto>>
    {
        //public class GetTareaPorIdQueryHandler(IRepository<Tarea> repository) : UseCaseHandler, IRequestHandler<GetTareaPorIdQuery, Result<GetTareaPorIdQueryDto>>
        //{
        //    public async Task<Result<GetTareaPorIdQueryDto>> Handle(GetTareaPorIdQuery request, CancellationToken cancellationToken)
        //    {
                
        //        var result = await repository.ObtenerPorIdAsync(request.Id);
                

        //        var tareas = result.Select(x => new GetTareaPorIdQueryDto
        //        {
        //            Id = x.Id,
        //            Titulo = x.Titulo,
        //            Descripcion = x.Descripcion,
        //            Estado = x.Estado,
        //        }).ToList();

        //        var response = new GetTareaPorIdQueryDto()
        //        {
        //            Tareas = tareas
        //        };

        //        return Succeded(response);
        //    }
        //}
    }
}
