using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoZoe.BusinessObjects.AutoBal;
using System.Text.Json;

namespace SisAutoBal.Web.Services.AutoBal
{
    public class AccesoService : IAccesoService
    {
        private readonly IHttpClientFactory clientFactory;
        public AccesoService(IHttpClientFactory clientFactory_)
        {
            clientFactory = clientFactory_;
        }
        [HttpPost]
        public async Task<bool> Grabar(CAcceso oAcceso)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/Acceso/Grabar");
                request.Content = JsonContent.Create(oAcceso);
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
        public async Task<int> Eliminar(String Cod_Acceso)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso/Eliminar/" + Cod_Acceso);
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
        public async Task<CAcceso> Recuperar(String Cod_Acceso) 
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso/Recuperar/" + Cod_Acceso);
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
                    CAcceso? cAcceso = await JsonSerializer.DeserializeAsync<CAcceso>(responseStream, options);
                    return cAcceso!;
                }
                else
                {
                    return new CAcceso();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> Existe(String Cod_Acceso)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso/Existe/" + Cod_Acceso);
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
        public async Task<IList<CAcceso>> Listar(String Cod_Acceso, String Nombre_Acceso, String Descripcion)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso/Listar/" + Cod_Acceso + "/" + Nombre_Acceso +"/"+Descripcion);
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
                    IList<CAcceso>? cAcceso = await JsonSerializer.DeserializeAsync<IList<CAcceso>>(responseStream, options);
                    return cAcceso!;
                }
                else
                {
                    return new List<CAcceso>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IList<CAcceso>> BuscarAcceso(String IDPerfil) 
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso/BuscarAcceso/" + IDPerfil);
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
                    IList<CAcceso>? cAcceso = await JsonSerializer.DeserializeAsync<IList<CAcceso>>(responseStream, options);
                    return cAcceso!;
                }
                else
                {
                    return new List<CAcceso>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IList<CAcceso>> Menu(int IDPerfil) 
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso/Menu/" + IDPerfil);
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
                    IList<CAcceso>? cAcceso = await JsonSerializer.DeserializeAsync<IList<CAcceso>>(responseStream, options);
                    return cAcceso!;
                }
                else
                {
                    return new List<CAcceso>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
