using FinanceManager.Domain.Entities;
using FinanceManager.Domain.Interfaces;
using FinanceManager.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Persistence.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext _context;

        public TransactionRepository(ApplicationDbContext context)  
        {
            _context = context;
        }

        public async Task AddAsync(Transaction transaction)
        {
            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var transaction = await _context.Transactions.FirstOrDefaultAsync(x => x.Id == id);
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Transaction>> GetAllByUserAsync(Guid userId)
        {
            return await _context.Transactions.AsNoTracking().Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id)
        {
            return await _context.Transactions.AsNoTracking().FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
