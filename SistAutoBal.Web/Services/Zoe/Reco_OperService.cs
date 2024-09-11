using SisAutoZoe.BusinessObjects.Zoe;
using System.Text.Json;

namespace SisAutoBal.Web.Services.Zoe
{
    public class Reco_OperService : IReco_OperService
    {
        private readonly IHttpClientFactory _clientFactory;
        public Reco_OperService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<bool> Grabar(CReco_Oper oReco_Oper)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/Reco_Oper/Grabar");
                request.Content = JsonContent.Create(oReco_Oper);
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
        public async Task<int> Eliminar(String Cod_TipoOper, Int32 Cod_Punto)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Reco_Oper/Eliminar/" + Cod_TipoOper + "/" + Cod_Punto);
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
        public async Task<CReco_Oper> Recuperar(String Cod_TipoOper, Int32 Cod_Punto)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Reco_Oper/Recuperar/" + Cod_TipoOper + "/" + Cod_Punto);
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
                    CReco_Oper? cReco_Oper = await JsonSerializer.DeserializeAsync<CReco_Oper>(responseStream, options);
                    return cReco_Oper!;
                }
                else
                {
                    return new CReco_Oper();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> Existe(String Cod_TipoOper, Int32 Cod_Punto)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Reco_Oper/Existe/" + Cod_TipoOper + "/" + Cod_Punto);
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
        public async Task<IList<CReco_Oper>> Listar(CReco_Oper oReco_Oper)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/Reco_Oper/Listar");
                request.Content = JsonContent.Create(oReco_Oper);
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
                    IList<CReco_Oper>? cReco_Oper = await JsonSerializer.DeserializeAsync<IList<CReco_Oper>>(responseStream, options);
                    return cReco_Oper!;
                }
                else
                {
                    return new List<CReco_Oper>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
