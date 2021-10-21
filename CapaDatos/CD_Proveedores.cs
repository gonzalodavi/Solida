using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Proveedores
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        


        public void InsertarProveedores(string cuit, string empresa,string nombre, string apellido, string mail, string tel, string calle, int nro, string piso, string dpto, string localidad, string codpostal, string barrio, string provincia)
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cuit", cuit);
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@mail", mail);
            comando.Parameters.AddWithValue("@tel", tel);
            comando.Parameters.AddWithValue("@calle", calle);
            comando.Parameters.AddWithValue("@nro", nro);
            comando.Parameters.AddWithValue("@piso", piso);
            comando.Parameters.AddWithValue("@dpto", dpto);
            comando.Parameters.AddWithValue("@localidad", localidad);
            comando.Parameters.AddWithValue("@codpostal", codpostal);
            comando.Parameters.AddWithValue("@barrio", barrio);
            comando.Parameters.AddWithValue("@provincia", provincia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        


        


        public void ModificaProveedor(string cuit, string empresa, string nombre, string apellido, string mail, string tel, string calle, int nro, string piso, string dpto, string loca, string codpostal, string barrio, string prov)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cuit", cuit);
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@mail", mail);
            comando.Parameters.AddWithValue("@tel", tel);
            comando.Parameters.AddWithValue("@calle", calle);
            comando.Parameters.AddWithValue("@nro", nro);
            comando.Parameters.AddWithValue("@piso", piso);
            comando.Parameters.AddWithValue("@dpto", dpto);
            comando.Parameters.AddWithValue("@loca", loca);
            comando.Parameters.AddWithValue("@codpostal", codpostal);
            comando.Parameters.AddWithValue("@barrio", barrio);
            comando.Parameters.AddWithValue("@prov", prov);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarProveedor(string cuit)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cuit", cuit);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        

        /*public int BuscaProvincia(CD_Proveedores Prov)
        {
            int NroIdProv = 0;
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarIDProvincia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParProvincia = new SqlParameter();
                ParProvincia.ParameterName = "@provincia";
                ParProvincia.SqlDbType = SqlDbType.VarChar;
                ParProvincia.Size = 100;
                ParProvincia.Value = Prov.Provincia;
                SqlCmd.Parameters.Add(ParProvincia);

                SqlDataReader registro = SqlCmd.ExecuteReader();
                if (registro.Read())
                {
                    NroIdProv = Convert.ToInt32(registro["ID_PROVINCIA"]);
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
            return NroIdProv;
        }*/
    }
}
