using Contracts.Services.DTO.BankAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IBankAccountService
    {
        Task<BankAccountResponseDto> AddAccount(BankAccountDto account);
    }
}
