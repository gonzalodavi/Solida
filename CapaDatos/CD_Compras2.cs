using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Compras2
    {
        readonly CD_DetallesCompras cd_DetallesCompras = new CD_DetallesCompras();
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistros()
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("MostrarCompras", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter da = new SqlDataAdapter(command);
          
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public DataTable BuscarRegistros(string fechainicial, string fechafin)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("BuscarComprasPorFecha", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@fechainicio", fechainicial);
            command.Parameters.AddWithValue("@fechafin", fechafin);

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(dt);
            da.Dispose();
            return dt;
        }

        public string InsertarCompras(CE_Compras compras, List<CE_DetalleCompras> detallesCompras)
        {
            string respuesta;
            try
            {
                conectar.Open();
                SqlTransaction transaction = conectar.BeginTransaction();
                SqlCommand command = new SqlCommand
                {
                    Connection = conectar,
                    Transaction = transaction,
                    CommandText = "InsertarCompras",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdCompra = new SqlParameter
                {
                    ParameterName = "@idcompra",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(ParIdCompra);
                command.Parameters.AddWithValue("@numcomp", compras.NumeroCompras);
                command.Parameters.AddWithValue("@fecha", compras.Fecha);
                command.Parameters.AddWithValue("@estado", compras.Estado);
                command.Parameters.AddWithValue("@cuit", compras.Cuit);
            

                respuesta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar registro";

                if (respuesta.Equals("OK"))
                {
                   /* compras.IdCompras = Convert.ToInt32(command.Parameters["@idcompra"].Value);
                    foreach (CE_DetalleCompras det in detallesCompras)
                    {
                        det.IdCompras = compras.IdCompras;
                        respuesta = cd_DetallesCompras.InsertarDetallesCompras(det, ref conectar, ref transaction);

                        if (!respuesta.Equals("OK"))
                        {
                            break;
                        }
                    }*/
                }
                if (respuesta.Equals("OK"))
                {
                    transaction.Commit();
                }
                else
                {
                    transaction.Rollback();
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                {
                    conectar.Close();
                }
            }
            return respuesta;
        }

        public void AnularCompobantes(CE_Compras idcompra)
        {
            SqlCommand command = new SqlCommand("AnularCompra", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();
            command.Parameters.AddWithValue("@idcompra", idcompra.IdCompras);
            command.ExecuteNonQuery();
            conectar.Close();
        }
    }
}
