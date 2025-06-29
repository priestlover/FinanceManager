using FinanceManager.Domain.Entities;
using FinanceManager.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Application.Transactions.Queries.GetTransactionsForUser
{
    public class GetTransactionForUserQueryHandler : IRequestHandler<GetTransactionsForUserQuery, List<Transaction>> 
    {
        private readonly ITransactionRepository _transactionRepository;

        public GetTransactionForUserQueryHandler(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<List<Transaction>> Handle(GetTransactionsForUserQuery request, CancellationToken cancellationToken)
        {
            return await _transactionRepository.GetAllByUserAsync(request.UserId);
        }
        

        
    }
}
