using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using RentProjectAPI.Services.KasaService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KasaController : ControllerBase
    {
        private readonly IKasaService _kasaService;
        public KasaController(IKasaService kasaService)
        {
            _kasaService = kasaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Kasa>>> GetAllKasas()
        {
            return await _kasaService.GetAllKasas();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Kasa>> GetSingleKasa(int id)
        {
            var result = await _kasaService.GetSingleKasa(id);
            if (result is null)
                return NotFound("Aradağınız kasa bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Kasa>>> AddKasa(Kasa singlekasa)
        {
            var result = await _kasaService.AddKasa(singlekasa);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Kasa>>> UpdateKasa(int id, Kasa request)
        {
            var result = await _kasaService.UpdateKasa(id, request);
            if (result is null)
                return NotFound("Aradağınız kasa bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Kasa>>> DeleteKasa(int id)
        {
            var result = await _kasaService.DeleteKasa(id);
            if (result is null)
                return NotFound("Aradağınız kasa bulunamadı.");
            return Ok(result);
        }
    }
}
