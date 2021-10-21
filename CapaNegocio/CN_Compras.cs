using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class CN_Compras
    {
        private CD_Compras objetoCD = new CD_Compras();

        public static DataTable Mostrar()
        {
            return new CD_Compras().Mostrar();
        }

        public static DataTable MostrarAnulados()
        {
            return new CD_Compras().MostrarAnulados();
        }

        public static string Insertar(string numcompra, DateTime fecha,
            string estado, string cuit, int iduser, DataTable dtDetalles)
        {
            CD_Compras Obj = new CD_Compras();
            Obj.NumCompra = numcompra;
            Obj.FechaCompra = fecha;
            Obj.Estado = estado;
            Obj.Cuit = cuit;
            Obj.UserID = iduser;
          
            List<CD_DetallesCompras> detalles = new List<CD_DetallesCompras>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                CD_DetallesCompras detalle = new CD_DetallesCompras();

                detalle.Cantidad = Convert.ToInt32(row["CANT"].ToString());
                detalle.IdProducto = Convert.ToInt32(row["IDPRODUCTO"].ToString());
                detalle.Costo = Convert.ToDecimal(row["PRECIO"].ToString());
                detalle.Iva = Convert.ToDecimal(row["IVA"].ToString());
                detalle.Subtotal = Convert.ToDecimal(row["SUBTOTAL"].ToString());

                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        public void AnularComprobantes(int idCompra)
        {
            CD_Compras objeto = new CD_Compras();
            objeto.IdCompra = idCompra;            
            objeto.AnularComprobantes(objeto);
        }

        public static DataTable BuscarRegistros(string fechainicial, string fechafin)
        {
            return new CD_Compras().BuscarRegistros(fechainicial, fechafin);
        }
        public static DataTable BuscarRegistrosAnulados(string fechainicial, string fechafin)
        {
            return new CD_Compras().BuscarRegistrosAnulados(fechainicial, fechafin);
        }

        /*public DataTable CargarComboBoxProd()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargarComboBoxProd();
            return dt;
        }

        public DataTable CargarComboBoxProv()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargarComboBoxProv();
            return dt;
        }

        public int MostrarUltimaCompra()
        {            
            int numero = objetoCD.ConsultarIdCompra();
            return numero;
        }

        public string ConsultaDomicilio(string cuit)
        {
            string cadena = objetoCD.ConsultarDomicilio(cuit);
            return cadena;
        }*/

    }
}
