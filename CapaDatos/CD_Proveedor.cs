using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Proveedor
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //Variables
        private string _Cuit;
        private string _RazonSocial;
        private string _Nombre;
        private string _Apellido;
        private string _Mail;
        private string _Telefono;
        private int _IdDomicilio;
        private string _Descripcion;

        //Propiedades
        public string Cuit
        {
            get { return _Cuit; }
            set { _Cuit = value; }
        }

        public string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public int IdDomicilio
        {
            get { return _IdDomicilio; }
            set { _IdDomicilio = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        //Constructores
        public CD_Proveedor()
        {
        }

        public CD_Proveedor(string cuit, string razonsocial, string nombre, string apellido, string mail, string telefono, int iddomicilio, string descripcion)
        {
            this.Cuit = cuit;
            this.RazonSocial = razonsocial;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Telefono = telefono;
            this.IdDomicilio = iddomicilio;
            this.Descripcion = descripcion;
        }

        public DataTable MostrarProveedores()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarProveedor(string nombre)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarProveedorXNombre";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);

            SqlDataReader registros = comando.ExecuteReader();
            tabla.Load(registros);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable BuscarProveedorCuit(string cuit)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarProveedorXCUIT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cuit", cuit);

            SqlDataReader registros = comando.ExecuteReader();
            tabla.Load(registros);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarProveedores";
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

        //METODO INSERTAR PROVEEDOR
        public string Insertar(CD_Proveedor Proveedor)
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
                SqlCmd.CommandText = "Insertar_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCuit = new SqlParameter();
                ParCuit.ParameterName = "@cuit";
                ParCuit.SqlDbType = SqlDbType.VarChar;
                ParCuit.Size = 50;
                ParCuit.Value = Proveedor.Cuit;
                SqlCmd.Parameters.Add(ParCuit);

                SqlParameter ParRazonSocial = new SqlParameter();
                ParRazonSocial.ParameterName = "@razonsocial";
                ParRazonSocial.SqlDbType = SqlDbType.VarChar;
                ParRazonSocial.Size = 150;
                ParRazonSocial.Value = Proveedor.RazonSocial;
                SqlCmd.Parameters.Add(ParRazonSocial);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Proveedor.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 100;
                ParApellido.Value = Proveedor.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@mail";
                ParMail.SqlDbType = SqlDbType.VarChar;
                ParMail.Size = 150;
                ParMail.Value = Proveedor.Mail;
                SqlCmd.Parameters.Add(ParMail);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParIdDomicilio = new SqlParameter();
                ParIdDomicilio.ParameterName = "@iddom";
                ParIdDomicilio.SqlDbType = SqlDbType.Int;
                ParIdDomicilio.Value = Proveedor.IdDomicilio;
                SqlCmd.Parameters.Add(ParIdDomicilio);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 500;
                ParDescripcion.Value = Proveedor.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

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


        //METODO MODIFICAR PROVEEDOR
        public string Modificar(CD_Proveedor Proveedor)
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
                SqlCmd.CommandText = "ModificarProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCuit = new SqlParameter();
                ParCuit.ParameterName = "@cuit";
                ParCuit.SqlDbType = SqlDbType.VarChar;
                ParCuit.Size = 50;
                ParCuit.Value = Proveedor.Cuit;
                SqlCmd.Parameters.Add(ParCuit);

                SqlParameter ParRazonSocial = new SqlParameter();
                ParRazonSocial.ParameterName = "@razonsocial";
                ParRazonSocial.SqlDbType = SqlDbType.VarChar;
                ParRazonSocial.Size = 150;
                ParRazonSocial.Value = Proveedor.RazonSocial;
                SqlCmd.Parameters.Add(ParRazonSocial);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Proveedor.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 100;
                ParApellido.Value = Proveedor.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@mail";
                ParMail.SqlDbType = SqlDbType.VarChar;
                ParMail.Size = 150;
                ParMail.Value = Proveedor.Mail;
                SqlCmd.Parameters.Add(ParMail);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParIdDomicilio = new SqlParameter();
                ParIdDomicilio.ParameterName = "@iddom";
                ParIdDomicilio.SqlDbType = SqlDbType.Int;
                ParIdDomicilio.Value = Proveedor.IdDomicilio;
                SqlCmd.Parameters.Add(ParIdDomicilio);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 500;
                ParDescripcion.Value = Proveedor.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Pudo Actualizar el Registro";

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
        //Método Eliminar
        public string Eliminar(CD_Proveedor Proveedor)
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
                SqlCmd.CommandText = "EliminarProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParProveedor = new SqlParameter();
                ParProveedor.ParameterName = "@cuit";
                ParProveedor.SqlDbType = SqlDbType.VarChar;
                ParProveedor.Size = 50;
                ParProveedor.Value = Proveedor.Cuit;
                SqlCmd.Parameters.Add(ParProveedor);


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
