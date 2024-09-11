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

namespace SisAutoBal.BusinessObjects.Auxiliar
{
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CDatosCamionReq
    {

        [DataMember()]
        public string NU_REQU_ATEN { get; set; }

        [DataMember()]
        public Int32 ID_REQU_ATEN { get; set; }

        [DataMember()]
        public String CO_CLIE { get; set; }

        [DataMember()]
        public String DE_CARG { get; set; }

        [DataMember()]
        public String DE_MERC { get; set; }

        [DataMember()]
        public String NO_COND { get; set; }

        [DataMember()]
        public String AP_COND { get; set; }

        [DataMember()]
        public String NU_BREV { get; set; }

        [DataMember()]
        public String DE_CLIE { get; set; }


        [DataMember()]
        public String ID_TRAN { get; set; }

        [DataMember()]
        public String ID_REGI_COND { get; set; }

        [DataMember()]
        public long ID_TICK_ANTE { get; set; }

        [DataMember()]
        public int ID_UNID { get; set; }

        [DataMember()]
        public int ID_EMPR { get; set; }

        [DataMember()]
        public String DE_NUME_TRAC { get; set; }

        [DataMember()]
        public String DE_NUME_TAUX { get; set; }

        [DataMember()]
        public String NU_RECA { get; set; }

        [DataMember()]
        public String NU_SALI { get; set; }

        [DataMember()]
        public long ID_DOCU_ORIG { get; set; }

        [DataMember()]
        public string ID_REGI { get; set; }

        [DataMember()]
        public bool Tiene_MIC { get; set; }


        [DataMember()]
        public short NU_SECU_ITEM { get; set; }

        [DataMember()]
        public String NU_GUIA_REMI { get; set; }

        [DataMember()]
        public String ID_CIUD { get; set; }
        
        [DataMember()]
        public String Servicio_Base { get; set; }


        #region Constructores
        // Constructores
        public CDatosCamionReq()
        {
        }

        public CDatosCamionReq(string NU_REQU_ATEN_, Int32 ID_REQU_ATEN_, String CO_CLIE_, String DE_CARG_, String DE_MERC_, String NO_COND_, String AP_COND_, String NU_BREV_, String DE_CLIE_, String ID_TRAN_, String ID_REGI_COND_, long ID_TICK_ANTE_, int ID_UNID_, int ID_EMPR_, String DE_NUME_TRAC_, String DE_NUME_TAUX_, String NU_RECA_, String NU_SALI_, long ID_DOCU_ORIG_, string ID_REGI_, bool Tiene_MIC_, short NU_SECU_ITEM_, String NU_GUIA_REMI_, String ID_CIUD_, String Servicio_Base_)
        {
            NU_REQU_ATEN = NU_REQU_ATEN_;
            ID_REQU_ATEN = ID_REQU_ATEN_;
            CO_CLIE = CO_CLIE_;
            DE_CARG = DE_CARG_;
            DE_MERC = DE_MERC_;
            NO_COND = NO_COND_;
            AP_COND = AP_COND_;
            NU_BREV = NU_BREV_;
            DE_CLIE = DE_CLIE_;
            ID_TRAN = ID_TRAN_;
            ID_REGI_COND = ID_REGI_COND_;
            ID_TICK_ANTE = ID_TICK_ANTE_;
            ID_UNID = ID_UNID_;
            ID_EMPR = ID_EMPR_;
            DE_NUME_TRAC = DE_NUME_TRAC_;
            DE_NUME_TAUX = DE_NUME_TAUX_;
            NU_RECA = NU_RECA_;
            NU_SALI = NU_SALI_;
            ID_DOCU_ORIG = ID_DOCU_ORIG_;
            ID_REGI = ID_REGI_;
            Tiene_MIC = Tiene_MIC_;
            NU_SECU_ITEM = NU_SECU_ITEM_;
            NU_GUIA_REMI = NU_GUIA_REMI_;
            ID_CIUD = ID_CIUD_;
            Servicio_Base = Servicio_Base_;
        }
        #endregion
    }
}
