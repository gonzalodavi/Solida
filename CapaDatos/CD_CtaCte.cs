using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_CtaCte
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private int _Id;
        private string _DniCuit;
        private string _Cuit;
        private DateTime _Fecha;
        private string _Comprobante;
        private string _Concepto;
        private Decimal _Debe;
        private Decimal _Haber;
        private Decimal _ValorCheque;
        private Decimal _ValorEfectivo;
        private Decimal _ValorBanco;
        private Decimal _Total;
        private Decimal _Asignado;
        private Decimal _Interes;
        private string _Asigna;
        private string _Estado;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string DniCuit
        {
            get { return _DniCuit; }
            set { _DniCuit = value; }
        }

        public string Cuit
        {
            get { return _Cuit; }
            set { _Cuit = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string Comprobante
        {
            get { return _Comprobante; }
            set { _Comprobante = value; }
        }

        public string Concepto
        {
            get { return _Concepto; }
            set { _Concepto = value; }
        }

        public Decimal Debe
        {
            get { return _Debe; }
            set { _Debe = value; }
        }

        public Decimal Haber
        {
            get { return _Haber; }
            set { _Haber = value; }
        }

        public Decimal ValorCheque
        {
            get { return _ValorCheque; }
            set { _ValorCheque = value; }
        }

        public Decimal ValorEfectivo
        {
            get { return _ValorEfectivo; }
            set { _ValorEfectivo = value; }
        }

        public Decimal ValorBanco
        {
            get { return _ValorBanco; }
            set { _ValorBanco = value; }
        }

        public Decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        public Decimal Asignado
        {
            get { return _Asignado; }
            set { _Asignado = value; }
        }

        public Decimal Interes
        {
            get { return _Interes; }
            set { _Interes = value; }
        }
        public string Asigna
        {
            get { return _Asigna; }
            set { _Asigna = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public CD_CtaCte()
        {
        }


        public CD_CtaCte(int id, string dnicuit, string cuit, DateTime fecha, string comprob,
            string concepto, decimal debe, decimal haber, decimal vcheque, decimal vefectivo,
            decimal vbanco, decimal total, decimal asignado, decimal interes, string asigna, string estado)
        {
            
            this.Id = id;
            this.DniCuit = dnicuit;
            this.Cuit = cuit;
            this.Fecha = fecha;
            this.Comprobante = comprob;
            this.Concepto = concepto;
            this.Debe = debe;
            this.Haber = haber;
            this.ValorCheque = vcheque;
            this.ValorEfectivo = vefectivo;
            this.ValorBanco = vbanco;
            this.Total = total;
            this.Asignado = asignado;
            this.Interes = interes;
            this.Asigna = asigna;
            this.Estado = estado;
        }

        //METODO INSERTAR
        public string Insertar(CD_CtaCte CtaCte)
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
                SqlCmd.CommandText = "Insertar_CtaCte";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParDniCuit = new SqlParameter();
                ParDniCuit.ParameterName = "@dnicuit";
                ParDniCuit.SqlDbType = SqlDbType.VarChar;
                ParDniCuit.Size = 50;
                ParDniCuit.Value = CtaCte.DniCuit;
                SqlCmd.Parameters.Add(ParDniCuit);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = CtaCte.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "@cmpbte";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 15;
                ParComprobante.Value = CtaCte.Comprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                SqlParameter ParConcepto = new SqlParameter();
                ParConcepto.ParameterName = "@concepto";
                ParConcepto.SqlDbType = SqlDbType.VarChar;
                ParConcepto.Size = 350;
                ParConcepto.Value = CtaCte.Concepto;
                SqlCmd.Parameters.Add(ParConcepto);

                SqlParameter ParDebe = new SqlParameter();
                ParDebe.ParameterName = "@debe";
                ParDebe.SqlDbType = SqlDbType.Money;                
                ParDebe.Value = CtaCte.Debe;
                SqlCmd.Parameters.Add(ParDebe);

                SqlParameter ParHaber = new SqlParameter();
                ParHaber.ParameterName = "@haber";
                ParHaber.SqlDbType = SqlDbType.Money;
                ParHaber.Value = CtaCte.Haber;
                SqlCmd.Parameters.Add(ParHaber);

                SqlParameter ParValorCheque = new SqlParameter();
                ParValorCheque.ParameterName = "@vcheque";
                ParValorCheque.SqlDbType = SqlDbType.Money;
                ParValorCheque.Value = CtaCte.ValorCheque;
                SqlCmd.Parameters.Add(ParValorCheque);

                SqlParameter ParValorEfectivo = new SqlParameter();
                ParValorEfectivo.ParameterName = "@vefect";
                ParValorEfectivo.SqlDbType = SqlDbType.Money;
                ParValorEfectivo.Value = CtaCte.ValorEfectivo;
                SqlCmd.Parameters.Add(ParValorEfectivo);

                SqlParameter ParValorBanco = new SqlParameter();
                ParValorBanco.ParameterName = "@vbanco";
                ParValorBanco.SqlDbType = SqlDbType.Money;
                ParValorBanco.Value = CtaCte.ValorBanco;
                SqlCmd.Parameters.Add(ParValorBanco);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Money;
                ParTotal.Value = CtaCte.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParAsignado = new SqlParameter();
                ParAsignado.ParameterName = "@asignado";
                ParAsignado.SqlDbType = SqlDbType.Money;
                ParAsignado.Value = CtaCte.Asignado;
                SqlCmd.Parameters.Add(ParAsignado);

                SqlParameter ParInteres = new SqlParameter();
                ParInteres.ParameterName = "@interes";
                ParInteres.SqlDbType = SqlDbType.Money;
                ParInteres.Value = CtaCte.Interes;
                SqlCmd.Parameters.Add(ParInteres);

                SqlParameter ParAsigna = new SqlParameter();
                ParAsigna.ParameterName = "@asigna";
                ParAsigna.SqlDbType = SqlDbType.VarChar;
                ParAsigna.Size = 1;
                ParAsigna.Value = CtaCte.Asigna;
                SqlCmd.Parameters.Add(ParAsigna);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = CtaCte.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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

        public string ModificarRegistroCtaCte(CD_CtaCte CtaCte)
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
                SqlCmd.CommandText = "AnularRegistroCtaCte";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "@cmpbte";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 20;
                ParComprobante.Value = CtaCte.Comprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                SqlParameter ParConcepto = new SqlParameter();
                ParConcepto.ParameterName = "@concepto";
                ParConcepto.SqlDbType = SqlDbType.VarChar;
                ParConcepto.Size = 350;
                ParConcepto.Value = CtaCte.Concepto;
                SqlCmd.Parameters.Add(ParConcepto); 

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se ANULO el Registro EN CTA CTE";

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

        public DataTable CargarComboBoxCliente()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarComboBoxClientes", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }

        public DataTable MostrarDetCta(string dni,string fecha1, string fecha2)
        {
            DataTable DtResultado = new DataTable("detalle");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "DetalleCtaCte_PorFecha";
                SqlCmd.Parameters.AddWithValue("@dni", dni);
                SqlCmd.Parameters.AddWithValue("@fecha1", fecha1);
                SqlCmd.Parameters.AddWithValue("@fecha2", fecha2);

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

        public DataTable MostrarDetCtaCompleto(string dni)
        {
            DataTable DtResultado = new DataTable("detalle");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "DetalleCtaCte_Simple";
                SqlCmd.Parameters.AddWithValue("@dni", dni);

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
        

        public decimal MostrarSaldo(string idcliente)
        {
            decimal saldo = 0;

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar_SaldoCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {                
                saldo = Convert.ToDecimal(registro["SALDOC"]);
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return saldo;
        }


        //PARA PROVEEDORES

        //METODO INSERTAR
        public string InsertarP(CD_CtaCte CtaCteP)
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
                SqlCmd.CommandText = "Insertar_CtaCteP";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParDniCuit = new SqlParameter();
                ParDniCuit.ParameterName = "@cuit";
                ParDniCuit.SqlDbType = SqlDbType.VarChar;
                ParDniCuit.Size = 50;
                ParDniCuit.Value = CtaCteP.Cuit;
                SqlCmd.Parameters.Add(ParDniCuit);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = CtaCteP.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "@cmpbte";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 15;
                ParComprobante.Value = CtaCteP.Comprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                SqlParameter ParConcepto = new SqlParameter();
                ParConcepto.ParameterName = "@concepto";
                ParConcepto.SqlDbType = SqlDbType.VarChar;
                ParConcepto.Size = 350;
                ParConcepto.Value = CtaCteP.Concepto;
                SqlCmd.Parameters.Add(ParConcepto);

                SqlParameter ParDebe = new SqlParameter();
                ParDebe.ParameterName = "@debe";
                ParDebe.SqlDbType = SqlDbType.Money;
                ParDebe.Value = CtaCteP.Debe;
                SqlCmd.Parameters.Add(ParDebe);

                SqlParameter ParHaber = new SqlParameter();
                ParHaber.ParameterName = "@haber";
                ParHaber.SqlDbType = SqlDbType.Money;
                ParHaber.Value = CtaCteP.Haber;
                SqlCmd.Parameters.Add(ParHaber);

                SqlParameter ParValorCheque = new SqlParameter();
                ParValorCheque.ParameterName = "@vcheque";
                ParValorCheque.SqlDbType = SqlDbType.Money;
                ParValorCheque.Value = CtaCteP.ValorCheque;
                SqlCmd.Parameters.Add(ParValorCheque);

                SqlParameter ParValorEfectivo = new SqlParameter();
                ParValorEfectivo.ParameterName = "@vefect";
                ParValorEfectivo.SqlDbType = SqlDbType.Money;
                ParValorEfectivo.Value = CtaCteP.ValorEfectivo;
                SqlCmd.Parameters.Add(ParValorEfectivo);

                SqlParameter ParValorBanco = new SqlParameter();
                ParValorBanco.ParameterName = "@vbanco";
                ParValorBanco.SqlDbType = SqlDbType.Money;
                ParValorBanco.Value = CtaCteP.ValorBanco;
                SqlCmd.Parameters.Add(ParValorBanco);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Money;
                ParTotal.Value = CtaCteP.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParAsignado = new SqlParameter();
                ParAsignado.ParameterName = "@asignado";
                ParAsignado.SqlDbType = SqlDbType.Money;
                ParAsignado.Value = CtaCteP.Asignado;
                SqlCmd.Parameters.Add(ParAsignado);

                SqlParameter ParInteres = new SqlParameter();
                ParInteres.ParameterName = "@interes";
                ParInteres.SqlDbType = SqlDbType.Money;
                ParInteres.Value = CtaCteP.Interes;
                SqlCmd.Parameters.Add(ParInteres);

                SqlParameter ParAsigna = new SqlParameter();
                ParAsigna.ParameterName = "@asigna";
                ParAsigna.SqlDbType = SqlDbType.VarChar;
                ParAsigna.Size = 1;
                ParAsigna.Value = CtaCteP.Asigna;
                SqlCmd.Parameters.Add(ParAsigna);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 15;
                ParEstado.Value = CtaCteP.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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

        public string ModificarRegistroCtaCteP(CD_CtaCte CtaCteP)
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
                SqlCmd.CommandText = "AnularRegistroCtaCteP";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "@cmpbte";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 20;
                ParComprobante.Value = CtaCteP.Comprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                SqlParameter ParConcepto = new SqlParameter();
                ParConcepto.ParameterName = "@concepto";
                ParConcepto.SqlDbType = SqlDbType.VarChar;
                ParConcepto.Size = 350;
                ParConcepto.Value = CtaCteP.Concepto;
                SqlCmd.Parameters.Add(ParConcepto);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se ANULO el Registro EN CTA CTE";

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

        public DataTable CargarComboBoxProveedor()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarComboBoxProveedores", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return dt;
        }

        public DataTable MostrarDetCtaP(string cuit, string fecha1, string fecha2)
        {
            DataTable DtResultado = new DataTable("detalleP");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "DetalleCtaCteP_PorFecha";
                SqlCmd.Parameters.AddWithValue("@cuit", cuit);
                SqlCmd.Parameters.AddWithValue("@fecha1", fecha1);
                SqlCmd.Parameters.AddWithValue("@fecha2", fecha2);

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

        public DataTable MostrarDetCtaCompletoP(string cuit)
        {
            DataTable DtResultado = new DataTable("detalleP");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "DetalleCtaCteP_Simple";
                SqlCmd.Parameters.AddWithValue("@cuit", cuit);

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


        public decimal MostrarSaldoP(string idproveedor)
        {
            decimal saldo = 0;

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar_SaldoProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproveedor", idproveedor);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                saldo = Convert.ToDecimal(registro["SALDOP"]);
            }
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return saldo;
        }
    }
}
