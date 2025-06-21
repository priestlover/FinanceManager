using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Domain.Entities
{
    internal class FinanceReport
    {
        public Guid Id { get; private set; }

        public DateTime PeriodStart { get; private set; }

        public DateTime PeriodEnd { get; private set;}

        public decimal TotalIncome { get; private set; }

        public decimal TotalExpenses { get; private set; }

        public decimal NetTotal => TotalIncome - TotalExpenses;

        public List<Transaction> Transactions { get; private set; }

        public Guid UserId { get; private set; }

        private FinanceReport() { }

        public FinanceReport(Guid id, DateTime periodStart, DateTime periodEnd, decimal totalIncome, decimal totalExpenses, List<Transaction> transactions, Guid userId)
        {
            Id = Guid.NewGuid();
            PeriodStart = periodStart;
            PeriodEnd = periodEnd;
            TotalIncome = totalIncome;
            TotalExpenses = totalExpenses;
            Transactions = new List<Transaction>();
            UserId = userId;
        }
    }
}
