using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services.DTO.FamilyMembers
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class LoginResponseDto
    {
        public bool Succeeded { get; set; }
    }
}
