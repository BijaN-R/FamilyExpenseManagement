using Application.DTO;
using Application.Services.Contracts;
using DataAccess.Repositories.Contracts;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
