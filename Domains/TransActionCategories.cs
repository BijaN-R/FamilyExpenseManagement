using Utilities.Enums;

namespace Domains
{
    public class TransactionCategories : BaseModel
    {
        public TransactionTypes TransactionType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Transactions> Transactions { get; set; }
    }
}
