using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using MediatR;

namespace Application.UseCases.Transactions.Queries.GetTransactions
{
    public class GetTareasQuery : IRequest<Result<GetTareasQueryDto>>
    {
        public class GetTransactionsQueryHandler() : UseCaseHandler, IRequestHandler<GetTareasQuery, Result<GetTareasQueryDto>>
        {
            public async Task<Result<GetTareasQueryDto>> Handle(GetTareasQuery request, CancellationToken cancellationToken)
            {
                await Task.CompletedTask;

                var tareas = new List<GetTareasQueryValueDto>()
                {
                    new GetTareasQueryValueDto()
                    {
                        Id = 1,
                        Value = 1500
                    },
                    new GetTareasQueryValueDto()
                    {
                        Id = 2,
                        Value = 3500
                    },
                    new GetTareasQueryValueDto()
                    {
                        Id = 3,
                        Value = 4500
                    }
                };

                var response = new GetTareasQueryDto()
                {
                    Tareas = tareas
                };

                return Succeded(response);
            }

            //public async Task<Result<GetTransactionsQueryDto>> Handle(GetTransactionsQuery request, CancellationToken cancellationToken)
            //{
            //    var result = await repository.GetAllAsync();

            //    var transactions = result.Select(x => new GetTransactionsQueryValueDto
            //    {
            //        Id = x.Id,
            //        Title = x.Title,
            //    }).ToList();

            //    var response = new GetTransactionsQueryDto()
            //    {
            //        Transactions = transactions
            //    };

            //    return Succeded(response);
            //}
        }
    }
}
