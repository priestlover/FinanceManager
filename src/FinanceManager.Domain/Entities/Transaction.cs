using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.Domain.Enums;

namespace FinanceManager.Domain.Entities
{
    internal class Transaction
    {
        
        public int Id { get; private set; }

        public string Category { get; private set; }

        public decimal Amount { get; private set; }
        
        public TransactionType TransactionType { get; private set; }

        public PaymentMethod PaymentMethod { get; private set; }

        public string Description { get; private set; }

        public DateTime Date { get; private set; }

        public Guid UserId { get; private set; }

        private Transaction() { }

        public Transaction(string category, decimal amount, TransactionType transactionType, PaymentMethod paymentMethod, string description, DateTime date, Guid userId)
        {
            Category = category;
            Amount = amount;
            TransactionType = transactionType;
            PaymentMethod = paymentMethod;
            Description = description;
            Date = date;
            UserId = userId;
        }
    }
}
