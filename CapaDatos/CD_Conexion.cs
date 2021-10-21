using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        //static private string CadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\FACULTAD\\SOLIDA\\AccesoEnCapas\\AccesoDatos\\BaseDatos\\bd2.mdf;Integrated Security=True;Connect Timeout=30";
        static private string CadenaConexion = "Data Source=DESKTOP-JUM49FN;DataBase= bd2;Integrated Security=true";

        private SqlConnection Conexion = new SqlConnection(CadenaConexion);
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
