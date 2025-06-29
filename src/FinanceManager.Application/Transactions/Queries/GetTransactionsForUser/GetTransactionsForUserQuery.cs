using FinanceManager.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Application.Transactions.Queries.GetTransactionsForUser
{
    public class GetTransactionsForUserQuery : IRequest<List<Transaction>>
    {
        public Guid UserId {  get; set; }
    }
}
