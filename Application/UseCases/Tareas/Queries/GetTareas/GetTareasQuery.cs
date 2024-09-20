using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Tareas.Queries.GetTareas
{
    public class GetTareasQuery() : IRequest<Result<GetTareasQueryDto>>
    {
        public class GetTareasQueryHandler(IRepository<Tarea> repository) : UseCaseHandler, IRequestHandler<GetTareasQuery, Result<GetTareasQueryDto>>
        {
            public async Task<Result<GetTareasQueryDto>> Handle(GetTareasQuery request, CancellationToken cancellationToken)
            {
                var result = await repository.ListarTodosAsync();

                var tareas = result.Select(x => new GetTareasQueryValueDto
                {
                    Id = x.Id,
                    Titulo = x.Titulo,
                    Descripcion = x.Descripcion,
                    Estado = x.Estado,
                }).ToList();

                var response = new GetTareasQueryDto()
                {
                    Tareas = tareas
                };

                return Succeded(response);
            }
        }

        //public class GetTareasQueryHandler() : UseCaseHandler, IRequestHandler<GetTareasQuery, Result<GetTareasQueryDto>>
        //{
        //    public async Task<Result<GetTareasQueryDto>> Handle(GetTareasQuery request, CancellationToken cancellationToken)
        //    {
        //        await Task.CompletedTask;

        //        var tareas = new List<GetTareasQueryValueDto>()
        //        {
        //            new GetTareasQueryValueDto()
        //            {
        //                Id = 1,
        //                Value = 1500
        //            },
        //            new GetTareasQueryValueDto()
        //            {
        //                Id = 2,
        //                Value = 3500
        //            },
        //            new GetTareasQueryValueDto()
        //            {
        //                Id = 3,
        //                Value = 4500
        //            }
        //        };

        //        var response = new GetTareasQueryDto()
        //        {
        //            Tareas = tareas
        //        };

        //        return Succeded(response);
        //    }            
        //}


    }
}
