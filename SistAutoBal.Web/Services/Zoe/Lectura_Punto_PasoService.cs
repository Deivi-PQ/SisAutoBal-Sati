using SisAutoZoe.BusinessObjects.Zoe;
using System.Text.Json;

namespace SisAutoBal.Web.Services.Zoe
{
    public partial class Lectura_Punto_PasoService : ILectura_Punto_PasoService
    {
        private readonly IHttpClientFactory clientFactory;
        public Lectura_Punto_PasoService(IHttpClientFactory _clientFactory)
        {
            clientFactory = _clientFactory;
        }
        public async Task<IList<CLectura_Punto_Paso>> Listar(String SN, String Nro_Placa, String FechaInicio, String FechaFinal, String Tipo)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/Lectura_Punto_Paso/Listar/"+ SN +"/"+ Nro_Placa + "/" + FechaInicio + "/" + FechaFinal+"/"+Tipo);
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
                    IList<CLectura_Punto_Paso>? cBloqueoPasoBalanza = await JsonSerializer.DeserializeAsync<IList<CLectura_Punto_Paso>>(responseStream, options);
                    return cBloqueoPasoBalanza!;
                }
                else
                {
                    return new List<CLectura_Punto_Paso>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
