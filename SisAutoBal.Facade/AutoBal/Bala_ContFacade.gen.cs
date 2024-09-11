//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 7 de mayo de 2024
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNet.InfoApp;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.DataObjects.AutoBal;
using SisAutoBal.Facade.OfiOper;

namespace SisAutoBal.Facade.AutoBal
{


    [DataObject(true)]
    public partial class Bala_ContFacade
    {

        private Bala_ContDao bala_Cont;

        // --- Variables de control de errores 
        private string Error;

        private bool hayError;

        #region Constructores
        public Bala_ContFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
                default:
                    bala_Cont = new Bala_ContDao();
                    break;
            }
        }
        #endregion

        #region Metodos de Control de Errores
        public virtual string getError()
        {
            return Error;
        }

        public virtual bool HayError()
        {
            return hayError;
        }
        #endregion

        #region Metodos Basicos
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CBala_Cont oBala_Cont)
        {
            Error = "";
            hayError = false;
            TTIPO_BALAFacade faTTIPO_BALA = new TTIPO_BALAFacade();
            //---Validando campos no nulos
            if (oBala_Cont.ID_BALA.Trim() == "")
            {
                Error = "ID_BALA no puede ser vacío.";
                hayError = true;
                return false;
            }
            else if (oBala_Cont.SNContr.Trim() == "")
            {
                Error = "SNContr no puede ser vacío.";
                hayError = true;
                return false;
            }
            //---Validando referencias foraneas
            else if (!faTTIPO_BALA.Existe(oBala_Cont.ID_BALA))
            {//---No existe clave foranea pero permite vacio
                Error = string.Concat("El valor ", oBala_Cont.ID_BALA, " en ID_BALA no existe. (TTIPO_BALA, ID_BALA)");
                hayError = true;
                return false;
            }
            else
                return bala_Cont.Grabar(oBala_Cont);
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CBala_Cont oBala_Cont, out string error)
        {
            bool rpta = Grabar(oBala_Cont);
            error = Error;
            return rpta;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String ID_BALA)
        {
            return bala_Cont.Eliminar(ID_BALA);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CBala_Cont Recuperar(String ID_BALA)
        {
            return bala_Cont.Recuperar(ID_BALA);
        }
        #endregion

        #region Metodos Secundarios
        public virtual bool Existe(String ID_BALA)
        {
            return bala_Cont.Existe(ID_BALA);
        }

        public virtual bool Existe(String ID_BALA, out CBala_Cont oBala_Cont)
        {
            return bala_Cont.Existe(ID_BALA, out oBala_Cont);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CBala_Cont> Listar()
        {
            return bala_Cont.Listar();
        }
        public virtual IList<CBala_ContDet> Buscar(String ID_Bala, String SNContr)
        { 
           return bala_Cont.Buscar(ID_Bala, SNContr);
        }
        #endregion
    }
}
