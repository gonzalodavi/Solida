using System;
using System.Collections.Generic;
using System.Text;
using CapaComun.Cache;
using CapaDatos;
using CapaDatos.SqlServerDB;

namespace CapaNegocio
{
    public class ModeloUsuario
    {
        DatosUsuario datosU = new DatosUsuario();

        private int userID;
        private string user;
        private string pass;
        private string nombre;
        private string apellido;
        private string rol;
        private string email;

        public ModeloUsuario(int userID, string user, string pass, string nombre, string apellido, string email)
        {
            this.userID = userID;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;            
            this.email = email;
        }

        public ModeloUsuario()
        {

        }


        public string editarPerfilUsuario()
        {
            try
            {
                datosU.editarPerfil(userID, user, nombre, apellido, email);
                LoginUser(user, pass);
                return "Se modificó el Perfil de Usuario";
            }
            catch (Exception ex)
            {
                return "El nombre de Usuario ya existe, intente con otro";
            }
        }

        public string registrarNuevoUsuario()
        {
            try
            {
                datosU.registrarPerfil(user, pass, nombre, apellido, rol, email);
                LoginUser(user, pass);
                return "Se ha realizado el registro del nuevo perfil correctamente.\n\nPor favor cierre la sesión y vuelva a ingresar para ver los cambios";
            }
            catch (Exception ex)
            {
                return "El nombre de Usuario ya existe, intente con otro";
            }
        }
        public string mostrarUsuarios()
        {
            try
            {
                datosU.registrarPerfil(user, pass, nombre, apellido, rol, email);
                LoginUser(user, pass);
                return "Se ha realizado el registro del nuevo perfil correctamente.\n\nPor favor cierre la sesión y vuelva a ingresar para ver los cambios";
            }
            catch (Exception ex)
            {
                return "El nombre de Usuario ya existe, intente con otro";
            }
        }


        public string cambiarClave()
        {
            if (pass != UserLoginCache.Clave)
            {
                datosU.editarClave(userID, pass);
                LoginUser(user, pass);
                return "Se modificó la clave correctamente";
            }
            else
            {
                return "La clave es igual a la anterior, intente nuevamente";
            }
        }

        //public string cargarSesiones() { }


        public bool LoginUser(string usuario, string clave)
        {
            return datosU.Login(usuario, clave);
        }

        public string recuperarClave(string solicitudUsuario)
        {
            return datosU.recuperarClave(solicitudUsuario);
        }

        public void MetodoDeCargos()
        {
            if (UserLoginCache.Rango == Roles.Administrador)
            {

            }
            if (UserLoginCache.Rango == Roles.Encargado || UserLoginCache.Rango == Roles.Encargado)
            {

            }
        }
    }
}
