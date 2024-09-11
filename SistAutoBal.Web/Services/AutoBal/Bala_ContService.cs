//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 7 de mayo de 2024
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ServiceModel;
using SisAutoBal.BusinessObjects.AutoBal;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace SisAutoBal.Web.Services.AutoBal
{
      
    public  class Bala_ContService : IBala_ContService
    {
        private readonly IHttpClientFactory _clientFactory;
        public Bala_ContService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        [HttpPost]
        public async Task<bool> Grabar(CBala_Cont cBala_Cont)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/Bala_Cont/Grabar");
                request.Content = JsonContent.Create(cBala_Cont);
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
        
        public async Task<int> Eliminar(String ID_BALA)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Bala_Cont/Eliminar/" + ID_BALA);
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
                    return await JsonSerializer.DeserializeAsync<int>(responseStream, options);
                }
                else
                {
                    return 0;
                }
            }
            catch ( Exception)
            {
                throw;
            }
        }
        
        public async Task<CBala_Cont> Recuperar(String ID_BALA)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Bala_Cont/Recuperar/" + ID_BALA);
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
                    return await JsonSerializer.DeserializeAsync<CBala_Cont>(responseStream, options);
                }
                else
                {
                    return new CBala_Cont();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public async Task<bool> Existe(String ID_BALA)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Bala_Cont/Existe/" + ID_BALA);
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
        
        public async Task<IList<CBala_Cont>> Listar()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Bala_Cont/Listar/");
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
                    IList<CBala_Cont>? cBala_Cont = await JsonSerializer.DeserializeAsync<IList<CBala_Cont>>(responseStream, options);
                    return cBala_Cont!;
                }
                else
                {
                    return new List<CBala_Cont>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IList<CBala_ContDet>> Buscar(String ID_Bala, String SNContr)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Bala_Cont/Buscar/" + ID_Bala + "/" + SNContr);
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
                    IList<CBala_ContDet>? cBloqueoPasoBalanza = await JsonSerializer.DeserializeAsync<IList<CBala_ContDet>>(responseStream, options);
                    return cBloqueoPasoBalanza!;
                }
                else
                {
                    return new List<CBala_ContDet>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
