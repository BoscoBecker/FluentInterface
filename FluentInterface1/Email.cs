namespace FluentInterface1
{
    public class Email
    {
        public string Destino { get; set; }
        public string Origem { get; set; }
        public string Assunto { get; set; }
        public string Body { get; set; }

        public override string ToString()
        {
            return ($"{Destino} - {Origem}\n {Assunto}\n {Body}\n");
        }
    }
}
