using SisAutoBal.BusinessObjects.OfiSegu;
using System.Text.Json;

namespace SisAutoBal.Web.Services.OfiSegu
{
    public class CMusuaService : ICMusuaService
    {
        private readonly IHttpClientFactory _clientFactory;
        public CMusuaService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<CMUSUA> RecuperarUsuario(String NO_USUA)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/MUSUA/RecuperarUsuario/" + NO_USUA);
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
                    return await JsonSerializer.DeserializeAsync<CMUSUA>(responseStream, options);
                }
                else
                {
                    return new CMUSUA();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> ExisteUsuario(String NO_USUA)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/MUSUA/ExisteUsuario/" + NO_USUA);
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
