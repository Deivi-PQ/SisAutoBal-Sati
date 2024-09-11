//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 6 de marzo de 2023
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CBloqueoPasoBalanza
    {
        
        [DataMember()]
        public int IDBloqueBal {get;set;}
        
        [DataMember()]
        public Int64 ID_REQU_ATEN {get;set;}

        [DataMember()]
        public String Nro_Placa { get; set; }

        [DataMember()]
        public String MotivoBloqueo {get;set;}
        
        [DataMember()]
        public Char EstadoBloqueo {get;set;}
        
        [DataMember()]
        public DateTime FechaAprobacion {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA {get;set;}

        

        #region Constructores
        // Constructores
        public CBloqueoPasoBalanza()
        {

        }
        
        public CBloqueoPasoBalanza(int IDBloqueBal_, Int64 ID_REQU_ATEN_, String Nro_Placa_, String MotivoBloqueo_, Char EstadoBloqueo_, DateTime FechaAprobacion_, Int32 ID_USUA_)
        {
            IDBloqueBal = IDBloqueBal_;
            ID_REQU_ATEN = ID_REQU_ATEN_;
            MotivoBloqueo = MotivoBloqueo_;
            EstadoBloqueo = EstadoBloqueo_;
            FechaAprobacion = FechaAprobacion_;
            ID_USUA = ID_USUA_;
            Nro_Placa = Nro_Placa_;
        }
        #endregion
    }
}
