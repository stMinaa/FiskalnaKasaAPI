using FiskalnaKasaAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiskalnaKasaAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly KasaContext _context;

        public CustomerController(KasaContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {

            var pacijenti = await _context.Customers.ToListAsync();
            return Ok(pacijenti);
        }
    }
}
