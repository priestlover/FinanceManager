using FinanceManager.Application.Transactions.Commands.CreateTransaction;
using FinanceManager.Application.Transactions.Commands.DeleteTransaction;
using FinanceManager.Application.Transactions.Queries.GetTransactionById;
using FinanceManager.Application.Transactions.Queries.GetTransactionsForUser;
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

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _mediator.Send(new GetTransactionByIdQuery {TransactionId = id });
            return Ok(result);
        }

        [HttpGet("user/{userId:guid}")]
        public async Task<IActionResult> GetByUser(Guid userId)
        {
            var result = await _mediator.Send(new GetTransactionsForUserQuery { UserId = userId });
            return Ok(result);
        }

        [HttpDelete("{id:guid}")]
        public async Task <IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteTransactionCommand { TransactionId = id});
            return NoContent();
        }

    }
}
