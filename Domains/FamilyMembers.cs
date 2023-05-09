using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Utilities.Enums;

namespace Domains
{
    [Index(nameof(UserName), IsUnique = true)]
    public class FamilyMembers : BaseModel
    {
        [Required]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now.AddYears(-8);
        public FamilyRelationships RelationToHeadOfHousehold { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
    }
}
