using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo
{
    public interface INotificationSender
    {
        void SendNotification(string message);
    }

    public class EmailSender : INotificationSender
    {
        private EmailConfiguration emailConfiguration;

        public EmailSender(EmailConfiguration emailConfiguration)
        {
            this.emailConfiguration = emailConfiguration;
        }

        public void SendNotification(string message)
        {
            System.Diagnostics.Debug.WriteLine("******************************************************");
            System.Diagnostics.Debug.WriteLine($"EMAIL SENT {emailConfiguration.ServerName}:{emailConfiguration.ServerPort}");
            System.Diagnostics.Debug.WriteLine("******************************************************");
        }
    }

    public class EmailConfiguration
    {
        public string ServerName { get; set; }
        public int ServerPort { get; set; }
    }
}
