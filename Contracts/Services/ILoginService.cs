﻿using Contracts.Services.DTO.FamilyMembers;

namespace Contracts.Services
{
    public interface ILoginService
    {
        Task<LoginResponseDto> Login(LoginDto model);
        Task<RegisterResponseDto> Register(RegisterDto model);
        Task<List<MemberDto>> GetAll();
    }
}