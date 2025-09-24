using System;
using System.Globalization;
using Conta_Bancaria;


ContaBancaria cont;

Console.Write( "Entre o número da conta: ");
int conta = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char resp = char.Parse(Console.ReadLine());

if (resp == 'S' || resp == 's') {

    Console.Write("Entre o valor de depósito: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    
     cont = new ContaBancaria  (conta, titular, depositoInicial);

}
else {
    
     cont = new ContaBancaria(conta, titular);

}
Console.WriteLine();

Console.WriteLine("Dados da conta atualizados");
Console.WriteLine(cont);


Console.WriteLine();

Console.Write("Entre um valor para deposito: ");
double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
cont.Depositar(deposito);
Console.WriteLine("Dados da conta atualizados");
Console.WriteLine(cont);



Console.WriteLine();

Console.Write("Entre um valor para saque: ");
   deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
cont.Sacar(deposito);
Console.WriteLine("Dados da conta atualizados");
Console.WriteLine(cont);


