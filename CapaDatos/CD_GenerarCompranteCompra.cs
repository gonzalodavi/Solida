using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_GenerarCompranteCompra
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable GenerarComprobantes(int idcompra)
        {
            conectar.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = conectar;
                command.CommandText = "GenerarComprobanteCompra";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idcompra", idcompra);

                var reader = command.ExecuteReader();
                var tabla = new DataTable();
                tabla.Load(reader);
                return tabla;
            }
        }

    }
}
