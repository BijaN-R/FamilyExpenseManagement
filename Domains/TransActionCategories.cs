
using System.ComponentModel.DataAnnotations;
using Utilities.Enums;

namespace Domains
{
    public class TransActionCategories : BaseModel
    {
        public TransactionTypes TransactionType { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
