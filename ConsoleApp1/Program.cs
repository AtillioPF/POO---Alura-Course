using bytebank;

Console.WriteLine("hello");

ContaCorrente conta1 = new ContaCorrente("01423-x", 12, "Unicredit","Atillio Fetter", 1564221.57);

Console.WriteLine("Titular: " + conta1.Titular);
Console.WriteLine("Conta: " + conta1.Conta);
Console.WriteLine("Número Agencia: " + conta1.NumeroAgencia);
Console.WriteLine("Nome Agencia: " + conta1.NomeAgencia);
Console.WriteLine("Saldo: "+ conta1.Saldo);

ContaCorrente conta2 = new ContaCorrente("adw32-ax", 12, "Unicredit", "John Oliveira", 1564221.57);

Console.WriteLine("Titular: " + conta1.Titular);
Console.WriteLine("Conta: " + conta1.Conta);
Console.WriteLine("Número Agencia: " + conta1.NumeroAgencia);
Console.WriteLine("Nome Agencia: " + conta1.NomeAgencia);
Console.WriteLine("Saldo: " + conta1.Saldo);

bool transferencia = conta1.Transferir(250000, conta2);
bool saque = conta1.Sacar(2000);
Console.WriteLine("Saque realizado? "+(saque?"Sim":"Não"));
Console.WriteLine("Transferencia realizada? " + (transferencia ? "Sim" : "Não"));
Console.WriteLine("Saldo: " + conta1.Saldo);
Console.WriteLine("Saldo: " + conta2.Saldo);