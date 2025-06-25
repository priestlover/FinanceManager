using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Domain.Entities
{
    internal class FinanceReport
    {
        public DateTime PeriodStart { get; private set; }

        public DateTime PeriodEnd { get; private set;}

        public decimal TotalIncome { get; private set; }

        public decimal TotalExpenses { get; private set; }

        public decimal NetTotal => TotalIncome - TotalExpenses;

        private readonly List<Transaction> _transactions = new();

        public IReadOnlyCollection<Transaction> Transactions => _transactions.AsReadOnly();

        private FinanceReport() {
            
        }

        public  
    }
}
