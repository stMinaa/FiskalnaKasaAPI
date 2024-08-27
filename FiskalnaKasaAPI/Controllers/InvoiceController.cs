using Microsoft.AspNetCore.Mvc;
using FiskalnaKasaAPI.Models;
using System.Linq;
using FiskalnaKasaAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace FiskalnaKasaAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {

        private readonly KasaContext _context;

        public InvoiceController(KasaContext context)
        {
            _context = context;
        }


        


    }
}
