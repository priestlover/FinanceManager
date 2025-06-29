using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Domain.Interfaces
{
    public interface ITransactionRepository
    {
        Task AddAsync(Transaction transaction);
        Task<Transaction?> GetByIdAsync(Guid id);
        Task<List<Transaction>> GetAllByUserAsync(Guid userId);
        Task DeleteAsync(Guid id);
    }
}
