using ScBank;

var contaDoArthur = new Conta("Arthur");

contaDoArthur.Depositar(1000);
contaDoArthur.Sacar(500);
contaDoArthur.imprimirExtrato();

var contaDaMaria = new Conta("Maria");
contaDaMaria.Depositar(2000);
contaDaMaria.Sacar(500);
contaDaMaria.imprimirExtrato();


contaDoArthur.Depositar(5000);
contaDoArthur.imprimirExtrato();