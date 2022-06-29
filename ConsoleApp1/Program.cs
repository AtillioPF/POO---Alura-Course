using bytebank;

Console.WriteLine("Hello, Welcome to bytebank!! \n");

//ContaCorrente conta1 = new ContaCorrente("01423-x", 12, "Unicredit", new Cliente("Atillio Fetter", "123322123", "Programador"));

//Console.WriteLine("Titular: " + conta1.cliente.Nome);
//Console.WriteLine("Conta: " + conta1.Conta);
//Console.WriteLine("Número Agencia: " + conta1.NumeroAgencia);
//Console.WriteLine("Nome Agencia: " + conta1.NomeAgencia);
//Console.WriteLine("Saldo: " + conta1.Saldo);

//ContaCorrente conta2 = new ContaCorrente("adw32-ax", 12, "Unicredit", new Cliente("John Oliveira", "12ada2123", "Programador"));

//Console.WriteLine("Titular: " + conta1.cliente.Nome);
//Console.WriteLine("Conta: " + conta1.Conta);
//Console.WriteLine("Número Agencia: " + conta1.NumeroAgencia);
//Console.WriteLine("Nome Agencia: " + conta1.NomeAgencia);
//Console.WriteLine("Saldo: " + conta1.Saldo);

//bool transferencia = conta1.Transferir(250000, conta2);
//bool saque = conta1.Sacar(2000);
//Console.WriteLine("Saque realizado? " + (saque ? "Sim" : "Não"));
//Console.WriteLine("Transferencia realizada? " + (transferencia ? "Sim" : "Não"));
//Console.WriteLine("Saldo de " + conta1.cliente.Nome + ": " + conta1.Saldo);
//Console.WriteLine("Saldo de " + conta2.cliente.Nome + ": " + conta2.Saldo);


ContaCorrente conta3 = new ContaCorrente("asdasd-as",12,"Banco Central");
conta3.Titular = new Cliente("Atillio", "123213","Jogador Caro");
conta3.Depositar(300);
Console.WriteLine("Saldo Conta de "+conta3.Titular.Nome+": " +conta3.Saldo);