using Application.UseCases.Transactions.Queries.GetTransactions;
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
    }
}
