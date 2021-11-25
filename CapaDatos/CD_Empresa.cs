using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Empresa
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        private string _Razon;
        private string _Nombre;
        private string _Cuit;
        private DateTime _InicioAct;
        private string _Iibb;
        private string _CondIva;
        private string _Provincia;
        private string _Localidad;
        private string _Codpostal;
        private string _Direccion;
        private string _Sucursal;
        private int _IdSucursal;

        public string Razon
        {
            get { return _Razon; }
            set { _Razon = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Cuit
        {
            get { return _Cuit; }
            set { _Cuit = value; }
        }

        public DateTime InicioAct
        {
            get { return _InicioAct; }
            set { _InicioAct = value; }
        }

        public string Iibb
        {
            get { return _Iibb; }
            set { _Iibb = value; }
        }

        public string CondIva
        {
            get { return _CondIva; }
            set { _CondIva = value; }
        }

        public string Provincia
        {
            get { return _Provincia; }
            set { _Provincia = value; }
        }

        public string Localidad
        {
            get { return _Localidad; }
            set { _Localidad = value; }
        }

        public string Codpostal
        {
            get { return _Codpostal; }
            set { _Codpostal = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string Sucursal
        {
            get { return _Sucursal; }
            set { _Sucursal = value; }
        }

        public int IdSucursal
        {
            get { return _IdSucursal; }
            set { _IdSucursal = value; }
        }

        public CD_Empresa()
        {
        }


        public CD_Empresa(string razon, string nombre, string cuit, DateTime inicioact, string iibb, string condiva, string provincia, string localidad, string codpostal, string direccion, string sucursal, int idsucursal)
        {            
            this.Razon = razon;
            this.Nombre = nombre;
            this.Cuit = cuit;
            this.InicioAct = inicioact;
            this.Iibb = iibb;
            this.CondIva = condiva;
            this.Provincia = provincia;
            this.Localidad = localidad;
            this.Codpostal = codpostal;
            this.Direccion = direccion;
            this.Sucursal = sucursal;
            this.IdSucursal = idsucursal;
        }


        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("datosempresa");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarDatosEmpresa";
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

        public DataTable MostrarSucursales()
        {
            DataTable DtResultado = new DataTable("datossucursales");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarDatosSucursal";
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

        public string Modificar(CD_Empresa Empresa)
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
                SqlCmd.CommandText = "Modificar_Empresa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRazonSocial = new SqlParameter();
                ParRazonSocial.ParameterName = "@razon";
                ParRazonSocial.SqlDbType = SqlDbType.VarChar;
                ParRazonSocial.Size = 150;
                ParRazonSocial.Value = Empresa.Razon;
                SqlCmd.Parameters.Add(ParRazonSocial);

                SqlParameter ParApellidoYNombre = new SqlParameter();
                ParApellidoYNombre.ParameterName = "@apenom";
                ParApellidoYNombre.SqlDbType = SqlDbType.VarChar;
                ParApellidoYNombre.Size = 200;
                ParApellidoYNombre.Value = Empresa.Nombre;
                SqlCmd.Parameters.Add(ParApellidoYNombre);

                SqlParameter ParCuit = new SqlParameter();
                ParCuit.ParameterName = "@cuit";
                ParCuit.SqlDbType = SqlDbType.VarChar;
                ParCuit.Size = 50;
                ParCuit.Value = Empresa.Cuit;
                SqlCmd.Parameters.Add(ParCuit);

                SqlParameter ParInicioAct = new SqlParameter();
                ParInicioAct.ParameterName = "@inicioact";
                ParInicioAct.SqlDbType = SqlDbType.Date;
                ParInicioAct.Value = Empresa.InicioAct;
                SqlCmd.Parameters.Add(ParInicioAct);                

                SqlParameter ParIngresosBrutos = new SqlParameter();
                ParIngresosBrutos.ParameterName = "@iibb";
                ParIngresosBrutos.SqlDbType = SqlDbType.VarChar;
                ParIngresosBrutos.Size = 20;
                ParIngresosBrutos.Value = Empresa.Iibb;
                SqlCmd.Parameters.Add(ParIngresosBrutos);

                SqlParameter ParCondicionIVA = new SqlParameter();
                ParCondicionIVA.ParameterName = "@condiva";
                ParCondicionIVA.SqlDbType = SqlDbType.VarChar;
                ParCondicionIVA.Size = 50;
                ParCondicionIVA.Value = Empresa.CondIva;
                SqlCmd.Parameters.Add(ParCondicionIVA);

                SqlParameter ParProvincia = new SqlParameter();
                ParProvincia.ParameterName = "@provincia";
                ParProvincia.SqlDbType = SqlDbType.VarChar;
                ParProvincia.Size = 100;
                ParProvincia.Value = Empresa.Provincia;
                SqlCmd.Parameters.Add(ParProvincia);

                SqlParameter ParLocalidad = new SqlParameter();
                ParLocalidad.ParameterName = "@localidad";
                ParLocalidad.SqlDbType = SqlDbType.VarChar;
                ParLocalidad.Size = 100;
                ParLocalidad.Value = Empresa.Localidad;
                SqlCmd.Parameters.Add(ParLocalidad);

                SqlParameter ParCodigoPostal = new SqlParameter();
                ParCodigoPostal.ParameterName = "@codpostal";
                ParCodigoPostal.SqlDbType = SqlDbType.VarChar;
                ParCodigoPostal.Size = 20;
                ParCodigoPostal.Value = Empresa.Codpostal;
                SqlCmd.Parameters.Add(ParCodigoPostal);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 300;
                ParDireccion.Value = Empresa.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);             

                SqlParameter ParIdSucursal = new SqlParameter();
                ParIdSucursal.ParameterName = "@idsucursal";
                ParIdSucursal.SqlDbType = SqlDbType.Int;
                ParIdSucursal.Value = Empresa.IdSucursal;
                SqlCmd.Parameters.Add(ParIdSucursal);

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
        public string GuardarSucursal(CD_Empresa Sucursal)
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
                SqlCmd.CommandText = "Guardar_Sucursal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParSucursal = new SqlParameter();
                ParSucursal.ParameterName = "@sucursal";
                ParSucursal.SqlDbType = SqlDbType.VarChar;
                ParSucursal.Size = 10;
                ParSucursal.Value = Sucursal.Sucursal;
                SqlCmd.Parameters.Add(ParSucursal);


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
        public void EliminarSucursal(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarSucursal(string suc, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificaSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@suc", suc);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public string ConsultaExisteSucursal(string nombre)
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
                SqlCmd.CommandText = "BuscarSiExisteSucursal";
                SqlCmd.Parameters.AddWithValue("@nombre", nombre);

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
    }
}
