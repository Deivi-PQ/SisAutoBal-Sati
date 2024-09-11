using System.Data;
using System.Text.Json;
using SisAutoBal.Web.Models;

namespace SisAutoBal.Web.Services.Zoe
{
    public partial class Dato_rfid_pasoService : IDato_rfid_pasoService
    {
        private readonly IHttpClientFactory clientFactory;
        public Dato_rfid_pasoService(IHttpClientFactory _clientFactory)
        {
            clientFactory = _clientFactory;
        }
        public async Task<DataTable> AtencionReporte(String FechaInicio, String FechaFinal, String Nro_Placa, String Tipo_Oper)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/TDato_rfid_paso/AtencionReporte/" + FechaInicio + "/"+ FechaFinal + "/" +Nro_Placa+"/"+Tipo_Oper);
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
                    byte[] datatable = await JsonSerializer.DeserializeAsync<byte[]>(responseStream, options);
                    Utils util = new Utils();
                    return Utils.DecompressDataTable(datatable!);
                }
                else
                {
                    return null!;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
