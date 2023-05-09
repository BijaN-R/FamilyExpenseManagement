using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
