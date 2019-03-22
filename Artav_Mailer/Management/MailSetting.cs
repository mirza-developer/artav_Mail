
namespace Artav_Mailer.Management
{
    public class MailSetting
    {
        public MailSetting()
        {
            this.FromMailAddress = string.Empty;
            this.MailServiceUsername = string.Empty;
            this.MailServicePassword = string.Empty;
            this.HostNameOrIp = string.Empty;
            this.IsBodyHtml = false;
            this.EnableSsl = false;
            this.Port = 8081;
        }
        public string FromMailAddress { get; set; }
        public string MailServiceUsername { get; set; }
        public string MailServicePassword { get; set; }
        public string HostNameOrIp { get; set; }
        public bool IsBodyHtml { get; set; }
        public bool EnableSsl { get; set; }
        public int Port { get; set; }
    }
}
