using System;
using Microsoft.AspNetCore.Mvc;
using SisAutoZoe.BusinessObjects.Zoe;
using System.Text.Json;

namespace SisAutoBal.Web.Services.Zoe
{
    public partial class TPunto_PasoService : ITPunto_PasoService
    {
        private readonly IHttpClientFactory _clientFactory;
        public TPunto_PasoService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<bool> Grabar(CTPunto_Paso oTPunto_Paso)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/TPunto_Paso/Grabar");
                request.Content = JsonContent.Create(oTPunto_Paso);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = _clientFactory.CreateClient("SisAutoZoe");
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
        
        public async Task<int> Eliminar(Int32 Cod_Punto)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/TPunto_Paso/Eliminar/" + Cod_Punto);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = _clientFactory.CreateClient("SisAutoZoe");
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
        
        public async Task<CTPunto_Paso> Recuperar(Int32 Cod_Punto)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/TPunto_Paso/Recuperar/" + Cod_Punto);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = _clientFactory.CreateClient("SisAutoZoe");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    CTPunto_Paso? cTPunto_Pasos = await JsonSerializer.DeserializeAsync<CTPunto_Paso>(responseStream, options);
                    return cTPunto_Pasos!;
                }
                else
                {
                    return new CTPunto_Paso();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public async Task<bool> Existe(Int32 Cod_Punto)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/TPunto_Paso/Existe/" + Cod_Punto);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = _clientFactory.CreateClient("SisAutoZoe");
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
        
        public async Task<IList<CTPunto_Paso>> Listar(CTPunto_Paso cTPunto_Paso)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/TPunto_Paso/Listar");
                request.Content = JsonContent.Create(cTPunto_Paso);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = _clientFactory.CreateClient("SisAutoZoe");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    IList<CTPunto_Paso>? cPunto_Paso = await JsonSerializer.DeserializeAsync<IList<CTPunto_Paso>>(responseStream, options);
                    return cPunto_Paso!;
                }
                else
                {
                    return new List<CTPunto_Paso>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IList<CTPunto_Paso>> Buscar(String ID_Punto, String SNContr)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/TPunto_Paso/Buscar/" + ID_Punto + "/" + SNContr);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = _clientFactory.CreateClient("SisAutoZoe");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    IList<CTPunto_Paso>? cPunto_Paso = await JsonSerializer.DeserializeAsync<IList<CTPunto_Paso>>(responseStream, options);
                    return cPunto_Paso!;
                }
                else
                {
                    return new List<CTPunto_Paso>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> Next()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/TPunto_Paso/Next");
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = _clientFactory.CreateClient("SisAutoZoe");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    int next = await JsonSerializer.DeserializeAsync<int>(responseStream, options);
                    return next;
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
    }
}
