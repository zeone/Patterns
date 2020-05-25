using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.Builder
{
    /// <summary>
    /// Реализация строителя при помощи методов расширения
    /// </summary>
    public static class ExMailMessageBuilder
    {
        public static MailMessage From(this MailMessage mailMessage, string address, string name)
        {
            mailMessage.From = new MailAddress(address, name);
            return mailMessage;
        }

        public static MailMessage To(this MailMessage mailMessage, string address, string name)
        {
            mailMessage.To.Add(new MailAddress(address, name));
            return mailMessage;
        }

        public static MailMessage Subject(this MailMessage mailMessage, string subject)
        {
            mailMessage.Subject = subject;
            return mailMessage;
        }
    }
}
