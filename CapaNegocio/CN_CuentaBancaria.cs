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
