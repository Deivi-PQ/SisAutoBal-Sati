using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.BusinessObjects.OfiSegu;
using System.Net;
using System.Text.Json;

namespace SisAutoBal.Web.Services.AutoBal
{
    public class BloqueoPasoBalanzaService:IBloqueoPasoBalanzaService
    {
        private readonly IHttpClientFactory _clientFactory;
        public BloqueoPasoBalanzaService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        
        public async Task<IList<CBloqueoPasoBalanza>> Listar(DateTime Fecha, char Estado)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/BloqueoPasoBalanza/Listar/" + Fecha.ToString("MM-dd-yyyy") + "/" + Estado);
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
                    IList<CBloqueoPasoBalanza>? cBloqueoPasoBalanza = await JsonSerializer.DeserializeAsync<IList<CBloqueoPasoBalanza>>(responseStream, options);
                    return cBloqueoPasoBalanza!;
                }
                else
                {
                    return new List<CBloqueoPasoBalanza>();
                }
            }
            catch (Exception )
            {
                throw;
            }
        }
        public async Task<CBloqueoPasoBalanza> Recuperar(String IDBloqueBal)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/BloqueoPasoBalanza/Recuperar/" + IDBloqueBal);
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
                    CBloqueoPasoBalanza? cBloqueoPasoBalanza = await JsonSerializer.DeserializeAsync<CBloqueoPasoBalanza>(responseStream, options);
                    return cBloqueoPasoBalanza!;
                }
                else
                {
                    return new CBloqueoPasoBalanza();
                }
            }catch (Exception ) { throw; }
        }
        public async Task<bool> Actualizar(int ID_REQU_ATEN, string Nro_Placa, string EstadoBloqueo, int ID_USUA)
        {
            try
            {
                Uri uri = new Uri($"api/BloqueoPasoBalanza/Actualizar/{ID_REQU_ATEN.ToString()}/{Nro_Placa}/{EstadoBloqueo}/{ID_USUA.ToString()}");
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
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
            catch (Exception ) { throw; }
        }
    }
}
