using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.UrunlerService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlerController : ControllerBase
    {
        private readonly IUrunlerService _urunlerService;
        public UrunlerController(IUrunlerService urunlerService)
        {
            _urunlerService = urunlerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Urunler>>> GetAllUruns()
        {
            return await _urunlerService.GetAllUruns();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Urunler>> GetSingleUrun(int id)
        {
            var result = await _urunlerService.GetSingleUrun(id);
            if (result is null)
                return NotFound("Aradağınız ürün bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Urunler>>> AddUrun(Urunler singleurun)
        {
            var result = await _urunlerService.AddUrun(singleurun);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Urunler>>> UpdateUrun(int id, Urunler request)
        {
            var result = await _urunlerService.UpdateUrun(id, request);
            if (result is null)
                return NotFound("Aradağınız ürün bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Urunler>>> DeleteUrun(int id)
        {
            var result = await _urunlerService.DeleteUrun(id);
            if (result is null)
                return NotFound("Aradağınız ürün bulunamadı.");
            return Ok(result);
        }

    }
}
