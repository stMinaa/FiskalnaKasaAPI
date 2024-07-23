using FiskalnaKasaAPI.Data;
using FiskalnaKasaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiskalnaKasaAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController: ControllerBase
    {

        private readonly KasaContext _context;

        public ServicesController(KasaContext context)
        {
            _context = context;
        }



    }
}
