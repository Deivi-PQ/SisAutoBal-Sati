using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    public partial class CAuditoriaBalazaGenaral
    {
        public int Nro { get; set; }
        public String ID_BALA { get; set; }
        public String DE_TIPO { get; set;}
        public String Accion { get; set; }
        public String DE_USUA { get; set;}
        public DateTime Fecha { get;set;}
        public CAuditoriaBalazaGenaral() { }
        public CAuditoriaBalazaGenaral(int nro, string iD_BALA, string dE_TIPO, string accion, string dE_USUA, DateTime fecha)
        {
            Nro = nro;
            ID_BALA = iD_BALA;
            DE_TIPO = dE_TIPO;
            Accion = accion;
            DE_USUA = dE_USUA;
            Fecha = fecha;
        }
    }
}
