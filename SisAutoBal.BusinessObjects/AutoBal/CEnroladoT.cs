using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    public partial class CEnroladoT
    {
        public String ID_REGI_PLAC { get; set; }
        public String Cod_RFID { get; set; }
        public String Fecha_Valida { get; set; }
        public String EstadoCarga { get; set; }
        public CEnroladoT() { }
        public CEnroladoT(String ID_REGI_PLAC_, String Cod_RFID_,String Fecha_Valida_, String EstadoCarga_) 
        { 
            ID_REGI_PLAC= ID_REGI_PLAC_;
            Cod_RFID= Cod_RFID_;
            Fecha_Valida= Fecha_Valida_;
            EstadoCarga= EstadoCarga_;
        }
    }
}
