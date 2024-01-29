using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.PcMasterService;

namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PcMasterController : ControllerBase
    {
        private readonly IPcMasterService _pcMasterService;
        public PcMasterController(IPcMasterService pcMasterService)
        {
            _pcMasterService = pcMasterService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PcMaster>>> GetAllPcMasters()
        {
            return await _pcMasterService.GetAllPcMasters();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<PcMaster>> GetSinglePcMaster(int id)
        {
            var result = await _pcMasterService.GetSinglePcMaster(id);
            if (result is null)
                return NotFound("Aradağınız PcMaster bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<PcMaster>>> AddPcMaster(PcMaster singlepcmaster)
        {
            var result = await _pcMasterService.AddPcMaster(singlepcmaster);

            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<PcMaster>>> UpdatePcMaster(int id, PcMaster request)
        {
            var result = await _pcMasterService.UpdatePcMaster(id, request);
            if (result is null)
                return NotFound("Aradağınız PcMaster bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<PcMaster>>> DeletePcMaster(int id)
        {
            var result = await _pcMasterService.DeletePcMaster(id);
            if (result is null)
                return NotFound("Aradağınız PcMaster bulunamadı.");
            return Ok(result);
        }
    }
}
