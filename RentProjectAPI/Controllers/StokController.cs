using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.StokService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StokController : ControllerBase
    {
        private readonly IStokService _stokService;
        public StokController(IStokService stokService)
        {
            _stokService = stokService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Stok>>> GetAllStoks()
        {
            return await _stokService.GetAllStoks();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Stok>> GetSingleStok(int id)
        {
            var result = await _stokService.GetSingleStok(id);
            if (result is null)
                return NotFound("Aradağınız Stok bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Stok>>> AddStok(Stok singlestok)
        {
            var result = await _stokService.AddStok(singlestok);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Stok>>> UpdateStok(int id, Stok request)
        {
            var result = await _stokService.UpdateStok(id, request);
            if (result is null)
                return NotFound("Aradağınız Stok bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Stok>>> DeleteStok(int id)
        {
            var result = await _stokService.DeleteStok(id);
            if (result is null)
                return NotFound("Aradağınız stok bulunamadı.");
            return Ok(result);
        }
    }
}
