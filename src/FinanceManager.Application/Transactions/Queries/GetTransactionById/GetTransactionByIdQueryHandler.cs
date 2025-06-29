using FinanceManager.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Transactions.Queries.GetTransactionById
{
    public class GetTransactionByIdQueryHandler : IRequestHandler<GetTransactionByIdQuery,Transaction?>
    {
        private readonly ITransactionRepository _transactionRepository;

        public GetTransactionByIdQueryHandler(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<Transaction?> Handle(GetTransactionByIdQuery request, CancellationToken cancellationToken)
        {
            return await _transactionRepository.GetByIdAsync(request.TransactionId);
        }

    }
}
