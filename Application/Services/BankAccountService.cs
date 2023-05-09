using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Contracts.Services.DTO.BankAccounts;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _repository;
        private readonly IMapper _mapper;

        public BankAccountService(IBankAccountRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BankAccountResponseDto> AddAccount(BankAccountDto account)
        {
            var model = _mapper.Map<BankAccounts>(account);
            var response = await _repository.AddAsync(model);

            return _mapper.Map<BankAccountResponseDto>(response);
        }
    }
}
