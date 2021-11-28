using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Banco
    {
        public static string Insertar(string numComprobante, string tipoComprob, string numTrasnf, DateTime fecT, int idBco, string ctaBco, string titular, decimal importe, string estado)
        {
            CD_Banco Obj = new CD_Banco();

            Obj.NumComprobante = numComprobante;
            Obj.TipoConprobante = tipoComprob;
            Obj.NumTransferencia = numTrasnf;
            Obj.FechaTransferencia = fecT;
            Obj.IdBanco = idBco;
            Obj.CuentaBanco = ctaBco;
            Obj.Titular = titular;           
            Obj.Importe = importe;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }
        public static int ConsultaUltimaTransf()
        {
            CD_Banco Obj = new CD_Banco();
            int nro = Obj.ConsultarUltimaTransferencia();
            return nro;
        }

        public static string EliminarTransf(int id)
        {
            CD_Banco Obj = new CD_Banco();
            Obj.IdTransferencia = id;
            return Obj.Eliminar(Obj);
        }

        public static string ConsultaSiExisteTransf(string estado)
        {
            CD_Banco Obj = new CD_Banco();
            string rpta = Obj.ConsultaExisteTransf(estado);
            return rpta;
        }

        public static string ActivarTransfPendientes(string estadoActual, string estadoNuevo)
        {
            CD_Banco Obj = new CD_Banco();
            Obj.Estado = estadoActual;
            Obj.EstadoNuevo = estadoNuevo;

            return Obj.ActivarTransferenciasPendientes(Obj);
        }
    }    
}
