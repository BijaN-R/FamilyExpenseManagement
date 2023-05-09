using Contracts.Services;
using Contracts.Services.DTO.BankAccounts;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[bank-accounts]")]
    public class BankAccountsController : ControllerBase
    {
        private readonly IBankAccountService _service;

        public BankAccountsController(IBankAccountService service)
        {
            _service = service;
        }

        [HttpPost("/add-account")]
        public async Task<IActionResult> AddBankAccount([FromBody] BankAccountDto model)
        {
            var result = await _service.AddAccount(model);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Can't add this account!" });
        }
    }
}
