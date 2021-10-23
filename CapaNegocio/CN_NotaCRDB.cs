using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_NotaCRDB
    {
        CD_NotaCRDB objetoCD = new CD_NotaCRDB();

        public static string Insertar(int userID, DateTime fecha, string nronota, string dni, decimal importe, string detalle, string estado, string tipo)
        {
             
            CD_NotaCRDB Obj = new CD_NotaCRDB();
            Obj.UserID = userID;
            Obj.Fecha = fecha;
            Obj.NroNota = nronota;
            Obj.Dni = dni;
            Obj.Importe = importe;
            Obj.Detalle = detalle;
            Obj.Estado = estado;
            Obj.Tipo = tipo;
            Obj.Detalle = detalle;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new CD_NotaCRDB().Mostrar();
        }
        public void AnularComprobante(int id, string tipo)
        {
            CD_NotaCRDB objeto = new CD_NotaCRDB();
            objeto.Id = id;
            objeto.Tipo = tipo;
            objeto.AnularNota(objeto);
        }
        public int MostrarUltimaNota()
        {
            int numero = objetoCD.ConsultarIDNota();
            return numero;
        }
    }
}
