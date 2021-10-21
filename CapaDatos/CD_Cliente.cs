using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Cliente
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private string _Dni;
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Mail;
        private string _CondicionIVA;
        private string _RazonSocial;
        private int _IdDomicilio;


        //Propiedades

        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
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
        
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }
       
        public string CondicionIVA
        {
            get { return _CondicionIVA; }
            set { _CondicionIVA = value; }
        }

        public string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }

        public int IdDomicilio
        {
            get { return _IdDomicilio; }
            set { _IdDomicilio = value; }
        }
       

        //Constructores
        public CD_Cliente()
        {
        }

        public CD_Cliente(string dni, string nombre, string apellido, string telefono, string mail, string condiva, string razonsocial, int iddomicilio)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Mail = mail;
            this.CondicionIVA = condiva;
            this.RazonSocial = razonsocial;            
            this.IdDomicilio = iddomicilio;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarClientes";
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

        public DataTable MostrarClientes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarClientesxNOM(string nombre)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarClienteXNombre";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);

            SqlDataReader registros = comando.ExecuteReader();
            tabla.Load(registros);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable BuscarxDNI(string dni)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarClienteXDNI";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);

            SqlDataReader registros = comando.ExecuteReader();
            tabla.Load(registros);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        //METODO INSERTAR CLIENTE
        public string Insertar(CD_Cliente Cliente)
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
                SqlCmd.CommandText = "Insertar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.VarChar;
                ParDni.Size = 50;
                ParDni.Value = Cliente.Dni;
                SqlCmd.Parameters.Add(ParDni);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 100;
                ParApellido.Value = Cliente.Apellido;
                SqlCmd.Parameters.Add(ParApellido);                

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@mail";
                ParMail.SqlDbType = SqlDbType.VarChar;
                ParMail.Size = 150;
                ParMail.Value = Cliente.Mail;
                SqlCmd.Parameters.Add(ParMail);

                SqlParameter ParCondIVA = new SqlParameter();
                ParCondIVA.ParameterName = "@condiva";
                ParCondIVA.SqlDbType = SqlDbType.VarChar;
                ParCondIVA.Size = 50;
                ParCondIVA.Value = Cliente.CondicionIVA;
                SqlCmd.Parameters.Add(ParCondIVA);

                SqlParameter ParRazonSocial = new SqlParameter();
                ParRazonSocial.ParameterName = "@razonsocial";
                ParRazonSocial.SqlDbType = SqlDbType.VarChar;
                ParRazonSocial.Size = 150;
                ParRazonSocial.Value = Cliente.RazonSocial;
                SqlCmd.Parameters.Add(ParRazonSocial);

                SqlParameter ParIdDomicilio = new SqlParameter();
                ParIdDomicilio.ParameterName = "@iddom";
                ParIdDomicilio.SqlDbType = SqlDbType.Int;
                ParIdDomicilio.Value = Cliente.IdDomicilio;
                SqlCmd.Parameters.Add(ParIdDomicilio);

                

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

        //METODO MODIFICAR CLIENTE
        public string Modificar(CD_Cliente Cliente)
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
                SqlCmd.CommandText = "Modificar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.VarChar;
                ParDni.Size = 50;
                ParDni.Value = Cliente.Dni;
                SqlCmd.Parameters.Add(ParDni);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 100;
                ParApellido.Value = Cliente.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@mail";
                ParMail.SqlDbType = SqlDbType.VarChar;
                ParMail.Size = 150;
                ParMail.Value = Cliente.Mail;
                SqlCmd.Parameters.Add(ParMail);

                SqlParameter ParCondIVA = new SqlParameter();
                ParCondIVA.ParameterName = "@condiva";
                ParCondIVA.SqlDbType = SqlDbType.VarChar;
                ParCondIVA.Size = 50;
                ParCondIVA.Value = Cliente.CondicionIVA;
                SqlCmd.Parameters.Add(ParCondIVA);

                SqlParameter ParRazonSocial = new SqlParameter();
                ParRazonSocial.ParameterName = "@razonsocial";
                ParRazonSocial.SqlDbType = SqlDbType.VarChar;
                ParRazonSocial.Size = 150;
                ParRazonSocial.Value = Cliente.RazonSocial;
                SqlCmd.Parameters.Add(ParRazonSocial);

                SqlParameter ParIdDomicilio = new SqlParameter();
                ParIdDomicilio.ParameterName = "@iddom";
                ParIdDomicilio.SqlDbType = SqlDbType.Int;
                ParIdDomicilio.Value = Cliente.IdDomicilio;
                SqlCmd.Parameters.Add(ParIdDomicilio);



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


        //Método Eliminar
        public string Eliminar(CD_Cliente Cliente)
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
                SqlCmd.CommandText = "EliminarCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParProveedor = new SqlParameter();
                ParProveedor.ParameterName = "@dni";
                ParProveedor.SqlDbType = SqlDbType.VarChar;
                ParProveedor.Size = 50;
                ParProveedor.Value = Cliente.Dni;
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
