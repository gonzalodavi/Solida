using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;        
        private SqlCommand comando = new SqlCommand();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarProd(string codbar)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codbar", codbar);
            SqlDataReader registros = comando.ExecuteReader();
            tabla.Load(registros);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;         
        }
        public DataTable BuscarProdnom(string nombre)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarProductosNom";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            SqlDataReader registros = comando.ExecuteReader();
            tabla.Load(registros);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable CargarComboBoxRubros()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarComboBoxRubros", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }
        public DataTable CargarComboBoxAlic()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarComboBoxAlic", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }
        public DataTable CargarComboBoxMarca()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarComboBoxMarca", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }
        public DataTable CargarComboBoxModelo()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarComboBoxModelo", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }

        public void AgregaProducto (string descrip, string codBar, int rubro, int alic, decimal costo, decimal venta, int stock, int stockmin, int modelo, int marca)
        {            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProducto";
            comando.CommandType = CommandType.StoredProcedure;            
            comando.Parameters.AddWithValue("@descrip", descrip);
            comando.Parameters.AddWithValue("@codBar", codBar);
            comando.Parameters.AddWithValue("@rubro", rubro);
            comando.Parameters.AddWithValue("@alic", alic);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@venta", venta);            
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@stockmin", stockmin);
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificaProducto(int id, string descrip, string codBar, int rubro, int alic, decimal costo, decimal venta, int stock, int stockmin, int modelo, int marca)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descrip", descrip);
            comando.Parameters.AddWithValue("@codBar", codBar);
            comando.Parameters.AddWithValue("@rubro", rubro);
            comando.Parameters.AddWithValue("@alic", alic);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@venta", venta);         
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@stockmin", stockmin);
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminaProducto(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
    
}
