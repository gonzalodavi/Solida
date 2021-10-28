using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Recibo
    {
        CD_Recibo objetoCD = new CD_Recibo();

        public static string Insertar(string nrorecibo, DateTime fecha, string dni, int user, decimal efectivo, decimal valores, decimal banco, decimal total, string detalle, string estado)
        {
            CD_Recibo Obj = new CD_Recibo();
            Obj.NroRecibo = nrorecibo;
            Obj.Fecha = fecha;
            Obj.Dni = dni;
            Obj.User = user;
            Obj.Efectivo = efectivo;
            Obj.Valores = valores;
            Obj.Banco = banco;
            Obj.Total = total;
            Obj.Detalle = detalle;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new CD_Recibo().Mostrar();
        }
        public static DataTable MostrarAnulados()
        {
            return new CD_Recibo().MostrarAnulados();
        }

        public void AnularRecibo(int idRecibo)
        {
            CD_Recibo objeto = new CD_Recibo();
            objeto.Id = idRecibo;
            objeto.AnularRecibo(objeto);
        }

        public int MostrarUltimoRecibo()
        {
            int numero = objetoCD.ConsultarIDRecibo();
            return numero;
        }

        public static DataTable BuscarRegistros(string fechainicial, string fechafin)
        {
            return new CD_Recibo().BuscarRegistros(fechainicial, fechafin);
        }
        public static DataTable BuscarRegistrosAnulados(string fechainicial, string fechafin)
        {
            return new CD_Recibo().BuscarRegistrosAnulados(fechainicial, fechafin);
        }


        //PARA LAS ORDENES DE PAGO

        public static string InsertarOP(string nroOPago, DateTime fecha, string cuit, int user, decimal efectivo, decimal valores, decimal banco, decimal total, string detalle, string estado)
        {
            CD_Recibo Obj = new CD_Recibo();
            Obj.NroRecibo = nroOPago;
            Obj.Fecha = fecha;
            Obj.Dni = cuit;
            Obj.User = user;
            Obj.Efectivo = efectivo;
            Obj.Valores = valores;
            Obj.Banco = banco;
            Obj.Total = total;
            Obj.Detalle = detalle;
            Obj.Estado = estado;

            return Obj.InsertarOP(Obj);
        }

        public static DataTable MostrarOP()
        {
            return new CD_Recibo().MostrarOP();
        }
        public static DataTable MostrarAnuladosOP()
        {
            return new CD_Recibo().MostrarAnuladosOP();
        }

        public void AnularOPago(int idOPago)
        {
            CD_Recibo objeto = new CD_Recibo();
            objeto.Id = idOPago;
            objeto.AnularOPago(objeto);
        }

        public int MostrarUltimaOPago()
        {
            int numero = objetoCD.ConsultarIDOPago();
            return numero;
        }

        public static DataTable BuscarRegistrosOP(string fechainicial, string fechafin)
        {
            return new CD_Recibo().BuscarRegistrosOP(fechainicial, fechafin);
        }
        public static DataTable BuscarRegistrosAnuladosOP(string fechainicial, string fechafin)
        {
            return new CD_Recibo().BuscarRegistrosAnuladosOP(fechainicial, fechafin);
        }

    }
}
