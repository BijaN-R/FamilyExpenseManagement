namespace Domains
{
    public class BankAccounts : BaseModel
    {
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public List<Transactions> Transactions { get; set; }
    }
}
