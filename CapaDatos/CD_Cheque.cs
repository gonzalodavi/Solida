using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Cheque
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;

        //Variables
        private int _IdCheque;
        private string _NumComprobante;
        private string _TipoConprobante;
        private string _NumCheque;
        private DateTime _FechaEmision;
        private DateTime _FechaCredito;
        private string _Banco;
        private string _Titular;
        private string _Beneficiario;        
        private decimal _Importe;
        private string _Estado;
        private string _EstadoNuevo;
        private int _IdOPago;

        public int IdCheque
        {
            get { return _IdCheque; }
            set { _IdCheque = value; }
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

        public string NumCheque
        {
            get { return _NumCheque; }
            set { _NumCheque = value; }
        }

        public DateTime FechaEmision
        {
            get { return _FechaEmision; }
            set { _FechaEmision = value; }
        }

        public DateTime FechaCredito
        {
            get { return _FechaCredito; }
            set { _FechaCredito = value; }
        }

        public string Banco
        {
            get { return _Banco; }
            set { _Banco = value; }
        }

        public string Titular
        {
            get { return _Titular; }
            set { _Titular = value; }
        }

        public string Beneficiario
        {
            get { return _Beneficiario; }
            set { _Beneficiario = value; }
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
        public int IdOPago
        {
            get { return _IdOPago; }
            set { _IdOPago = value; }
        }


        public CD_Cheque()
        {
        }

        public CD_Cheque(int idcheque, string numComprobante, string tipoComprob, string numCheque, DateTime fechaEmision, DateTime fechaCredito,
            string banco, string titular, string beneficiario, decimal importe, string estado, string estadoNuevo, int idOPago)
        {
            this.IdCheque = idcheque;
            this.NumComprobante = numComprobante;
            this.TipoConprobante = tipoComprob;
            this.NumCheque = numCheque;
            this.FechaEmision = fechaEmision;
            this.FechaCredito = fechaCredito;
            this.Banco = banco;
            this.Titular = titular;
            this.Beneficiario = beneficiario;
            this.Importe = importe;
            this.Estado = estado;
            this.EstadoNuevo = estadoNuevo;
            this.IdOPago = idOPago;
        }

        public DataTable Mostrar(CD_Cheque cheque)
        {
            DataTable DtResultado = new DataTable("cheques");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Cheques";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = cheque.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public string ConsultarEstadoCheque(string estado,string nrocomprob)
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
                SqlCmd.CommandText = "ConsultaEstadoCheque";
                SqlCmd.Parameters.AddWithValue("@estado", estado);
                SqlCmd.Parameters.AddWithValue("@nrocomprob", nrocomprob);                

                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    rpta = "OK";
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

        public DataTable MostrarXFecha(CD_Cheque cheque)
        {
            DataTable DtResultado = new DataTable("cheques");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_ChequesXFecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = cheque.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public int CantidadCheques(CD_Cheque cheq)
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
                SqlCmd.CommandText = "Mostrar_CantidadCheques";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = cheq.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    nro = Convert.ToInt32(registro["CANTIDAD"]);
                }
            }
            catch
            {
                nro = 0;
            }
            return nro;
        }

        public string TotalCheques(CD_Cheque cheqs)
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
                SqlCmd.CommandText = "Mostrar_SaldoCheques";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = cheqs.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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


        public string Insertar(CD_Cheque Cheques)
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
                SqlCmd.CommandText = "Insertar_Cheques";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCheque = new SqlParameter();
                ParIdCheque.ParameterName = "@idcheque";
                ParIdCheque.SqlDbType = SqlDbType.Int;
                ParIdCheque.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdCheque);

                SqlParameter ParNumComprobante = new SqlParameter();
                ParNumComprobante.ParameterName = "@numComprobante";
                ParNumComprobante.SqlDbType = SqlDbType.VarChar;
                ParNumComprobante.Size = 20;
                ParNumComprobante.Value = Cheques.NumComprobante;
                SqlCmd.Parameters.Add(ParNumComprobante);

                SqlParameter ParTipoComprobante = new SqlParameter();
                ParTipoComprobante.ParameterName = "@tipoComprobante";
                ParTipoComprobante.SqlDbType = SqlDbType.VarChar;
                ParTipoComprobante.Size = 20;
                ParTipoComprobante.Value = Cheques.TipoConprobante;
                SqlCmd.Parameters.Add(ParTipoComprobante);

                SqlParameter ParNumCheque = new SqlParameter();
                ParNumCheque.ParameterName = "@numCheque";
                ParNumCheque.SqlDbType = SqlDbType.VarChar;
                ParNumCheque.Size = 20;
                ParNumCheque.Value = Cheques.NumCheque;
                SqlCmd.Parameters.Add(ParNumCheque);

                SqlParameter ParFechaEmision = new SqlParameter();
                ParFechaEmision.ParameterName = "@fechaE";
                ParFechaEmision.SqlDbType = SqlDbType.Date;
                ParFechaEmision.Value = Cheques.FechaEmision;
                SqlCmd.Parameters.Add(ParFechaEmision);

                SqlParameter ParFechaCredito = new SqlParameter();
                ParFechaCredito.ParameterName = "@fechaC";
                ParFechaCredito.SqlDbType = SqlDbType.Date;
                ParFechaCredito.Value = Cheques.FechaCredito;
                SqlCmd.Parameters.Add(ParFechaCredito);

                SqlParameter ParBanco = new SqlParameter();
                ParBanco.ParameterName = "@banco";
                ParBanco.SqlDbType = SqlDbType.VarChar;
                ParBanco.Size = 50;
                ParBanco.Value = Cheques.Banco;
                SqlCmd.Parameters.Add(ParBanco);

                SqlParameter ParTitular = new SqlParameter();
                ParTitular.ParameterName = "@titular";
                ParTitular.SqlDbType = SqlDbType.VarChar;
                ParTitular.Size = 100;
                ParTitular.Value = Cheques.Titular;
                SqlCmd.Parameters.Add(ParTitular);

                SqlParameter ParBeneficiario = new SqlParameter();
                ParBeneficiario.ParameterName = "@beneficiario";
                ParBeneficiario.SqlDbType = SqlDbType.VarChar;
                ParBeneficiario.Size = 100;
                ParBeneficiario.Value = Cheques.Beneficiario;
                SqlCmd.Parameters.Add(ParBeneficiario);

                SqlParameter ParImporte = new SqlParameter();
                ParImporte.ParameterName = "@importe";
                ParImporte.SqlDbType = SqlDbType.Money;
                ParImporte.Value = Cheques.Importe;
                SqlCmd.Parameters.Add(ParImporte);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = Cheques.Estado;
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

        public string ActivarChequesPendientes(CD_Cheque Cheque)
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
                SqlCmd.CommandText = "Activar_Cheques";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstadoActual = new SqlParameter();
                ParEstadoActual.ParameterName = "@estadoActual";
                ParEstadoActual.SqlDbType = SqlDbType.VarChar;
                ParEstadoActual.Size = 15;
                ParEstadoActual.Value = Cheque.Estado;
                SqlCmd.Parameters.Add(ParEstadoActual);

                SqlParameter ParEstadoNuevo = new SqlParameter();
                ParEstadoNuevo.ParameterName = "@estadoNuevo";
                ParEstadoNuevo.SqlDbType = SqlDbType.VarChar;
                ParEstadoNuevo.Size = 15;
                ParEstadoNuevo.Value = Cheque.EstadoNuevo;
                SqlCmd.Parameters.Add(ParEstadoNuevo);                

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() >= 1 ? "OK" : "NO se pudieron Activar Los Cheques Pendientes";

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


        public string ModificarCheque(CD_Cheque Cheque)
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
                SqlCmd.CommandText = "Modificar_UnCheque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCheque = new SqlParameter();
                ParIdCheque.ParameterName = "@idcheque";
                ParIdCheque.SqlDbType = SqlDbType.Int;
                ParIdCheque.Value = Cheque.IdCheque;
                SqlCmd.Parameters.Add(ParIdCheque);

                SqlParameter ParEstadoActual = new SqlParameter();
                ParEstadoActual.ParameterName = "@estadoActual";
                ParEstadoActual.SqlDbType = SqlDbType.VarChar;
                ParEstadoActual.Size = 15;
                ParEstadoActual.Value = Cheque.Estado;
                SqlCmd.Parameters.Add(ParEstadoActual);

                SqlParameter ParEstadoNuevo = new SqlParameter();
                ParEstadoNuevo.ParameterName = "@estadoNuevo";
                ParEstadoNuevo.SqlDbType = SqlDbType.VarChar;
                ParEstadoNuevo.Size = 15;
                ParEstadoNuevo.Value = Cheque.EstadoNuevo;
                SqlCmd.Parameters.Add(ParEstadoNuevo);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo Modificar EL ESTADO DEL CHEQUE";

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

        public string ConsultaExisteCheques(string estado)
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
                SqlCmd.CommandText = "BuscarSiExisteCheque";
                
                SqlCmd.Parameters.AddWithValue("@estado", estado);

                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    rpta = "OK";
                    Eliminar_Cheques(estado);
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

        public string ConsultaEstadoCheque(string estado)
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
                SqlCmd.CommandText = "ConsultaPorEstadoCheque";

                SqlCmd.Parameters.AddWithValue("@estado", estado);

                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    rpta = "OK";                    
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

        public int ConsultarUltimoCheque()
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
                SqlCmd.CommandText = "ConsultaUltCheq";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    nro = Convert.ToInt32(registro["ID_CHEQUE"]);
                }
            }
            catch
            {
                nro = 0;
            }
            return nro;
        }

        public string ModificaEstadoCheque(CD_Cheque Cheque)
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
                SqlCmd.CommandText = "Modifica_EstadoCheques";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstadoActual = new SqlParameter();
                ParEstadoActual.ParameterName = "@estadoActual";
                ParEstadoActual.SqlDbType = SqlDbType.VarChar;
                ParEstadoActual.Size = 15;
                ParEstadoActual.Value = Cheque.Estado;
                SqlCmd.Parameters.Add(ParEstadoActual);

                SqlParameter ParEstadoNuevo = new SqlParameter();
                ParEstadoNuevo.ParameterName = "@estadoNuevo";
                ParEstadoNuevo.SqlDbType = SqlDbType.VarChar;
                ParEstadoNuevo.Size = 15;
                ParEstadoNuevo.Value = Cheque.EstadoNuevo;
                SqlCmd.Parameters.Add(ParEstadoNuevo);

                SqlParameter ParIdOPago = new SqlParameter();
                ParIdOPago.ParameterName = "@idopago";
                ParIdOPago.SqlDbType = SqlDbType.Int;
                ParIdOPago.Value = Cheque.IdOPago;
                SqlCmd.Parameters.Add(ParIdOPago);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo Modificar LOS ESTADOS DE LOS CHEQUES";

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

        public string EstadoCheque(CD_Cheque Cheque)
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
                SqlCmd.CommandText = "DevuelveChequesaActivos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstadoActual = new SqlParameter();
                ParEstadoActual.ParameterName = "@estadoActual";
                ParEstadoActual.SqlDbType = SqlDbType.VarChar;
                ParEstadoActual.Size = 15;
                ParEstadoActual.Value = Cheque.Estado;
                SqlCmd.Parameters.Add(ParEstadoActual);

                SqlParameter ParEstadoNuevo = new SqlParameter();
                ParEstadoNuevo.ParameterName = "@estadoNuevo";
                ParEstadoNuevo.SqlDbType = SqlDbType.VarChar;
                ParEstadoNuevo.Size = 15;
                ParEstadoNuevo.Value = Cheque.EstadoNuevo;
                SqlCmd.Parameters.Add(ParEstadoNuevo);

                SqlParameter ParIdOPago = new SqlParameter();
                ParIdOPago.ParameterName = "@idopago";
                ParIdOPago.SqlDbType = SqlDbType.Int;
                ParIdOPago.Value = Cheque.IdOPago;
                SqlCmd.Parameters.Add(ParIdOPago);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo Modificar LOS ESTADOS DE LOS CHEQUES";

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

        public string Eliminar_Cheques(string estado)
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
                SqlCmd.CommandText = "Eliminar_Cheques";
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

        public string Anular_Cheques(CD_Cheque cheques)
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
                SqlCmd.CommandText = "AnularCheques";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "@nrocomprob";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 20;
                ParComprobante.Value = cheques.NumComprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo ANULAR EL CHEQUE";

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



        public string Eliminar(CD_Cheque Cheq)
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
                SqlCmd.CommandText = "EliminarCheque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCheque = new SqlParameter();
                ParIdCheque.ParameterName = "@idcheque";
                ParIdCheque.SqlDbType = SqlDbType.Int;
                ParIdCheque.Value = Cheq.IdCheque;
                SqlCmd.Parameters.Add(ParIdCheque);


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

    }
}
