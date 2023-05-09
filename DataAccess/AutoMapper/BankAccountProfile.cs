using AutoMapper;
using Contracts.Services.DTO.BankAccounts;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AutoMapper
{
    public class BankAccountProfile : Profile
    {
        public BankAccountProfile()
        {
            CreateMap<BankAccounts, BankAccountResponseDto>();
            CreateMap<BankAccountDto, BankAccounts>();
        }

    }
}
