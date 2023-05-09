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
        Task<List<TransActionCategories>> GetAllAsync();
        Task<TransActionCategories> GetByIdAsync(int id);
        Task<List<TransActionCategories>> GetByPartOfNameAsync(string text);
        Task<TransActionCategories> AddAsync(TransActionCategories category);
        Task<TransActionCategories> UpdateAsync(TransActionCategories category);
    }
}
