using FiskalnaKasaAPI.Data;
using FiskalnaKasaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiskalnaKasaAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceItemController : ControllerBase
    {
        private readonly KasaContext _context;

        public InvoiceItemController(KasaContext context)
        {
            _context = context;
        }

        [HttpGet("Customer/{customerId}/Uninvoiced")]
        public async Task<ActionResult<IEnumerable<InvoiceItem>>> GetUninvoicedItemsByCustomer(int customerId)
        {
            var uninvoicedItems = await _context.InvoiceItems
               .Where(ii => ii.CustomerId == customerId && ii.InvoiceId == null)
               .Include(ii => ii.PriceList) // Include the PriceList
               .ThenInclude(pl => pl.Service) // Include the related Service from PriceList
               .ToListAsync();

            if (uninvoicedItems == null || !uninvoicedItems.Any())
            {
                return NotFound("No uninvoiced items found for the selected customer.");
            }

            return Ok(uninvoicedItems);
        }
    }
}
