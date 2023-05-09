using Contracts.Services.DTO.BankAccounts;

namespace Contracts.Services
{
    public interface IBankAccountService
    {
        Task<BankAccountResponseDto> AddAccount(BankAccountDto account);
        Task<BankAccountResponseDto> UpdateAccount(BankAccountDto account);
        Task<List<BankAccountResponseDto>> GetAllAccounts();
        Task<BankAccountResponseDto> GetAccountById(int id);
    }
}
