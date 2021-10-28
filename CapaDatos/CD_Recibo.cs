using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Recibo
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);


        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private int _Id;
        private string _NroRecibo;
        private DateTime _Fecha;
        private string _Dni;
        private int _User;
        private decimal _Efectivo;
        private decimal _Valores;
        private decimal _Banco;
        private decimal _Total;
        private string _Detalle;
        private string _Estado;


        //Propiedades

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string NroRecibo
        {
            get { return _NroRecibo; }
            set { _NroRecibo = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        public int User
        {
            get { return _User; }
            set { _User = value; }
        }

        public decimal Efectivo
        {
            get { return _Efectivo; }
            set { _Efectivo = value; }
        }

        public decimal Valores
        {
            get { return _Valores; }
            set { _Valores = value; }
        }

        public decimal Banco
        {
            get { return _Banco; }
            set { _Banco = value; }
        }

        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        public string Detalle
        {
            get { return _Detalle; }
            set { _Detalle = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


        //Constructores
        public CD_Recibo()
        {
        }

        public CD_Recibo(int id, string nrorecibo, DateTime fecha, string dni, int user, decimal efectivo, decimal valores, decimal banco, decimal total, string detalle, string estado)
        {
            this.Id = id;
            this.NroRecibo = nrorecibo;
            this.Fecha = fecha;
            this.Dni = dni;
            this.User = user;
            this.Efectivo = efectivo;
            this.Valores = valores;
            this.Banco = banco;
            this.Total = total;
            this.Detalle = detalle;
            this.Estado = estado;
        }

        //METODO MOSTRAR RECIBOS

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("recibos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarRecibos";
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
            DataTable DtResultado = new DataTable("recibosA");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarRecibosAnulados";
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

        //METODO INSERTAR
        public string Insertar(CD_Recibo Recibo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Recibo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNroRecibo = new SqlParameter();
                ParNroRecibo.ParameterName = "@nroRecibo";
                ParNroRecibo.SqlDbType = SqlDbType.VarChar;
                ParNroRecibo.Size = 20;
                ParNroRecibo.Value = Recibo.NroRecibo;
                SqlCmd.Parameters.Add(ParNroRecibo);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Recibo.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.VarChar;
                ParDni.Size = 50;
                ParDni.Value = Recibo.Dni;
                SqlCmd.Parameters.Add(ParDni);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.Int;                
                ParUsuario.Value = Recibo.User;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParEfectivo = new SqlParameter();
                ParEfectivo.ParameterName = "@efectivo";
                ParEfectivo.SqlDbType = SqlDbType.Money;
                ParEfectivo.Value = Recibo.Efectivo;
                SqlCmd.Parameters.Add(ParEfectivo);

                SqlParameter ParValores = new SqlParameter();
                ParValores.ParameterName = "@valores";
                ParValores.SqlDbType = SqlDbType.Money;
                ParValores.Value = Recibo.Valores;
                SqlCmd.Parameters.Add(ParValores);

                SqlParameter ParBanco = new SqlParameter();
                ParBanco.ParameterName = "@banco";
                ParBanco.SqlDbType = SqlDbType.Money;
                ParBanco.Value = Recibo.Banco;
                SqlCmd.Parameters.Add(ParBanco);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Money;
                ParTotal.Value = Recibo.Total;
                SqlCmd.Parameters.Add(ParTotal);   

                SqlParameter ParDetalle = new SqlParameter();
                ParDetalle.ParameterName = "@detalle";
                ParDetalle.SqlDbType = SqlDbType.VarChar;
                ParDetalle.Size = 500;
                ParDetalle.Value = Recibo.Detalle;
                SqlCmd.Parameters.Add(ParDetalle);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = Recibo.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    this.Id = Convert.ToInt32(SqlCmd.Parameters["@id"].Value);

                    DisminuirSaldoCliente(Recibo.Id);
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
        public void AnularRecibo(CD_Recibo recibo)
        {
            SqlCommand command = new SqlCommand("AnularRecibo", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();
            command.Parameters.AddWithValue("@idrecibo", recibo.Id);
            command.ExecuteNonQuery();
            conectar.Close();
            AumentarSaldoCliente(recibo.Id);
          
        }

        public string DisminuirSaldoCliente(int idrecibo)
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
                SqlCmd.CommandText = "DisminuirSaldo_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRecibo = new SqlParameter();
                ParIdRecibo.ParameterName = "@id";
                ParIdRecibo.SqlDbType = SqlDbType.Int;
                ParIdRecibo.Value = idrecibo;
                SqlCmd.Parameters.Add(ParIdRecibo);

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

        public string AumentarSaldoCliente(int idrecibo)
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
                SqlCmd.CommandText = "AumentarSaldo_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRecibo = new SqlParameter();
                ParIdRecibo.ParameterName = "@id";
                ParIdRecibo.SqlDbType = SqlDbType.Int;
                ParIdRecibo.Value = idrecibo;
                SqlCmd.Parameters.Add(ParIdRecibo);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Aumento el saldo del cliente";


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
        public int ConsultarIDRecibo()
        {
            int numero = 0;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarUltimoRecibo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                numero = Convert.ToInt32(leer["NRO_RECIBO"].ToString());
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return numero;
        }

        public DataTable BuscarRegistros(string fechainicial, string fechafin)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("BuscarRecibosPorFecha", conectar)
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
            SqlCommand command = new SqlCommand("BuscarRecibosPorFechaAnulados", conectar)
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


        //METODO MOSTRAR ORDEN DE PAGO

        public DataTable MostrarOP()
        {
            DataTable DtResultado = new DataTable("oPagos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarOPagos";
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

        public DataTable MostrarAnuladosOP()
        {
            DataTable DtResultado = new DataTable("oPagosA");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarOPagosAnulados";
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

        //METODO INSERTAR
        public string InsertarOP(CD_Recibo OPago)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_OPago";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNroOPago = new SqlParameter();
                ParNroOPago.ParameterName = "@nroOPago";
                ParNroOPago.SqlDbType = SqlDbType.VarChar;
                ParNroOPago.Size = 20;
                ParNroOPago.Value = OPago.NroRecibo;
                SqlCmd.Parameters.Add(ParNroOPago);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = OPago.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParCuit = new SqlParameter();
                ParCuit.ParameterName = "@cuit";
                ParCuit.SqlDbType = SqlDbType.VarChar;
                ParCuit.Size = 50;
                ParCuit.Value = OPago.Dni;
                SqlCmd.Parameters.Add(ParCuit);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.Int;
                ParUsuario.Value = OPago.User;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParEfectivo = new SqlParameter();
                ParEfectivo.ParameterName = "@efectivo";
                ParEfectivo.SqlDbType = SqlDbType.Money;
                ParEfectivo.Value = OPago.Efectivo;
                SqlCmd.Parameters.Add(ParEfectivo);

                SqlParameter ParValores = new SqlParameter();
                ParValores.ParameterName = "@valores";
                ParValores.SqlDbType = SqlDbType.Money;
                ParValores.Value = OPago.Valores;
                SqlCmd.Parameters.Add(ParValores);

                SqlParameter ParBanco = new SqlParameter();
                ParBanco.ParameterName = "@banco";
                ParBanco.SqlDbType = SqlDbType.Money;
                ParBanco.Value = OPago.Banco;
                SqlCmd.Parameters.Add(ParBanco);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Money;
                ParTotal.Value = OPago.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParDetalle = new SqlParameter();
                ParDetalle.ParameterName = "@detalle";
                ParDetalle.SqlDbType = SqlDbType.VarChar;
                ParDetalle.Size = 500;
                ParDetalle.Value = OPago.Detalle;
                SqlCmd.Parameters.Add(ParDetalle);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = OPago.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    this.Id = Convert.ToInt32(SqlCmd.Parameters["@id"].Value);

                    AumentarSaldoProveedor(OPago.Id);
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
        public void AnularOPago(CD_Recibo oPago)
        {
            SqlCommand command = new SqlCommand("AnularOPago", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();
            command.Parameters.AddWithValue("@idOPago", oPago.Id);
            command.ExecuteNonQuery();
            conectar.Close();
            DisminuirSaldoProveedor(oPago.Id);
        }

        public string DisminuirSaldoProveedor(int idOPago)
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
                SqlCmd.CommandText = "DisminuirSaldo_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdOPago = new SqlParameter();
                ParIdOPago.ParameterName = "@id";
                ParIdOPago.SqlDbType = SqlDbType.Int;
                ParIdOPago.Value = idOPago;
                SqlCmd.Parameters.Add(ParIdOPago);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Disminuyó el saldo del Proveedor";


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

        public string AumentarSaldoProveedor(int idOPago)
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
                SqlCmd.CommandText = "AumentarSaldo_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdOPago = new SqlParameter();
                ParIdOPago.ParameterName = "@id";
                ParIdOPago.SqlDbType = SqlDbType.Int;
                ParIdOPago.Value = idOPago;
                SqlCmd.Parameters.Add(ParIdOPago);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Aumento el saldo del Proveedor";


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
        public int ConsultarIDOPago()
        {
            int numero = 0;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarUltimaOPago";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                numero = Convert.ToInt32(leer["NRO_OPAGO"].ToString());
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return numero;
        }

        public DataTable BuscarRegistrosOP(string fechainicial, string fechafin)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("BuscarOpagosPorFecha", conectar)
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

        public DataTable BuscarRegistrosAnuladosOP(string fechainicial, string fechafin)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("BuscarOPagosPorFechaAnulados", conectar)
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
    }
}
