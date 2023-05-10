using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Enums;

namespace Contracts.Services.DTO.Transaction
{
    public class TransactionDto
    {
        public TransactionTypes TransactionType { get; set; }
        public int Amount { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int BankAccountId { get; set; }
        public int FamilyMemberId { get; set; }
    }

    public class TransactionUpdateDto : TransactionDto
    {
        public Guid Id { get; set; }
    }

    public class TransactionResponseDto
    {
        public Guid Id { get; set; }
        public string TransactionType { get; set; }
        public int Amount { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int BankAccountId { get; set; }
        public int FamilyMemberId { get; set; }
    }
}
