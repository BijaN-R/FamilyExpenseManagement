using Contracts.Repositories;
using Domains;
using Microsoft.EntityFrameworkCore;
using Utilities.Enums;

namespace DataAccess.Repositories
{
    public class TransactionRepository : ITransactionsRepository
    {
        private readonly ExpenseManagerDbContext _context;

        public TransactionRepository(ExpenseManagerDbContext context)
        {
            _context = context;
        }

        public async Task<Transactions> AddAsync(Transactions transaction)
        {
            await _context.AddAsync(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }

        public Task<Transactions> Delete(Transactions transaction)
        {
            return Task.FromResult(_context.Remove(transaction).Entity);
        }

        public async Task<List<Transactions>> GetAllExpenseTransactions()
        {
            return await _context.Transactions.Where(x => x.TransactionType == TransactionTypes.Expense).ToListAsync();
        }

        public async Task<List<Transactions>> GetAllIncomeTransactions()
        {
            return await _context.Transactions.Where(x=>x.TransactionType == TransactionTypes.Income).ToListAsync();
        }

        public async Task<List<Transactions>> GetAllTransactions()
        {
            return await _context.Transactions.ToListAsync();
        }

        public async Task<Transactions> GetByIdAsync(Guid id)
        {
           return await _context.Transactions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Transactions> UpdateAsync(Transactions transaction)
        {
            _context.Update(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }
    }
}
