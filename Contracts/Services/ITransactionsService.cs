using Contracts.Services.DTO.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface ITransactionsService
    {
        Task<TransactionResponseDto> AddAsync(TransactionDto transaction);
        Task<TransactionResponseDto> UpdateAsync(TransactionUpdateDto transaction);
        Task<TransactionResponseDto> Delete(Guid id);
        Task<TransactionResponseDto> GetById(Guid id);
        Task<List<TransactionResponseDto>> GetAllTransactions();
        Task<List<TransactionResponseDto>> GetAllIncomeTransactions();
        Task<List<TransactionResponseDto>> GetAllExpenseTransactions();
    }
}
