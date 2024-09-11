using SisAutoZoe.BusinessObjects.Zoe;
using System.Text.Json;

namespace SisAutoBal.Web.Services.Zoe
{
    public partial class Tipo_OperService : ITipo_OperService
    {
        private readonly IHttpClientFactory clientFactory;
        public Tipo_OperService(IHttpClientFactory clientFactory_)
        {
            clientFactory = clientFactory_;
        }
        public async Task<bool> Grabar(CTipo_Oper oTipo_Oper)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/Tipo_Oper/Grabar");
                request.Content = JsonContent.Create(oTipo_Oper);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoZoe");
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
        public async Task<int> Eliminar(String Cod_TipoOper)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Tipo_Oper/Eliminar/" + Cod_TipoOper);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoZoe");
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
        public async Task<CTipo_Oper> Recuperar(String Cod_TipoOper) 
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Tipo_Oper/Recuperar/" + Cod_TipoOper);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoZoe");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    CTipo_Oper? cTipo_Oper = await JsonSerializer.DeserializeAsync<CTipo_Oper>(responseStream, options);
                    return cTipo_Oper!;
                }
                else
                {
                    return new CTipo_Oper();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> Existe(String Cod_TipoOper)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Tipo_Oper/Existe/" + Cod_TipoOper);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoZoe");
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
        public async Task<IList<CTipo_Oper>> Listar(String Cod_TipoOper, String Nom_TipoOper)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Tipo_Oper/Listar/" + Cod_TipoOper + "/"+ Nom_TipoOper);
                request.Headers.Add("Authorization", "Bearer 1234");
                var client = clientFactory.CreateClient("SisAutoZoe");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    IList<CTipo_Oper>? cTipo_Oper = await JsonSerializer.DeserializeAsync<IList<CTipo_Oper>>(responseStream, options);
                    return cTipo_Oper!;
                }
                else
                {
                    return new List<CTipo_Oper>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
