using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_DetallesCompras
    {
        //Variables
        private int _IdDetalleCompra;
        private int _IdCompra;
        private int _IdProducto;
        private decimal _Cantidad;
        private decimal _Costo;
        private decimal _Iva;
        private decimal _Subtotal;

        //Propiedades
        public int IdDetalleCompra
        {
            get { return _IdDetalleCompra; }
            set { _IdDetalleCompra = value; }
        }

        public int IdCompra
        {
            get { return _IdCompra; }
            set { _IdCompra = value; }
        }

        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public decimal Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
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
        public CD_DetallesCompras()
        {
        }

        public CD_DetallesCompras(int idDetalleCompra, int idCompra,
            int idProducto, decimal cantidad, decimal costo, decimal iva, decimal subtotal)
        {
            this.IdDetalleCompra = idDetalleCompra;
            this.IdCompra = idCompra;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.Costo = costo;
            this.Iva = iva;
            this.Subtotal = subtotal;
        }

        //Método Insertar
        public string Insertar(CD_DetallesCompras Detalles_Compras,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Insertar_DetalleCompra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Compra = new SqlParameter();
                ParIddetalle_Compra.ParameterName = "@iddetalle";
                ParIddetalle_Compra.SqlDbType = SqlDbType.Int;
                ParIddetalle_Compra.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_Compra);

                SqlParameter ParIdCompra = new SqlParameter();
                ParIdCompra.ParameterName = "@idcompra";
                ParIdCompra.SqlDbType = SqlDbType.Int;
                ParIdCompra.Value = Detalles_Compras.IdCompra;
                SqlCmd.Parameters.Add(ParIdCompra);

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@idproducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = Detalles_Compras.IdProducto;
                SqlCmd.Parameters.Add(ParIdProducto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Decimal;
                ParCantidad.Value = Detalles_Compras.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecioCosto = new SqlParameter();
                ParPrecioCosto.ParameterName = "@costo";
                ParPrecioCosto.SqlDbType = SqlDbType.Money;
                ParPrecioCosto.Value = Detalles_Compras.Costo;
                SqlCmd.Parameters.Add(ParPrecioCosto);

                SqlParameter ParImporteIVA = new SqlParameter();
                ParImporteIVA.ParameterName = "@iva";
                ParImporteIVA.SqlDbType = SqlDbType.Money;
                ParImporteIVA.Value = Detalles_Compras.Iva;
                SqlCmd.Parameters.Add(ParImporteIVA);

                SqlParameter ParSubTotal = new SqlParameter();
                ParSubTotal.ParameterName = "@subtotal";
                ParSubTotal.SqlDbType = SqlDbType.Money;
                ParSubTotal.Value = Detalles_Compras.Subtotal;
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
        /*public string InsertarDetallesCompras(CE_DetalleCompras detallesCompras, ref SqlConnection connection, ref SqlTransaction transaction)
        {
            string respuesta;
            try
            {
                SqlCommand command = new SqlCommand("InsertarDetalleCompra", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    Transaction = transaction
                };
                command.Parameters.AddWithValue("@cant", detallesCompras.Cantidad);
                command.Parameters.AddWithValue("@idprod", detallesCompras.Producto);
                command.Parameters.AddWithValue("@precio", detallesCompras.Importe);
                command.Parameters.AddWithValue("@iva", detallesCompras.Iva);
                command.Parameters.AddWithValue("@subtotal", detallesCompras.SubTotal);
                command.Parameters.AddWithValue("@idcompra", detallesCompras.IdCompras);
                respuesta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el detalle de la venta";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;
        }*/
    }
}
