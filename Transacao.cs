namespace ScBank
{
    public class Transacao
    {
        //Atributos
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
        //construtor
        public Transacao(decimal valor, string tipo)
        {
            Valor = valor;
            Tipo = tipo;
            Data = DateTime.Now;
        }
        //metodos
        public void ImprimirTransacao()
        {
            Console.WriteLine($"Data: {Data}, Tipo: {Tipo}, Valor: {Valor:C2}");
        }
    }
}