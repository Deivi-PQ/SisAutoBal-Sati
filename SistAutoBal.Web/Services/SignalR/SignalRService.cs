using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.BusinessObjects.OfiOper;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace SisAutoBal.Web.Services.SignalR
{
    public class SignalRService: ISignalRService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _configuration;
        public SignalRService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }

        public async Task<IList<CTTIPO_BALA>> Listar()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/TTIPO_BALA/Listar");
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
                    return await JsonSerializer.DeserializeAsync<IList<CTTIPO_BALA>>(responseStream, options);
                }
                else
                {
                    return new List<CTTIPO_BALA>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<String> AperturaBarrera(String TBala, String SN_Contr, String Tipo, String Sentido)
        {
            String Mensaje = "";
            String ComandoAp = "";
            if (Sentido == null && Tipo == "Open")
            {
                ComandoAp = "C:221:CONTROL DEVICE 01010101";
            }
            else if (Sentido == null && Tipo == "Close")
            {
                ComandoAp = "C:221:CONTROL DEVICE 01020101";
            }
            else if (Sentido == "_SAL" && Tipo == "Open")
            {
                ComandoAp = "C:221:CONTROL DEVICE 01030101";
            }
            else if (Sentido == "_SAL" && Tipo == "Close")
            {
                ComandoAp = "C:221:CONTROL DEVICE 01040101";
            }
            /*//Puerta Auxi
            else if (Puerta == 5)
            {
                ComandoAp = "C:221:CONTROL DEVICE 01010205";
            }
            else if (Puerta == 6)
            {
                ComandoAp = "C:221:CONTROL DEVICE 01040205";
            }*/

            using (HttpClient client = new HttpClient())
            {
                //String url = "http://192.168.1.103:8053/iclock/comando?SN=" + NRO_SERIE + "&Comando=" + ComandoAp;
                String URL_Api_ZKTeco = _configuration["UrlServicioZKT"];
                String url = URL_Api_ZKTeco + "?SN=" + SN_Contr + "&Comando=" + ComandoAp;

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, null);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Mensaje = "Respuesta exitosa: " + responseContent + TBala;
                    }
                    else
                    {
                        Mensaje = "La solicitud POST falló con código de respuesta: " + response.StatusCode;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = "Error: " + ex.Message;
                }
            }
            return Mensaje;

        }



        public async Task<String> EncendidoSemaforo(String TBala, String SN_Contr, String Tipo, String Sentido)
        {
            String Mensaje = "";
            String ComandoAp = "";
            if (Sentido == null && Tipo == "Open")
            {
                ComandoAp = "C:221:CONTROL DEVICE 01010215";
            }
            else if (Sentido == null && Tipo == "Close")
            {
                ComandoAp = "C:221:CONTROL DEVICE 01020215";
            }
            if (Sentido == "_SAL" && Tipo == "Open")
            {
                ComandoAp = "C:221:CONTROL DEVICE 01010215";
            }
            else if (Sentido == "_SAL" && Tipo == "Close")
            {
                ComandoAp = "C:221:CONTROL DEVICE 01020215";
            }
            using (HttpClient client = new HttpClient())
            {
                String URL_Api_ZKTeco = _configuration["UrlServicioZKT"];
                String url = URL_Api_ZKTeco + "?SN=" + SN_Contr + "&Comando=" + ComandoAp;
                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, null);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Mensaje = "Respuesta exitosa: " + responseContent + TBala;
                    }
                    else
                    {
                        Mensaje = "La solicitud POST falló con código de respuesta: " + response.StatusCode;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = "Error: " + ex.Message;
                }
            }
            return Mensaje;

        }
    }
}
