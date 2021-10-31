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


        public CD_Cheque()
        {
        }

        public CD_Cheque(int idcheque, string numComprobante, string tipoComprob, string numCheque, DateTime fechaEmision, DateTime fechaCredito,
            string banco, string titular, string beneficiario, decimal importe, string estado)
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

        public string ConfirmaCheque()
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
                SqlCmd.CommandText = "Confirma_Cheques";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo Modificar";

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

        public string Eliminar_Cheques()
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

    }
}
