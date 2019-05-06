using Disofi.Utils;
using System;
using System.Data;
using System.Net.Mail;
using System.Web.Configuration;
using System.Web.UI;


namespace DisofiLafete.Utils
{
    public class EnvioMail
    {
        private readonly Control _control = new Control();
        private DataSet _ds = new DataSet();
        private const string Ur = "~/Utils/HTMLCorreos/";

        public string SendCorreoSolitaModificación(string pBody)
        {
            try
            {
                return Smtp.Send(new MailMessage()
                {
                    To = {
            WebConfigurationManager.AppSettings["correoAdmin"]
          },
                    CC = {
            WebConfigurationManager.AppSettings["correoCC"]
          },
                    From = new MailAddress(WebConfigurationManager.AppSettings["sistema"], "Asignación de Tarea ."),
                    Subject = "Nueva Orden de Atención",
                    Body = pBody,
                    IsBodyHtml = true
                }) ? "ok" : "NOK";
            }
            catch (Exception ex)
            {
                throw new CapturaExcepciones(ex);
            }
        }

        public string SendSolicitudCajaChica(string pBody, string email, string tipo)
        {
            try
            {
                return Smtp.Send(new MailMessage()
                {
                    To = {
            email
          },
                    Bcc = {
            WebConfigurationManager.AppSettings["correoAdmin"]
          },
                    CC = {
            WebConfigurationManager.AppSettings["correoCC"]
          },
                    From = new MailAddress(WebConfigurationManager.AppSettings["sistema"], "Caja Chica"),
                    Subject = tipo,
                    Body = pBody,
                    IsBodyHtml = true
                }) ? "ok" : "NOK";
            }
            catch (Exception ex)
            {
                throw new CapturaExcepciones(ex);
            }
        }
    }
}