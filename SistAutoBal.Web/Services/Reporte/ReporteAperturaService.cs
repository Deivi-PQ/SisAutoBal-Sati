using SisAutoBal.BusinessObjects.AutoBal;
using System.Text.Json;

namespace SisAutoBal.Web.Services.Reporte
{
    public class ReporteAperturaService:IReporteAperturaService
    {
        private readonly IHttpClientFactory _clientFactory;
        public ReporteAperturaService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IList<CAuditoriaBalanza>> ListarPorFecha(String Estado, String FechaInicio, String FechaFinal)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/AuditoriaBalanza/ListarPorFecha/" + Estado + "/" + FechaInicio + "/" + FechaFinal);
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
                    return await JsonSerializer.DeserializeAsync<IList<CAuditoriaBalanza>>(responseStream, options);
                }
                else
                {
                    return new List<CAuditoriaBalanza>();
                }
            }
            catch (Exception)
            {
                throw ;
            }
        }
        public async Task<IList<CAuditoriaBalazaGenaral>> Listar_X_Fecha(String FechaInicio, String FechaFinal, String Balanza, String Estado)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/AuditoriaBalanza/Listar_X_Fecha/" +FechaInicio + "/" + FechaFinal + "/" + Balanza + "/" + Estado);
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
                    return await JsonSerializer.DeserializeAsync<IList<CAuditoriaBalazaGenaral>>(responseStream, options);
                }
                else
                {
                    return new List<CAuditoriaBalazaGenaral>();
                }
            }
            catch (Exception)
            {
                throw;
            }
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
                    return await JsonSerializer.DeserializeAsync<IList<CAuditoriaBalanza>>(responseStream, options);
                }
                else
                {
                    return new List<CAuditoriaBalanza>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
