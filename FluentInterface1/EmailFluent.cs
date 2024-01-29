using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface1
{
    public class EmailFluent
    {
        private readonly Email email;
        public EmailFluent()
        {
            email = new Email();
        }

        public EmailFluent OrigemEmail(string origem)
        {
            email.Origem = origem;
            return this;
        }
        public EmailFluent DestinoEmail(string destino)
        {
            email.Destino = destino;
            return this;
        }
        public EmailFluent AssuntoEmail(string assunto)
        {
            email.Assunto = assunto;
            return this;
        }
        public EmailFluent BodyEmail(string body)
        {
            email.Body = body;
            return this;
        }
        public Email Build()
        {
            return email;
        }
    }
}
