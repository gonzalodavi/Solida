using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Ventas
    {
        private CD_Ventas objetoCD = new CD_Ventas();

        public DataTable CargarSucursales()
        {
            CD_Ventas Obj = new CD_Ventas();
            DataTable dt = new DataTable();
            dt = Obj.MostrarSucursales();
            return dt;
        }
        public static DataTable Mostrar()
        {
            return new CD_Ventas().Mostrar();
        }

        public static DataTable MostrarAnulados()
        {
            return new CD_Ventas().MostrarAnulados();
        }        

        public static string Insertar(string sucursal, string numventa, DateTime fecha,
            string estado, string dni, int iduser, decimal totalvta, DataTable dtDetalles)
        {
            CD_Ventas Obj = new CD_Ventas();
            Obj.Sucursal = sucursal;
            Obj.NumVenta = numventa;
            Obj.FechaVenta = fecha;
            Obj.Estado = estado;
            Obj.Dni = dni;
            Obj.UserID = iduser;
            Obj.TotalVenta = totalvta;

            List<CD_DetallesVentas> detalles = new List<CD_DetallesVentas>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                CD_DetallesVentas detalle = new CD_DetallesVentas();

                detalle.Cantidad = Convert.ToDecimal(row["CANT"].ToString());
                detalle.IdProducto = Convert.ToInt32(row["IDPRODUCTO"].ToString());
                detalle.Precio = Convert.ToDecimal(row["PRECIO"].ToString());
                detalle.Iva = Convert.ToDecimal(row["IVA"].ToString());
                detalle.Subtotal = Convert.ToDecimal(row["SUBTOTAL"].ToString());

                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        public void AnularComprobantes(int idVenta)
        {
            CD_Ventas objeto = new CD_Ventas();
            objeto.IdVenta = idVenta;
            objeto.AnularComprobantes(objeto);
        }

        public static DataTable BuscarRegistros(string fechainicial, string fechafin)
        {
            return new CD_Ventas().BuscarRegistros(fechainicial, fechafin);
        }

        public static DataTable BuscarRegistrosxCuit(string cuit)
        {
            return new CD_Ventas().BuscarRegistrosxCuit(cuit);
        }

        public static DataTable BuscarRegistrosAnulados(string fechainicial, string fechafin)
        {
            return new CD_Ventas().BuscarRegistrosAnulados(fechainicial, fechafin);
        }

        public int MostrarUltimaVenta()
        {
            int numero = objetoCD.ConsultarIdVenta();
            return numero;
        }

        public string ConsultarSiVtaAsignada(string numComp)
        {
            CD_Ventas Obj = new CD_Ventas();
            string rpta = Obj.ConsultarVentaAsignada(numComp);
            return rpta;
        }
    }
}
