using FiskalnaKasaAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiskalnaKasaAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly KasaContext _context;

        public UserController(KasaContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetCashiers()
        {

            var kasiri = await _context.Users.ToListAsync();
            return Ok(kasiri);
        }
    }
}
