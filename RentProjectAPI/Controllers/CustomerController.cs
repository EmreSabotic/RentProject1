using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentProjectAPI.Services.CustomerService;


namespace RentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
                   _customerService = customerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            return await _customerService.GetAllCustomers();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Customer>> GetSingleCustomer(int id)
        {
            var result = await _customerService.GetSingleCustomer(id);
            if (result is null)
                return NotFound("Aradağınız müşteri bulunamadı.");
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<List<Customer>>> AddCustomer(Customer singlecustomer)
        {
            var result = await _customerService.AddCustomer(singlecustomer);
           
            return Ok(result);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<List<Customer>>> UpdateCustomer(int id, Customer request)
        {
            var result = await _customerService.UpdateCustomer(id, request);
            if (result is null)
                return NotFound("Aradağınız müşteri bulunamadı.");
            return Ok(result);
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Customer>>> DeleteCustomer(int id)
        {
           var result = await _customerService.DeleteCustomer(id);
            if (result is null)
                return NotFound("Aradağınız müşteri bulunamadı.");
            return Ok(result);
        }


    }
}
