using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos.SqlServerDB
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql()
        {
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\FACULTAD\\SOLIDA\\AccesoEnCapas\\AccesoDatos\\BaseDatos\\bd2.mdf;Integrated Security=True;Connect Timeout=30";
            connectionString = "Data Source=DESKTOP-JUM49FN;DataBase= bd2;Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
