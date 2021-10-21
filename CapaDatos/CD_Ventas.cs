using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Ventas
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;

        //Variables
        private int _IdVenta;
        private string _Sucursal;
        private string _NumVenta;
        private DateTime _FechaVenta;
        private string _Estado;
        private string _Dni;
        private int _UserID;

        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }

        public string Sucursal
        {
            get { return _Sucursal; }
            set { _Sucursal = value; }
        }

        public string NumVenta
        {
            get { return _NumVenta; }
            set { _NumVenta = value; }
        }

        public DateTime FechaVenta
        {
            get { return _FechaVenta; }
            set { _FechaVenta = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public CD_Ventas()
        {
        }

        public CD_Ventas(int idventa, string sucursal, string numventa, DateTime fechaventa,
            string estado, string dni, int idusuario)
        {
            this.IdVenta = idventa;
            this.Sucursal = sucursal;
            this.NumVenta = numventa;
            this.FechaVenta = fechaventa;
            this.Estado = estado;
            this.Dni = dni;
            this.UserID = idusuario;
        }

        public DataTable MostrarSucursales()
        {
            SqlDataAdapter da = new SqlDataAdapter("MostrarDatosSucursal", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("ventas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarVentas";
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
            DataTable DtResultado = new DataTable("ventasA");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarVentasAnuladas";
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

        public string Insertar(CD_Ventas Venta, List<CD_DetallesVentas> DetallesVentas)
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
                SqlCmd.CommandText = "Insertar_Venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@idventa";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdVenta);

                SqlParameter ParSucursal = new SqlParameter();
                ParSucursal.ParameterName = "@sucursal";
                ParSucursal.SqlDbType = SqlDbType.VarChar;
                ParSucursal.Size = 10;
                ParSucursal.Value = Venta.Sucursal;
                SqlCmd.Parameters.Add(ParSucursal);

                SqlParameter ParNroVenta = new SqlParameter();
                ParNroVenta.ParameterName = "@nro";
                ParNroVenta.SqlDbType = SqlDbType.VarChar;
                ParNroVenta.Size = 20;
                ParNroVenta.Value = Venta.NumVenta;
                SqlCmd.Parameters.Add(ParNroVenta);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Venta.FechaVenta;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = Venta.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.VarChar;
                ParDni.Size = 50;
                ParDni.Value = Venta.Dni;
                SqlCmd.Parameters.Add(ParDni);

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@iduser";
                ParUser.SqlDbType = SqlDbType.Int;
                ParUser.Value = Venta.UserID;
                SqlCmd.Parameters.Add(ParUser);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtener el código del comprobante generado
                    this.IdVenta = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
                    foreach (CD_DetallesVentas det in DetallesVentas)
                    {
                        det.IdVenta = this.IdVenta;
                        //Llamar al método insertar de la clase CD_DetalleVenta
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
                    DisminuirStock(this.IdVenta);
                    this.IdVenta = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
                    AumentaSaldoCliente(Venta.IdVenta);
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
        public string AumentaSaldoCliente(int idventa)
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
                SqlCmd.CommandText = "AumentaSaldo_ClienteFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@id";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Value = idventa;
                SqlCmd.Parameters.Add(ParIdVenta);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Disminuyó el saldo del cliente";


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

        public string DisminuyeSaldoCliente(int idventa)
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
                SqlCmd.CommandText = "DisminuyeSaldo_ClienteFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@id";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Value = idventa;
                SqlCmd.Parameters.Add(ParIdVenta);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Disminuyó el saldo del cliente";



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

        public string AumentarStock(int idventa)
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
                SqlCmd.CommandText = "AumentarStock_Venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@id";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Value = idventa;
                SqlCmd.Parameters.Add(ParIdVenta);

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

        public string DisminuirStock(int idventa)
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
                SqlCmd.CommandText = "DisminuirStock_Venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@id";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Value = idventa;
                SqlCmd.Parameters.Add(ParIdVenta);

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

        public void AnularComprobantes(CD_Ventas venta)
        {
            SqlCommand command = new SqlCommand("AnularVenta", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();
            command.Parameters.AddWithValue("@idventa", venta.IdVenta);
            command.ExecuteNonQuery();
            conectar.Close();
            AumentarStock(venta.IdVenta);
            DisminuyeSaldoCliente(venta.IdVenta);
        }

        public DataTable BuscarRegistros(string fechainicial, string fechafin)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("BuscarVentasPorFecha", conectar)
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
            SqlCommand command = new SqlCommand("BuscarVentasPorFechaAnuladas", conectar)
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

        public int ConsultarIdVenta()
        {
            int numero = 0;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarUltimaVenta";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                numero = Convert.ToInt32(leer["NUM_VENTA"].ToString());
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return numero;
        }
    }
}
