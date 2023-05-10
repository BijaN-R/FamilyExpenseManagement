using AutoMapper;
using Contracts.Services.DTO.Transaction;
using Domains;

namespace DataAccess.AutoMapper
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transactions, TransactionResponseDto>()
                .ForMember(des => des.TransactionType, opt => opt.MapFrom(src => src.TransactionType.ToString()));
            CreateMap<TransactionDto, Transactions>();
        }
    }
}
