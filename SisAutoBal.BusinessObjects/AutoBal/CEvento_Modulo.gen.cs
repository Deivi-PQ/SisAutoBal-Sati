using System.Runtime.Serialization;
using System;
using System.Collections.Generic;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    
    
    // Propiedades AutoImplementadas
    public partial class CEvento_Modulo
    {
        
        [DataMember()]
        public Int64 IDEvento {get;set;}
        
        [DataMember()]
        public String Modulo {get;set;}
        
        [DataMember()]
        public String Des_Evento {get;set;}
        
        [DataMember()]
        public String Usuario {get;set;}
        
        [DataMember()]
        public DateTime FechaHora {get;set;}
        
        [DataMember()]
        public Char Tipo_Evento {get;set;}
        
        #region Constructores
        // Constructores
        public CEvento_Modulo()
        {
        }
        
        public CEvento_Modulo(Int64 IDEvento_, String Modulo_, String Des_Evento_, String Usuario_, DateTime FechaHora_, Char Tipo_Evento_)
        {
            IDEvento = IDEvento_;
            Modulo = Modulo_;
            Des_Evento = Des_Evento_;
            Usuario = Usuario_;
            FechaHora = FechaHora_;
            Tipo_Evento = Tipo_Evento_;
        }
        #endregion
    }
}
