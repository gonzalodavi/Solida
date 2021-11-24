﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_CuentaBancaria
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private int _Id;
        private string _NumeroCta;
        private string _NombreCta;
        private string _TipoCta;
        private string _Titular;
        private string _CBU;
        private string _Alias;
        


        //Propiedades

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string NumeroCta
        {
            get { return _NumeroCta; }
            set { _NumeroCta = value; }
        }

        public string NombreCta
        {
            get { return _NombreCta; }
            set { _NombreCta = value; }
        }

        public string TipoCta
        {
            get { return _TipoCta; }
            set { _TipoCta = value; }
        }

        public string Titular
        {
            get { return _Titular; }
            set { _Titular = value; }
        }

        public string CBU
        {
            get { return _CBU; }
            set { _CBU = value; }
        }

        public string Alias
        {
            get { return _Alias; }
            set { _Alias = value; }
        }


        //Constructores
        public CD_CuentaBancaria()
        {
        }

        public CD_CuentaBancaria(int id, string nrocta, string nombre, string tipocta, string titular, string cbu, string alias)
        {
            this.Id = id;
            this.NumeroCta = nrocta;
            this.NombreCta = nombre;
            this.TipoCta = tipocta;
            this.Titular = titular;
            this.CBU = cbu;
            this.Alias = alias;       
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("cuentaBancaria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarEntidadesBancarias";
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

        public string Insertar(CD_CuentaBancaria CuentaBancaria)
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
                SqlCmd.CommandText = "Insertar_EntidadBancaria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCtaBancaria = new SqlParameter();
                ParIdCtaBancaria.ParameterName = "@id";
                ParIdCtaBancaria.SqlDbType = SqlDbType.Int;
                ParIdCtaBancaria.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdCtaBancaria);

                SqlParameter ParNumeroCuenta = new SqlParameter();
                ParNumeroCuenta.ParameterName = "@numcta";
                ParNumeroCuenta.SqlDbType = SqlDbType.VarChar;
                ParNumeroCuenta.Size = 20;
                ParNumeroCuenta.Value = CuentaBancaria.NumeroCta;
                SqlCmd.Parameters.Add(ParNumeroCuenta);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = CuentaBancaria.NombreCta;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParTipoCuenta = new SqlParameter();
                ParTipoCuenta.ParameterName = "@tipocta";
                ParTipoCuenta.SqlDbType = SqlDbType.VarChar;
                ParTipoCuenta.Size = 2;
                ParTipoCuenta.Value = CuentaBancaria.TipoCta;
                SqlCmd.Parameters.Add(ParTipoCuenta);

                SqlParameter ParTitular = new SqlParameter();
                ParTitular.ParameterName = "@titular";
                ParTitular.SqlDbType = SqlDbType.VarChar;
                ParTitular.Size = 100;
                ParTitular.Value = CuentaBancaria.Titular;
                SqlCmd.Parameters.Add(ParTitular);

                SqlParameter ParCBU = new SqlParameter();
                ParCBU.ParameterName = "@cbu";
                ParCBU.SqlDbType = SqlDbType.VarChar;
                ParCBU.Size = 22;
                ParCBU.Value = CuentaBancaria.CBU;
                SqlCmd.Parameters.Add(ParCBU);

                SqlParameter ParAlias = new SqlParameter();
                ParAlias.ParameterName = "@alias";
                ParAlias.SqlDbType = SqlDbType.VarChar;
                ParAlias.Size = 50;
                ParAlias.Value = CuentaBancaria.Alias;
                SqlCmd.Parameters.Add(ParAlias);

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

        public string Modificar(CD_CuentaBancaria CtaBancaria)
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
                SqlCmd.CommandText = "Modificar_EntidadBancaria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCtaBancaria = new SqlParameter();
                ParIdCtaBancaria.ParameterName = "@id";
                ParIdCtaBancaria.SqlDbType = SqlDbType.Int;
                ParIdCtaBancaria.Value = CtaBancaria.Id;
                SqlCmd.Parameters.Add(ParIdCtaBancaria);

                SqlParameter ParNumeroCuenta = new SqlParameter();
                ParNumeroCuenta.ParameterName = "@numcta";
                ParNumeroCuenta.SqlDbType = SqlDbType.VarChar;
                ParNumeroCuenta.Size = 20;
                ParNumeroCuenta.Value = CtaBancaria.NumeroCta;
                SqlCmd.Parameters.Add(ParNumeroCuenta);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = CtaBancaria.NombreCta;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParTipoCuenta = new SqlParameter();
                ParTipoCuenta.ParameterName = "@tipocta";
                ParTipoCuenta.SqlDbType = SqlDbType.VarChar;
                ParTipoCuenta.Size = 2;
                ParTipoCuenta.Value = CtaBancaria.TipoCta;
                SqlCmd.Parameters.Add(ParTipoCuenta);

                SqlParameter ParTitular = new SqlParameter();
                ParTitular.ParameterName = "@titular";
                ParTitular.SqlDbType = SqlDbType.VarChar;
                ParTitular.Size = 100;
                ParTitular.Value = CtaBancaria.Titular;
                SqlCmd.Parameters.Add(ParTitular);

                SqlParameter ParCBU = new SqlParameter();
                ParCBU.ParameterName = "@cbu";
                ParCBU.SqlDbType = SqlDbType.VarChar;
                ParCBU.Size = 22;
                ParCBU.Value = CtaBancaria.CBU;
                SqlCmd.Parameters.Add(ParCBU);

                SqlParameter ParAlias = new SqlParameter();
                ParAlias.ParameterName = "@alias";
                ParAlias.SqlDbType = SqlDbType.VarChar;
                ParAlias.Size = 50;
                ParAlias.Value = CtaBancaria.Alias;
                SqlCmd.Parameters.Add(ParAlias);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Modifico el Registro";

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

        public string Eliminar(CD_CuentaBancaria CuentaBancaria)
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
                SqlCmd.CommandText = "EliminarCuentaBancaria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCtaBancaria = new SqlParameter();
                ParIdCtaBancaria.ParameterName = "@id";
                ParIdCtaBancaria.SqlDbType = SqlDbType.Int;
                ParIdCtaBancaria.Value = CuentaBancaria.Id;
                SqlCmd.Parameters.Add(ParIdCtaBancaria);


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