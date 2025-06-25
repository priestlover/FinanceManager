using FinanceManager.Application.Transactions.Commands.CreateTransaction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FinanceManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {
        private readonly IMediator _mediator;

        public TransactionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTransactionCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }
    }
}
