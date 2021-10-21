using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class CD_Remito
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        //Variables
        private int _IdRemito;
        private string _TipoRemito;
        private string _NroRemito;
        private string _Cuit;
        private int _IdUser;
        private DateTime _FechaRemito;
        private string _Estado;

        //Propiedades
        public int IdRemito
        {
            get { return _IdRemito; }
            set { _IdRemito = value; }
        }

        public string TipoRemito
        {
            get { return _TipoRemito; }
            set { _TipoRemito = value; }
        }

        public string NroRemito
        {
            get { return _NroRemito; }
            set { _NroRemito = value; }
        }

        public string Cuit
        {
            get { return _Cuit; }
            set { _Cuit = value; }
        }

        public int IdUser
        {
            get { return _IdUser; }
            set { _IdUser = value; }
        }    

        public DateTime FechaRemito
        {
            get { return _FechaRemito; }
            set { _FechaRemito = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


        //Constructores
        public CD_Remito()
        {
        }

        public CD_Remito(int idremito, string tipoRemito, string nroRemito,
            string cuit, int idUser, DateTime fechaRemito)
        {
            this.IdRemito = idremito;
            this.TipoRemito = tipoRemito;
            this.NroRemito = nroRemito;
            this.Cuit = cuit;
            this.IdUser = idUser;
            this.FechaRemito = fechaRemito;            
        }



        //Métodos


        //MOSTRAR REMITOS

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("remitos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarRemitos";
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
            DataTable DtResultado = new DataTable("remitos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarRemitosAnulados";
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

        public DataTable BuscarRegistros(string fechainicial, string fechafin)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("BuscarRemitosPorFecha", conectar)
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
            SqlCommand command = new SqlCommand("BuscarRemitosPorFechaAnulados", conectar)
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

        public void AnularCompobanteSalida(CD_Remito remito)
        {
            SqlCommand command = new SqlCommand("AnularRemito", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();
            command.Parameters.AddWithValue("@idremito", remito.IdRemito);
            command.ExecuteNonQuery();
            conectar.Close();
            AumentarStock(remito.IdRemito);            
        }
        public void AnularCompobanteEntrada(CD_Remito remito)
        {
            SqlCommand command = new SqlCommand("AnularRemito", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();
            command.Parameters.AddWithValue("@idremito", remito.IdRemito);
            command.ExecuteNonQuery();
            conectar.Close();
            DisminuirStock(remito.IdRemito);
        }

        // METODO ACTUALIZAR STOCK
        public string DisminuirStock(int idrem)
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
                SqlCmd.CommandText = "DisminuirStock_Remito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRemito = new SqlParameter();
                ParIdRemito.ParameterName = "@id";
                ParIdRemito.SqlDbType = SqlDbType.Int;
                ParIdRemito.Value = idrem;
                SqlCmd.Parameters.Add(ParIdRemito);              

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
        public string AumentarStock(int idrem)
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
                SqlCmd.CommandText = "AumentarStock_Remito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRemito = new SqlParameter();
                ParIdRemito.ParameterName = "@id";
                ParIdRemito.SqlDbType = SqlDbType.Int;
                ParIdRemito.Value = idrem;
                SqlCmd.Parameters.Add(ParIdRemito);

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


        //INSERTAR REMITO
        public string Insertar(CD_Remito Remito, List<CD_DetalleRemito> DetalleRemito)
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
                SqlCmd.CommandText = "Insertar_Remito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRemito = new SqlParameter();
                ParIdRemito.ParameterName = "@idremito";
                ParIdRemito.SqlDbType = SqlDbType.Int;
                ParIdRemito.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdRemito);

                SqlParameter ParTipoRemito = new SqlParameter();
                ParTipoRemito.ParameterName = "@tipo";
                ParTipoRemito.SqlDbType = SqlDbType.VarChar;
                ParTipoRemito.Size = 20;
                ParTipoRemito.Value = Remito.TipoRemito;
                SqlCmd.Parameters.Add(ParTipoRemito);

                SqlParameter ParNroRemito = new SqlParameter();
                ParNroRemito.ParameterName = "@nro";
                ParNroRemito.SqlDbType = SqlDbType.VarChar;
                ParNroRemito.Size = 20;
                ParNroRemito.Value = Remito.NroRemito;
                SqlCmd.Parameters.Add(ParNroRemito);

                SqlParameter ParCuit = new SqlParameter();
                ParCuit.ParameterName = "@cuit";
                ParCuit.SqlDbType = SqlDbType.VarChar;
                ParCuit.Size = 50;
                ParCuit.Value = Remito.Cuit;
                SqlCmd.Parameters.Add(ParCuit);

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@iduser";
                ParUser.SqlDbType = SqlDbType.Int;
                ParUser.Value = Remito.IdUser;
                SqlCmd.Parameters.Add(ParUser);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Remito.FechaRemito;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = Remito.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtener el código del remito generado
                    this.IdRemito = Convert.ToInt32(SqlCmd.Parameters["@idremito"].Value);
                    foreach (CD_DetalleRemito det in DetalleRemito)
                    {
                        det.IdRemito = this.IdRemito;
                        //Llamar al método insertar de la clase CD_DetalleRemito
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
                    if(this.TipoRemito == "SALIDA")
                    {
                        DisminuirStock(this.IdRemito);
                    }
                    else
                    {
                        AumentarStock(this.IdRemito);
                    }
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
    }
}
