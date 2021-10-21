using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Compras2
    {
        readonly CD_Compras2 objeto = new CD_Compras2();


        public static DataTable MostrarRegistros()
        {
            return new CD_Compras2().MostrarRegistros();
        }

        public static DataTable BuscarRegistros(string fechainicial, string fechafin)
        {
            return new CD_Compras2().BuscarRegistros(fechainicial, fechafin);
        }

        public static string InsertarCompras(CE_Compras compras, DataTable DTDetallesCompras)
        {
            CD_Compras2 objCompras = new CD_Compras2();
            List<CE_DetalleCompras> detalles = new List<CE_DetalleCompras>();
            foreach (DataRow row in DTDetallesCompras.Rows)
            {
                CE_DetalleCompras detallesCompras = new CE_DetalleCompras
                {
                    Cantidad = Convert.ToInt32(row["CANT"].ToString()),
                    Producto = Convert.ToInt32(row["PRODUCTO"].ToString()),
                    Importe = Convert.ToDecimal(row["PRECIO"].ToString()),
                    Iva = Convert.ToDecimal(row["IVA"].ToString()),
                    SubTotal = Convert.ToDecimal(row["SUBTOTAL"].ToString())
                };
                detalles.Add(detallesCompras);
            }
            return objCompras.InsertarCompras(compras, detalles);
        }

        public void AnularComprobantes(CE_Compras idCompra)
        {
            objeto.AnularCompobantes(idCompra);
        }
    }
}
