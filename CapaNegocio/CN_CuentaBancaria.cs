using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_CuentaBancaria
    {
        private CD_CuentaBancaria objetoCD = new CD_CuentaBancaria();

        public DataTable CargaCuentasBanco()
        {
            CD_CuentaBancaria Obj = new CD_CuentaBancaria();
            DataTable dt = new DataTable();
            dt = Obj.CargarComboBoxCuentasBanco();
            return dt;
        }
        public static DataTable Mostrar()
        {
            return new CD_CuentaBancaria().Mostrar();
        }

        public static DataTable MostrarDetalleBanco(int idCta)
        {
            CD_CuentaBancaria Obj = new CD_CuentaBancaria();
            Obj.Id = idCta;            
            return Obj.DetalleCtaBanco(Obj);
        }

        public static string TotalDebe(int idBanco)
        {
            CD_CuentaBancaria Obj = new CD_CuentaBancaria();
            Obj.Id = idBanco;
            return Obj.TotalDebe(Obj); ;
        }

        public static string TotalHaber(int idBanco)
        {
            CD_CuentaBancaria Obj = new CD_CuentaBancaria();
            Obj.Id = idBanco;
            return Obj.TotalHaber(Obj); ;
        }

        public static string TotalImporte(int idBanco)
        {
            CD_CuentaBancaria Obj = new CD_CuentaBancaria();
            Obj.Id = idBanco;
            return Obj.TotalImporte(Obj); ;
        }

        public static string Insertar(string numcta, string nombre, string tipocta, string titular, string cbu, string alias)
        {
            CD_CuentaBancaria Obj = new CD_CuentaBancaria();
            Obj.NumeroCta = numcta;
            Obj.NombreCta = nombre;
            Obj.TipoCta = tipocta;
            Obj.Titular = titular;
            Obj.CBU = cbu;
            Obj.Alias = alias;

            return Obj.Insertar(Obj);
        }

        public static string Modificar(int id, string numcta, string nombre, string tipocta, string titular, string cbu, string alias)
        {
            CD_CuentaBancaria Obj = new CD_CuentaBancaria();
            Obj.Id = id;
            Obj.NumeroCta = numcta;
            Obj.NombreCta = nombre;
            Obj.TipoCta = tipocta;
            Obj.Titular = titular;
            Obj.CBU = cbu;
            Obj.Alias = alias;

            return Obj.Modificar(Obj);
        }

        public static string Eliminar(int id)
        {
            CD_CuentaBancaria Obj = new CD_CuentaBancaria();
            Obj.Id = id;
            return Obj.Eliminar(Obj);
        }
    }
}
