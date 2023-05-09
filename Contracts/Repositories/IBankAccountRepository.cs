using Domains;

namespace Contracts.Repositories
{
    public interface IBankAccountRepository
    {
        Task<BankAccounts> AddAsync(BankAccounts account);
        Task<BankAccounts> UpdateAsync(BankAccounts account);
        Task<BankAccounts> GetById(int id);
        Task<List<BankAccounts>> GetAll();
    }
}
