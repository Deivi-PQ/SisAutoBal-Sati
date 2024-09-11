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
using SisAutoBal.BusinessObjects.OfiSegu;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace SisAutoBal.DataObjects.OfiSegu
{


    public partial class MUSUADao : DataAccessBase
    {

        public virtual CMUSUA getMUSUA(DataRow dr)
        {
            return new CMUSUA(Convert.ToInt32(dr["ID_USUA"]), 
                Convert.ToString(dr["NO_USUA"]), 
                Convert.ToString(dr["ST_USUA_WIND"]), 
                Convert.ToString(dr["NO_CLAV"]), 
                Convert.ToString(LComun.IsDbNull(dr["FE_MODI_CLAV"], "")), 
                Convert.ToString(LComun.IsDbNull(dr["DE_DIRE_MAIL"], "")), 
                Convert.ToString(dr["ST_ACTI"]), 
                Convert.ToString(dr["ST_BLOQ_IFAL"]), 
                Convert.ToString(dr["ST_CACL_INGR"]), 
                Convert.ToString(dr["ST_EXPI_CLAV"]), 
                Convert.ToString(LComun.IsDbNull(dr["ST_EXPI_USUA"], "")), 
                Convert.ToString(LComun.IsDbNull(dr["FE_EXPI_USUA"], "")), 
                Convert.ToString(dr["TI_CONE"]), 
                Convert.ToInt32(dr["ID_EMPR"]), 
                Convert.ToInt32(dr["ID_UNID"]), 
                Convert.ToInt32(LComun.IsDbNull(dr["NU_VECE_CONE"],0)), 
                Convert.ToDateTime(LComun.IsDbNull(dr["FE_ULTI_CONE"], DateTime.Now)), 
                Convert.ToString(dr["ST_HORA"]), 
                Convert.ToString(LComun.IsDbNull(dr["HO_INIC"], "")), 
                Convert.ToString(LComun.IsDbNull(dr["HO_FINA"], "")), 
                Convert.ToString(dr["ST_DOMI"]), Convert.ToString(dr["ST_LUNE"]), 
                Convert.ToString(dr["ST_MART"]), Convert.ToString(dr["ST_MIER"]), 
                Convert.ToString(dr["ST_JUEV"]), Convert.ToString(dr["ST_VIER"]), 
                Convert.ToString(dr["ST_SABA"]), Convert.ToInt32(dr["ID_USUA_CREA"]), 
                Convert.ToDateTime(dr["FE_USUA_CREA"]), Convert.ToInt32(dr["ID_USUA_MODI"]), 
                Convert.ToDateTime(dr["FE_USUA_MODI"]), Convert.ToString(LComun.IsDbNull(dr["DE_USUA"], "")));
        }

        public virtual CMUSUA getMUSUA(IDataReader dr)
        {
            return new CMUSUA(Convert.ToInt32(dr["ID_USUA"]),
                Convert.ToString(dr["NO_USUA"]),
                Convert.ToString(dr["ST_USUA_WIND"]),
                Convert.ToString(dr["NO_CLAV"]),
                Convert.ToString(LComun.IsDbNull(dr["FE_MODI_CLAV"], "")),
                Convert.ToString(LComun.IsDbNull(dr["DE_DIRE_MAIL"], "")),
                Convert.ToString(dr["ST_ACTI"]),
                Convert.ToString(dr["ST_BLOQ_IFAL"]),
                Convert.ToString(dr["ST_CACL_INGR"]),
                Convert.ToString(dr["ST_EXPI_CLAV"]),
                Convert.ToString(LComun.IsDbNull(dr["ST_EXPI_USUA"], "")),
                Convert.ToString(LComun.IsDbNull(dr["FE_EXPI_USUA"], "")),
                Convert.ToString(dr["TI_CONE"]),
                Convert.ToInt32(dr["ID_EMPR"]),
                Convert.ToInt32(dr["ID_UNID"]),
                Convert.ToInt32(LComun.IsDbNull(dr["NU_VECE_CONE"], 0)),
                Convert.ToDateTime(LComun.IsDbNull(dr["FE_ULTI_CONE"], DateTime.Now)),
                Convert.ToString(dr["ST_HORA"]),
                Convert.ToString(LComun.IsDbNull(dr["HO_INIC"], "")),
                Convert.ToString(LComun.IsDbNull(dr["HO_FINA"], "")),
                Convert.ToString(dr["ST_DOMI"]), Convert.ToString(dr["ST_LUNE"]),
                Convert.ToString(dr["ST_MART"]), Convert.ToString(dr["ST_MIER"]),
                Convert.ToString(dr["ST_JUEV"]), Convert.ToString(dr["ST_VIER"]),
                Convert.ToString(dr["ST_SABA"]), Convert.ToInt32(dr["ID_USUA_CREA"]),
                Convert.ToDateTime(dr["FE_USUA_CREA"]), Convert.ToInt32(dr["ID_USUA_MODI"]),
                Convert.ToDateTime(dr["FE_USUA_MODI"]), Convert.ToString(LComun.IsDbNull(dr["DE_USUA"], "")));
        }

        #region Metodos Principales

        public virtual CMUSUA Recuperar(Int32 ID_USUA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiSegu.TS_TTMUSUA_Q01", ID_USUA).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getMUSUA(dtDatos.Rows[0]);
            else
                return new CMUSUA();
        }

        public virtual bool Existe(Int32 ID_USUA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiSegu.TS_TTMUSUA_Q01", ID_USUA).Tables[0];
            return dtDatos.Rows.Count > 0;
        }

        public virtual bool Existe(Int32 ID_USUA, out CMUSUA oMUSUA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiSegu.TS_TTMUSUA_Q01", ID_USUA).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oMUSUA = getMUSUA(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oMUSUA = new CMUSUA();
                return false;
            }
        }

        public virtual IList<CMUSUA> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "OfiSegu.TS_TTMUSUA_Q02"))
            {
                IList<CMUSUA> list = new List<CMUSUA>();
                while (dr.Read())
                    list.Add(getMUSUA(dr));
                return list;
            }
        }
        #endregion

        public virtual CMUSUA RecuperarUsuario(String NO_USUA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiSegu.TS_TTMUSUA_Q03", NO_USUA).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getMUSUA(dtDatos.Rows[0]);
            else
                return new CMUSUA();
        }
        public virtual bool ExisteUsuario(String NO_USUA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiSegu.TS_TTMUSUA_Q03", NO_USUA).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
    }
}
