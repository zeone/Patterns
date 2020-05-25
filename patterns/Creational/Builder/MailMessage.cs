using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace patterns.Creational.Builder
{
    public class MailMessage
    {
        public MailAddress From { get; set; }

        public List<MailAddress> To { get; } = new List<MailAddress>();

        public List<MailAddress> CC { get; } = new List<MailAddress>();

        public string Subject { get; set; }

        public string Body { get; set; }

        public Encoding Encoding { get; set; }
    }
}
