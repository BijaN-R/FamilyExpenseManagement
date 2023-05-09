using Contracts.Repositories;
using Contracts.Services;
using Contracts.Services.DTO;
using Domains;
using Utilities.Extensions;

namespace Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly IFamilyMembersRepository _repository;

        public LoginService(IFamilyMembersRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MemberDto>> GetAll()
        {
            var result = new List<MemberDto>();
            var members = await _repository.GetAllAsync();

            members.ForEach(m =>
               {
                   result.Add(new MemberDto(m.UserName,
                                            m.FirstName,
                                            m.LastName,
                                            m.Email,
                                            m.BirthDate,
                                            m.RelationToHeadOfHousehold.ToString(),
                                            m.PhoneNo));
               });

            return result;
        }

        public async Task<LoginResponseDto> Login(LoginDto model)
        {
            var result = new LoginResponseDto();
            var response = await _repository.GetByUsernameAndPassword(model.Username, model.Password.RenderToHash());
            result.Succeeded = response is null ? false : true;
            return result;
        }

        public async Task<RegisterResponseDto> Register(RegisterDto model)
        {
            var result = new RegisterResponseDto();
            var domainModel = new FamilyMembers()
            {
                UserName = model.Username,
                Password = model.Password.RenderToHash(),
                FirstName = model.Firstname,
                LastName = model.Lastname,
                BirthDate = model.BirthDate,
                PhoneNo = model.PhoneNo,
                Email = model.Email,
                RelationToHeadOfHousehold = model.RelationToHeadOfHousehold
            };

            result.Id = await _repository.AddAsync(domainModel);

            return result;
        }
    }
}
