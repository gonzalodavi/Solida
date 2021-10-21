using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Domicilio
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //Variables
        private int _IdDomicilio;
        private string _Calle;
        private int _Nro;
        private string _Piso;
        private string _Dpto;
        private int _IdBarrio;
        private string _Localidad;
        private string _Barrio;
        private string _CodigoPostal;
        private string _NomProvincia;        
        private int _Id_Localidad;
        private int _IdProvincia;

        //Propiedades
        public int IdDomicilio
        {
            get { return _IdDomicilio; }
            set { _IdDomicilio = value; }
        }

        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; }
        }
  
        public int Nro
        {
            get { return _Nro; }
            set { _Nro = value; }
        }

        public string Piso
        {
            get { return _Piso; }
            set { _Piso = value; }
        }
   
        public string Dpto
        {
            get { return _Dpto; }
            set { _Dpto = value; }
        }
        
        public int IdBarrio
        {
            get { return _IdBarrio; }
            set { _IdBarrio = value; }
        }

        public string Localidad
        {
            get { return _Localidad; }
            set { _Localidad = value; }
        }

        public string NomProvincia
        {
            get { return _NomProvincia; }
            set { _NomProvincia = value; }
        }

        public string Barrio
        {
            get { return _Barrio; }
            set { _Barrio = value; }
        }

        public string CodigoPostal
        {
            get { return _CodigoPostal; }
            set { _CodigoPostal = value; }
        }

        public int IdProvincia
        {
            get { return _IdProvincia; }
            set { _IdProvincia = value; }
        }

        public int Id_Localidad
        {
            get { return _Id_Localidad; }
            set { _Id_Localidad = value; }
        }


        //Constructores 
        public CD_Domicilio()
        {
        }

        public CD_Domicilio(int idDomicilio,string calle, int nro,
            string piso,string dpto, int idBarrio,
            string localidad, string barrio, string codigopostal, 
            string provincia, int idprovincia, int idlocalidad)
        {
            this.IdDomicilio = idDomicilio;
            this.Calle = calle;
            this.Nro = nro;
            this.Piso = piso;
            this._Dpto = dpto;
            this.IdBarrio = idBarrio;
            this.IdProvincia = idprovincia;
            this.Localidad = localidad;
            this.Id_Localidad = idlocalidad;
            this.CodigoPostal = codigopostal;
            this.Barrio = barrio;
            this.NomProvincia = provincia;
        }
        public string Insertar(CD_Domicilio Domicilio)
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
                SqlCmd.CommandText = "Insertar_Direccion";
                SqlCmd.CommandType = CommandType.StoredProcedure;                

                SqlParameter ParIdDomicilio = new SqlParameter();
                ParIdDomicilio.ParameterName = "@iddom";
                ParIdDomicilio.SqlDbType = SqlDbType.Int;
                ParIdDomicilio.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDomicilio);

                SqlParameter ParCalle = new SqlParameter();
                ParCalle.ParameterName = "@calle";
                ParCalle.SqlDbType = SqlDbType.VarChar;
                ParCalle.Size = 150;
                ParCalle.Value = Domicilio.Calle;
                SqlCmd.Parameters.Add(ParCalle);

                SqlParameter ParNro = new SqlParameter();
                ParNro.ParameterName = "@nro";
                ParNro.SqlDbType = SqlDbType.Int;
                ParNro.Value = Domicilio.Nro;
                SqlCmd.Parameters.Add(ParNro);

                SqlParameter ParPiso = new SqlParameter();
                ParPiso.ParameterName = "@piso";
                ParPiso.SqlDbType = SqlDbType.VarChar;
                ParPiso.Size = 50;
                ParPiso.Value = Domicilio.Piso;
                SqlCmd.Parameters.Add(ParPiso);

                SqlParameter ParDpto = new SqlParameter();
                ParDpto.ParameterName = "@dpto";
                ParDpto.SqlDbType = SqlDbType.VarChar;
                ParDpto.Size = 50;
                ParDpto.Value = Domicilio.Dpto;
                SqlCmd.Parameters.Add(ParDpto);

                SqlParameter ParIdBarrio = new SqlParameter();
                ParIdBarrio.ParameterName = "@idbarrio";
                ParIdBarrio.SqlDbType = SqlDbType.Int;
                ParIdBarrio.Value = Domicilio.IdBarrio;
                SqlCmd.Parameters.Add(ParIdBarrio);

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

        public string Modificar(CD_Domicilio Domicilio)
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
                SqlCmd.CommandText = "Modificar_Direccion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDomicilio = new SqlParameter();
                ParIdDomicilio.ParameterName = "@iddom";
                ParIdDomicilio.SqlDbType = SqlDbType.Int;
                ParIdDomicilio.Value = Domicilio.IdDomicilio;
                SqlCmd.Parameters.Add(ParIdDomicilio);

                SqlParameter ParCalle = new SqlParameter();
                ParCalle.ParameterName = "@calle";
                ParCalle.SqlDbType = SqlDbType.VarChar;
                ParCalle.Size = 150;
                ParCalle.Value = Domicilio.Calle;
                SqlCmd.Parameters.Add(ParCalle);

                SqlParameter ParNro = new SqlParameter();
                ParNro.ParameterName = "@nro";
                ParNro.SqlDbType = SqlDbType.Int;
                ParNro.Value = Domicilio.Nro;
                SqlCmd.Parameters.Add(ParNro);

                SqlParameter ParPiso = new SqlParameter();
                ParPiso.ParameterName = "@piso";
                ParPiso.SqlDbType = SqlDbType.VarChar;
                ParPiso.Size = 50;
                ParPiso.Value = Domicilio.Piso;
                SqlCmd.Parameters.Add(ParPiso);

                SqlParameter ParDpto = new SqlParameter();
                ParDpto.ParameterName = "@dpto";
                ParDpto.SqlDbType = SqlDbType.VarChar;
                ParDpto.Size = 50;
                ParDpto.Value = Domicilio.Dpto;
                SqlCmd.Parameters.Add(ParDpto);

                SqlParameter ParIdBarrio = new SqlParameter();
                ParIdBarrio.ParameterName = "@idbarrio";
                ParIdBarrio.SqlDbType = SqlDbType.Int;
                ParIdBarrio.Value = Domicilio.IdBarrio;
                SqlCmd.Parameters.Add(ParIdBarrio);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


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

        public int Consultar()
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
                SqlCmd.CommandText = "ConsultaUltDom";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    nro = Convert.ToInt32(registro["DOM"]);
                }
            }
            catch
            {
                nro = 0;
            }
            return nro;
        }

        public int ConsultaParaModDom(int iddom)
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
                SqlCmd.CommandText = "ConsultarDomicilioxMod";
                SqlCmd.Parameters.AddWithValue("@iddom",iddom);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    nro = Convert.ToInt32(registro["DOM"]);
                }
            }
            catch
            {
                nro = 0;
            }
            return nro;
        }

        public DataTable MostrarDomEnGrilla(int iddom)
        {
            DataTable DtResultado = new DataTable("domicilio");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ConsultaDomicilioxID";
                SqlCmd.Parameters.AddWithValue("@iddom", iddom);
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

        
        public string InsertarLocalidad(CD_Domicilio Prov)
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
                SqlCmd.CommandText = "InsertarLocalidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdLocalidad = new SqlParameter();
                ParIdLocalidad.ParameterName = "@idlocalidad";
                ParIdLocalidad.SqlDbType = SqlDbType.Int;
                ParIdLocalidad.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdLocalidad);

                SqlParameter ParLocalidad = new SqlParameter();
                ParLocalidad.ParameterName = "@localidad";
                ParLocalidad.SqlDbType = SqlDbType.VarChar;
                ParLocalidad.Size = 150;
                ParLocalidad.Value = Prov.Localidad;
                SqlCmd.Parameters.Add(ParLocalidad);

                SqlParameter ParIdProvincia = new SqlParameter();
                ParIdProvincia.ParameterName = "@idprovincia";
                ParIdProvincia.SqlDbType = SqlDbType.Int;
                ParIdProvincia.Value = Prov.IdProvincia;
                SqlCmd.Parameters.Add(ParIdProvincia);

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

        public string InsertarBarrio(CD_Domicilio Bar)
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
                SqlCmd.CommandText = "InsertarBarrio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdBarrio = new SqlParameter();
                ParIdBarrio.ParameterName = "@idbarrio";
                ParIdBarrio.SqlDbType = SqlDbType.Int;
                ParIdBarrio.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdBarrio);

                SqlParameter ParBarrio = new SqlParameter();
                ParBarrio.ParameterName = "@barrio";
                ParBarrio.SqlDbType = SqlDbType.VarChar;
                ParBarrio.Size = 150;
                ParBarrio.Value = Bar.Barrio;
                SqlCmd.Parameters.Add(ParBarrio);

                SqlParameter ParIdLocalidad = new SqlParameter();
                ParIdLocalidad.ParameterName = "@idlocalidad";
                ParIdLocalidad.SqlDbType = SqlDbType.Int;
                ParIdLocalidad.Value = Bar.Id_Localidad;
                SqlCmd.Parameters.Add(ParIdLocalidad);

                SqlParameter ParCodPostal = new SqlParameter();
                ParCodPostal.ParameterName = "@codpostal";
                ParCodPostal.SqlDbType = SqlDbType.VarChar;
                ParCodPostal.Size = 10;
                ParCodPostal.Value = Bar.CodigoPostal;
                SqlCmd.Parameters.Add(ParCodPostal);

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

        public string Eliminar(CD_Domicilio Dom)
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
                SqlCmd.CommandText = "EliminarDomicilio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDom = new SqlParameter();
                ParIdDom.ParameterName = "@id";
                ParIdDom.SqlDbType = SqlDbType.Int;
                ParIdDom.Value = Dom.IdDomicilio;
                SqlCmd.Parameters.Add(ParIdDom);


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
        public DataTable MostrarLocalidad(CD_Domicilio Prov)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarLocalidades";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProvincia = new SqlParameter();
                ParIdProvincia.ParameterName = "@idprovincia";
                ParIdProvincia.SqlDbType = SqlDbType.Int;
                ParIdProvincia.Value = Prov.IdProvincia;
                SqlCmd.Parameters.Add(ParIdProvincia);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

               
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable MostrarLocalidadEnComboBox(CD_Domicilio Prov)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarLocalidades";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProvincia = new SqlParameter();
                ParIdProvincia.ParameterName = "@idprovincia";
                ParIdProvincia.SqlDbType = SqlDbType.Int;
                ParIdProvincia.Value = Prov.IdProvincia;
                SqlCmd.Parameters.Add(ParIdProvincia);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                if (DtResultado.Rows.Count < 1)
                {
                    DtResultado = null;
                }

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        public DataTable MostrarBarrio(CD_Domicilio Prov)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarBarrios";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDLocalidad = new SqlParameter();
                ParIDLocalidad.ParameterName = "@idloc";
                ParIDLocalidad.SqlDbType = SqlDbType.Int;
                ParIDLocalidad.Value = Prov.Id_Localidad;
                SqlCmd.Parameters.Add(ParIDLocalidad);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable MostrarProvincia()
        {
            SqlDataAdapter da = new SqlDataAdapter("MostrarProvincias", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }
        public string MostrarCodigoPostal(int id)
        {
            string rpta = "";

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCodigoPostal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idbarrio", id);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                rpta = registro["CODIGO_POSTAL"].ToString();
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return rpta;
        }

        public string BuscaDomicilio(int id)
        {
            string rpta = "";

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarDomicilio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@iddom", id);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                rpta = registro["DIREC"].ToString();
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return rpta;
        }

        public DataTable BuscaDomicilioxCalle(string calle)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarDomxCalle";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@calle", calle);

            SqlDataReader registros = comando.ExecuteReader();
            tabla.Load(registros);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("domicilio");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarDomicilios";
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
    }
}
