namespace ScBank
{
    public class Funcionario : Pessoa
    {
        
        public int NumeroMatricula { get; set; }
        public string Funcao { get; set; }
      

        public Funcionario() 
        {
            NumeroMatricula = new Random().Next();
        }

        public static Funcionario CriarEPreencherFuncionario()
        {
            Funcionario funcionarioObj = new Funcionario();
            funcionarioObj.Preencher();
            return funcionarioObj;
        }

        public  override  void Preencher()
        {
            Console.WriteLine("Cadastro de Funcionario");
            base.Preencher();
            Console.WriteLine("Digite a Função: ");
            Funcao = Console.ReadLine();
        }

        public override void Imprimir()
        {

            //base ele existe para toda classe filha e carrega o contexto do pai. 
            //ou seja voce consegue acessar as propriedades, métodos e construtor do pai diretamente 
            // util especialmente para chamar metodos virtuais que foram sobre escritos, asssim temos 
            // o comportamento sobreescrito + o comportamento padrão do pai. 
            base.Imprimir();
            Console.WriteLine("Matricula: "+ NumeroMatricula);
            Console.WriteLine("Funcao: "+ Funcao);            
        }
    }
}