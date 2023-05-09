using Utilities.Enums;

namespace Domains
{
    public class FamilyMembers : BaseModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now.AddYears(-8);
        public FamilyRelationships RelationToHeadOfHousehold { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public List<Transactions> Transactions { get; set; }
    }
}
