using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Banco
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;

        //Variables
        private int _IdTransferencia;
        private string _NumComprobante;
        private string _TipoConprobante;
        private string _NumTransferencia;
        private DateTime _FechaTransferencia;
        private int _IdBanco;
        private string _CuentaBanco;
        private string _Titular;
        private decimal _Importe;
        private string _Estado;
        private string _EstadoNuevo;


        public int IdTransferencia
        {
            get { return _IdTransferencia; }
            set { _IdTransferencia = value; }
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

        public string NumTransferencia
        {
            get { return _NumTransferencia; }
            set { _NumTransferencia = value; }
        }

        public DateTime FechaTransferencia
        {
            get { return _FechaTransferencia; }
            set { _FechaTransferencia = value; }
        }

        public int IdBanco
        {
            get { return _IdBanco; }
            set { _IdBanco = value; }
        }       

        public string CuentaBanco
        {
            get { return _CuentaBanco; }
            set { _CuentaBanco = value; }
        }

        public string Titular
        {
            get { return _Titular; }
            set { _Titular = value; }
        }

        public decimal Importe
        {
            get { return _Importe; }
            set { _Importe = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public string EstadoNuevo
        {
            get { return _EstadoNuevo; }
            set { _EstadoNuevo = value; }
        }

        public CD_Banco()
        {
        }

        public CD_Banco(int idtransf, string numComprobante, string tipoComprob, string numTrasnf, DateTime fechaTransf, int idbanco,
            string ctabco, string titular, decimal importe, string estado, string estadoNuevo)
        {
            this.IdTransferencia = idtransf;
            this.NumComprobante = numComprobante;
            this.TipoConprobante = tipoComprob;
            this.NumTransferencia = numTrasnf;
            this.FechaTransferencia = fechaTransf;
            this.IdBanco = idbanco;
            this.CuentaBanco = ctabco;
            this.Titular = titular;
            this.Importe = importe;
            this.Estado = estado;
            this.EstadoNuevo = estadoNuevo;

        }

        public string Insertar(CD_Banco Transferencias)
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
                SqlCmd.CommandText = "Insertar_Transferencias";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTransferencia = new SqlParameter();
                ParIdTransferencia.ParameterName = "@idtransf";
                ParIdTransferencia.SqlDbType = SqlDbType.Int;
                ParIdTransferencia.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdTransferencia);

                SqlParameter ParNumComprobante = new SqlParameter();
                ParNumComprobante.ParameterName = "@numComprobante";
                ParNumComprobante.SqlDbType = SqlDbType.VarChar;
                ParNumComprobante.Size = 20;
                ParNumComprobante.Value = Transferencias.NumComprobante;
                SqlCmd.Parameters.Add(ParNumComprobante);

                SqlParameter ParTipoComprobante = new SqlParameter();
                ParTipoComprobante.ParameterName = "@tipoComprobante";
                ParTipoComprobante.SqlDbType = SqlDbType.VarChar;
                ParTipoComprobante.Size = 20;
                ParTipoComprobante.Value = Transferencias.TipoConprobante;
                SqlCmd.Parameters.Add(ParTipoComprobante);

                SqlParameter ParNumTransferencia = new SqlParameter();
                ParNumTransferencia.ParameterName = "@numTransf";
                ParNumTransferencia.SqlDbType = SqlDbType.VarChar;
                ParNumTransferencia.Size = 20;
                ParNumTransferencia.Value = Transferencias.NumTransferencia;
                SqlCmd.Parameters.Add(ParNumTransferencia);

                SqlParameter ParFechaTransferencia = new SqlParameter();
                ParFechaTransferencia.ParameterName = "@fechaTransf";
                ParFechaTransferencia.SqlDbType = SqlDbType.Date;
                ParFechaTransferencia.Value = Transferencias.FechaTransferencia;
                SqlCmd.Parameters.Add(ParFechaTransferencia);

                SqlParameter ParIdBanco = new SqlParameter();
                ParIdBanco.ParameterName = "@idBanco";
                ParIdBanco.SqlDbType = SqlDbType.Int;
                ParIdBanco.Value = Transferencias.IdBanco;
                SqlCmd.Parameters.Add(ParIdBanco);

                SqlParameter ParCtaBanco = new SqlParameter();
                ParCtaBanco.ParameterName = "@ctabco";
                ParCtaBanco.SqlDbType = SqlDbType.VarChar;
                ParCtaBanco.Size = 100;
                ParCtaBanco.Value = Transferencias.CuentaBanco;
                SqlCmd.Parameters.Add(ParCtaBanco);

                SqlParameter ParTitular = new SqlParameter();
                ParTitular.ParameterName = "@titular";
                ParTitular.SqlDbType = SqlDbType.VarChar;
                ParTitular.Size = 100;
                ParTitular.Value = Transferencias.Titular;
                SqlCmd.Parameters.Add(ParTitular);

                SqlParameter ParImporte = new SqlParameter();
                ParImporte.ParameterName = "@importe";
                ParImporte.SqlDbType = SqlDbType.Money;
                ParImporte.Value = Transferencias.Importe;
                SqlCmd.Parameters.Add(ParImporte);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = Transferencias.Estado;
                SqlCmd.Parameters.Add(ParEstado);


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

        public int ConsultarUltimaTransferencia()
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
                SqlCmd.CommandText = "ConsultaUltTransf";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    nro = Convert.ToInt32(registro["ID_TRANSF"]);
                }
            }
            catch
            {
                nro = 0;
            }
            return nro;
        }

        public string Eliminar(CD_Banco Transf)
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
                SqlCmd.CommandText = "EliminarTransferencia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTransf = new SqlParameter();
                ParIdTransf.ParameterName = "@idtransf";
                ParIdTransf.SqlDbType = SqlDbType.Int;
                ParIdTransf.Value = Transf.IdTransferencia;
                SqlCmd.Parameters.Add(ParIdTransf);


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

        public string ConsultaExisteTransf(string estado)
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
                SqlCmd.CommandText = "BuscarSiExisteTransf";

                SqlCmd.Parameters.AddWithValue("@estado", estado);

                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    rpta = "OK";
                    Eliminar_Transf(estado);
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

        public string Eliminar_Transf(string estado)
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
                SqlCmd.CommandText = "Eliminar_Transf";
                SqlCmd.Parameters.AddWithValue("@estadoNuevo", estado);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo Eliminar";

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

        public string ActivarTransferenciasPendientes(CD_Banco Transferencias)
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
                SqlCmd.CommandText = "Activar_Transferencias";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstadoActual = new SqlParameter();
                ParEstadoActual.ParameterName = "@estadoActual";
                ParEstadoActual.SqlDbType = SqlDbType.VarChar;
                ParEstadoActual.Size = 15;
                ParEstadoActual.Value = Transferencias.Estado;
                SqlCmd.Parameters.Add(ParEstadoActual);

                SqlParameter ParEstadoNuevo = new SqlParameter();
                ParEstadoNuevo.ParameterName = "@estadoNuevo";
                ParEstadoNuevo.SqlDbType = SqlDbType.VarChar;
                ParEstadoNuevo.Size = 15;
                ParEstadoNuevo.Value = Transferencias.EstadoNuevo;
                SqlCmd.Parameters.Add(ParEstadoNuevo);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudieron Activar Las Transferencias Pendientes";

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

        public string Anular_Transferencias(CD_Banco transfe)
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
                SqlCmd.CommandText = "AnularTransferenciasRecibidas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "@nrocomprob";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 20;
                ParComprobante.Value = transfe.NumComprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo ANULAR LAS TANSFERENCIAS";

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

    }
}
