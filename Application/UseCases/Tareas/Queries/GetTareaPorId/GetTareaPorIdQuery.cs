
using Application.UseCases.Common.Results;
using MediatR;

namespace Application.UseCases.Tareas.Queries.GetTareaPorId
{
    
    public record GetTareaPorIdQuery(Guid Id) : IRequest<Result<GetTareaPorIdQueryDto>>;
}
