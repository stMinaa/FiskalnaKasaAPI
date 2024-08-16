using FiskalnaKasaAPI.Data;
using FiskalnaKasaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;

namespace FiskalnaKasaAPI.Services
{
    public class FiscalizationService
    {
        private readonly HttpClient _httpClient;

        public FiscalizationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //neki test link
        /*https://vsdc.sandbox.suf.purs.gov.rs/api/v3/invoices */

        //NE ZNAM JEL OVO DOBR0 --> MILAN
        public async Task FiscalizeInvoiceAsync(Invoice invoice)
        {
            // Priprema podataka
            var esirRequest = new
            {
                cashier = new
                {
                    invoice.User.FirstName,
                    invoice.User.LastName
                },
                buyerId = "30:XD999999",  //nmp
                buyerCostCenterId = invoice?.PatientServices?.First()?.Customer?.PIB ?? "", //VALJDA PIB?
                invoiceType = 0,   //nmp
                transactionType = 0,   //nmp
                payment = new[]
        {
            new
            {
                amount = invoice?.TotalAmount,
                paymentType = invoice?.PaymentType
            }
        },
                invoiceNumber = /*invoice.ESIR ??*/ "BIZNISOFT e0.9",  //lupam jer ne znam sta je sta
                options = new
                {
                    omitTextualRepresentation = "0",
                    omitQRCodeGen = "1"
                },

                items = invoice.PatientServices.Select(invoiceItem => new
                {
                    gtin = invoiceItem.PriceList?.Service?.ServiceNumber ?? "default-gtin",  // Fallback if GTIN is not available
                    name = invoiceItem.PriceList?.Service?.ServiceName ?? "Unknown Item",  // Fallback if name is not available
                    quantity = invoiceItem.Quantity,
                    discount = 0,  // Assuming no discounts for simplicity
                    labels = new string[] { },  // NISAM IMPLEMENTIRALA OVO AKO TREBA - KASNIJE
                    unitPrice = invoiceItem.PriceList?.Price ?? 0,
                    totalAmount = invoiceItem.TotalPrice
                }).ToArray()
            };

            // Serialize the invoice data to JSON
            var jsonEsir = JsonSerializer.Serialize(esirRequest);
            var httpEsirContent = new StringContent(jsonEsir, Encoding.UTF8, "application/json");

            // Send the request to the fiscalization server
            var response = await _httpClient.PostAsync("HTTP/DO/ESIR/SERVERA", httpEsirContent);

            // The response can be ignored as per your requirements
            response.EnsureSuccessStatusCode();
        }

    }
}
