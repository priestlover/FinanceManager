using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Transactions.Queries.GetTransactionById
{
    public class GetTransactionByIdQuery : IRequest<Transaction?>
    {
        public Guid TransactionId { get; set; }
    }
}
