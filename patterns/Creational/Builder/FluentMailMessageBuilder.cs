using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patterns.Creational.Builder
{
    /// <summary>
    /// Строитель используеться для возвращения объекта с большим количеством опциональных полей
    /// В результате мы определяем только нужные и все
    ///
    /// данный строитель явлеться паттерном fuent(interface)builder. отличаеться от обычного тем что в обычном у нас есть абстрактный класс строителя
    /// и конкретные строители (через прослойку, не нужно создавать методы которые будут возвращать разные реализации строителей
    /// например: абстрактный клас имеет 2 метода, CreateWith attachment и CreateWithoutAttachment. Нам надо было бы реализовать строитель для сообщения. передать его 
    /// в конкретный клас реализованный от абстрактного, и кнутри реализовать эти 2 метода).
    /// То здесь мы просто используем только точ то нужну при создании объекта.
    /// Упрощает код и не нужно городить прослойки
    /// </summary>
    public class FluentMailMessageBuilder
    {
        private readonly MailMessage _mailMessage = new MailMessage();

        public FluentMailMessageBuilder From(string address, string name)
        {
            _mailMessage.From = new MailAddress(address, name);
            return this;
        }

        public FluentMailMessageBuilder To(string address, string name)
        {
            _mailMessage.To.Add(new MailAddress(address, name));
            return this;
        }

        public FluentMailMessageBuilder Cc(string address, string name)
        {
            _mailMessage.CC.Add(new MailAddress(address, name));
            return this;
        }

        public FluentMailMessageBuilder Subject(string subject)
        {
            _mailMessage.Subject = subject;
            return this;
        }

        public FluentMailMessageBuilder Body(string body, Encoding encoding)
        {
            _mailMessage.Body = body;
            _mailMessage.Encoding = encoding;
            return this;
        }

        public MailMessage Build()
        {
            if (!_mailMessage.To.Any())
            {
                throw new InvalidOperationException("Can't create a mail message with empty To. Please call 'To' method first");
            }
            return _mailMessage;
        }

        //неявное преобразование строителя в MailMessage. Можно использовать без выхова Build
        public static implicit operator MailMessage(FluentMailMessageBuilder builder)
        {
            return builder.Build();
        }

    }
}
