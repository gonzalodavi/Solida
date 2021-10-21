using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaComun.Cache;

namespace CapaDatos.SqlServerDB
{
    public class DatosUsuario : ConnectionToSql
    {
        public void editarPerfil(int id, string user, string nombre, string apellido, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Usuarios set Usuario=@user, Nombre=@nombre, Apellido=@apellido, Email=@mail where UserID=@id";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void registrarPerfil(string user, string pass, string nombre, string apellido, string rol, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "inser into Usuarios values (Usuario=@user, Clave=@pass, Nombre=@nombre, Apellido=@apellido, Rango=@rol, Email=@mail)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void editarClave(int id, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Usuarios set Clave=@pass where UserID=@id";
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void iniciarSesion(int id, DataSetDateTime fechainicio)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into Sesiones(IdSesion,UserSesion) values(@id,@fechainicio) ";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@user", fechainicio);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }



        public bool Login(string usuario, string clave)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where Usuario=@usuario and Clave=@clave";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@clave", clave);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.UserId = reader.GetInt32(0);
                            UserLoginCache.Usuario = reader.GetString(1);
                            UserLoginCache.Clave = reader.GetString(2);
                            UserLoginCache.Nombre = reader.GetString(3);
                            UserLoginCache.Apellido = reader.GetString(4);
                            UserLoginCache.Rango = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
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

        public string recuperarClave(string pedirUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuarios where Usuario=@usuario or Email=@mail";
                    command.Parameters.AddWithValue("@usuario", pedirUsuario);
                    command.Parameters.AddWithValue("@mail", pedirUsuario);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + " " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);
                        var mailService = new EmailServices.SoporteMailSistema();
                        mailService.enviaMail(
                          subject: "SYSTEM: Solicitud de recuperacion de contraseña",
                          body: "      Hola, " + userName + "\n  Has solicitado recuperar tu contraseña.\n\n" +
                          "  Tu contraseña actual es: " + accountPassword +
                          "\n  Se recomieda que al iniciar sesión cambies tu contraseña.\n\n  Muchas Gracias! Soporte SOLIDA",
                          recibeMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "\n     Solicitaste recuperar tu contraseña.\n" +
                          "     Por favor revisa tu correo: \n     " + userMail +
                          "\n     Sin embargo, cambia tu contraseña\n     inmediatamente.";
                    }
                    else
                        return "No existe una cuenta\n    con ese Nombre de Usuario o E-mail";
                }
            }
        }
    }
}
