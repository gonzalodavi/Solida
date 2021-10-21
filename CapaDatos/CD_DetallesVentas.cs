using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_DetallesVentas
    {
        //Variables
        private int _IdDetalleVenta;
        private int _IdVenta;
        private int _IdProducto;
        private int _Cantidad;
        private decimal _Precio;
        private decimal _Iva;
        private decimal _Subtotal;

        //Propiedades
        public int IdDetalleVenta
        {
            get { return _IdDetalleVenta; }
            set { _IdDetalleVenta = value; }
        }

        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }

        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public decimal Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        public decimal Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }

        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }


        //Constructores 
        public CD_DetallesVentas()
        {
        }

        public CD_DetallesVentas(int idDetalleVenta, int idVenta,
            int idProducto, int cantidad, decimal precio, decimal iva, decimal subtotal)
        {
            this.IdDetalleVenta = idDetalleVenta;
            this.IdVenta = idVenta;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Iva = iva;
            this.Subtotal = subtotal;
        }

        //Método Insertar
        public string Insertar(CD_DetallesVentas Detalles_Ventas,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Insertar_DetalleVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Venta = new SqlParameter();
                ParIddetalle_Venta.ParameterName = "@iddetalle";
                ParIddetalle_Venta.SqlDbType = SqlDbType.Int;
                ParIddetalle_Venta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_Venta);

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@idventa";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Value = Detalles_Ventas.IdVenta;
                SqlCmd.Parameters.Add(ParIdVenta);

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@idproducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = Detalles_Ventas.IdProducto;
                SqlCmd.Parameters.Add(ParIdProducto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Detalles_Ventas.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.Money;
                ParPrecio.Value = Detalles_Ventas.Precio;
                SqlCmd.Parameters.Add(ParPrecio);

                SqlParameter ParImporteIVA = new SqlParameter();
                ParImporteIVA.ParameterName = "@iva";
                ParImporteIVA.SqlDbType = SqlDbType.Money;
                ParImporteIVA.Value = Detalles_Ventas.Iva;
                SqlCmd.Parameters.Add(ParImporteIVA);

                SqlParameter ParSubTotal = new SqlParameter();
                ParSubTotal.ParameterName = "@subtotal";
                ParSubTotal.SqlDbType = SqlDbType.Money;
                ParSubTotal.Value = Detalles_Ventas.Subtotal;
                SqlCmd.Parameters.Add(ParSubTotal);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
    }
}
