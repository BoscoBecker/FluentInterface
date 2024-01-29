using System;

namespace FluentInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailFluent();

            email.OrigemEmail("macoratti@yahoo.com")
                 .DestinoEmail("microsoft@hotmail.com")
                 .AssuntoEmail("Testando a classe Email")
                 .BodyEmail("Teste de utilização da classe Email")
                 .Build();

            Console.WriteLine(email.ToString());
            Console.ReadLine();
        }
    }
}
