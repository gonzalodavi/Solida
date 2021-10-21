using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_DetalleRemito
    {
        //Variables
        private int _IdDetalleRemito;
        private int _IdRemito;
        private int _IdProducto;
        private int _Cantidad;

        //Propiedades
        public int IdDetalleRemito
        {
            get { return _IdDetalleRemito; }
            set { _IdDetalleRemito = value; }
        }

        public int IdRemito
        {
            get { return _IdRemito; }
            set { _IdRemito = value; }
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

        //Constructores 
        public CD_DetalleRemito()
        {
        }

        public CD_DetalleRemito(int idDetalleRemito, int idRemito,
            int idProducto, int cantidad)
        {
            this.IdDetalleRemito = idDetalleRemito;
            this.IdRemito = idRemito;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
        }

        //Método Insertar
        public string Insertar(CD_DetalleRemito Detalle_Remito,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Insertar_DetalleRemito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Remito = new SqlParameter();
                ParIddetalle_Remito.ParameterName = "@iddetalle";
                ParIddetalle_Remito.SqlDbType = SqlDbType.Int;
                ParIddetalle_Remito.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_Remito);

                SqlParameter ParIdRemito = new SqlParameter();
                ParIdRemito.ParameterName = "@idremito";
                ParIdRemito.SqlDbType = SqlDbType.Int;
                ParIdRemito.Value = Detalle_Remito.IdRemito;
                SqlCmd.Parameters.Add(ParIdRemito);

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@idproducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = Detalle_Remito.IdProducto;
                SqlCmd.Parameters.Add(ParIdProducto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Detalle_Remito.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);               

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
