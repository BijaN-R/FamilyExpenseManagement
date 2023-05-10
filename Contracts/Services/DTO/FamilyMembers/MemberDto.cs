namespace Contracts.Services.DTO.FamilyMembers
{
    public class MemberDto
    {
        public MemberDto(int id, string username, string firstname, string lastname, string email, DateTime birthDate, string relationToHeadOfHousehold, string phoneNo)
        {
            Id = id;
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            BirthDate = birthDate;
            RelationToHeadOfHousehold = relationToHeadOfHousehold;
            PhoneNo = phoneNo;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string RelationToHeadOfHousehold { get; set; }
        public string PhoneNo { get; set; }
    }
}
