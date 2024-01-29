using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.PcPosMasterService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PcPosMasterController : ControllerBase
    {
        private readonly IPcPosMasterService _pcPosMasterService;
        public PcPosMasterController(IPcPosMasterService pcPosMasterService)
        {
            _pcPosMasterService = pcPosMasterService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PcPosMaster>>> GetAllPcPosMasters()
        {
            return await _pcPosMasterService.GetAllPcPosMasters();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<PcPosMaster>> GetSinglePcPosMaster(int id)
        {
            var result = await _pcPosMasterService.GetSinglePcPosMaster(id);
            if (result is null)
                return NotFound("Aradağınız PcPosMaster bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<PcPosMaster>>> AddPcPosMaster(PcPosMaster singlepcposmaster)
        {
            var result = await _pcPosMasterService.AddPcPosMaster(singlepcposmaster);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<PcPosMaster>>> UpdatePcPosMaster(int id, PcPosMaster request)
        {
            var result = await _pcPosMasterService.UpdatePcPosMaster(id, request);
            if (result is null)
                return NotFound("Aradağınız PcPosMaster bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<PcPosMaster>>> DeletePcPosMaster(int id)
        {
            var result = await _pcPosMasterService.DeletePcPosMaster(id);
            if (result is null)
                return NotFound("Aradağınız PcPosMaster bulunamadı.");
            return Ok(result);
        }
    }
}
