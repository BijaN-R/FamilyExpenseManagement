using System.ComponentModel.DataAnnotations;
using Utilities.Enums;

namespace Domains
{
    public class Transactions : BaseModel<Guid>
    {
        [Required]
        public TransactionTypes TransactionType { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public TransActionCategories Category { get; set; }
        public BankAccounts Account { get; set; }
        public FamilyMembers Transactor { get; set; }
    }
}
