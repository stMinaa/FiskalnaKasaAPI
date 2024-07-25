using FiskalnaKasaAPI.Data;
using FiskalnaKasaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FiskalnaKasaAPI.Services
{
    public class InvoiceService
    {
        private readonly KasaContext _context;

        public InvoiceService(KasaContext context)
        {
            _context = context;
        }

        public async Task<Invoice> CreateInvoiceForPatientAsync(int userId, int patientId)
        {
            var patientServices = await _context.PatientServices
                .Where(ps => ps.PatientId == patientId && ps.InvoiceId == null)
                .Include(ps => ps.PriceList)
                .ToListAsync();

            if (patientServices == null || !patientServices.Any())
            {
                throw new Exception("No services found for the given patient.");
            }

            var invoice = new Invoice
            {
                InvoiceDate = DateTime.Now,
                UserId = userId,
                TotalAmount = patientServices.Sum(ps => ps.PriceList.Price),
                Status = "not paid",
                PatientServices = patientServices
            };

            _context.Invoices.Add(invoice);

            foreach (var service in patientServices)
            {
                service.InvoiceId = invoice.Id;
            }

            await _context.SaveChangesAsync();

            return invoice;
        }

        public async Task<Invoice> CreateInvoiceForDateRangeAsync(int userId, DateTime startDate, DateTime endDate)
        {
            var patientServices = await _context.PatientServices
                .Where(ps => ps.ServiceDate >= startDate && ps.ServiceDate <= endDate && ps.InvoiceId == null)
                .Include(ps => ps.PriceList)
                .ToListAsync();

            if (patientServices == null || !patientServices.Any())
            {
                throw new Exception("No services found in the given date range.");
            }

            var invoice = new Invoice
            {
                InvoiceDate = DateTime.Now,
                UserId = userId,
                TotalAmount = patientServices.Sum(ps => ps.PriceList.Price),
                Status = "not paid",
                PatientServices = patientServices
            };

            _context.Invoices.Add(invoice);

            foreach (var service in patientServices)
            {
                service.InvoiceId = invoice.Id;
            }

            await _context.SaveChangesAsync();

            return invoice;
        }
    }
}
