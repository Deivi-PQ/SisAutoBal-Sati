using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using System.Text.Json;

namespace SisAutoBal.Web.Services.AutoBal
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IHttpClientFactory clientFactory;
        public UsuarioService(IHttpClientFactory clientFactory_)
        {
            clientFactory = clientFactory_;
        }
        [HttpPost]
        public async Task<bool> Grabar(CUsuario cUsuario)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "api/Usuario/Grabar");
                request.Content = JsonContent.Create(cUsuario);
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
        public async Task<int> Eliminar(String CodUsuario)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Usuario/Eliminar/" + CodUsuario);
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
        public async Task<CUsuario> Recuperar(String CodUsuario)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Usuario/Recuperar/" + CodUsuario);
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
                    CUsuario? cUsuario = await JsonSerializer.DeserializeAsync<CUsuario>(responseStream, options);
                    return cUsuario!;
                }
                else
                {
                    return new CUsuario();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> Existe(String CodUsuario)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Usuario/Existe/" + CodUsuario);
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
        public async Task<IList<CUsuario>> Listar(String CodUsuario, String Nombre_Usuario, String IDPerfil)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Usuario/Listar/"+CodUsuario+"/"+Nombre_Usuario+"/"+IDPerfil);
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
                    IList<CUsuario>? cUsuario = await JsonSerializer.DeserializeAsync<IList<CUsuario>>(responseStream, options);
                    return cUsuario!;
                }
                else
                {
                    return new List<CUsuario>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
