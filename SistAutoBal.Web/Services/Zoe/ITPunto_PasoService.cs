using System;
using System.Text;
using System.Collections.Generic;
using System.ServiceModel;
using SisAutoZoe.BusinessObjects.Zoe;

namespace SisAutoBal.Web.Services.Zoe
{
    
    
    public interface ITPunto_PasoService
    {

        Task<bool> Grabar(CTPunto_Paso oTPunto_Paso);

        Task<int> Eliminar(Int32 Cod_Punto);
        
        Task<CTPunto_Paso> Recuperar(Int32 Cod_Punto);
        
        Task<bool> Existe(Int32 Cod_Punto);

        Task<IList<CTPunto_Paso>> Listar(CTPunto_Paso cTPunto_Paso);
        Task<IList<CTPunto_Paso>> Buscar(String ID_Punto, String SNContr);
        Task<int> Next();
    }
}
