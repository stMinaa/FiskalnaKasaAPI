using FiskalnaKasaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiskalnaKasaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly InvoiceService _invoiceService;

        public InvoiceController(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost("create-by-patient")]
        public async Task<IActionResult> CreateInvoiceForPatient(int userId, int patientId)
        {
            try
            {
                var invoice = await _invoiceService.CreateInvoiceForPatientAsync(userId, patientId);
                return Ok(invoice);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

      //  [HttpPost("create-by-daterange")]
       /* public async Task<IActionResult> CreateInvoiceForDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var invoice = await _invoiceService.CreateInvoiceForDateRangeAsync(userId, startDate, endDate);
                return Ok(invoice);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }*/
    }
}
