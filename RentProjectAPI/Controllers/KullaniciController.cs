using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.CustomerService;
using RentProjectAPI.Services.KategorilerService;
using RentProjectAPI.Services.KullaniciService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciService _kullaniciService;
        public KullaniciController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Kullanici>>> GetAllKullanicis()
        {
            return await _kullaniciService.GetAllKullanicis();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Kullanici>> GetSingleKullanici(int id)
        {
            var result = await _kullaniciService.GetSingleKullanici(id);
            if (result is null)
                return NotFound("Aradağınız kullanici bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Kullanici>>> AddKullanici(Kullanici singlekullanici)
        {
            var result = await _kullaniciService.AddKullanici(singlekullanici);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Kullanici>>> UpdateKullanici(int id, Kullanici request)
        {
            var result = await _kullaniciService.UpdateKullanici(id, request);
            if (result is null)
                return NotFound("Aradağınız kullanıcı bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Kullanici>>> DeleteKullanici(int id)
        {
            var result = await _kullaniciService.DeleteKullanici(id);
            if (result is null)
                return NotFound("Aradağınız kullanıcı bulunamadı.");
            return Ok(result);
        }
    }
}
