using Microsoft.AspNetCore.Mvc;
using FiskalnaKasaAPI.Models;
using System.Linq;
using FiskalnaKasaAPI.Data;
using Microsoft.EntityFrameworkCore;


namespace FiskalnaKasaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {

        private readonly KasaContext _context;

        public DepartmentController(KasaContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            
            var activeDepartments = await _context.Departments
                                                  .Where(d => d.IsActive) // Filter for active departments
                                                  .ToListAsync();
            return Ok(activeDepartments);
        }

    }
}
