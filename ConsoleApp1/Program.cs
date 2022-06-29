using bytebank;

Console.WriteLine("hello");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Atillio";
conta1.conta = "0asd-a";
conta1.numeroAgencia = 12;
conta1.nomeAgencia = "asdasd";
conta1.saldo = 9884034.09;


Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agencia: " + conta1.numeroAgencia);
Console.WriteLine("Nome Agencia: " + conta1.nomeAgencia);
Console.WriteLine("Saldo: "+ conta1.saldo);

bool saque = conta1.Sacar(2000);
Console.WriteLine("Saque realizado? "+(saque?"Sim":"Não"));
Console.WriteLine("Saldo: " + conta1.saldo);