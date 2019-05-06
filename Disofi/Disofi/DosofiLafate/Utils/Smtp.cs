using Disofi.Utils;
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;


namespace DisofiLafete.Utils
{
    public class Smtp
    {
        private static string smtpServer_1 = ConfigurationManager.AppSettings.Get(nameof(smtpServer_1));
        private static string smtpPort_1 = ConfigurationManager.AppSettings.Get(nameof(smtpPort_1));
        private static string smtpUser_1 = ConfigurationManager.AppSettings.Get(nameof(smtpUser_1));
        private static string smtpPassword_1 = ConfigurationManager.AppSettings.Get(nameof(smtpPassword_1));
        private static string mailfrom_1 = ConfigurationManager.AppSettings.Get("mailFrom_1");
        private static string displayName_1 = ConfigurationManager.AppSettings.Get(nameof(displayName_1));
        private static string smtpServer_2 = ConfigurationManager.AppSettings.Get(nameof(smtpServer_2));
        private static string smtpPort_2 = ConfigurationManager.AppSettings.Get(nameof(smtpPort_2));
        private static string smtpUser_2 = ConfigurationManager.AppSettings.Get(nameof(smtpUser_2));
        private static string smtpPassword_2 = ConfigurationManager.AppSettings.Get(nameof(smtpPassword_2));
        private static string mailfrom_2 = ConfigurationManager.AppSettings.Get("mailFrom_2");
        private static string displayName_2 = ConfigurationManager.AppSettings.Get(nameof(displayName_2));
        private static string smtpServer_3 = ConfigurationManager.AppSettings.Get(nameof(smtpServer_3));
        private static string smtpPort_3 = ConfigurationManager.AppSettings.Get(nameof(smtpPort_3));
        private static string smtpUser_3 = ConfigurationManager.AppSettings.Get(nameof(smtpUser_3));
        private static string smtpPassword_3 = ConfigurationManager.AppSettings.Get(nameof(smtpPassword_3));
        private static string mailfrom_3 = ConfigurationManager.AppSettings.Get("mailFrom_3");
        private static string displayName_3 = ConfigurationManager.AppSettings.Get(nameof(displayName_3));

        public static bool Send(MailMessage message)
        {
            bool flag;
            try
            {
                flag = Smtp.SendByPrimario(message);
            }
            catch (Exception ex)
            {
                throw new CapturaExcepciones(ex);
            }
            return flag;
        }

        private static bool SendByPrimario(MailMessage message)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(Smtp.mailfrom_1, Smtp.displayName_1);
                message.From = mailAddress;
                SmtpClient smtpClient = new SmtpClient(Smtp.smtpServer_1, Convert.ToInt32(Smtp.smtpPort_1));
                smtpClient.UseDefaultCredentials = false;
                NetworkCredential networkCredential = new NetworkCredential(Smtp.smtpUser_1, Smtp.smtpPassword_1);
                smtpClient.Credentials = (ICredentialsByHost)networkCredential;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                throw new CapturaExcepciones(ex);
            }
        }
    }
}