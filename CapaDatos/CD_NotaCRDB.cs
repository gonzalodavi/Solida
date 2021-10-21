using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
 
namespace CapaDatos
{
    public class CD_NotaCRDB
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);


        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private int _Id;
        private int _UserID;        
        private DateTime _Fecha;
        private string _NroNota;
        private string _Dni;
        private decimal _Importe;
        private string _Detalle;
        private string _Estado;
        private string _Tipo;

        //Propiedades

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string NroNota
        {
            get { return _NroNota; }
            set { _NroNota = value; }
        }

        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        public decimal Importe
        {
            get { return _Importe; }
            set { _Importe = value; }
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

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        //Constructores
        public CD_NotaCRDB()
        {
        }

        public CD_NotaCRDB(int id, int userID, DateTime fecha, string nronota, string dni, decimal importe, string detalle, string estado, string tipo)
        {
            this.Id = id;
            this.UserID = userID;
            this.Fecha = fecha;
            this.NroNota = nronota;
            this.Dni = dni;
            this.Importe = importe;
            this.Detalle = detalle;
            this.Estado = estado;
            this.Tipo = tipo;
        }

        //METODO MOSTRAR NOTAS

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("notas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarNotas";
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
        public string Insertar(CD_NotaCRDB Nota)
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
                SqlCmd.CommandText = "Insertar_NotaCRDB";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.Int;
                ParUsuario.Value = Nota.UserID;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Nota.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParNroNota = new SqlParameter();
                ParNroNota.ParameterName = "@nroNota";
                ParNroNota.SqlDbType = SqlDbType.VarChar;
                ParNroNota.Size = 20;
                ParNroNota.Value = Nota.NroNota;
                SqlCmd.Parameters.Add(ParNroNota);                

                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.VarChar;
                ParDni.Size = 50;
                ParDni.Value = Nota.Dni;
                SqlCmd.Parameters.Add(ParDni);
                                
                SqlParameter ParImporte = new SqlParameter();
                ParImporte.ParameterName = "@importe";
                ParImporte.SqlDbType = SqlDbType.Money;
                ParImporte.Value = Nota.Importe;
                SqlCmd.Parameters.Add(ParImporte);

                SqlParameter ParDetalle = new SqlParameter();
                ParDetalle.ParameterName = "@detalle";
                ParDetalle.SqlDbType = SqlDbType.VarChar;
                ParDetalle.Size = 500;
                ParDetalle.Value = Nota.Detalle;
                SqlCmd.Parameters.Add(ParDetalle);               

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = Nota.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParTipoNota = new SqlParameter();
                ParTipoNota.ParameterName = "@tipo";
                ParTipoNota.SqlDbType = SqlDbType.VarChar;
                ParTipoNota.Size = 20;
                ParTipoNota.Value = Nota.Tipo;
                SqlCmd.Parameters.Add(ParTipoNota);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    this.Id = Convert.ToInt32(SqlCmd.Parameters["@id"].Value);
                    if(this.Tipo == "CREDITO")
                    {
                        DisminuirSaldoCliente(Nota.Id);
                    }
                    else
                    {
                        AumentarSaldoCliente(Nota.Id);
                    }
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
        public void AnularNota(CD_NotaCRDB nota)
        {
            SqlCommand command = new SqlCommand("AnularNota", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();
            command.Parameters.AddWithValue("@idnota", nota.Id);
            command.ExecuteNonQuery();
            conectar.Close();

            if (nota.Tipo == "CREDITO")
            {
                AumentarSaldoCliente(nota.Id);
            }
            else
            {
                DisminuirSaldoCliente(nota.Id);
            }
        }

        public string DisminuirSaldoCliente(int idnota)
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
                SqlCmd.CommandText = "DisminuirSaldo_ClienteNotaDBCR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdNota = new SqlParameter();
                ParIdNota.ParameterName = "@id";
                ParIdNota.SqlDbType = SqlDbType.Int;
                ParIdNota.Value = idnota;
                SqlCmd.Parameters.Add(ParIdNota);

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

        public string AumentarSaldoCliente(int idnota)
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
                SqlCmd.CommandText = "AumentarSaldo_ClienteNotaDBCR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdNota = new SqlParameter();
                ParIdNota.ParameterName = "@id";
                ParIdNota.SqlDbType = SqlDbType.Int;
                ParIdNota.Value = idnota;
                SqlCmd.Parameters.Add(ParIdNota);

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
    }
}
