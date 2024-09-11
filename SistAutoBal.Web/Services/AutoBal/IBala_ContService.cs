//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 7 de mayo de 2024
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ServiceModel;
using SisAutoBal.BusinessObjects.AutoBal;


namespace SisAutoBal.Web.Services.AutoBal
{
    
    
    public interface IBala_ContService
    {

        Task<bool> Grabar(CBala_Cont oBala_Cont);
        Task<int> Eliminar(String ID_BALA);
        Task<CBala_Cont> Recuperar(String ID_BALA);    
        Task<bool> Existe(String ID_BALA);
        Task<IList<CBala_Cont>> Listar();
        Task<IList<CBala_ContDet>> Buscar(String ID_Bala, String SNContr);
    }
}
