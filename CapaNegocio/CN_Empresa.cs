using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Empresa
    {
        public static DataTable Mostrar()
        {
            return new CD_Empresa().Mostrar();
        }

        public static DataTable MostrarSucursales()
        {
            return new CD_Empresa().MostrarSucursales();
        }

        public static string GuardarDatos(string razon, string nombre, string cuit, DateTime inicioAct, string iibb, string condIva, string provincia, string localidad, string codpostal, string direccion)
        {
            CD_Empresa Obj = new CD_Empresa();
            Obj.Razon = razon;
            Obj.Nombre = nombre;
            Obj.Cuit = cuit;
            Obj.InicioAct = inicioAct;
            Obj.Iibb = iibb;
            Obj.CondIva = condIva;
            Obj.Provincia = provincia;
            Obj.Localidad = localidad;
            Obj.Codpostal = codpostal;
            Obj.Direccion = direccion;
    
            return Obj.Modificar(Obj);
        }
        public static string GuardarSucursal(string sucursal)
        {
            CD_Empresa Obj = new CD_Empresa();
            Obj.Sucursal = sucursal;
            

            return Obj.GuardarSucursal(Obj);
        }
    }
}
