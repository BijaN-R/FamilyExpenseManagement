using Contracts.Repositories;
using Domains;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Repositories
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly ExpenseManagerDbContext _context;

        public BankAccountRepository(ExpenseManagerDbContext context)
        {
            _context = context;
        }

        public async Task<BankAccounts> AddAsync(BankAccounts account)
        {
            await _context.BankAccounts.AddAsync(account);
            await _context.SaveChangesAsync();

            return account;
        }

        public async Task<List<BankAccounts>> GetAll()
        {
            return await _context.BankAccounts.ToListAsync();
        }

        public async Task<BankAccounts> GetById(int id)
        {
            return await _context.BankAccounts.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<BankAccounts> UpdateAsync(BankAccounts account)
        {
            var result = _context.BankAccounts.Update(account).Entity;
            await _context.SaveChangesAsync();
            return result;
        }
    }
}
