using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        //INSTANCIAMOS UN OBJETO DE LA CLASE CD_USUARIOS
        private CD_Usuarios objetoCD = new CD_Usuarios();


        public static DataTable MostrarUsuarios()
        {
            return new CD_Usuarios().Mostrar();
        }

        public static string ConsultaSiExisteUserEnComprob(string proc, int id)
        {
            CD_Usuarios Obj = new CD_Usuarios();
            string rpta = Obj.ConsultaSiExisteUserEnComprob(proc,id);
            return rpta;
        }

        public static string ConsultaExisteNombreUser(string nombre, int id)
        {
            CD_Usuarios Obj = new CD_Usuarios();
            string rpta = Obj.ConsultaExisteNombreUser(nombre,id);
            return rpta;
        }

        public DataTable MostrarSesiones()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarSesion();
            return tabla;
        }

        public DataTable BuscarSesiones(string fecha1,string fecha2)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarSesiones(fecha1,fecha2);
            return tabla;
        }

        public DataTable CargarComboBox()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargarComboBox();
            return dt;
        }

        public DataTable MostrarUltimaSesion()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ConsultarIdSesion();
            return tabla;
        }

        public void InsertarUsuarios(string user, string pass, string name, string apellido, string rango, string email)
        {
            objetoCD.Insertar(user, pass, name, apellido, rango, email);
        }

        public void InsertarSesiones(string user, string fechainicio)
        {
            objetoCD.InsertarSesion(user, Convert.ToDateTime(fechainicio));
        }

        public void InsertarRoles(string rol)
        {
            objetoCD.InsertarRol(rol);
        }

        public void EditarUsuarios(string user, string pass, string name, string apellido, string rango, string email, string id)
        {
            objetoCD.Editar(user, pass, name, apellido, rango, email, Convert.ToInt32(id));
        }

        public void EditarSesiones(string fechafin, string tiempo)
        {
            objetoCD.EditarSesion(Convert.ToDateTime(fechafin), tiempo);
        }

        public void EliminarUsuario(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
