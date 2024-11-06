using Microsoft.AspNetCore.Mvc;
using FiskalnaKasaAPI.Models;
using System.Linq;
using FiskalnaKasaAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace FiskalnaKasaAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PriceListController : ControllerBase
    {

        private readonly KasaContext _context;

        public PriceListController(KasaContext context)
        {
            _context = context;
        }


        // 1. Vraća važeće PriceList objekte za određeni Department
        [HttpGet("department/{departmentId}/valid")]
        public IActionResult GetValidPriceLists(int departmentId)
        {
            var currentDate = DateOnly.FromDateTime(DateTime.Now);
            var validPrices = _context.PriceLists
                .Where(pl => pl.DeparmentId == departmentId
                            && pl.DateStart <= currentDate
                            && pl.DateEnd >= currentDate
                            && pl.Service.IsActive==true )
                 .Select(pl => new
                 {
                     pl.Id,
                     pl.Price,
                     pl.DateStart,
                     pl.DateEnd,
                     ServiceName = pl.Service.ServiceName,
                     ServiceNumber = pl.Service.ServiceNumber
                 })
                  .ToList();

            if (validPrices.Count == 0)
                return NotFound("No valid services found for this department.");

            return Ok(validPrices);
        }

        //kad saljemo req, ne stavljamo iz active i id
        //2. napraviti novi Service po departmanu u priceList
        [HttpPost("{departmentId}/services")]
        public async Task<IActionResult> AddServiceToDepartment(int departmentId, [FromBody] Service newService, decimal price, int pdv)
        {
            // Check if the department exists
            var department = await _context.Departments.FindAsync(departmentId);
            if (department == null)
            {
                return NotFound("Department not found");
            }

            // Add the new service to the database and save changes to get a valid ServiceId
            newService.IsActive = true;
            _context.Services.Add(newService);
            await _context.SaveChangesAsync();

            // Create a new PriceList entry for the saved service with a valid ServiceId
            var priceListEntry = new PriceList
            {
                DeparmentId = departmentId,
                ServiceId = newService.Id, // This should now be valid
                Price = price, // Default price; update as necessary
                DateStart = DateOnly.FromDateTime(DateTime.Now),
                PDVPercent = pdv,
                PDVDateStart = DateOnly.FromDateTime(DateTime.Now)
            };
            _context.PriceLists.Add(priceListEntry);

            // Save the PriceList entry to the database
            await _context.SaveChangesAsync();

            return Ok(newService);
        }



        // 3. Promeni cenu (Kreiranje nove instance sa novom cenom)
        [HttpPut("api/PriceList/{id}/Update")]
        public IActionResult UpdatePriceList(int id, [FromBody] PriceList updatedPriceList)
        {
            var existingPriceList = _context.PriceLists
                .FirstOrDefault(pl => pl.Id == id);

            if (existingPriceList == null)
            {
                return NotFound($"PriceList with Id {id} not found.");
            }

            bool priceChanged = existingPriceList.Price != updatedPriceList.Price;
            bool pdvChanged = existingPriceList.PDVPercent != updatedPriceList.PDVPercent;

            if (!priceChanged || !pdvChanged)
            {
                // Ako nisu promenjeni Price, ne dozvoliti promenu DateStart
                if (existingPriceList.DateStart != updatedPriceList.DateStart ||
                    existingPriceList.PDVDateStart != updatedPriceList.PDVDateStart)
                {
                    return BadRequest("DateStart or PDVDateStart cannot be changed unless Price or PDV are updated.");
                }
            }


            // Kreiramo novu instancu PriceList sa ažuriranim vrednostima
            var newPriceList = new PriceList
            {
                DeparmentId = existingPriceList.DeparmentId, // Zadržavamo originalne vrednosti
                ServiceId = existingPriceList.ServiceId, // Zadržavamo originalne vrednosti
                Price = updatedPriceList.Price,
                DateStart = DateOnly.FromDateTime(DateTime.UtcNow), // Postavljamo trenutni datum kao DateStart
                DateEnd = updatedPriceList.DateEnd,
                PDVPercent = updatedPriceList.PDVPercent,
                PDVDateStart = DateOnly.FromDateTime(DateTime.UtcNow),
                PDVDateEnd = updatedPriceList.PDVDateEnd
            };

            _context.PriceLists.Add(newPriceList);
            _context.SaveChanges();

            return Ok(newPriceList);
        }


    }
}
