using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.DepoService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepoController : ControllerBase
    {
        private readonly IDepoService _depoService;
        public DepoController(IDepoService depoService)
        {
            _depoService = depoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Depo>>> GetAllDepos()
        {
            return await _depoService.GetAllDepos();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Depo>> GetSingleDepo(int id)
        {
            var result = await _depoService.GetSingleDepo(id);
            if (result is null)
                return NotFound("Aradağınız depo bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Depo>>> AddDepo(Depo singledepo)
        {
            var result = await _depoService.AddDepo(singledepo);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Depo>>> UpdateDepo(int id, Depo request)
        {
            var result = await _depoService.UpdateDepo(id, request);
            if (result is null)
                return NotFound("Aradağınız depo bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Depo>>> DeleteDepo(int id)
        {
            var result = await _depoService.DeleteDepo(id);
            if (result is null)
                return NotFound("Aradağınız depo bulunamadı.");
            return Ok(result);
        }
    }
}
