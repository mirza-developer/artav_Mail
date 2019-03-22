using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Artav_Mailer.Management;

namespace Artav_Mailer
{
    public class Mailing
    {
        public bool SendSmtp(MailMessage message, MailSetting setting)
        {
            try
            {
                if (!ValidateSettingBefore(setting))
                    return false;
                message.From = new MailAddress(setting.FromMailAddress);
                message.IsBodyHtml = setting.IsBodyHtml;
                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = setting.MailServiceUsername,
                        Password = setting.MailServicePassword
                    };
                    smtp.Credentials = credential;
                    smtp.Host = setting.HostNameOrIp;
                    smtp.Port = setting.Port;
                    smtp.EnableSsl = setting.EnableSsl;
                    //     smtp.Port = 8081;
                    // smtp.EnableSsl = true;
                    smtp.Send(message);

                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> SendSmtpAsync(MailMessage message, MailSetting setting)
        {
            try
            {
                if (!ValidateSettingBefore(setting))
                    return false;
                message.From = new MailAddress(setting.FromMailAddress);
                message.IsBodyHtml = setting.IsBodyHtml;
                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = setting.MailServiceUsername,
                        Password = setting.MailServicePassword
                    };
                    smtp.Credentials = credential;
                    smtp.Host = setting.HostNameOrIp;
                    smtp.Port = setting.Port;
                    smtp.EnableSsl = setting.EnableSsl;
                    //     smtp.Port = 8081;
                    // smtp.EnableSsl = true;
                    smtp.Send(message);

                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }


        private bool ValidateSettingBefore(MailSetting passedInstance)
        {
            if (passedInstance.FromMailAddress == string.Empty)
                return false;
            if (passedInstance.MailServiceUsername == string.Empty)
                return false;
            if (passedInstance.MailServicePassword == string.Empty)
                return false;
            if (passedInstance.HostNameOrIp == string.Empty)
                return false;
            return true;
        }
    }
}
