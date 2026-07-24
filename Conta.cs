namespace ScBank
{
    public class Conta
    {
        //atributos
        public int Numero { get;  set; }
        public string Titular { get; set; }
        public decimal Saldo { get;  set; }
        
        //construtor
        public Conta(string titular)
        {
            Titular = titular;
            Numero = new Random().Next();
        }

        //métodos
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            Saldo -= valor;
        }

        public void imprimirExtrato()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Número da conta: {Numero}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo:C}");
            Console.WriteLine("================================");

        }
    }
}