using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_Caja
    {
        public static string Insertar(string numComprobante, string tipoComprob, DateTime fecC, string titular, string dnicuit,string estado, decimal debe, decimal haber, decimal importe)
        {
            CD_Caja Obj = new CD_Caja();

            Obj.NumComprobante = numComprobante;
            Obj.TipoConprobante = tipoComprob;
            Obj.FechaCaja = fecC;
            Obj.Titular = titular;
            Obj.DniCuit = dnicuit;
            Obj.Estado = estado;            
            Obj.Debe = debe;
            Obj.Haber = haber;
            Obj.Importe = importe;        

            return Obj.Insertar(Obj);
        }
        public static int ConsultaUltimaCaja()
        {
            CD_Caja Obj = new CD_Caja();
            int nro = Obj.ConsultarUltimaCaja();
            return nro;
        }

        public static string EliminarMovCaja(int id)
        {
            CD_Caja Obj = new CD_Caja();
            Obj.IdCaja = id;
            return Obj.Eliminar(Obj);
        }

        public static string ConsultaSiExisteCaja(string estado)
        {
            CD_Caja Obj = new CD_Caja();
            string rpta = Obj.ConsultaExisteCaja(estado);
            return rpta;
        }

        public static string ActivarTransfPendientes(string estadoActual, string estadoNuevo)
        {
            CD_Caja Obj = new CD_Caja();
            Obj.Estado = estadoActual;
            Obj.EstadoNuevo = estadoNuevo;

            return Obj.ActivarCajasPendientes(Obj);
        }

        public static string Anular_CajaMovRecibidos(string nrocomprob)
        {
            CD_Caja Obj = new CD_Caja();
            Obj.NumComprobante = nrocomprob;
            return Obj.Anular_CajaMovRecibidos(Obj);
        }

        public static string Anular_CajaMovRealizado(string nrocomprob)
        {
            CD_Caja Obj = new CD_Caja();
            Obj.NumComprobante = nrocomprob;
            return Obj.Anular_CajaMovRealizado(Obj);
        }

        public static DataTable MostrarDetalleCaja()
        {
            CD_Caja Obj = new CD_Caja();
            return Obj.DetalleCtaCaja(Obj);
        }

        public static string TotalDebe()
        {
            CD_Caja Obj = new CD_Caja();            
            return Obj.TotalDebe(Obj); ;
        }

        public static string TotalHaber()
        {
            CD_Caja Obj = new CD_Caja();            
            return Obj.TotalHaber(Obj); ;
        }

        public static string TotalImporte()
        {
            CD_Caja Obj = new CD_Caja();            
            return Obj.TotalImporte(Obj); ;
        }
    }
}
