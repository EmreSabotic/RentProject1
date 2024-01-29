using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.DövizService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DövizController : ControllerBase
    {
        private readonly IDövizService _dövizService;
        public DövizController(IDövizService dövizService)
        {
            _dövizService = dövizService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Döviz>>> GetAllDövizs()
        {
            return await _dövizService.GetAllDövizs();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Döviz>> GetSingleDöviz(int id)
        {
            var result = await _dövizService.GetSingleDöviz(id);
            if (result is null)
                return NotFound("Aradağınız döviz bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Döviz>>> AddBirim(Döviz singledöviz)
        {
            var result = await _dövizService.AddDöviz(singledöviz);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Döviz>>> UpdateDöviz(int id, Döviz request)
        {
            var result = await _dövizService.UpdateDöviz(id, request);
            if (result is null)
                return NotFound("Aradağınız döviz bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Döviz>>> DeleteDöviz(int id)
        {
            var result = await _dövizService.DeleteDöviz(id);
            if (result is null)
                return NotFound("Aradağınız döviz bulunamadı.");
            return Ok(result);
        }
    }
}
