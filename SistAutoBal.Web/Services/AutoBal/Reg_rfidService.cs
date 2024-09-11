using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using System.Collections.Generic;
using System.Text.Json;

namespace SisAutoBal.Web.Services.AutoBal
{
    public class Reg_rfidService : IReg_rfidService
    {
        private readonly IHttpClientFactory clientFactory;
        public Reg_rfidService(IHttpClientFactory clientFactory_)
        {
            clientFactory = clientFactory_;
        }
        [HttpPost]
        public async Task<bool> Grabar(CREGI_RFID cREGI_RFID)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/REGRFID/Grabar");
                request.Content = JsonContent.Create(cREGI_RFID);
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
        public async Task<int> Eliminar(String Cod_RFID)
        {
            try 
            { 
                var request = new HttpRequestMessage(HttpMethod.Get, "api/REGRFID/Eliminar/" + Cod_RFID);
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
        public async Task<bool> Existe(String Cod_RFID)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/REGRFID/Existe/" + Cod_RFID);
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

        public async Task<IList<CREGI_RFID>> Listar(String ID_REGI_PLAC, String Cod_RFID, String VigenciaIni, String VigenciaFin)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/REGRFID/Listar/" + ID_REGI_PLAC + "/" + Cod_RFID + "/" + VigenciaIni + "/" + VigenciaFin);
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
                    IList<CREGI_RFID>? cREGI_RFIDs = await JsonSerializer.DeserializeAsync<IList<CREGI_RFID>>(responseStream, options);
                    return cREGI_RFIDs!;
                }
                else
                {
                    return new List<CREGI_RFID>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> Existe_Placa(String ID_REGI_PLAC)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/REGRFID/Existe_Placa/" + ID_REGI_PLAC);
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
        public async Task<CREGI_RFID> Recuperar(String Cod_RFID)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/REGRFID/Recuperar/" + Cod_RFID);
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
                    CREGI_RFID? cREGI_RFID = await JsonSerializer.DeserializeAsync<CREGI_RFID>(responseStream, options);
                    return cREGI_RFID!;
                }
                else
                {
                    return new CREGI_RFID();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<CREGI_RFID> PlacaRFID(String ID_REGI_PLAC)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/REGRFID/PlacaRFID/" + ID_REGI_PLAC);
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
                    CREGI_RFID? cREGI_RFID = await JsonSerializer.DeserializeAsync<CREGI_RFID>(responseStream, options);
                    return cREGI_RFID!;
                }
                else
                {
                    return new CREGI_RFID();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IList<CEnroladoT>> ProcesarArchivo(CArchivo archivo)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/REGRFID/ProcesarArchivo");
                request.Content = JsonContent.Create(archivo);
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
                    List<CEnroladoT>? cREGI_RFID = (List <CEnroladoT>?) await JsonSerializer.DeserializeAsync<IList<CEnroladoT>>(responseStream, options);
                    return cREGI_RFID!;
                }
                else
                {
                    return new List<CEnroladoT>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
