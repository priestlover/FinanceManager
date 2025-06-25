using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Domain.Entities
{
    internal class Budget
    {
        public Guid Id { get; private set; }

        public string Category { get; private set; }

        public decimal Limit { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        private Budget() { }

    }
}
