using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Proveedor
    {

        private CD_Proveedor objetoCD = new CD_Proveedor();


        public static string Insertar(string cuit, string razonsocial, string nombre, string apellido,string mail, string telefono, int iddomicilio, string descrip)
        {
            CD_Proveedor Obj = new CD_Proveedor();
            Obj.Cuit = cuit;
            Obj.RazonSocial = razonsocial;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Mail = mail;
            Obj.Telefono = telefono;
            Obj.IdDomicilio = iddomicilio;
            Obj.Descripcion = descrip;

            return Obj.Insertar(Obj);
        }
        public static string Modificar(string cuit, string razonsocial, string nombre, string apellido, string mail, string telefono, int iddomicilio, string descrip)
        {
            CD_Proveedor Obj = new CD_Proveedor();
            Obj.Cuit = cuit;
            Obj.RazonSocial = razonsocial;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Mail = mail;
            Obj.Telefono = telefono;
            Obj.IdDomicilio = iddomicilio;
            Obj.Descripcion = descrip;

            return Obj.Modificar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new CD_Proveedor().Mostrar();
        }
        public static string Eliminar(string proveedor)
        {
            CD_Proveedor Obj = new CD_Proveedor();
            Obj.Cuit = proveedor;
            return Obj.Eliminar(Obj);
        }

        public DataTable BuscarProveedor(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarProveedor(nombre);
            return tabla;
        }

        public DataTable BuscarProveedorCuit(string cuit)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarProveedorCuit(cuit);
            return tabla;
        }

        public DataTable MostrarProveedor()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProveedores();
            return tabla;
        }
    }
}
