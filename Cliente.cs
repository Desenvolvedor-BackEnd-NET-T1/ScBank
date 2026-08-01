

namespace ScBank
{
    public class Cliente() : Pessoa
    {
        public string End {  get;  set; }
      
        public static Cliente CriarEPreencherCliente()
        {
            Cliente clienteObj = new Cliente();
            clienteObj.Preencher();
            return clienteObj;
        }

        public override void Preencher()
        {
            Console.WriteLine("Cadastro de Cliente");
            base.Preencher();
            Console.WriteLine("Digite o Enderco: ");
            End = Console.ReadLine();
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Endereço: "+ End);
        }
    }
}