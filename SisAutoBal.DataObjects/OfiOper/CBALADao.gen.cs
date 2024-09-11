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
using LibreriaBSNet;
using SisAutoBal.BusinessObjects.Auxiliar;

namespace SisAutoBal.DataObjects.OfiOper
{


    public partial class CBALADao : DataAccessBase
    {

        public virtual CCBALA getCBALA(DataRow dr)
        {
            DateTime? FE_SALI = null;

            if (dr["FE_SALI"] != DBNull.Value)
                FE_SALI = Convert.ToDateTime(dr["FE_SALI"]);

            return new CCBALA(Convert.ToInt64(dr["ID_MOVI_BALA"]),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_MOVI_DUES"], 0)),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_MOVI_OPER"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["NU_MOVI"], "")),
                Convert.ToString(dr["TI_MOVI_INDI"]),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_TICK_ANTE"], 0)),
                Convert.ToInt32(dr["ID_UNID"]),
                Convert.ToInt32(dr["ID_EMPR"]),
                Convert.ToString(dr["ID_BALA"]),
                Convert.ToString(dr["CO_CLIE"]),
                Convert.ToDateTime(dr["FE_ENTR"]),
                Convert.ToString(dr["HO_ENTR"]),
                FE_SALI,
                Convert.ToString(LComun.IsDbNull(dr["HO_SALI"], "")),
                Convert.ToString(LComun.IsDbNull(dr["ID_TRAN"], "")),
                Convert.ToString(dr["ID_REGI_PLAC"]),
                Convert.ToString(LComun.IsDbNull(dr["ID_REGI_COND"], "")),
                Convert.ToString(LComun.IsDbNull(dr["DE_NUME_TRAC"], "")),
                Convert.ToString(LComun.IsDbNull(dr["DE_NUME_TAUX"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_RECA"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_SALI"], "")),
                Convert.ToInt64(dr["ID_DOCU_ORIG"]),
                Convert.ToInt16(dr["NU_SECU_ITEM"]),
                Convert.ToString(LComun.IsDbNull(dr["DE_OBSE"], "")),
                Convert.ToDecimal(LComun.IsDbNull(dr["CA_PES1"], 0)),
                Convert.ToDecimal(LComun.IsDbNull(dr["CA_PES2"], 0)),
                Convert.ToDecimal(LComun.IsDbNull(dr["CA_PESO_SECO"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["DE_MICS"], "")),
                Convert.ToDecimal(LComun.IsDbNull(dr["NU_PESO_MICS"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["NU_CART_PORT"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_DUES"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_FACT"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_GUIA_REMI"], "")),
                Convert.ToString(LComun.IsDbNull(dr["ID_CIUD"], "")),
                Convert.ToString(dr["ST_CIER"]),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_EJES"], 0)),
                Convert.ToString(dr["ID_TIPO_JORN"]),
                Convert.ToString(dr["TI_SITU"]),
                Convert.ToString(LComun.IsDbNull(dr["NU_CHAS"], "")),
                Convert.ToInt16(LComun.IsDbNull(dr["NU_VUEL"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["NU_NOTA_ENTR"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_MESA_PART"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_CORR_CONT"], "")),
                Convert.ToString(LComun.IsDbNull(dr["FE_CONT"], "")),
                Convert.ToString(dr["ST_CERT_CESO"]),
                Convert.ToString(dr["CO_BODE"]),
                Convert.ToString(LComun.IsDbNull(dr["FE_TRAN_BDLO"], "")),
                Convert.ToString(LComun.IsDbNull(dr["HO_TRAN_BDLO"], "")),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_MOVI_BDLO"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["CO_PERS_PES1"], "")),
                Convert.ToString(LComun.IsDbNull(dr["CO_PERS_PES2"], "")),
                Convert.ToString(LComun.IsDbNull(dr["CO_REGU_PESO"], "")),
                Convert.ToString(LComun.IsDbNull(dr["CO_EDIT_PESO"], "")),
                Convert.ToString(dr["ST_EDIT_PESO"]),
                Convert.ToString(dr["ST_CIER_JORN"]),
                Convert.ToString(LComun.IsDbNull(dr["DE_MOTI_ANUL"], "")),
                Convert.ToInt32(dr["ID_USUA_CREA"]),
                Convert.ToDateTime(dr["FE_USUA_CREA"]),
                Convert.ToInt32(dr["ID_USUA_MODI"]),
                Convert.ToDateTime(dr["FE_USUA_MODI"]),
                Convert.ToDateTime(LComun.IsDbNull(dr["FE_PRIM_PESA"], DateTime.Now)),
                Convert.ToDateTime(LComun.IsDbNull(dr["FE_SEGU_PESA"], DateTime.Now)),
                Convert.ToString(LComun.IsDbNull(dr["CO_REGU_PES1"], "")),
                Convert.ToString(LComun.IsDbNull(dr["CO_REGU_PES2"], "")),
                Convert.ToString(LComun.IsDbNull(dr["ST_MOVI_TRAF"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_MOVI_BDLO"], "")),
                Convert.ToString(LComun.IsDbNull(dr["ID_BAL2"], "")),
                Convert.ToString(LComun.IsDbNull(dr["DE_MOTI_ROLE"], "")),
                Convert.ToString(LComun.IsDbNull(dr["DE_MOTI_REGU"], "")),
                Convert.ToBoolean(LComun.IsDbNull(dr["FI_Estado"], false))
                );
        }

        public virtual CCBALA getCBALA(IDataReader dr)
        {
            DateTime? FE_SALI = null;

            if (dr["FE_SALI"] != DBNull.Value)
                FE_SALI = Convert.ToDateTime(dr["FE_SALI"]);

            return new CCBALA(Convert.ToInt64(dr["ID_MOVI_BALA"]),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_MOVI_DUES"], 0)),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_MOVI_OPER"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["NU_MOVI"], "")),
                Convert.ToString(dr["TI_MOVI_INDI"]),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_TICK_ANTE"], 0)),
                Convert.ToInt32(dr["ID_UNID"]),
                Convert.ToInt32(dr["ID_EMPR"]),
                Convert.ToString(dr["ID_BALA"]),
                Convert.ToString(dr["CO_CLIE"]),
                Convert.ToDateTime(dr["FE_ENTR"]),
                Convert.ToString(dr["HO_ENTR"]),
                FE_SALI,
                Convert.ToString(LComun.IsDbNull(dr["HO_SALI"], "")),
                Convert.ToString(LComun.IsDbNull(dr["ID_TRAN"], "")),
                Convert.ToString(dr["ID_REGI_PLAC"]),
                Convert.ToString(LComun.IsDbNull(dr["ID_REGI_COND"], "")),
                Convert.ToString(LComun.IsDbNull(dr["DE_NUME_TRAC"], "")),
                Convert.ToString(LComun.IsDbNull(dr["DE_NUME_TAUX"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_RECA"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_SALI"], "")),
                Convert.ToInt64(dr["ID_DOCU_ORIG"]),
                Convert.ToInt16(dr["NU_SECU_ITEM"]),
                Convert.ToString(LComun.IsDbNull(dr["DE_OBSE"], "")),
                Convert.ToDecimal(LComun.IsDbNull(dr["CA_PES1"], 0)),
                Convert.ToDecimal(LComun.IsDbNull(dr["CA_PES2"], 0)),
                Convert.ToDecimal(LComun.IsDbNull(dr["CA_PESO_SECO"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["DE_MICS"], "")),
                Convert.ToDecimal(LComun.IsDbNull(dr["NU_PESO_MICS"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["NU_CART_PORT"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_DUES"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_FACT"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_GUIA_REMI"], "")),
                Convert.ToString(LComun.IsDbNull(dr["ID_CIUD"], "")),
                Convert.ToString(dr["ST_CIER"]),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_EJES"], 0)),
                Convert.ToString(dr["ID_TIPO_JORN"]),
                Convert.ToString(dr["TI_SITU"]),
                Convert.ToString(LComun.IsDbNull(dr["NU_CHAS"], "")),
                Convert.ToInt16(LComun.IsDbNull(dr["NU_VUEL"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["NU_NOTA_ENTR"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_MESA_PART"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_CORR_CONT"], "")),
                Convert.ToString(LComun.IsDbNull(dr["FE_CONT"], "")),
                Convert.ToString(dr["ST_CERT_CESO"]),
                Convert.ToString(dr["CO_BODE"]),
                Convert.ToString(LComun.IsDbNull(dr["FE_TRAN_BDLO"], "")),
                Convert.ToString(LComun.IsDbNull(dr["HO_TRAN_BDLO"], "")),
                Convert.ToInt64(LComun.IsDbNull(dr["ID_MOVI_BDLO"], 0)),
                Convert.ToString(LComun.IsDbNull(dr["CO_PERS_PES1"], "")),
                Convert.ToString(LComun.IsDbNull(dr["CO_PERS_PES2"], "")),
                Convert.ToString(LComun.IsDbNull(dr["CO_REGU_PESO"], "")),
                Convert.ToString(LComun.IsDbNull(dr["CO_EDIT_PESO"], "")),
                Convert.ToString(dr["ST_EDIT_PESO"]),
                Convert.ToString(dr["ST_CIER_JORN"]),
                Convert.ToString(LComun.IsDbNull(dr["DE_MOTI_ANUL"], "")),
                Convert.ToInt32(dr["ID_USUA_CREA"]),
                Convert.ToDateTime(dr["FE_USUA_CREA"]),
                Convert.ToInt32(dr["ID_USUA_MODI"]),
                Convert.ToDateTime(dr["FE_USUA_MODI"]),
                Convert.ToDateTime(LComun.IsDbNull(dr["FE_PRIM_PESA"], DateTime.Now)),
                Convert.ToDateTime(LComun.IsDbNull(dr["FE_SEGU_PESA"], DateTime.Now)),
                Convert.ToString(LComun.IsDbNull(dr["CO_REGU_PES1"], "")),
                Convert.ToString(LComun.IsDbNull(dr["CO_REGU_PES2"], "")),
                Convert.ToString(LComun.IsDbNull(dr["ST_MOVI_TRAF"], "")),
                Convert.ToString(LComun.IsDbNull(dr["NU_MOVI_BDLO"], "")),
                Convert.ToString(LComun.IsDbNull(dr["ID_BAL2"], "")),
                Convert.ToString(LComun.IsDbNull(dr["DE_MOTI_ROLE"], "")),
                Convert.ToString(LComun.IsDbNull(dr["DE_MOTI_REGU"], "")),
                Convert.ToBoolean(LComun.IsDbNull(dr["FI_Estado"], false))
                );
        }



        public CDatosCamionReq getDatosCamionReq(DataRow dr)
        {
            return new CDatosCamionReq(
                   Convert.ToString(LComun.IsDbNull(dr["NU_REQU_ATEN"], "")),
                   Convert.ToInt32(dr["ID_REQU_ATEN"]),
                   Convert.ToString(LComun.IsDbNull(dr["CO_CLIE"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["DE_CARG"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["DE_MERC"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["NO_COND"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["AP_COND"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["NU_BREV"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["DE_CLIE"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["ID_TRAN"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["ID_REGI_COND"], "")),
                   Convert.ToInt64(LComun.IsDbNull(dr["ID_TICK_ANTE"], 0)),
                   Convert.ToInt32(LComun.IsDbNull(dr["ID_UNID"], 0)),
                   Convert.ToInt32(LComun.IsDbNull(dr["ID_EMPR"], 0)),
                   Convert.ToString(LComun.IsDbNull(dr["DE_NUME_TRAC"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["DE_NUME_TAUX"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["NU_RECA"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["NU_SALI"], "")),
                   Convert.ToInt32(LComun.IsDbNull(dr["ID_DOCU_ORIG"], 0)),
                   Convert.ToString(LComun.IsDbNull(dr["ID_REGI"], "")),
                   Convert.ToBoolean(LComun.IsDbNull(dr["Tiene_MIC"], false)),
                   Convert.ToInt16(LComun.IsDbNull(dr["NU_SECU_ITEM"], 0)),
                   Convert.ToString(LComun.IsDbNull(dr["NU_GUIA_REMI"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["ID_CIUD"], "")),
                   Convert.ToString(LComun.IsDbNull(dr["Servicio_Base"], "")));
        }

        #region Metodos Principales
        public virtual bool Grabar(CCBALA oCBALA)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("OfiOper.spu_CBALA_Guardar"))
            {
                Db.AddInParameter(dbCmd, "ID_MOVI_BALA", DbType.Int64, oCBALA.ID_MOVI_BALA);
                Db.AddInParameter(dbCmd, "ID_MOVI_DUES", DbType.Int64, oCBALA.ID_MOVI_DUES);
                Db.AddInParameter(dbCmd, "ID_MOVI_OPER", DbType.Int64, oCBALA.ID_MOVI_OPER);
                Db.AddInParameter(dbCmd, "NU_MOVI", DbType.String, oCBALA.NU_MOVI);
                Db.AddInParameter(dbCmd, "TI_MOVI_INDI", DbType.String, oCBALA.TI_MOVI_INDI);
                Db.AddInParameter(dbCmd, "ID_TICK_ANTE", DbType.Int64, oCBALA.ID_TICK_ANTE);
                Db.AddInParameter(dbCmd, "ID_UNID", DbType.Int32, oCBALA.ID_UNID);
                Db.AddInParameter(dbCmd, "ID_EMPR", DbType.Int32, oCBALA.ID_EMPR);
                Db.AddInParameter(dbCmd, "ID_BALA", DbType.String, oCBALA.ID_BALA);
                Db.AddInParameter(dbCmd, "CO_CLIE", DbType.String, oCBALA.CO_CLIE);
                Db.AddInParameter(dbCmd, "FE_ENTR", DbType.DateTime, oCBALA.FE_ENTR);
                Db.AddInParameter(dbCmd, "HO_ENTR", DbType.String, oCBALA.HO_ENTR);
                Db.AddInParameter(dbCmd, "FE_SALI", DbType.DateTime, oCBALA.FE_SALI);
                Db.AddInParameter(dbCmd, "HO_SALI", DbType.String, oCBALA.HO_SALI);
                Db.AddInParameter(dbCmd, "ID_TRAN", DbType.String, oCBALA.ID_TRAN);
                Db.AddInParameter(dbCmd, "ID_REGI_PLAC", DbType.String, oCBALA.ID_REGI_PLAC);
                Db.AddInParameter(dbCmd, "ID_REGI_COND", DbType.String, oCBALA.ID_REGI_COND);
                Db.AddInParameter(dbCmd, "DE_NUME_TRAC", DbType.String, oCBALA.DE_NUME_TRAC);
                Db.AddInParameter(dbCmd, "DE_NUME_TAUX", DbType.String, oCBALA.DE_NUME_TAUX);
                Db.AddInParameter(dbCmd, "NU_RECA", DbType.String, oCBALA.NU_RECA);
                Db.AddInParameter(dbCmd, "NU_SALI", DbType.String, oCBALA.NU_SALI);
                Db.AddInParameter(dbCmd, "ID_DOCU_ORIG", DbType.Int64, oCBALA.ID_DOCU_ORIG);
                Db.AddInParameter(dbCmd, "NU_SECU_ITEM", DbType.Int16, oCBALA.NU_SECU_ITEM);
                Db.AddInParameter(dbCmd, "DE_OBSE", DbType.String, oCBALA.DE_OBSE);
                Db.AddInParameter(dbCmd, "CA_PES1", DbType.Decimal, oCBALA.CA_PES1);
                Db.AddInParameter(dbCmd, "CA_PES2", DbType.Decimal, oCBALA.CA_PES2);
                Db.AddInParameter(dbCmd, "CA_PESO_SECO", DbType.Decimal, oCBALA.CA_PESO_SECO);
                Db.AddInParameter(dbCmd, "DE_MICS", DbType.String, oCBALA.DE_MICS);
                Db.AddInParameter(dbCmd, "NU_PESO_MICS", DbType.Decimal, oCBALA.NU_PESO_MICS);
                Db.AddInParameter(dbCmd, "NU_CART_PORT", DbType.String, oCBALA.NU_CART_PORT);
                Db.AddInParameter(dbCmd, "NU_DUES", DbType.String, oCBALA.NU_DUES);
                Db.AddInParameter(dbCmd, "NU_FACT", DbType.String, oCBALA.NU_FACT);
                Db.AddInParameter(dbCmd, "NU_GUIA_REMI", DbType.String, oCBALA.NU_GUIA_REMI);
                Db.AddInParameter(dbCmd, "ID_CIUD", DbType.String, oCBALA.ID_CIUD);
                Db.AddInParameter(dbCmd, "ST_CIER", DbType.String, oCBALA.ST_CIER);
                Db.AddInParameter(dbCmd, "ID_EJES", DbType.Int64, oCBALA.ID_EJES);
                Db.AddInParameter(dbCmd, "ID_TIPO_JORN", DbType.String, oCBALA.ID_TIPO_JORN);
                Db.AddInParameter(dbCmd, "TI_SITU", DbType.String, oCBALA.TI_SITU);
                Db.AddInParameter(dbCmd, "NU_CHAS", DbType.String, oCBALA.NU_CHAS);
                Db.AddInParameter(dbCmd, "NU_VUEL", DbType.Int16, oCBALA.NU_VUEL);
                Db.AddInParameter(dbCmd, "NU_NOTA_ENTR", DbType.String, oCBALA.NU_NOTA_ENTR);
                Db.AddInParameter(dbCmd, "NU_MESA_PART", DbType.String, oCBALA.NU_MESA_PART);
                Db.AddInParameter(dbCmd, "NU_CORR_CONT", DbType.String, oCBALA.NU_CORR_CONT);
                Db.AddInParameter(dbCmd, "FE_CONT", DbType.String, oCBALA.FE_CONT);
                Db.AddInParameter(dbCmd, "ST_CERT_CESO", DbType.String, oCBALA.ST_CERT_CESO);
                Db.AddInParameter(dbCmd, "CO_BODE", DbType.String, oCBALA.CO_BODE);
                Db.AddInParameter(dbCmd, "FE_TRAN_BDLO", DbType.String, oCBALA.FE_TRAN_BDLO);
                Db.AddInParameter(dbCmd, "HO_TRAN_BDLO", DbType.String, oCBALA.HO_TRAN_BDLO);
                Db.AddInParameter(dbCmd, "ID_MOVI_BDLO", DbType.Int64, oCBALA.ID_MOVI_BDLO);
                Db.AddInParameter(dbCmd, "CO_PERS_PES1", DbType.String, oCBALA.CO_PERS_PES1);
                Db.AddInParameter(dbCmd, "CO_PERS_PES2", DbType.String, oCBALA.CO_PERS_PES2);
                Db.AddInParameter(dbCmd, "CO_REGU_PESO", DbType.String, oCBALA.CO_REGU_PESO);
                Db.AddInParameter(dbCmd, "CO_EDIT_PESO", DbType.String, oCBALA.CO_EDIT_PESO);
                Db.AddInParameter(dbCmd, "ST_EDIT_PESO", DbType.String, oCBALA.ST_EDIT_PESO);
                Db.AddInParameter(dbCmd, "ST_CIER_JORN", DbType.String, oCBALA.ST_CIER_JORN);
                Db.AddInParameter(dbCmd, "DE_MOTI_ANUL", DbType.String, oCBALA.DE_MOTI_ANUL);
                Db.AddInParameter(dbCmd, "ID_USUA_CREA", DbType.Int32, oCBALA.ID_USUA_CREA);
                Db.AddInParameter(dbCmd, "FE_USUA_CREA", DbType.DateTime, oCBALA.FE_USUA_CREA);
                Db.AddInParameter(dbCmd, "ID_USUA_MODI", DbType.Int32, oCBALA.ID_USUA_MODI);
                Db.AddInParameter(dbCmd, "FE_USUA_MODI", DbType.DateTime, oCBALA.FE_USUA_MODI);
                Db.AddInParameter(dbCmd, "FE_PRIM_PESA", DbType.DateTime, oCBALA.FE_PRIM_PESA);
                Db.AddInParameter(dbCmd, "FE_SEGU_PESA", DbType.DateTime, oCBALA.FE_SEGU_PESA);
                Db.AddInParameter(dbCmd, "CO_REGU_PES1", DbType.String, oCBALA.CO_REGU_PES1);
                Db.AddInParameter(dbCmd, "CO_REGU_PES2", DbType.String, oCBALA.CO_REGU_PES2);
                Db.AddInParameter(dbCmd, "ST_MOVI_TRAF", DbType.String, oCBALA.ST_MOVI_TRAF);
                Db.AddInParameter(dbCmd, "NU_MOVI_BDLO", DbType.String, oCBALA.NU_MOVI_BDLO);
                Db.AddInParameter(dbCmd, "ID_BAL2", DbType.String, oCBALA.ID_BAL2);
                Db.AddInParameter(dbCmd, "DE_MOTI_ROLE", DbType.String, oCBALA.DE_MOTI_ROLE);
                Db.AddInParameter(dbCmd, "DE_MOTI_REGU", DbType.String, oCBALA.DE_MOTI_REGU);
                Db.AddInParameter(dbCmd, "FI_Estado", DbType.Boolean, oCBALA.FI_Estado);
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }

        public virtual int Eliminar(Int64 ID_MOVI_BALA)
        {
            return Db.ExecuteNonQuery("OfiOper.spu_CBALA_Eliminar", ID_MOVI_BALA);
        }

        public CCBALA Recuperar(Int64 ID_MOVI_BALA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CBALA_Recuperar", ID_MOVI_BALA).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getCBALA(dtDatos.Rows[0]);
            else
                return new CCBALA();
        }

        public virtual bool Existe(Int64 ID_MOVI_BALA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CBALA_Recuperar", ID_MOVI_BALA).Tables[0];
            return dtDatos.Rows.Count > 0;
        }

        public virtual bool Existe(Int64 ID_MOVI_BALA, out CCBALA oCBALA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CBALA_Recuperar", ID_MOVI_BALA).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oCBALA = getCBALA(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oCBALA = new CCBALA();
                return false;
            }
        }

        public virtual IList<CCBALA> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "OfiOper.spu_CBALA_Listar"))
            {
                IList<CCBALA> list = new List<CCBALA>();
                while (dr.Read())
                    list.Add(getCBALA(dr));
                return list;
            }
        }
        #endregion


        #region Metodos para Grabar y Actualizar Pesajes

        /// <summary>
        /// Devuelve NU_MOVI
        /// </summary>
        /// <param name="oCBALA"></param>
        /// <returns></returns>
        public string Grabar_Peso(CCBALA oCBALA)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("OfiOper.TS_TCBALA_I01"))
            {
                dbCmd.CommandTimeout = 80;

                Db.AddInParameter(dbCmd, "ISID_BALA", DbType.String, oCBALA.ID_BALA);
                Db.AddInParameter(dbCmd, "ISTI_MOVI_INDI", DbType.String, oCBALA.TI_MOVI_INDI);
                Db.AddInParameter(dbCmd, "ISID_REGI_PLAC", DbType.String, oCBALA.ID_REGI_PLAC);
                Db.AddInParameter(dbCmd, "ISID_TRAN", DbType.String, oCBALA.ID_TRAN);
                Db.AddInParameter(dbCmd, "ISID_REGI_COND", DbType.String, oCBALA.ID_REGI_COND);
                Db.AddInParameter(dbCmd, "INID_TICK_ANTE", DbType.Int64, oCBALA.ID_TICK_ANTE);
                Db.AddInParameter(dbCmd, "INID_UNID", DbType.Int32, oCBALA.ID_UNID);
                Db.AddInParameter(dbCmd, "INID_EMPR", DbType.Int32, oCBALA.ID_EMPR);
                Db.AddInParameter(dbCmd, "ISDE_NUME_TRAC", DbType.String, oCBALA.DE_NUME_TRAC);
                Db.AddInParameter(dbCmd, "ISDE_NUME_TAUX", DbType.String, oCBALA.DE_NUME_TAUX);
                Db.AddInParameter(dbCmd, "INID_EJES", DbType.Int64, oCBALA.ID_EJES);
                Db.AddInParameter(dbCmd, "ISCO_CLIE", DbType.String, oCBALA.CO_CLIE);
                Db.AddInParameter(dbCmd, "ISNU_RECA", DbType.String, oCBALA.NU_RECA);
                Db.AddInParameter(dbCmd, "ISNU_SALI", DbType.String, oCBALA.NU_SALI);
                Db.AddInParameter(dbCmd, "INID_DOCU_ORIG", DbType.Int64, oCBALA.ID_DOCU_ORIG);
                Db.AddInParameter(dbCmd, "ISNU_SECU_ITEM", DbType.Int16, oCBALA.NU_SECU_ITEM);
                Db.AddInParameter(dbCmd, "ISST_CERT_CESO", DbType.String, oCBALA.ST_CERT_CESO);
                Db.AddInParameter(dbCmd, "ISNU_GUIA_REMI", DbType.String, oCBALA.NU_GUIA_REMI);
                Db.AddInParameter(dbCmd, "ISCO_BODE", DbType.String, oCBALA.CO_BODE);
                Db.AddInParameter(dbCmd, "ISNU_FACT", DbType.String, oCBALA.NU_FACT);
                Db.AddInParameter(dbCmd, "ISID_CIUD", DbType.String, oCBALA.ID_CIUD);
                Db.AddInParameter(dbCmd, "ISDE_OBSE", DbType.String, oCBALA.DE_OBSE);
                Db.AddInParameter(dbCmd, "ISDE_MICS", DbType.String, oCBALA.DE_MICS);
                Db.AddInParameter(dbCmd, "INNU_PESO_MICS", DbType.Decimal, oCBALA.NU_PESO_MICS);
                Db.AddInParameter(dbCmd, "ISNU_CART_PORT", DbType.String, oCBALA.NU_CART_PORT);
                Db.AddInParameter(dbCmd, "ISNU_NOTA_ENTR", DbType.String, oCBALA.NU_NOTA_ENTR);
                Db.AddInParameter(dbCmd, "ISNU_DUES", DbType.String, oCBALA.NU_DUES);
                Db.AddInParameter(dbCmd, "INID_USUA_CREA", DbType.Int32, oCBALA.ID_USUA_CREA);
                DataTable dtdatos = Db.ExecuteDataSet(dbCmd).Tables[0];
                if (dtdatos.Rows.Count > 0)
                    return dtdatos.Rows[0][0].ToString();
                else
                    return "";
            }
        }


        public bool Grabar_Peso_Movimiento(CCBALA oCBALA)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("OfiOper.TS_TCBALA_U01"))
            {

                Db.AddInParameter(dbCmd, "INID_MOVI_BALA", DbType.Int64, oCBALA.ID_MOVI_BALA);
                Db.AddInParameter(dbCmd, "ISTI_MOVI_INDI", DbType.String, oCBALA.TI_MOVI_INDI);
                Db.AddInParameter(dbCmd, "ISID_BALA", DbType.String, oCBALA.ID_BALA);
                Db.AddInParameter(dbCmd, "ISFE_ENTR", DbType.DateTime, oCBALA.FE_ENTR);
                Db.AddInParameter(dbCmd, "ISHO_ENTR", DbType.String, oCBALA.HO_ENTR);

                if (oCBALA.FE_SALI != null)
                    Db.AddInParameter(dbCmd, "ISFE_SALI", DbType.DateTime, oCBALA.FE_SALI);
                else
                    Db.AddInParameter(dbCmd, "ISFE_SALI", DbType.DateTime, DBNull.Value);

                Db.AddInParameter(dbCmd, "ISHO_SALI", DbType.String, oCBALA.HO_SALI);
                Db.AddInParameter(dbCmd, "ISID_REGI_PLAC", DbType.String, oCBALA.ID_REGI_PLAC);
                Db.AddInParameter(dbCmd, "INID_TICK_ANTE", DbType.Int64, oCBALA.ID_TICK_ANTE);
                Db.AddInParameter(dbCmd, "ISDE_NUME_TRAC", DbType.String, oCBALA.DE_NUME_TRAC);
                Db.AddInParameter(dbCmd, "ISDE_NUME_TAUX", DbType.String, oCBALA.DE_NUME_TAUX);
                Db.AddInParameter(dbCmd, "INID_EJES", DbType.Int64, oCBALA.ID_EJES);
                Db.AddInParameter(dbCmd, "ISNU_RECA", DbType.String, oCBALA.NU_RECA);
                Db.AddInParameter(dbCmd, "ISNU_SALI", DbType.String, oCBALA.NU_SALI);
                Db.AddInParameter(dbCmd, "INID_DOCU_ORIG", DbType.Int64, oCBALA.ID_DOCU_ORIG);
                Db.AddInParameter(dbCmd, "INNU_SECU_ITEM", DbType.Int16, oCBALA.NU_SECU_ITEM);
                Db.AddInParameter(dbCmd, "ISID_TIPO_JORN", DbType.String, oCBALA.ID_TIPO_JORN);
                Db.AddInParameter(dbCmd, "ISNU_GUIA_REMI", DbType.String, oCBALA.NU_GUIA_REMI);
                Db.AddInParameter(dbCmd, "ISNU_FACT", DbType.String, oCBALA.NU_FACT);
                Db.AddInParameter(dbCmd, "ISID_CIUD", DbType.String, oCBALA.ID_CIUD);
                Db.AddInParameter(dbCmd, "ISDE_OBSE", DbType.String, oCBALA.DE_OBSE);
                Db.AddInParameter(dbCmd, "INCA_PES1", DbType.Decimal, oCBALA.CA_PES1);
                Db.AddInParameter(dbCmd, "INCA_PES2", DbType.Decimal, oCBALA.CA_PES2);
                Db.AddInParameter(dbCmd, "ISST_CIER_JORN", DbType.String, oCBALA.ST_CIER_JORN);
                Db.AddInParameter(dbCmd, "ISNU_CHAS", DbType.String, oCBALA.NU_CHAS);
                Db.AddInParameter(dbCmd, "INID_UNID", DbType.Int32, oCBALA.ID_UNID);
                Db.AddInParameter(dbCmd, "INID_EMPR", DbType.Int32, oCBALA.ID_EMPR);
                Db.AddInParameter(dbCmd, "INID_USUA", DbType.Int32, oCBALA.ID_USUA_MODI);
                Db.AddInParameter(dbCmd, "ISCO_MENU", DbType.String, "");
                Db.AddInParameter(dbCmd, "ISCO_MODU", DbType.String, "");
                Db.AddInParameter(dbCmd, "ISCO_SIST", DbType.String, "");
                Db.AddInParameter(dbCmd, "ISCO_CLIE", DbType.String, oCBALA.CO_CLIE);
                Db.AddInParameter(dbCmd, "ISID_REGI_COND", DbType.String, oCBALA.ID_REGI_COND);
                Db.AddInParameter(dbCmd, "ISID_TRAN", DbType.String, oCBALA.ID_TRAN);
                return Db.ExecuteNonQuery(dbCmd) > 0;

            }
        }

        #endregion Metodos para Grabar y Actualzar Pesajes

        #region Validaciones y Bloqueos


        public CDatosCamionReq Recuperar_Camion_QR(string NU_REQU_ATEN, string Nro_Placa)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_AUTBAL_Q01", NU_REQU_ATEN, Nro_Placa).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getDatosCamionReq(dtDatos.Rows[0]);
            else
                return new CDatosCamionReq();
        }

        /// <summary>
        /// Buscando si hay un pesaje abierto para la placa
        /// </summary>
        /// <param name="Nro_Placa"></param>
        /// <returns></returns>
        public CCBALA Tiene_Pesaje(string Nro_Placa)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.TS_TTCBALA_Q01", Nro_Placa).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getCBALA(dtDatos.Rows[0]);
            else
                return new CCBALA();
        }

        public CCBALA RecuperarXNroMov(string NU_MOVI)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.TS_TTCBALA_Q02", NU_MOVI).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getCBALA(dtDatos.Rows[0]);
            else
                return new CCBALA();
        }

        public string Tiene_Bloqueo_X_Casuisticas(string NU_REQU_ATEN, string Nro_Placa, char Tipo_Mov, double Peso_BalanzaKg)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_AUTBAL_Q03", NU_REQU_ATEN, Nro_Placa, Tipo_Mov, Peso_BalanzaKg).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return dtDatos.Rows[0]["Motivo"].ToString() + " | " + dtDatos.Rows[0]["Descripcion"].ToString();
            else
                return "";
        }

        public DataTable getFormato_Impresion(string NU_MOVI)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_AUTBAL_Q06", NU_MOVI).Tables[0];

            return dtDatos;
        }


        #endregion Validaciones y Bloqueos
    }
}
