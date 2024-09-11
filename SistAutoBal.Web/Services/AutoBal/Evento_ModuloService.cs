using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using System.Text.Json;

namespace SisAutoBal.Web.Services.AutoBal
{
    public class Evento_ModuloService: IEvento_ModuloService
    {
        private readonly IHttpClientFactory clientFactory;
        public Evento_ModuloService(IHttpClientFactory clientFactory_)
        {
            clientFactory = clientFactory_;
        }
        [HttpPost]
        public async Task<bool> Grabar(CEvento_Modulo cEvento_Modulo)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/Evento_Modulo/Grabar");
                request.Content = JsonContent.Create(cEvento_Modulo);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoBal");
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
            catch (Exception e)
            {
                Logger.ReferenceEquals(e, null);
                throw;
            }
        }
        public async Task<int> Eliminar(Int64 IDEvento)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Evento_Modulo/Eliminar/" + IDEvento);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoBal");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    return await JsonSerializer.DeserializeAsync<int>(responseStream, options);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<CEvento_Modulo> Recuperar(Int64 IDEvento)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Evento_Modulo/Recuperar/" + IDEvento);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoBal");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    CEvento_Modulo? cEvento_Modulo = await JsonSerializer.DeserializeAsync<CEvento_Modulo>(responseStream, options);
                    return cEvento_Modulo!;
                }
                else
                {
                    return new CEvento_Modulo();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> Existe(Int64 IDEvento)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Evento_Modulo/Existe/" + IDEvento);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoBal");
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
        public async Task<IList<CEvento_Modulo>> Listar()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Evento_Modulo/Listar");
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoBal");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    IList<CEvento_Modulo>? cEvento_Modulo = await JsonSerializer.DeserializeAsync<IList<CEvento_Modulo>>(responseStream, options);
                    return cEvento_Modulo!;
                }
                else
                {
                    return new List<CEvento_Modulo>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
