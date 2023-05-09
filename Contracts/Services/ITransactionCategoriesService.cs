using Contracts.Services.DTO.TransactionCategories;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface ITransactionCategoriesService
    {
        Task<List<TransactionCategoriesResponseDto>> GetAllTransactionCategories();
        Task<List<TransactionCategoriesResponseDto>> SearchTransactionCategories(string text);
        Task<TransactionCategoriesResponseDto> GetById(int id);
        Task<TransactionCategoriesResponseDto> AddTransactionCategory(TransactionCategoriesDto model);
        Task<TransactionCategoriesResponseDto> UpdateTransactionCategory(TransactionCategoriesDto model);
    }
}
