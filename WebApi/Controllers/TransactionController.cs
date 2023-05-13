using Contracts.Services;
using Contracts.Services.DTO.Transaction;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[transaction]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionsService _service;

        public TransactionController(ITransactionsService service)
        {
            _service = service;
        }

        [HttpPost("/add-transaction")]
        public async Task<IActionResult> AddTransaction([FromBody] TransactionDto model)
        {
            var result = await _service.AddAsync(model);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Can't add this transaction!" });
        }

        [HttpPost("/update-transaction")]
        public async Task<IActionResult> UpdateTransaction([FromBody] TransactionUpdateDto model)
        {
            var result = await _service.UpdateAsync(model);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Can't update this transaction!" });
        }

        [HttpDelete("/delete-transaction")]
        public async Task<IActionResult> DeleteTransaction(Guid id)
        {
            var result = await _service.Delete(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Can't delete this transaction!" });
        }

        [HttpGet("/get-transaction-by-id")]
        public async Task<IActionResult> GetTransactionById(Guid id)
        {
            var result = await _service.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "There is no such transaction!" });
        }

        [HttpGet("/get-all-transactions")]
        public async Task<IActionResult> GetAllTransactions()
        {
            var result = await _service.GetAllTransactions();
            if (result.Any())
            {
                return Ok(result);
            }

            return BadRequest(new { message = "There isn't any transaction!" });
        }

        [HttpGet("/get-all-expense-transactions")]
        public async Task<IActionResult> GetAllExpenseTransactions()
        {
            var result = await _service.GetAllExpenseTransactions();
            if (result.Any())
            {
                return Ok(result);
            }

            return BadRequest(new { message = "There isn't any expense transaction!" });
        }

        [HttpGet("/get-all-income-transactions")]
        public async Task<IActionResult> GetAllIncomeTransactions()
        {
            var result = await _service.GetAllIncomeTransactions();
            if (result.Any())
            {
                return Ok(result);
            }

            return BadRequest(new { message = "There isn't any inccme transaction!" });
        }
    }
}
