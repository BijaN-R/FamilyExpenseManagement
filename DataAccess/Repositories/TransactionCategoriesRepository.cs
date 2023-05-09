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

        public async Task<TransActionCategories> AddAsync(TransActionCategories category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<List<TransActionCategories>> GetAllAsync()
        {
            return await _context.TransactionCategories.ToListAsync();
        }

        public async Task<TransActionCategories> GetByIdAsync(int id)
        {
            return await _context.TransactionCategories.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<TransActionCategories>> GetByPartOfNameAsync(string text)
        {
            return await _context.TransactionCategories
                         .Where(t=>t.Name.Contains(text, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<TransActionCategories> UpdateAsync(TransActionCategories category)
        {
            _context.TransactionCategories.Update(category);
            await _context.SaveChangesAsync();

            return category;
        }
    }
}
