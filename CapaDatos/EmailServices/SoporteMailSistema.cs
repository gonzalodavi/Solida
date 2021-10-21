using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.EmailServices
{

    class SoporteMailSistema : ServidorCorreo
    {
        public SoporteMailSistema()
        {
            enviarMail = "solidacorporation@gmail.com";
            contrasena = "Myorep2Solida";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
