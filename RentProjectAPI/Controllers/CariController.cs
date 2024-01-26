using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.CariService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CariController : ControllerBase
    {
        private readonly ICariService _cariService;
        public CariController(ICariService cariService)
        {
            _cariService = cariService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cari>>> GetAllCaris()
        {
            return await _cariService.GetAllCaris();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Cari>> GetSingleCari(int id)
        {
            var result = await _cariService.GetSingleCari(id);
            if (result is null)
                return NotFound("Aradağınız cari bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Cari>>> AddCari(Cari singlecari)
        {
            var result = await _cariService.AddCari(singlecari);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Cari>>> UpdateCari(int id, Cari request)
        {
            var result = await _cariService.UpdateCari(id, request);
            if (result is null)
                return NotFound("Aradağınız cari bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Cari>>> DeleteCari(int id)
        {
            var result = await _cariService.DeleteCari(id);
            if (result is null)
                return NotFound("Aradağınız cari bulunamadı.");
            return Ok(result);
        }
    }
}
