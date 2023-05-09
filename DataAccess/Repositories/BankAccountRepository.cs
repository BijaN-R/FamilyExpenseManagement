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

        public async Task<BankAccounts> AddAsync(BankAccounts accounts)
        {
            await _context.BankAccounts.AddAsync(accounts);
            await _context.SaveChangesAsync();

            return accounts;
        }
    }
}
