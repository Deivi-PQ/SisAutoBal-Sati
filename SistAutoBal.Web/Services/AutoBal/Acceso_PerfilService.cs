using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using System.Text.Json;

namespace SisAutoBal.Web.Services.AutoBal
{
    public class Acceso_PerfilService: IAcceso_PerfilService
    {
        private readonly IHttpClientFactory clientFactory;
        public Acceso_PerfilService(IHttpClientFactory clientFactory_)
        {
            clientFactory = clientFactory_;
        }
        [HttpPost]
        public async Task<bool> Grabar(CAcceso_Perfil cAcceso_Perfil)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/Acceso_Perfil/Grabar");
                request.Content = JsonContent.Create(cAcceso_Perfil);
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
        public async Task<int> Eliminar(String Cod_Acceso, Int32 IDPerfil)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso_Perfil/Eliminar/" + Cod_Acceso+"/"+ IDPerfil);
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
        public async Task<CAcceso_Perfil> Recuperar(String Cod_Acceso, Int32 IDPerfil)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso_Perfil/Recuperar/" + Cod_Acceso+"/"+IDPerfil);
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
                    CAcceso_Perfil? cAcceso_Perfil = await JsonSerializer.DeserializeAsync<CAcceso_Perfil>(responseStream, options);
                    return cAcceso_Perfil!;
                }
                else
                {
                    return new CAcceso_Perfil();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> Existe(String Cod_Acceso, Int32 IDPerfil)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso_Perfil/Existe/" + Cod_Acceso + "/" + IDPerfil);
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
        public async Task<IList<CAcceso_Perfil>> Listar()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Acceso_Perfil/Listar");
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
                    IList<CAcceso_Perfil>? cAcceso_Perfil = await JsonSerializer.DeserializeAsync<IList<CAcceso_Perfil>>(responseStream, options);
                    return cAcceso_Perfil!;
                }
                else
                {
                    return new List<CAcceso_Perfil>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
