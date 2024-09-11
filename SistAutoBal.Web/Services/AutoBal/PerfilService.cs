using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using System.Text.Json;

namespace SisAutoBal.Web.Services.AutoBal
{
    public class PerfilService: IPerfilService
    {
        private readonly IHttpClientFactory clientFactory;
        public PerfilService(IHttpClientFactory clientFactory_)
        {
            clientFactory = clientFactory_;
        }
        [HttpPost]
        public async Task<bool> Grabar(CPerfil cPerfil)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/Perfil/Grabar");
                request.Content = JsonContent.Create(cPerfil);
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
        public async Task<int> Eliminar(Int32 IDPerfil)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Perfil/Eliminar/" + IDPerfil);
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
        public async Task<CPerfil> Recuperar(Int32 IDPerfil)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Perfil/Recuperar/" + IDPerfil);
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
                    CPerfil? cPerfil = await JsonSerializer.DeserializeAsync<CPerfil>(responseStream, options);
                    return cPerfil!;
                }
                else
                {
                    return new CPerfil();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> Existe(Int32 IDPerfil)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Perfil/Existe/" + IDPerfil);
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
        public async Task<IList<CPerfil>> Listar(String IDPerfil, String Des_Perfil, String Estado)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Perfil/Listar/"+ IDPerfil+"/"+Des_Perfil+"/"+Estado);
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
                    IList<CPerfil>? cPerfil = await JsonSerializer.DeserializeAsync<IList<CPerfil>>(responseStream, options);
                    return cPerfil!;
                }
                else
                {
                    return new List<CPerfil>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
