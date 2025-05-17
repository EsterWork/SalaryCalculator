using Microsoft.AspNetCore.Mvc;
using SalaryCalculatorApi.Models;
using SalaryCalculatorApi.Services;

namespace SalaryCalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalaryController : ControllerBase
    {
        private readonly SalaryService _salaryService;

        public SalaryController()
        {
            _salaryService = new SalaryService(); 
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] SalaryRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _salaryService.CalculateSalary(request);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
