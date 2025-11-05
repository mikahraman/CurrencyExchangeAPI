using CurrencyExchangeService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CurrencyExchangeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public CurrencyController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetRate(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return BadRequest("Lütfen geçerli bir para birimi kodu girin (Örn: USD, EUR).");

            string currencyCode = code.ToUpper();

            try
            {
                string apiUrl = $"https://api.frankfurter.app/latest?from={currencyCode}&to=TRY";

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (!response.IsSuccessStatusCode)
                {
                    return NotFound($"'{currencyCode}' kodu için veri bulunamadı veya servis şu an erişilemez durumda.");
                }

                // HATA BURADAYDI: Fazladan bir süslü parantez '}' vardı.
                string jsonString = await response.Content.ReadAsStringAsync();

                var exchangeData = JsonSerializer.Deserialize<ExchangeRateResponse>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (exchangeData != null && exchangeData.Rates.ContainsKey("TRY"))
                {
                    decimal tryRate = exchangeData.Rates["TRY"];

                    return Ok(new
                    {
                        FromCurrency = currencyCode,
                        ToCurrency = "TRY",
                        Rate = tryRate,
                        Date = exchangeData.Date,
                        Message = $"1 {currencyCode} şu anda {tryRate} Türk Lirası değerindedir."
                    });
                }
                else
                {
                    return StatusCode(500, "Dış servisten veri geldi ama TRY kuru bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Sunucu hatası: {ex.Message}");
            }
        }
    }
}