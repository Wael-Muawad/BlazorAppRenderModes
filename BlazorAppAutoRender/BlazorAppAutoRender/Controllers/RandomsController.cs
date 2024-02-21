using BlazorAppAutoRender.Client.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppAutoRender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomsController : ControllerBase
    {
        private readonly ISomeRandomData _randomDataService;

        public RandomsController(ISomeRandomData randomDataService)
        {
            _randomDataService=randomDataService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRandomData()
        {
            var result = await _randomDataService.GetDummyData();
            return Ok(result);
        }
    }
}
