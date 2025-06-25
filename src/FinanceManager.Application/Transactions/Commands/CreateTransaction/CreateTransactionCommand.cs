using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using FinanceManager.Domain.Interfaces;
using MediatR;


namespace FinanceManager.Application.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }

        public string Category { get; set; }

        public string Description { get; set; } = "";

        public decimal Amount { get; set; }

        public string TransactionType { get; set; }

        public string PaymentMethod { get; set; }

        public DateTime Date { get; set; }

    }



}
