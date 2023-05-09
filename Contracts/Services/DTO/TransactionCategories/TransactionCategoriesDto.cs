using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Enums;

namespace Contracts.Services.DTO.TransactionCategories
{
    public class TransactionCategoriesDto
    {
        public int Id { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class TransactionCategoriesResponseDto
    {
        public int Id { get; set; }
        public string TransactionType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
