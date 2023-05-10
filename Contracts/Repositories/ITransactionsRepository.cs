using Domains;

namespace Contracts.Repositories
{
    public interface ITransactionsRepository
    {
        Task<Transactions> AddAsync(Transactions transaction);
        Task<Transactions> UpdateAsync(Transactions transaction);
        Task<Transactions> Delete(Transactions transaction);
        Task<Transactions> GetByIdAsync(Guid id);
        Task<List<Transactions>> GetAllTransactions();
        Task<List<Transactions>> GetAllIncomeTransactions();
        Task<List<Transactions>> GetAllExpenseTransactions();
    }
}
