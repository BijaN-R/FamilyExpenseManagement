using AutoMapper;
using Contracts.Services.DTO.TransactionCategories;
using Domains;

namespace DataAccess.AutoMapper
{
    public class TransactionCategoryProfile : Profile
    {
        public TransactionCategoryProfile()
        {
            CreateMap<TransactionCategoriesDto, TransactionCategories>();
            CreateMap<TransactionCategories, TransactionCategoriesResponseDto>()
                .ForMember(des => des.TransactionType, opt => opt.MapFrom(src => src.TransactionType.ToString()));
        }
    }
}
