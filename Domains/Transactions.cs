using Utilities.Enums;

namespace Domains
{
    public class Transactions : BaseModel<Guid>
    {
        public TransactionTypes TransactionType { get; set; }
        public int Amount { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TransActionCategories Category { get; set; }
        public Accounts Account { get; set; }
        public FamilyMembers Transactor { get; set; }
    }
}
