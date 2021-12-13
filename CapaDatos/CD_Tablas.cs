using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Tablas
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public string ConsultaSiExisteXaEliminar(int id, string proc)
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
                SqlCmd.CommandText = proc;
                SqlCmd.Parameters.AddWithValue("@id", id);
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




        public string ConsultaExisteRubro(string nombre)
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
                SqlCmd.CommandText = "BuscarSiExisteRubro";                
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
        public string ConsultaExisteMarca(string nombre)
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
                SqlCmd.CommandText = "BuscarSiExisteMarca";
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

        public string ConsultaExisteModelo(string nombre)
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
                SqlCmd.CommandText = "BuscarSiExisteModelo";
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

        public string ConsultaExisteAlic(float nombre)
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
                SqlCmd.CommandText = "BuscarSiExisteAlic";
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

        public DataTable CargaRubros()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarRubros", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }
        public DataTable CargaAlicuotas()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarAlicuotas", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }
        public DataTable CargaMarcas()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarMarcas", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }
        public DataTable CargaModelos()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarModelos", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }


        public void AgregaRubro(string rubro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarNuevoRubro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@rubro", rubro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void AgregaAlicuota(double alic)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarNuevaAlic";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@alic", alic);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void AgregaMarca(string marca)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarNuevaMarca";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@marca", marca);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void AgregaModelo(string modelo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarNuevoModelo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificaRubro(string rubro, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarRubro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@rubro", rubro);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificaAlicuota(double alic, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarAlicuota";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@alic", alic);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificaModelo(string modelo, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarModelo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificaMarca(string marca, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarMarca";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EliminaRubro(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaRubro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminaAlicuota(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaAlicuota";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminaModelo(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaModelo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminaMarca(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaMarca";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
