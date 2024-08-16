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
                            && pl.DateEnd >= currentDate )
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

        //2. napraviti novi Service po departmanu u priceList


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
