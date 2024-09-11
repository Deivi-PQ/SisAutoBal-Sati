using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CBala_ContDet
    {
        [DataMember()]
        public String ID_BALA { get; set; }
        [DataMember()]
        public String DE_TIPO { get; set; }

        [DataMember()]
        public String SNContr { get; set; }

        #region Constructores
        // Constructores
        public CBala_ContDet()
        {
        }

        public CBala_ContDet(String ID_BALA_, string DE_TIPO_, String SNContr_)
        {
            ID_BALA = ID_BALA_;
            DE_TIPO = DE_TIPO_;
            SNContr = SNContr_;
        }
        #endregion
    }
}
