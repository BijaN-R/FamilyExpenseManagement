using System.ComponentModel.DataAnnotations;

namespace Domains
{
    public class BankAccounts : BaseModel
    {
        [Required]
        public string BankName { get; set; }
        public string AccountNo { get; set; }
    }
}
