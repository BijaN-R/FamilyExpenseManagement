using Contracts.Services;
using Contracts.Services.DTO.TransactionCategories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[transaction-categories]")]
    public class TransactionCategoriesController : ControllerBase
    {
        private readonly ITransactionCategoriesService _service;

        public TransactionCategoriesController(ITransactionCategoriesService service)
        {
            _service = service;
        }

        [HttpPost("/add-transaction-category")]
        public async Task<IActionResult> AddTransactionCategory([FromBody] TransactionCategoriesDto model)
        {
            var result = await _service.AddTransactionCategory(model);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Can't add this category!" });
        }

        [HttpPost("/update-transaction-category")]
        public async Task<IActionResult> UpdateTransactionCategory([FromBody] TransactionCategoriesDto model)
        {
            var result = await _service.UpdateTransactionCategory(model);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Can't update this category!" });
        }

        [HttpGet("/get-all-transaction-categories")]
        public async Task<IActionResult> GetAllTransactionCategories()
        {
            var result = await _service.GetAllTransactionCategories();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "There is no category!" });
        }

        [HttpGet("/search-transaction-categories")]
        public async Task<IActionResult> Search(string text)
        {
            var result = await _service.SearchTransactionCategories(text);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "There is no such category!" });
        }

        [HttpGet("/get-transaction-categories-by-id")]
        public async Task<IActionResult> Search(int id)
        {
            var result = await _service.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Category not found!" });
        }

    }
}
