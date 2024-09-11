//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 10 de octubre de 2023
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
    public partial class CREGI_RFID
    {
        
        [DataMember()]
        public String ID_REGI_PLAC {get;set;}
        
        [DataMember()]
        public String Cod_RFID {get;set;}
        
        [DataMember()]
        public DateTime? Vigencia {get;set;}
        
        [DataMember()]
        public DateTime? DateNew {get;set;}
        
        [DataMember()]
        public DateTime? DateEdit {get;set;}
        
        [DataMember()]
        public Int32 UserNew {get;set;}
        
        [DataMember()]
        public Int32 UserEdit {get;set;}
        [DataMember()]
        public Char Estado { get; set; }

        #region Constructores
        // Constructores
        public CREGI_RFID()
        {
        }
        
        public CREGI_RFID(String ID_REGI_PLAC_, String Cod_RFID_, DateTime? Vigencia_, DateTime? DateNew_, DateTime? DateEdit_, Int32 UserNew_, Int32 UserEdit_, Char Estado_)
        {
            ID_REGI_PLAC = ID_REGI_PLAC_;
            Cod_RFID = Cod_RFID_;
            Vigencia = Vigencia_;
            DateNew = DateNew_;
            DateEdit = DateEdit_;
            UserNew = UserNew_;
            UserEdit = UserEdit_;
            Estado = Estado_;
        }
        #endregion
    }
}
