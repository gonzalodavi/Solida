using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace CapaDatos.EmailServices
{
    public abstract class ServidorCorreo
    {
        private SmtpClient smtpClient;
        protected string enviarMail { get; set; }
        protected string contrasena { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(enviarMail, contrasena);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void enviaMail(string subject, string body, List<string> recibeMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(enviarMail);
                foreach (string mail in recibeMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);//Enviar mensaje
            }
            catch (Exception ex) { }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
