using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.KategorilerService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorilerController : ControllerBase
    {
        private readonly IKategorilerService _kategorilerService;
        public KategorilerController(IKategorilerService kategorilerService)
        {
            _kategorilerService = kategorilerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Kategoriler>>> GetAllKategoris()
        {
            return await _kategorilerService.GetAllKategoris();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Kategoriler>> GetSingleKategori(int id)
        {
            var result = await _kategorilerService.GetSingleKategori(id);
            if (result is null)
                return NotFound("Aradağınız kategori bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Kategoriler>>> AddKategori(Kategoriler singlekategori)
        {
            var result = await _kategorilerService.AddKategori(singlekategori);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Kategoriler>>> UpdateKategori(int id, Kategoriler request)
        {
            var result = await _kategorilerService.UpdateKategori(id, request);
            if (result is null)
                return NotFound("Aradağınız kategori bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Kategoriler>>> DeleteKategori(int id)
        {
            var result = await _kategorilerService.DeleteKategori(id);
            if (result is null)
                return NotFound("Aradağınız kategori bulunamadı.");
            return Ok(result);
        }
    }
}
