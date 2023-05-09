using AutoMapper;
using Contracts.Services.DTO.TransactionCategories;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AutoMapper
{
    public class TransactionCategoryProfile : Profile
    {
        public TransactionCategoryProfile()
        {
            CreateMap<TransactionCategoriesDto, TransactionCategories>();
            CreateMap<TransactionCategories, TransactionCategoriesResponseDto>();
        }
    }
}
