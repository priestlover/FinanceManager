using FinanceManager.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommandHandler : IRequestHandler<CreateTransactionCommand, Guid>
    {
        private readonly ITransactionRepository _transactionRepository;

        public CreateTransactionCommandHandler(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<Guid> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            var transaction =  new Transaction(request.Category, request.Description, request.Amount, request.TransactionType, request.PaymentMethod, request.Date);
             await _transactionRepository.AddAsync(transaction);
             return transaction.Id;
        }


    }
}
