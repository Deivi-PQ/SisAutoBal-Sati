//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: viernes, 20 de octubre de 2023
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
    public partial class CDatosRFID
    {
        
        [DataMember()]
        public Int32 ID {get;set;}

        [DataMember()]
        public String SN { get; set; }

        [DataMember()]
        public DateTime TTime {get;set;}
        
        [DataMember()]
        public String Pin {get;set;}
        
        [DataMember()]
        public String Cardno {get;set;}
        
        [DataMember()]
        public String Eventaddr {get;set;}
        
        [DataMember()]
        public String Evento {get;set;}
        
        [DataMember()]
        public String Inoutstatus {get;set;}
        
        [DataMember()]
        public String Verifytype {get;set;}
        
        [DataMember()]
        public String IIndex {get;set;}
        
        [DataMember()]
        public Boolean flagProcesado {get;set;}
        
        #region Constructores
        // Constructores
        public CDatosRFID()
        {
            ID = 0;
        }
        
        public CDatosRFID(Int32 ID_, String SN_, DateTime TTime_, String Pin_, String Cardno_, String Eventaddr_, String Evento_, String Inoutstatus_, String Verifytype_, String IIndex_, Boolean flagProcesado_)
        {
            ID = ID_;
            SN = SN_;
            TTime = TTime_;
            Pin = Pin_;
            Cardno = Cardno_;
            Eventaddr = Eventaddr_;
            Evento = Evento_;
            Inoutstatus = Inoutstatus_;
            Verifytype = Verifytype_;
            IIndex = IIndex_;
            flagProcesado = flagProcesado_;
        }
        #endregion
    }
}
