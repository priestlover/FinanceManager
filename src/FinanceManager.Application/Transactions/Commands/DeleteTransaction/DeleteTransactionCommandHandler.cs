using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using FinanceManager.Domain.Interfaces;

namespace FinanceManager.Application.Transactions.Commands.DeleteTransaction
{
    public class DeleteTransactionCommandHandler : IRequestHandler<DeleteTransactionCommand,Unit>
    {
        private readonly ITransactionRepository _transactionRepository;

        public DeleteTransactionCommandHandler(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<Unit> Handle(DeleteTransactionCommand request, CancellationToken cancellationToken)
        {
            await _transactionRepository.DeleteAsync(request.TransactionId);
            return Unit.Value;
        }
    }
}
