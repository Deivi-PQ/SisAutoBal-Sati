//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 7 de marzo de 2023
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNet.InfoApp;
using SisAutoBal.BusinessObjects.OfiOper;
using SisAutoBal.DataObjects.OfiOper;
using System.Data;
using System.Transactions;
using SisAutoBal.BusinessObjects.Auxiliar;

namespace SisAutoBal.Facade.OfiOper
{


    [DataObject(true)]
    public partial class CBALAFacade
    {

        private CBALADao cBALA;

        private string Error= "";

        private bool hayError = false;

        #region Constructores
        public CBALAFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
                default:
                    cBALA = new CBALADao();
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
        public virtual bool Grabar(CCBALA oCBALA)
        {
            Error = "";
            hayError = false;
            return cBALA.Grabar(oCBALA);
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CCBALA oCBALA, out string error)
        {
            bool rpta = Grabar(oCBALA);
            error = Error;
            return rpta;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int64 ID_MOVI_BALA)
        {
            return cBALA.Eliminar(ID_MOVI_BALA);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CCBALA Recuperar(Int64 ID_MOVI_BALA)
        {
            return cBALA.Recuperar(ID_MOVI_BALA);
        }
        #endregion

        #region Metodos Secundarios
        public virtual bool Existe(Int64 ID_MOVI_BALA)
        {
            return cBALA.Existe(ID_MOVI_BALA);
        }

        public virtual bool Existe(Int64 ID_MOVI_BALA, out CCBALA oCBALA)
        {
            return cBALA.Existe(ID_MOVI_BALA, out oCBALA);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CCBALA> Listar()
        {
            return cBALA.Listar();
        }
        #endregion

        #region Metodos para Grabar y Actualizar Pesajes

        /// <summary>
        /// Este metodo graba y actualiza el pesaje
        /// </summary>
        /// <param name="oCBALA"></param>
        /// <returns></returns>
        public string Grabar_Peso(CCBALA oCBALA)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    string NU_MOVI = "";

                    if (oCBALA.CA_PES2 > 0)
                    {
                        CCBALA oBalaTemp = cBALA.Tiene_Pesaje(oCBALA.ID_REGI_PLAC);

                        if (oBalaTemp.ID_MOVI_BALA > 0)
                        {
                            oCBALA.ID_MOVI_BALA = oBalaTemp.ID_MOVI_BALA;
                            oCBALA.CA_PES1 = oBalaTemp.CA_PES1;
                            NU_MOVI = oBalaTemp.NU_MOVI;
                            oCBALA.FE_ENTR = oBalaTemp.FE_ENTR;
                            oCBALA.HO_ENTR = oBalaTemp.HO_ENTR.Insert(2, ":");

                            oCBALA.FE_SALI = DateTime.Now;
                            oCBALA.HO_SALI = DateTime.Now.ToString("HH:mm");

                        }
                    }
                    else
                    {
                        oCBALA.FE_ENTR = DateTime.Now;
                        oCBALA.HO_ENTR = DateTime.Now.ToString("HH:mm");
                        oCBALA.FE_SALI = null;
                        NU_MOVI = cBALA.Grabar_Peso(oCBALA);
                    }
                    if (NU_MOVI != "")
                    {
                        CCBALA oBalaTemp = cBALA.RecuperarXNroMov(NU_MOVI);
                        oCBALA.ID_MOVI_BALA = oBalaTemp.ID_MOVI_BALA;
                        if (cBALA.Grabar_Peso_Movimiento(oCBALA))
                        {
                            scope.Complete();
                            return NU_MOVI;
                        }
                        else
                            return "";
                    }
                    else
                        return "";
                } 
            }
            catch (Exception ex)
            {
                LibreriaBSNet.Exceptions.Logger.Fatal(new Exception("Error grabando pesaje: "));

                LibreriaBSNet.Exceptions.Logger.Fatal(ex);
                Error = ex.Message;

                return "";
            }
        }



        #endregion Metodos para Grabar y Actualizar Pesajes


        #region Validaciones y Bloqueos
        /*public CDatosCamionReq Recuperar_Camion_QR(string NU_REQU_ATEN, string Nro_Placa)
        {
            return cBALA.Recuperar_Camion_QR(NU_REQU_ATEN, Nro_Placa);
        }*/

        public CCBALA Tiene_Pesaje(string Nro_Placa)
        {
            return cBALA.Tiene_Pesaje(Nro_Placa);
        }
        public string Tiene_Bloqueo_X_Casuisticas(string NU_REQU_ATEN, string Nro_Placa, char Tipo_Mov, double Peso_BalanzaKg)
        {
            return cBALA.Tiene_Bloqueo_X_Casuisticas(NU_REQU_ATEN, Nro_Placa, Tipo_Mov, Peso_BalanzaKg);
        }

        #endregion Validaciones y 

        public DataTable getFormato_Impresion(string NU_MOVI)
        {
            return cBALA.getFormato_Impresion(NU_MOVI);
        }
        
    }
}
