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

        public static string ConsultaSiExisteCheque(string estado)
        {
            CD_Cheque Obj = new CD_Cheque();
            string rpta = Obj.ConsultaExisteCheques(estado);
            return rpta;
        }

        public string ConfirmarCheque()
        {
            string rpta = objetoCD.ConfirmaCheque();
            return rpta;
        }

        public string Eliminar_Cheques()
        {
            string rpta = objetoCD.Eliminar_Cheques();
            return rpta;
        }

    }
}
