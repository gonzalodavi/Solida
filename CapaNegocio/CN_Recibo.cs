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

    }
}
