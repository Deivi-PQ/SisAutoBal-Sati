//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 7 de marzo de 2023
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using SisAutoBal.BusinessObjects.OfiOper;
using Microsoft.Practices.EnterpriseLibrary.Data;


namespace SisAutoBal.DataObjects.OfiOper
{


    public partial class TTIPO_BALADao : DataAccessBase
    {

        public virtual CTTIPO_BALA getTTIPO_BALA(DataRow dr)
        {
            return new CTTIPO_BALA(Convert.ToString(dr["ID_BALA"]), Convert.ToString(dr["ID_CLAS_BALA"]), Convert.ToInt32(dr["ID_EMPR"]), Convert.ToString(dr["DE_TIPO"]), Convert.ToString(dr["IP_MAQU"]), Convert.ToString(dr["IP_CA01"]), Convert.ToString(dr["CO_USUA_CA01"]), Convert.ToString(dr["CO_CONT_CA01"]), Convert.ToString(dr["IP_CA02"]), Convert.ToString(dr["CO_USUA_CA02"]), Convert.ToString(dr["CO_CONT_CA02"]), Convert.ToInt32(dr["ID_USUA_CREA"]), Convert.ToDateTime(dr["FE_USUA_CREA"]), Convert.ToInt32(dr["ID_USUA_MODI"]), Convert.ToDateTime(dr["FE_USUA_MODI"]), Convert.ToString(dr["ST_TRAF_CONT"]));
        }

        public virtual CTTIPO_BALA getTTIPO_BALA(IDataReader dr)
        {
            return new CTTIPO_BALA(Convert.ToString(dr["ID_BALA"]), Convert.ToString(dr["ID_CLAS_BALA"]), Convert.ToInt32(dr["ID_EMPR"]), Convert.ToString(dr["DE_TIPO"]), Convert.ToString(dr["IP_MAQU"]), Convert.ToString(dr["IP_CA01"]), Convert.ToString(dr["CO_USUA_CA01"]), Convert.ToString(dr["CO_CONT_CA01"]), Convert.ToString(dr["IP_CA02"]), Convert.ToString(dr["CO_USUA_CA02"]), Convert.ToString(dr["CO_CONT_CA02"]), Convert.ToInt32(dr["ID_USUA_CREA"]), Convert.ToDateTime(dr["FE_USUA_CREA"]), Convert.ToInt32(dr["ID_USUA_MODI"]), Convert.ToDateTime(dr["FE_USUA_MODI"]), Convert.ToString(dr["ST_TRAF_CONT"]));
        }

        #region Metodos Principales

        public virtual CTTIPO_BALA Recuperar(String ID_BALA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TTTIPO_BALA_Q01", ID_BALA).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getTTIPO_BALA(dtDatos.Rows[0]);
            else
                return new CTTIPO_BALA();
        }

        public virtual bool Existe(String ID_BALA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TTTIPO_BALA_Q01", ID_BALA).Tables[0];
            return dtDatos.Rows.Count > 0;
        }

        public virtual bool Existe(String ID_BALA, out CTTIPO_BALA oTTIPO_BALA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TTTIPO_BALA_Q01", ID_BALA).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oTTIPO_BALA = getTTIPO_BALA(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oTTIPO_BALA = new CTTIPO_BALA();
                return false;
            }
        }

        public virtual IList<CTTIPO_BALA> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "AutoBal.TS_TTTIPO_BALA_Q02"))
            {
                IList<CTTIPO_BALA> list = new List<CTTIPO_BALA>();
                while (dr.Read())
                    list.Add(getTTIPO_BALA(dr));
                return list;
            }
        }
        #endregion

    }
}
