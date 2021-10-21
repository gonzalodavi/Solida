using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{    
    public class CN_Remito
    {
        public static DataTable Mostrar()
        {
            return new CD_Remito().Mostrar();
        }

        public static DataTable MostrarAnulados()
        {
            return new CD_Remito().MostrarAnulados();
        }
        public static DataTable BuscarRegistros(string fechainicial, string fechafin)
        {
            return new CD_Remito().BuscarRegistros(fechainicial, fechafin);
        }
        public static DataTable BuscarRegistrosAnulados(string fechainicial, string fechafin)
        {
            return new CD_Remito().BuscarRegistrosAnulados(fechainicial, fechafin);
        }

        public static string Insertar(string tiporemito, string nroremito,
            string cuit, int iduser, DateTime fecha, string estado,DataTable dtDetalles)
        {
            CD_Remito Obj = new CD_Remito();
            
            Obj.TipoRemito = tiporemito;
            Obj.NroRemito = nroremito;
            Obj.Cuit = cuit;
            Obj.IdUser = iduser;
            Obj.FechaRemito = fecha;
            Obj.Estado = estado;

            List<CD_DetalleRemito> detalles = new List<CD_DetalleRemito>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                CD_DetalleRemito detalle = new CD_DetalleRemito();                
                detalle.IdProducto = Convert.ToInt32(row["ID_PRODUCTO"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["CANTIDAD"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        public void AnularComprobanteEntrada(int idRemito, string tipo)
        {
            CD_Remito objeto = new CD_Remito();
            objeto.IdRemito = idRemito;
            objeto.TipoRemito = tipo;
            objeto.AnularCompobanteEntrada(objeto);
        }

        public void AnularComprobanteSalida(int idRemito, string tipo)
        {
            CD_Remito objeto = new CD_Remito();
            objeto.IdRemito = idRemito;
            objeto.TipoRemito = tipo;
            objeto.AnularCompobanteSalida(objeto);
        }
    }
}
