using Utilities.Enums;

namespace Domains
{
    public class Transactions : BaseModel<Guid>
    {
        public TransactionTypes TransactionType { get; set; }
        public int Amount { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int BankAccountId { get; set; }
        public int FamilyMemberId { get; set; }
        public TransactionCategories Category { get; set; }
        public BankAccounts BankAccount { get; set; }
        public FamilyMembers FamilyMember { get; set; }
    }
}
