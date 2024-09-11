using Microsoft.AspNetCore.Mvc;
using SisAutoBal.Web.Models;
using SisAutoBal.BusinessObjects.AutoBal;
using System.Collections.Generic;
using System.Data;
using System.Web;
using SisAutoBal.Web.Services.AutoBal;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class TRegi_rfidController : Controller
    {
        private readonly IHttpContextAccessor contxt;
        private readonly IReg_rfidService reg_rfidservice;

        public TRegi_rfidController(IHttpContextAccessor contxt_, IReg_rfidService reg_rfidservice_)
        {
            contxt = contxt_;
            reg_rfidservice = reg_rfidservice_;
        }
        public IActionResult Index()
        {
            ViewData["vigenciaIni"]= DateTime.Now.AddYears(-0).ToString("dd/MM/yyyy");
            ViewData["vigenciaFin"]= DateTime.Now.AddYears(5).ToString("dd/MM/yyyy");
            ViewData["fvigencia"] = DateTime.Now.ToString("dd/MM/yyyy");
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Grabar(CREGI_RFID oREGI_RFID)
        {
            try
            {
                if (contxt.HttpContext is not null)
                {
                    oREGI_RFID.UserEdit = Convert.ToInt32(contxt.HttpContext.Session.GetString("IDUser"));
                    oREGI_RFID.UserNew = Convert.ToInt32(contxt.HttpContext.Session.GetString("IDUser"));
                    oREGI_RFID.Estado = oREGI_RFID.Estado.ToString() == "0"?'A':'D';
                }
                if(await reg_rfidservice.Grabar(oREGI_RFID))
                {
                    return new JsonResult(new { Error = true });
                }
                else
                {
                    return new JsonResult(new { Error = false });
                }
            }
            catch (Exception Ex)
            {
                return new JsonResult(new { Error = Ex.Message });
            }
        }
        public async Task<JsonResult> ActualizarTags(String ID_REGI_PLAC, String Cod_RFID,String Cod_RFIDN, String FeVigencia, String Estado)
        {
            try
            {
                int respuesta = await reg_rfidservice.Eliminar(Cod_RFID);
                if(respuesta >0)
                {
                    CREGI_RFID cREGI_RFID = new CREGI_RFID();
                    cREGI_RFID.ID_REGI_PLAC = ID_REGI_PLAC;
                    cREGI_RFID.Cod_RFID = Cod_RFIDN;
                    cREGI_RFID.Vigencia = Convert.ToDateTime(FeVigencia);
                    cREGI_RFID.Estado = Estado.ToString() == "0" ? 'A' : 'D';

                    if (await reg_rfidservice.Grabar(cREGI_RFID))
                    {
                        return new JsonResult(new { Error = true });
                    }
                    else
                    {
                        return new JsonResult(new { Error = false });
                    }
                }
                else
                { return new JsonResult(new {Error = false});}
            }
            catch (Exception Ex) { return new JsonResult(new { Error = Ex.Message }); }
        }

        public async Task<JsonResult> Buscar(String ID_REGI_PLAC, String Cod_RFID,String VigenciaIni, String VigenciaFin)
        {
            IList<CREGI_RFID> ListaPersonas = await reg_rfidservice.Listar(ID_REGI_PLAC==null?"*": ID_REGI_PLAC, Cod_RFID==null?"*": Cod_RFID, VigenciaIni, VigenciaFin);
            if (ListaPersonas != null)
            {
                return Json(ListaPersonas);
            }
            else
            {
                return Json(new List<CREGI_RFID>());
            }
        }
        public JsonResult LimpiarBusq()
        {
            return Json(new List<CREGI_RFID>());
        }
        public async Task<JsonResult> Recuperar(String Cod_RFID)
        {         
            CREGI_RFID cREGI_RFID = await reg_rfidservice.Recuperar( Cod_RFID);
            if (cREGI_RFID != null)
            {
                return Json(cREGI_RFID);
            }
            else
            {
                return Json(new CREGI_RFID());
            }
        }
        public async Task<JsonResult> Existe_Placa(String ID_REGI_PLAC)
        {         
            if (await reg_rfidservice.Existe_Placa(ID_REGI_PLAC.Trim()))
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
        

        [HttpPost]
        public async Task<JsonResult> ProcesarArchivo(CArchivo archivo)
        {
            IList<CEnroladoT> DatosPro = await reg_rfidservice.ProcesarArchivo(archivo);
            if (DatosPro != null)
            {
                return Json(DatosPro);
            }
            else
            {
                return Json(new List<CREGI_RFID>());
            }
        }
        public async Task<JsonResult> CargarContenidoTex(String ID_REGI_PLAC, String Cod_RFID, String Fecha_Valida, String EstadoCarga)
        {
            CREGI_RFID oREGI_RFID = new CREGI_RFID(ID_REGI_PLAC,Cod_RFID, Convert.ToDateTime(Fecha_Valida), null, null, Convert.ToInt32(contxt.HttpContext!.Session.GetString("IDUser")), Convert.ToInt32(contxt.HttpContext.Session.GetString("IDUser")), 'A');
            if (await reg_rfidservice.Grabar(oREGI_RFID))
            {
                CEnroladoT cEnroladoT = new CEnroladoT(ID_REGI_PLAC, Cod_RFID,Fecha_Valida,"Reguistro Grabado");
                return Json(cEnroladoT);
            }
            else
            {
                return Json(new CEnroladoT());
            }

        }
        public async Task<JsonResult> ExisteCod_RFID(String Cod_RFID, String ID_REGI_PLAC)
        {
            String Rest = "";
            if (await reg_rfidservice.Existe_Placa(ID_REGI_PLAC.Trim()))
            {
                CREGI_RFID cREGI_ = await reg_rfidservice.PlacaRFID(ID_REGI_PLAC);
                if (cREGI_.ID_REGI_PLAC != null && cREGI_.Cod_RFID != "" && cREGI_.ID_REGI_PLAC != null && cREGI_.ID_REGI_PLAC != "")
                {
                    if (cREGI_.Cod_RFID == Cod_RFID && cREGI_.ID_REGI_PLAC == ID_REGI_PLAC)
                    {
                        Rest = "Actualizar";
                    }
                    else if (cREGI_.Cod_RFID != Cod_RFID && cREGI_.ID_REGI_PLAC == ID_REGI_PLAC)
                    {
                        Rest = "Registrado";
                    }
                }
                else
                {
                    Rest = "Insertar";
                }
            }
            else
            {
                Rest = "Not";
            }
            return Json(Rest);
        }
        public Task<JsonResult> ProcesarText(String Texto)
        {
            char[] delimiterChars = { '\n' };
            IList<CEnroladoT> cEnroladoTs = new List<CEnroladoT>();

            String[] Registros = Texto.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            if (Registros.Length > 0)
            {
                cEnroladoTs = Registros
                    .Select(registro => registro.Trim().Split('\t'))
                    .Where(parts => parts.Length >= 2)
                    .Select(async parts =>
                    {
                        string ID_REGI_PLAC = parts[0].Trim();
                        string Cod_RFID = parts[1].Trim();

                        CEnroladoT cEnroladoT = new CEnroladoT
                        {
                            ID_REGI_PLAC = ID_REGI_PLAC,
                            Cod_RFID = Cod_RFID,
                            Fecha_Valida = DateTime.Now.ToString("dd/MM/yyyy")
                        };

                        if (await reg_rfidservice.Existe_Placa(ID_REGI_PLAC))
                        {
                            CREGI_RFID cREGI_ = await reg_rfidservice.PlacaRFID(ID_REGI_PLAC);
                            if (cREGI_ is not null)
                            {
                                CREGI_RFID oREGI_RFID = new CREGI_RFID
                                {
                                    ID_REGI_PLAC = ID_REGI_PLAC,
                                    Cod_RFID = Cod_RFID,
                                    Vigencia = DateTime.Now,
                                    DateNew = DateTime.Now,
                                    DateEdit = DateTime.Now,
                                    UserEdit = contxt.HttpContext != null ? Convert.ToInt32(contxt.HttpContext.Session.GetString("IDUser")) : 0,
                                    UserNew = contxt.HttpContext != null ? Convert.ToInt32(contxt.HttpContext.Session.GetString("IDUser")) : 0,
                                    Estado = cREGI_.Estado
                                };

                                cEnroladoT.EstadoCarga =  await reg_rfidservice.Grabar(oREGI_RFID)
                                    ? "Placa y RFID registrado"
                                    : "Placa y RFID no registrado";
                            }
                            else
                            {
                                cEnroladoT.EstadoCarga = "Placa Nro. " + cREGI_!.ID_REGI_PLAC + " asignado al RFID " + cREGI_.Cod_RFID + " Intentado asignar RFID " + Cod_RFID;
                            }
                        }
                        else
                        {
                            cEnroladoT.EstadoCarga = "Placa no registrado en el sistema";
                        }

                        return cEnroladoT;
                    })
                    .Select(task => task.Result)
                    .ToList();
            }

            return Task.FromResult(cEnroladoTs.Count > 0
                ? Json(cEnroladoTs)
                : Json(new List<CREGI_RFID>()));
        }
        [HttpPost]
        public async Task<JsonResult> GrabarDatos(IList<CEnroladoT> Lista) 
        {
            try
            {
                bool estado=false;
                if (Lista.Count > 0)
                {
                    int UserEdit=0;
                    int UserNew=0;
                    if (contxt.HttpContext is not null)
                    {
                        UserEdit = Convert.ToInt32(contxt.HttpContext.Session.GetString("IDUser")); 
                        UserNew = Convert.ToInt32(contxt.HttpContext.Session.GetString("IDUser"));
                    }
                    for (int i = 0; i < Lista.Count; i++)
                    {
                        CREGI_RFID oREGI_RFID = new CREGI_RFID(Lista[i].ID_REGI_PLAC, Lista[i].Cod_RFID, DateTime.Today, DateTime.Today, DateTime.Today, UserNew, UserEdit, 'A') ;
                        bool grabado = await reg_rfidservice.Grabar(oREGI_RFID);
                        estado = Convert.ToBoolean(grabado);
                    }
                }
                return new JsonResult(estado);
            }
            catch (Exception Ex)
            {
                return new JsonResult(new { Error = Ex.Message });
            }
        }
    }
}
