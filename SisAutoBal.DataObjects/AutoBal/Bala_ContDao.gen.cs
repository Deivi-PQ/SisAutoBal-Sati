//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 6 de mayo de 2024
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using SisAutoBal.BusinessObjects.AutoBal;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace SisAutoBal.DataObjects.AutoBal
{


    public partial class Bala_ContDao : DataAccessBase
    {

        public virtual CBala_Cont getBala_Cont(DataRow dr)
        {
            return new CBala_Cont(Convert.ToString(dr["ID_BALA"]), Convert.ToString(dr["SNContr"]));
        }

        public virtual CBala_Cont getBala_Cont(IDataReader dr)
        {
            return new CBala_Cont(Convert.ToString(dr["ID_BALA"]), Convert.ToString(dr["SNContr"]));
        }

        public virtual CBala_ContDet getBala_ContDet(DataRow dr)
        {
            return new CBala_ContDet(Convert.ToString(dr["ID_BALA"]), Convert.ToString(dr["DE_TIPO"]), Convert.ToString(dr["SNContr"]));
        }

        #region Metodos Principales
        public virtual bool Grabar(CBala_Cont oBala_Cont)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.TS_TBala_Cont_I01"))
            {
                Db.AddInParameter(dbCmd, "ID_BALA", DbType.String, oBala_Cont.ID_BALA);
                Db.AddInParameter(dbCmd, "SNContr", DbType.String, oBala_Cont.SNContr);
                // --- Ejecutando procedimiento almacenado
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }

        public virtual int Eliminar(String ID_BALA)
        {
            return Db.ExecuteNonQuery("AutoBal.TS_TBala_Cont_D01", ID_BALA);
        }

        public virtual CBala_Cont Recuperar(String ID_BALA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TBala_Cont_Q01", ID_BALA).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getBala_Cont(dtDatos.Rows[0]);
            else
                return new CBala_Cont();
        }

        public virtual bool Existe(String ID_BALA)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TBala_Cont_Q01", ID_BALA).Tables[0];
            return dtDatos.Rows.Count > 0;
        }

        public virtual bool Existe(String ID_BALA, out CBala_Cont oBala_Cont)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TBala_Cont_Q01", ID_BALA).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oBala_Cont = getBala_Cont(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oBala_Cont = new CBala_Cont();
                return false;
            }
        }

        public virtual IList<CBala_Cont> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "AutoBal.TS_TBala_Cont_Q02"))
            {
                IList<CBala_Cont> list = new List<CBala_Cont>();
                while (dr.Read())
                    list.Add(getBala_Cont(dr));
                return list;
            }
        }
        public virtual IList<CBala_ContDet> Buscar(String ID_Bala, String SNContr)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TBala_Cont_Q03", ID_Bala, SNContr).Tables[0];
            {
                IList<CBala_ContDet> list = new List<CBala_ContDet>();
                if (dtDatos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        list.Add(getBala_ContDet(dtDatos.Rows[i]));
                    }
                }
                return list;
            }
        }
        #endregion
    }
}
