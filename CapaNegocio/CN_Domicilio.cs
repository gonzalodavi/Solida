using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Domicilio
    {
        public static string Insertar(string calle, int nro, string piso, string dpto, int idbarrio)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            Obj.Calle = calle;
            Obj.Nro = nro;
            Obj.Piso = piso;
            Obj.Dpto = dpto;
            Obj.IdBarrio = idbarrio;
            return Obj.Insertar(Obj);
        }

        public static string Modificar(int id, string calle, int nro, string piso, string dpto, int idbarrio)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            Obj.IdDomicilio = id;
            Obj.Calle = calle;
            Obj.Nro = nro;
            Obj.Piso = piso;
            Obj.Dpto = dpto;
            Obj.IdBarrio = idbarrio;
            return Obj.Modificar(Obj);
        }

        public static string Eliminar(int id)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            Obj.IdDomicilio = id;
            return Obj.Eliminar(Obj);
        }

        public static int Consultar()
        {            
            CD_Domicilio Obj = new CD_Domicilio();
            int nro = Obj.Consultar();
            return nro;
        }
        public static int ConsultaDomxaMod(int iddom)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            int nro = Obj.ConsultaParaModDom(iddom);
            return nro;
        }

        public static DataTable MostrarDomicilioEnGrilla(int iddom)
        {
            return new CD_Domicilio().MostrarDomEnGrilla(iddom);
        }
        public static string InsertarLocalidad(string localidad, int idprovincia)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            Obj.Localidad = localidad;
            Obj.IdProvincia = idprovincia;
            return Obj.InsertarLocalidad(Obj);
        }

        public static DataTable Mostrar()
        {
            return new CD_Domicilio().Mostrar();
        }

        public static string InsertarBarrio(string barrio, int idlocalidad, string codigopostal)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            Obj.Barrio = barrio;
            Obj.Id_Localidad = idlocalidad;
            Obj.CodigoPostal = codigopostal;
            return Obj.InsertarBarrio(Obj);
        }

        public DataTable CargaProvincia()
        {
            CD_Domicilio Obj = new CD_Domicilio();
            DataTable dt = new DataTable();
            dt = Obj.MostrarProvincia();
            return dt;
        }

        public static DataTable CargaBarrio(int idloc)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            Obj.Id_Localidad = idloc;
            return Obj.MostrarBarrio(Obj);
        }

        public string CargarCodigoPostal(int id)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            string codpostal = Obj.MostrarCodigoPostal(id);
            return codpostal;
        }
        public string BuscarDomicilio(int id)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            string dom = Obj.BuscaDomicilio(id);
            return dom;
        }

        public DataTable BuscaUnDomicilio(string calle)
        {
            CD_Domicilio objetoCD = new CD_Domicilio();
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscaDomicilioxCalle (calle);
            return tabla;
        }

        public static DataTable CargaLocalidadEnComboBox(int idprovincia)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            Obj.IdProvincia = idprovincia;
            return Obj.MostrarLocalidadEnComboBox(Obj);
        }

        public static DataTable CargaLocalidad(int idprovincia)
        {
            CD_Domicilio Obj = new CD_Domicilio();
            Obj.IdProvincia = idprovincia;
            return Obj.MostrarLocalidad(Obj);
        }
    }
}
