using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CAuditoriaBalanza
    {

        [DataMember()]
        public Int64 IDAudBal { get; set; }

        [DataMember()]
        public String ID_BALA { get; set; }

        [DataMember()]
        public String Accion { get; set; }

        [DataMember()]
        public DateTime Fecha { get; set; }

        [DataMember()]
        public String Usuario { get; set; }

        [DataMember()]
        public String Motivo { get; set; }
        

        public CAuditoriaBalanza() 
        { }
        public CAuditoriaBalanza(Int64 iDAudBal, string iD_BALA, string accion, DateTime fecha, string usuario, string motivo)
        {
            IDAudBal = iDAudBal;
            ID_BALA = iD_BALA;
            Accion = accion;
            Fecha = fecha;
            Usuario = usuario;
            Motivo = motivo;

        }
    }
}
