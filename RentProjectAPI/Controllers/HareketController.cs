using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.HareketService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HareketController : ControllerBase
    {
        private readonly IHareketService _hareketService;
        public HareketController(IHareketService hareketService)
        {
            _hareketService = hareketService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hareket>>> GetAllHarekets()
        {
            return await _hareketService.GetAllHarekets();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Hareket>> GetSingleHareket(int id)
        {
            var result = await _hareketService.GetSingleHareket(id);
            if (result is null)
                return NotFound("Aradağınız Hareket bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Hareket>>> AddHareket(Hareket singlehareket)
        {
            var result = await _hareketService.AddHareket(singlehareket);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Hareket>>> UpdateHareket(int id, Hareket request)
        {
            var result = await _hareketService.UpdateHareket(id, request);
            if (result is null)
                return NotFound("Aradağınız Hareket bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Hareket>>> DeleteHareket(int id)
        {
            var result = await _hareketService.DeleteHareket(id);
            if (result is null)
                return NotFound("Aradağınız Hareket bulunamadı.");
            return Ok(result);
        }

    }
}
