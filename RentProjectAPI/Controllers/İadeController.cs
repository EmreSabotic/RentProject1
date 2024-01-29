using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.İadeService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class İadeController : ControllerBase
    {
        private readonly IİadeService _iadeService;
        public İadeController(IİadeService iadeService)
        {
            _iadeService = iadeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<İade>>> GetAllİades()
        {
            return await _iadeService.GetAllİades();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<İade>> GetSingleİade(int id)
        {
            var result = await _iadeService.GetSingleİade(id);
            if (result is null)
                return NotFound("Aradağınız iade bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<İade>>> Addİade(İade singleiade)
        {
            var result = await _iadeService.Addİade(singleiade);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<İade>>> Updateİade(int id, İade request)
        {
            var result = await _iadeService.Updateİade(id, request);
            if (result is null)
                return NotFound("Aradağınız iade bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<İade>>> Deleteİade(int id)
        {
            var result = await _iadeService.Deleteİade(id);
            if (result is null)
                return NotFound("Aradağınız iade bulunamadı.");
            return Ok(result);
        }
    }
}
