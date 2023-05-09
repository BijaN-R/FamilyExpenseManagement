using Domains;

namespace Contracts.Repositories
{
    public interface IBankAccountRepository
    {
        Task<BankAccounts> AddAsync(BankAccounts accounts);
    }
}
