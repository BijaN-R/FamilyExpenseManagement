using Utilities.Enums;

namespace Application.DTO
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public FamilyRelationships RelationToHeadOfHousehold { get; set; }
        public string PhoneNo { get; set; }
    }
    public class RegisterResponseDto
    {
        public int Id { get; set; }
    }
}
