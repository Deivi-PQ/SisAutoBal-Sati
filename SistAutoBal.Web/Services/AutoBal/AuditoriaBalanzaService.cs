using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using System.Text;
using System.Text.Json;

namespace SisAutoBal.Web.Services.AutoBal
{
    public class AuditoriaBalanzaService:IAuditoriaBalanzaService
    {
        private readonly IHttpClientFactory _clientFactory;

        public AuditoriaBalanzaService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<IList<CAuditoriaBalanza>> Listar()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/AuditoriaBalanza/Listar");
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = _clientFactory.CreateClient("SisAutoBal");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    IList<CAuditoriaBalanza>? cAuditoriaBalanza = await JsonSerializer.DeserializeAsync<IList<CAuditoriaBalanza>>(responseStream, options);
                    return cAuditoriaBalanza!;
                }
                else
                {
                    return new List<CAuditoriaBalanza>();
                }
            }
            catch (Exception )
            {
                throw;
            }
        }
        [HttpPost]
        public async Task<bool> Grabar(CAuditoriaBalanza oAuditoriaBalanza)
        { 
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/AuditoriaBalanza/Grabar");
                request.Content = JsonContent.Create(oAuditoriaBalanza);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = _clientFactory.CreateClient("SisAutoBal");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    return await JsonSerializer.DeserializeAsync<bool>(responseStream, options);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
