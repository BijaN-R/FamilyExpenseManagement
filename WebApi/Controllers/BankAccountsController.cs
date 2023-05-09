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

        [HttpPost("/update-account")]
        public async Task<IActionResult> UpdateBankAccount([FromBody] BankAccountDto model)
        {
            var result = await _service.UpdateAccount(model);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Update error!" });
        }

        [HttpGet("/get-all-bank-accounts")]
        public async Task<IActionResult> GetAllAccounts()
        {
            var result = await _service.GetAllAccounts();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Can't find any account!" });
        }

        [HttpGet("/get-account-by-id")]
        public async Task<IActionResult> GetAccount(int id)
        {
            var result = await _service.GetAccountById(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Can not find this account!" });
        }
    }
}
