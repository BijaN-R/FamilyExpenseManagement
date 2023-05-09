using Domains;

namespace Contracts.Repositories
{
    public interface ITransactionCategoriesRepository
    {
        Task<List<TransactionCategories>> GetAllAsync();
        Task<TransactionCategories> GetByIdAsync(int id);
        Task<List<TransactionCategories>> GetByPartOfNameAsync(string text);
        Task<TransactionCategories> AddAsync(TransactionCategories category);
        Task<TransactionCategories> UpdateAsync(TransactionCategories category);
    }
}
