using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Caja
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;

        //Variables
        private int _IdCaja;
        private string _NumComprobante;
        private string _TipoConprobante;
        private DateTime _FechaCaja;
        private string _Titular;
        private string _DniCuit;
        private string _Estado;
        private decimal _Debe;
        private decimal _Haber;
        private decimal _Importe;
        private string _EstadoNuevo;
        private DateTime _FechaInicio;
        private DateTime _FechaFin;

        public int IdCaja
        {
            get { return _IdCaja; }
            set { _IdCaja = value; }
        }

        public string NumComprobante
        {
            get { return _NumComprobante; }
            set { _NumComprobante = value; }
        }

        public string TipoConprobante
        {
            get { return _TipoConprobante; }
            set { _TipoConprobante = value; }
        }

        public DateTime FechaCaja
        {
            get { return _FechaCaja; }
            set { _FechaCaja = value; }
        }

        public string Titular
        {
            get { return _Titular; }
            set { _Titular = value; }
        }

        public string DniCuit
        {
            get { return _DniCuit; }
            set { _DniCuit = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public decimal Debe
        {
            get { return _Debe; }
            set { _Debe = value; }
        }

        public decimal Haber
        {
            get { return _Haber; }
            set { _Haber = value; }
        }

        public decimal Importe
        {
            get { return _Importe; }
            set { _Importe = value; }
        }

        public string EstadoNuevo
        {
            get { return _EstadoNuevo; }
            set { _EstadoNuevo = value; }
        }

        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }

        public CD_Caja()
        {
        }

        public CD_Caja(int idcaja, string numComprobante, string tipoComprob, DateTime fechaCaja,
           string titular, string estado, string dniCuit, decimal debe, decimal haber, decimal importe, string estadoNuevo, DateTime fechainicio, DateTime fechafin)
        {
            this.IdCaja = idcaja;
            this.NumComprobante = numComprobante;
            this.TipoConprobante = tipoComprob;         
            this.FechaCaja = fechaCaja;   
            this.Titular = titular;
            this.DniCuit = dniCuit;
            this.Estado = estado;
            this.Debe = debe;
            this.Haber = haber;
            this.Importe = importe;
            this.EstadoNuevo = estadoNuevo;
            this.FechaInicio = fechainicio;
            this.FechaFin = fechafin;
        }

        public string Insertar(CD_Caja MovCaja)
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
                SqlCmd.CommandText = "Insertar_Efectivo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEfectivo = new SqlParameter();
                ParIdEfectivo.ParameterName = "@idcaja";
                ParIdEfectivo.SqlDbType = SqlDbType.Int;
                ParIdEfectivo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdEfectivo);

                SqlParameter ParNumComprobante = new SqlParameter();
                ParNumComprobante.ParameterName = "@numComprobante";
                ParNumComprobante.SqlDbType = SqlDbType.VarChar;
                ParNumComprobante.Size = 20;
                ParNumComprobante.Value = MovCaja.NumComprobante;
                SqlCmd.Parameters.Add(ParNumComprobante);

                SqlParameter ParTipoComprobante = new SqlParameter();
                ParTipoComprobante.ParameterName = "@tipoComprobante";
                ParTipoComprobante.SqlDbType = SqlDbType.VarChar;
                ParTipoComprobante.Size = 20;
                ParTipoComprobante.Value = MovCaja.TipoConprobante;
                SqlCmd.Parameters.Add(ParTipoComprobante);

                SqlParameter ParFechaCaja = new SqlParameter();
                ParFechaCaja.ParameterName = "@fechaCaja";
                ParFechaCaja.SqlDbType = SqlDbType.Date;
                ParFechaCaja.Value = MovCaja.FechaCaja;
                SqlCmd.Parameters.Add(ParFechaCaja);

                SqlParameter ParTitular = new SqlParameter();
                ParTitular.ParameterName = "@titular";
                ParTitular.SqlDbType = SqlDbType.VarChar;
                ParTitular.Size = 100;
                ParTitular.Value = MovCaja.Titular;
                SqlCmd.Parameters.Add(ParTitular);

                SqlParameter ParDniCuit = new SqlParameter();
                ParDniCuit.ParameterName = "@dnicuit";
                ParDniCuit.SqlDbType = SqlDbType.VarChar;
                ParDniCuit.Size = 50;
                ParDniCuit.Value = MovCaja.DniCuit;
                SqlCmd.Parameters.Add(ParDniCuit);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = MovCaja.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParDebe = new SqlParameter();
                ParDebe.ParameterName = "@debe";
                ParDebe.SqlDbType = SqlDbType.Money;
                ParDebe.Value = MovCaja.Debe;
                SqlCmd.Parameters.Add(ParDebe);

                SqlParameter ParHaber = new SqlParameter();
                ParHaber.ParameterName = "@haber";
                ParHaber.SqlDbType = SqlDbType.Money;
                ParHaber.Value = MovCaja.Haber;
                SqlCmd.Parameters.Add(ParHaber);

                SqlParameter ParImporte = new SqlParameter();
                ParImporte.ParameterName = "@importe";
                ParImporte.SqlDbType = SqlDbType.Money;
                ParImporte.Value = MovCaja.Importe;
                SqlCmd.Parameters.Add(ParImporte);               


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


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

        public int ConsultarUltimaCaja()
        {
            int nro = 0;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ConsultaUltCaja";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    nro = Convert.ToInt32(registro["ID_CAJA"]);
                }
            }
            catch
            {
                nro = 0;
            }
            return nro;
        }

        public string Eliminar(CD_Caja CajaElim)
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
                SqlCmd.CommandText = "EliminarCaja";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCaja = new SqlParameter();
                ParIdCaja.ParameterName = "@idcaja";
                ParIdCaja.SqlDbType = SqlDbType.Int;
                ParIdCaja.Value = CajaElim.IdCaja;
                SqlCmd.Parameters.Add(ParIdCaja);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


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

        public string ConsultaExisteCaja(string estado)
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
                SqlCmd.CommandText = "BuscarSiExisteCaja";

                SqlCmd.Parameters.AddWithValue("@estado", estado);

                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    rpta = "OK";
                    Eliminar_Caja(estado);
                }
                else
                {
                    rpta = "NO";
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string Eliminar_Caja(string estado)
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
                SqlCmd.CommandText = "Eliminar_Caja";
                SqlCmd.Parameters.AddWithValue("@estadoNuevo", estado);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                rpta = SqlCmd.ExecuteNonQuery() >= 1 ? "OK" : "NO se pudo Eliminar";

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

        public string ActivarCajasPendientes(CD_Caja CajaTransf)
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
                SqlCmd.CommandText = "Activar_Cajas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstadoActual = new SqlParameter();
                ParEstadoActual.ParameterName = "@estadoActual";
                ParEstadoActual.SqlDbType = SqlDbType.VarChar;
                ParEstadoActual.Size = 15;
                ParEstadoActual.Value = CajaTransf.Estado;
                SqlCmd.Parameters.Add(ParEstadoActual);

                SqlParameter ParEstadoNuevo = new SqlParameter();
                ParEstadoNuevo.ParameterName = "@estadoNuevo";
                ParEstadoNuevo.SqlDbType = SqlDbType.VarChar;
                ParEstadoNuevo.Size = 15;
                ParEstadoNuevo.Value = CajaTransf.EstadoNuevo;
                SqlCmd.Parameters.Add(ParEstadoNuevo);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudieron Activar Los Movimientos de Caja Pendientes";

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

        public string Anular_CajaMovRecibidos(CD_Caja cajasanu)
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
                SqlCmd.CommandText = "AnularMovCajaRecibido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "@nrocomprob";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 20;
                ParComprobante.Value = cajasanu.NumComprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo ANULAR EL MOVIMIENTO DE CAJA";

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

        public string Anular_CajaMovRealizado(CD_Caja cajasanu)
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
                SqlCmd.CommandText = "AnularMovCajaRealizado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "@nrocomprob";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 20;
                ParComprobante.Value = cajasanu.NumComprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo ANULAR EL MOVIMIENTOS DE CAJA";

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

        public DataTable DetalleCtaCaja(CD_Caja detalle)
        {
            DataTable DtResultado = new DataTable("detalleCaja");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "InformeDetalleCaja";
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

        public DataTable DetalleCtaCajaxFecha(string fechainicial, string fechafin)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("InformeDetalleCajaxFecha", conectar)
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

       

        public string TotalDebe(CD_Caja totdebe)
        {
            string total = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SumaDebeCaja";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    total = registro["TOTAL"].ToString();
                }
            }
            catch
            {
                total = "";
            }
            return total;
        }

        public string TotalHaber(CD_Caja tothaber)
        {
            string total = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SumaHaberCaja";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    total = registro["TOTAL"].ToString();
                }
            }
            catch
            {
                total = "";
            }
            return total;
        }

        public string TotalImporte(CD_Caja totimporte)
        {
            string total = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SumaImporteCaja";
                SqlCmd.CommandType = CommandType.StoredProcedure;               

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    total = registro["TOTAL"].ToString();
                }
            }
            catch
            {
                total = "";
            }
            return total;
        }

        public string SaldoAnterior(CD_Caja saldoA)
        {
            string total = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SumaSaldoAntCaja";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = saldoA.FechaInicio;
                SqlCmd.Parameters.Add(ParFecha);

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    total = registro["TOTAL"].ToString();
                }
            }
            catch
            {
                total = "";
            }
            return total;
        }


    }
}
