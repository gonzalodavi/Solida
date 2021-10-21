using System;
using System.Collections.Generic;
using System.Text;

namespace CapaComun.Cache
{
    public static class UserLoginCache
    {
        public static int UserId { get; set; }
        public static string Usuario { get; set; }
        public static string Clave { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Rango { get; set; }
        public static string Email { get; set; }
        public static int id_sesion { get; set; }
    }
}
