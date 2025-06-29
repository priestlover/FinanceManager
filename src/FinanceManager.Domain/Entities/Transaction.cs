using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.Domain.Enums;

namespace FinanceManager.Domain.Entities
{
    public class Transaction
    {
        
        public Guid Id { get; private set; }

        public string Category { get; private set; }

        public string Description { get; private set; }

        public decimal Amount { get; private set; }
        
        public TransactionType TransactionType { get; private set; }

        public PaymentMethod PaymentMethod { get; private set; }

        public DateTime Date { get; private set; }

        public Guid UserId { get; private set; }    

        private Transaction() { }

        public Transaction(string category, string description, decimal amount, string transactionType, string paymentMethod, DateTime date)
        {
            Id = Guid.NewGuid();
            Category = category;
            Description = description;
            Amount = amount;
            TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), transactionType);
            PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), paymentMethod);
            Date = date;
        }

    }
}
