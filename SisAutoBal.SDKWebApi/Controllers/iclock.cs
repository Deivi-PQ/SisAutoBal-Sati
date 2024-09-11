using Microsoft.AspNetCore.Mvc;
using SisAutoBal.SDKWebApi.Util;
using SisAutoBal.Facade.AutoBal;
using SisAutoBal.BusinessObjects.AutoBal;
using Newtonsoft.Json;
using SisAutoBal.Facade;

namespace SisAutoBal.SDKWebApi.Controllers
{
    [Route("iclock")]
    [ApiController]
    public class IclockController : ControllerBase
    {
        public IclockController()
        {
           
        }

        [HttpGet("cdata")]
        public string GetCdata()
        {
            return "OK";
        }

        [HttpPost("cdata")]
        public async Task<IActionResult> PostData()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Request.Body))
                {
                    string body = await reader.ReadToEndAsync();
                    // Cambiamos "SN" a minúsculas para que sea insensible a mayúsculas y minúsculas.
                    string sn = HttpContext.Request.Query["SN"].ToString().ToLower();

                    string[] expectedKeys = { "time", "pin", "cardno", "eventaddr", "event", "inoutstatus", "verifytype", "index" };

                    var keyValuePairs = body.Split('\t').Select(kv => kv.Split('='));

                    var data = new Dictionary<string, string>();

                    foreach (var keyValue in keyValuePairs)
                    {
                        if (keyValue.Length == 2)
                        {
                            data[keyValue[0]] = keyValue[1];
                        }
                    }
                    if (expectedKeys.All(key => data.ContainsKey(key)))
                    {

                        var verifyTypeValue = data["verifytype"];
                        int verifyTypeValue_ = Convert.ToInt32(data["verifytype"]);
                        String Evento_ = data["event"].ToString();
                        String Cardno_ = "";
                        if (data["cardno"].ToString() != "")
                        {
                            if (data["cardno"].Length>=8)
                            {
                                Cardno_ = Convert.ToString(Convert.ToInt32(data["cardno"], 16));

                            }
                            else
                            {
                                Cardno_ = Convert.ToString(Convert.ToInt32(data["cardno"]));
                            }
                        }
                        else
                        {
                            Cardno_ = data["cardno"].ToString();
                        }
                        String Time = Convert.ToString(data["time"]);
                        String Pin = data["pin"];
                        String Eventaddr = data["eventaddr"];
                        String Evento = data["event"];
                        String Inoutstatus = data["inoutstatus"];
                        String Verifytype = verifyTypeValue;
                        String Iindex = data["index"];

                        if (int.TryParse(verifyTypeValue, out int verifyType) && verifyType == 4 && Evento_ == "27" && Cardno_ != "")
                        {
                            var dato = new CDatosRFID
                            {
                                SN = sn,
                                TTime = Convert.ToDateTime(Time),
                                Pin = Pin,
                                Cardno = Cardno_,
                                Eventaddr = Eventaddr,
                                Evento = Evento,
                                Inoutstatus = Inoutstatus,
                                Verifytype = Verifytype,
                                flagProcesado = false,
                            };
                            DatosRfidFacade datosRfidFacade = new DatosRfidFacade();
                            bool estado = datosRfidFacade.Grabar(dato);
                            return Ok("OK");
                        }
                        else if (verifyType == 200 && Evento_ != "20" && Cardno_ == "")
                        {
                            var dato = new CDatosRFID
                            {
                                SN = sn,
                                TTime = Convert.ToDateTime(Time),
                                Pin = Pin,
                                Cardno = "-1",
                                Eventaddr = Eventaddr,
                                Evento = Evento,
                                Inoutstatus = Inoutstatus,
                                Verifytype = Verifytype,
                                flagProcesado = false,
                            };
                            DatosRfidFacade datosRfidFacade = new DatosRfidFacade();
                            bool estado = datosRfidFacade.Grabar(dato);
                            return Ok("OK");
                        }
                        else
                        {
                            return BadRequest("OK");
                        }
                    }
                    else
                    {
                        return BadRequest("OK");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.InnerException);
            }
        }

        [HttpGet("registry")]
        public string GetRegistry()
        {
            return "RegistryCode=E5S64w3liy";
        }

        [HttpPost("registry")]
        public string PostRegistry()
        {
            return "RegistryCode=E5S64w3liy";
        }

        [HttpGet("push")]
        public string GetPush()
        {
            return @"ServerVersion=3.0.1
ServerName=ADMS
PushVersion=3.0.1
ErrorDelay=60
RequestDelay=2
TransTimes=00:00;14:00
TransInterval=1
TransTables=User	Transaction
Realtime=1
SessionID=90e868fffe9e8dc7-00003c14-0000003c-fbd84e529b99135c-bd413ef1
TimeoutSec=10
QRCodeDecryptKey=1d3d256332540820f9f54315de6bfde8
QRCodeDecryptType=2";
        }

        [HttpPost("push")]
        public string PostPush()
        {
            return "OK";
        }

        [HttpGet("getrequest")]
        public IActionResult GetComandosEstadoCero([FromQuery] string SN)
        {
            try
            {
                ComandosFacade comandoFacade = new ComandosFacade();
                CComandos comando = new CComandos();
                comando = comandoFacade.Recuperar(SN);
                if (comando != null)
                {
                    if (comando.sn == SN)
                    {
                        comando.Estado = "1";
                        comandoFacade.Grabar(comando);
                        return Ok(comando.Comando);
                    }
                    else
                    {
                        return Ok("OK");
                    }
                }
                else
                {
                    return NotFound("OK");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpGet("devicecmd")]
        public string GetDeviceCmd()
        {
            return "OK";
        }

        [HttpPost("devicecmd")]
        public string PostDeviceCmd()
        {
            return "OK";
        }

        [HttpGet("leer-datos")]
        public async Task<IActionResult> LeerDatos()
        {
            try
            {
                // Realiza una consulta para obtener todos los datos de la entidad Dato.

                DatosRfidFacade datosRfidFacade = new DatosRfidFacade();
                var Lista = datosRfidFacade.Listar();

                // Verifica si se encontraron datos.
                if (Lista != null)
                {
                    return Ok(Lista);
                }
                else
                {
                    // No se encontraron datos.
                    return NotFound("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
        [HttpGet("leer-comandos")]
        public async Task<IActionResult> LeerComandos()
        {
            try
            {
                //var comandos = await _context.Comandos.ToListAsync();
                ComandosFacade comandosFacade = new ComandosFacade();
                var comando = comandosFacade.Listar();
                if (comando.Count > 0)
                {
                    // Procesa y devuelve los comandos como sea necesario.
                    return Ok(comando);
                }
                else
                {
                    return NotFound("No se encontraron comandos.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
        [HttpPost("comando")]
        public async Task<IActionResult> InsertarComando([FromQuery] string SN, [FromQuery] string Comando)
        {
            try
            {
                // Crea una nueva instancia de Comandos con los valores proporcionados.
                var nuevoComando = new CComandos
                {
                    sn = SN,
                    Comando = Comando,
                    Estado = "0" // Establece el estado en 0 como valor predeterminado.
                };
                ComandosFacade comandofacade = new ComandosFacade();
                comandofacade.Grabar(nuevoComando);
                return Ok("Comando insertado con éxito.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
    }
}
