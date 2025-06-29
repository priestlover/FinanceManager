using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Application.Transactions.Commands.DeleteTransaction
{
    public class DeleteTransactionCommand : IRequest<Unit>
    {
        public Guid TransactionId { get; set; }
    }
}
