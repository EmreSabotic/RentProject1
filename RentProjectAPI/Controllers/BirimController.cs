using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.BirimService;


namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirimController : ControllerBase
    {
        private readonly IBirimService _birimService;
        public BirimController(IBirimService birimService)
        {
            _birimService = birimService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Birim>>> GetAllBirims()
        {
            return await _birimService.GetAllBirims();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Birim>> GetSingleBirim(int id)
        {
            var result = await _birimService.GetSingleBirim(id);
            if (result is null)
                return NotFound("Aradağınız birim bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Birim>>> AddBirim(Birim singlebirim)
        {
            var result = await _birimService.AddBirim(singlebirim);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Birim>>> UpdateBirim(int id, Birim request)
        {
            var result = await _birimService.UpdateBirim(id, request);
            if (result is null)
                return NotFound("Aradağınız birim bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Birim>>> DeleteBirim(int id)
        {
            var result = await _birimService.DeleteBirim(id);
            if (result is null)
                return NotFound("Aradağınız birim bulunamadı.");
            return Ok(result);
        }


    }

}

