using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidades;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Compras
    {

        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        private CD_Conexion conexion = new CD_Conexion();        
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        //Variables
        private int _IdCompra;
        private string _NumCompra;        
        private DateTime _FechaCompra;
        private string _Estado;
        private string _Cuit;
        private int _UserID;

        public int IdCompra
        {
            get { return _IdCompra; }
            set { _IdCompra = value; }
        }

        public string NumCompra
        {
            get { return _NumCompra; }
            set { _NumCompra = value; }
        }

        public DateTime FechaCompra
        {
            get { return _FechaCompra; }
            set { _FechaCompra = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public string Cuit
        {
            get { return _Cuit; }
            set { _Cuit = value; }
        }

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public CD_Compras()
        {
        }
        
        public CD_Compras(int idcompra, string numcompra, DateTime fechacompra,
            string estado, string cuit, int idusuario)
        {
            this.IdCompra = idcompra;
            this.NumCompra = numcompra;
            this.FechaCompra = fechacompra;
            this.Estado = estado;
            this.Cuit = cuit;
            this.UserID = idusuario;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("compras");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarCompras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable MostrarAnulados()
        {
            DataTable DtResultado = new DataTable("compras");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarComprasAnuladas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public string Insertar(CD_Compras Compra, List<CD_DetallesCompras> DetallesCompras)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer la trasacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Insertar_Compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCompra = new SqlParameter();
                ParIdCompra.ParameterName = "@idcompra";
                ParIdCompra.SqlDbType = SqlDbType.Int;
                ParIdCompra.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdCompra);

                SqlParameter ParNroCompra = new SqlParameter();
                ParNroCompra.ParameterName = "@nro";
                ParNroCompra.SqlDbType = SqlDbType.VarChar;
                ParNroCompra.Size = 20;
                ParNroCompra.Value = Compra.NumCompra;
                SqlCmd.Parameters.Add(ParNroCompra);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Compra.FechaCompra;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = Compra.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParCuit = new SqlParameter();
                ParCuit.ParameterName = "@cuit";
                ParCuit.SqlDbType = SqlDbType.VarChar;
                ParCuit.Size = 50;
                ParCuit.Value = Compra.Cuit;
                SqlCmd.Parameters.Add(ParCuit);

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@iduser";
                ParUser.SqlDbType = SqlDbType.Int;
                ParUser.Value = Compra.UserID;
                SqlCmd.Parameters.Add(ParUser);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtener el código del remito generado
                    this.IdCompra = Convert.ToInt32(SqlCmd.Parameters["@idcompra"].Value);
                    foreach (CD_DetallesCompras det in DetallesCompras)
                    {
                        det.IdCompra = this.IdCompra;
                        //Llamar al método insertar de la clase CD_DetalleCompra
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                    }
                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                    AumentarStock(this.IdCompra);
                    this.IdCompra = Convert.ToInt32(SqlCmd.Parameters["@idcompra"].Value);
                    DisminuyeSaldoProveedor(Compra.IdCompra);
                }
                else
                {
                    SqlTra.Rollback();
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string AumentaSaldoProveedor(int idcompra)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "AumentaSaldo_ProveedorFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCompra = new SqlParameter();
                ParIdCompra.ParameterName = "@id";
                ParIdCompra.SqlDbType = SqlDbType.Int;
                ParIdCompra.Value = idcompra;
                SqlCmd.Parameters.Add(ParIdCompra);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Aumentó el saldo del proveedor";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string DisminuyeSaldoProveedor(int idcompra)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "DisminuyeSaldo_ProveedorFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCompra = new SqlParameter();
                ParIdCompra.ParameterName = "@id";
                ParIdCompra.SqlDbType = SqlDbType.Int;
                ParIdCompra.Value = idcompra;
                SqlCmd.Parameters.Add(ParIdCompra);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Disminuyó el saldo del proveedor";



            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string AumentarStock(int idcompra)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "AumentarStock_Compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCompra = new SqlParameter();
                ParIdCompra.ParameterName = "@id";
                ParIdCompra.SqlDbType = SqlDbType.Int;
                ParIdCompra.Value = idcompra;
                SqlCmd.Parameters.Add(ParIdCompra);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizó el stock";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string DisminuirStock(int idcompra)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "DisminuirStock_Compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCompra = new SqlParameter();
                ParIdCompra.ParameterName = "@id";
                ParIdCompra.SqlDbType = SqlDbType.Int;
                ParIdCompra.Value = idcompra;
                SqlCmd.Parameters.Add(ParIdCompra);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizó el stock";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public void AnularComprobantes(CD_Compras compra)
        {
            SqlCommand command = new SqlCommand("AnularCompra", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();
            command.Parameters.AddWithValue("@idcompra", compra.IdCompra);
            command.ExecuteNonQuery();
            conectar.Close();
            DisminuirStock(compra.IdCompra);
            AumentaSaldoProveedor(compra.IdCompra);
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

        public DataTable BuscarRegistrosAnulados(string fechainicial, string fechafin)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("BuscarComprasPorFechaAnuladas", conectar)
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

        public int ConsultarIdCompra()
        {
            int numero = 0;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarUltimaComp";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                numero = Convert.ToInt32(leer["ID_COMPRA"].ToString());
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return numero;
        }


        /*public DataTable CargarComboBoxProd()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarComboBoxProductos", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }

        public DataTable CargarComboBoxProv()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarComboBoxProveedor", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }

        
        public string ConsultarDomicilio(string cuit)
        {
            string cadena = "";
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarDomicilio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cuit", cuit);
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                cadena = leer["DOMICILIO"].ToString();
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return cadena;
        }*/



    }
}
