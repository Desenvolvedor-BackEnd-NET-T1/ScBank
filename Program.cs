// Crie um sistema que:
// Exibe um menu com opções:
// Depositar
// Sacar
// Ver extrato
// Sair
// O menu deve aparecer pelo menos uma vez.
// O saldo não pode ficar negativo.
// O usuário deve conseguir fazer várias operações até escolher sair.
// O extrato deve exibir todas as entradas e saídas e o saldo da conta 

void ExibirMenu()
{   
    Console.WriteLine("Bem vindos ao ScBank");
    Console.WriteLine("Escolha uma opção para continuar: ");
    Console.WriteLine("A - Depositar");
    Console.WriteLine("B - Sacar");
    Console.WriteLine("C - Ver Extrato");
    Console.WriteLine("D - Sair ");
}

decimal PedirDecimal()
{
    //decimal valor = decimal.Parse(Console.ReadLine());
    bool ehNumero = decimal .TryParse(Console.ReadLine(), out decimal valor);
    while (!ehNumero )
    {
        Console.WriteLine("Valor inválido digite novamente: ");
        ehNumero = decimal.TryParse(Console.ReadLine(), out valor);
    }
    return valor;
}

List<decimal> extrato = new List<decimal>(); 

decimal ObterSaldo()
{
    decimal saldo = 0; 
    foreach(var transacao in extrato)
    {
        saldo += transacao;
    }
    return saldo; 
}

void Depositar()
{
    Console.WriteLine("\nDigite o valor para depositar: \n");
    decimal valor = PedirDecimal();
    extrato.Add(valor);
}

void Sacar()
{
    Console.WriteLine("\nDigite o valor para sacar: \n");
    decimal valor = PedirDecimal();
    if (valor > 0)
    {
        valor = valor *-1;
    }

    if(ObterSaldo()  < valor * -1)
    {
        Console.WriteLine("Saldo Insuficiente \n\n"); 
    }
    else
    {
        extrato.Add(valor);
    }

    
}

void VerExtrato()
{
    Console.WriteLine("\nSegue seu extrato: \n");

    foreach( var transacao in extrato)
    {
        Console.WriteLine(transacao);
    }

    Console.WriteLine("Seu saldo é de: "+ ObterSaldo());
    
}

string opcao; 
do
{
    ExibirMenu();
    opcao = Console.ReadLine();
    if (opcao.ToUpper() == "A") 
    {
        Depositar();
    }
    else if (opcao == "B" || opcao == "b")
    {
        Sacar();
    }
    else if (opcao.ToLower() == "c")
    {
        VerExtrato();
    }
    else if (opcao == "D"|| opcao == "d")
    {}
    else
    {
        Console.WriteLine("opcao invalida, tente novamente");
    }
}while( opcao.ToUpper() != "D");