using Contracts.Repositories;
using Domains;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class TransactionCategoriesRepository : ITransactionCategoriesRepository
    {
        private readonly ExpenseManagerDbContext _context;

        public TransactionCategoriesRepository(ExpenseManagerDbContext context)
        {
            _context = context;
        }

        public async Task<TransactionCategories> AddAsync(TransactionCategories category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<List<TransactionCategories>> GetAllAsync()
        {
            return await _context.TransactionCategories.ToListAsync();
        }

        public async Task<TransactionCategories> GetByIdAsync(int id)
        {
            return await _context.TransactionCategories.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<TransactionCategories>> GetByPartOfNameAsync(string text)
        {
            return await _context.TransactionCategories
                         .Where(t=>t.Name.Contains(text, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<TransactionCategories> UpdateAsync(TransactionCategories category)
        {
            _context.TransactionCategories.Update(category);
            await _context.SaveChangesAsync();

            return category;
        }
    }
}
