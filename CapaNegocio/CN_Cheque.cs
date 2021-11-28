using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Cheque
    {
        private CD_Cheque objetoCD = new CD_Cheque();

        public static DataTable Mostrar(string estado)
        {
            CD_Cheque Obj = new CD_Cheque();
            Obj.Estado = estado;
            return Obj.Mostrar(Obj);
        }

        public string ConsultarEstadoCheque(string estado, string numComp)
        {
            CD_Cheque Obj = new CD_Cheque();
            string rpta = Obj.ConsultarEstadoCheque(estado, numComp);
            return rpta;
        }
        public static DataTable MostrarXFecha(string estado)
        {
            CD_Cheque Obj = new CD_Cheque();
            Obj.Estado = estado;
            return Obj.MostrarXFecha(Obj);
        }

        public static int CantidadCheques(string estado)
        {
            CD_Cheque Obj = new CD_Cheque();
            Obj.Estado = estado;        
            return Obj.CantidadCheques(Obj); ;
        }

        public static string TotalCheques(string estado)
        {
            CD_Cheque Obj = new CD_Cheque();
            Obj.Estado = estado;
            return Obj.TotalCheques(Obj); ;
        }

        public static string Insertar(string numComprobante, string tipoComprob, string numcheq, DateTime fecE, DateTime fecC, string Bco, string Titu, string Bene, decimal Import, string estad)
        {
            CD_Cheque Obj = new CD_Cheque();

            Obj.NumComprobante = numComprobante;
            Obj.TipoConprobante = tipoComprob;
            Obj.NumCheque = numcheq;
            Obj.FechaEmision = fecE;
            Obj.FechaCredito = fecC;
            Obj.Banco = Bco;
            Obj.Titular = Titu;
            Obj.Beneficiario = Bene;
            Obj.Importe = Import;
            Obj.Estado = estad;

            return Obj.Insertar(Obj);
        }

        public static string ModificarCheque(int idcheque,string estadoActual, string estadoNuevo)
        {
            CD_Cheque Obj = new CD_Cheque();
            Obj.IdCheque = idcheque;
            Obj.Estado = estadoActual;
            Obj.EstadoNuevo = estadoNuevo;
            return Obj.ModificarCheque(Obj);
        }

        public static int ConsultaUltimoCheque()
        {
            CD_Cheque Obj = new CD_Cheque();
            int nro = Obj.ConsultarUltimoCheque();
            return nro;
        }

        public static string ConsultaSiExisteCheque(string estado)
        {
            CD_Cheque Obj = new CD_Cheque();
            string rpta = Obj.ConsultaExisteCheques(estado);
            return rpta;
        }

        public static string ConsultaSiExisteChequeOP(string estado)
        {
            CD_Cheque Obj = new CD_Cheque();
            string rpta = Obj.ConsultaExisteChequesOP(estado);
            return rpta;
        }

        public static string ActivarChequesPendientes(string estadoActual, string estadoNuevo)
        {
            CD_Cheque Obj = new CD_Cheque();
            Obj.Estado = estadoActual;
            Obj.EstadoNuevo = estadoNuevo;
           
            return Obj.ActivarChequesPendientes(Obj);
        }


        public static string ModificarEstadoCheque(string estadoActual, string estadoNuevo, int idOPago)
        {
            CD_Cheque Obj = new CD_Cheque();
            Obj.Estado = estadoActual;
            Obj.EstadoNuevo = estadoNuevo;
            Obj.IdOPago = idOPago;
            return Obj.ModificaEstadoCheque(Obj);
        }

        public static string EstadoCheque(string estadoActual, string estadoNuevo, int idOPago)
        {
            CD_Cheque Obj = new CD_Cheque();
            Obj.Estado = estadoActual;
            Obj.EstadoNuevo = estadoNuevo;
            Obj.IdOPago = idOPago;
            return Obj.EstadoCheque(Obj);
        }

        public static string Anular_Cheques(string nrocomprob)
        {
            CD_Cheque Obj = new CD_Cheque();            
            Obj.NumComprobante = nrocomprob;
            return Obj.Anular_Cheques(Obj);
        }

        public static string EliminarCheq(int id)
        {
            CD_Cheque Obj = new CD_Cheque();
            Obj.IdCheque = id;
            return Obj.Eliminar(Obj);
        }

    }
}
