using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objetoCD = new CD_Cliente();


        public static DataTable Mostrar()
        {
            return new CD_Cliente().Mostrar();
        }
        public static string Insertar(string dni, string nombre, string apellido, string telefono, string mail, string condiva, string razonsocial, int iddomicilio)
        {
            CD_Cliente Obj = new CD_Cliente();
            Obj.Dni = dni;            
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Telefono = telefono;
            Obj.Mail = mail;
            Obj.CondicionIVA = condiva;
            Obj.RazonSocial = razonsocial;
            Obj.IdDomicilio = iddomicilio;

            return Obj.Insertar(Obj);
        }
        public static string Modificar(string dni, string nombre, string apellido, string telefono, string mail, string condiva, string razonsocial, int iddomicilio)
        {
            CD_Cliente Obj = new CD_Cliente();
            Obj.Dni = dni;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Telefono = telefono;
            Obj.Mail = mail;
            Obj.CondicionIVA = condiva;
            Obj.RazonSocial = razonsocial;
            Obj.IdDomicilio = iddomicilio;

            return Obj.Modificar(Obj);
        }
        public static string Eliminar(string cliente)
        {
            CD_Cliente Obj = new CD_Cliente();
            Obj.Dni = cliente;
            return Obj.Eliminar(Obj);
        }

        public DataTable BuscarClientesxNom(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarClientesxNOM(nombre);
            return tabla;
        }

        public DataTable BuscarClientexDNI(string cuit)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarxDNI(cuit);
            return tabla;
        }

        public DataTable MostrarCLientes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarClientes();
            return tabla;
        }

    }
}
