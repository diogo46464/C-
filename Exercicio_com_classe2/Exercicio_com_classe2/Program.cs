using System.Globalization;
using Exercicio_com_classe2;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();



     
Console.WriteLine("Dados da primeira pessoa:");
Console.WriteLine("Nome: ");
p1.Name = Console.ReadLine()??"";
Console.WriteLine("Idade: ");
p1.age = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Dados da segunda pessoa:");
Console.WriteLine("Nome: ");
p2.Name = Console.ReadLine() ?? "";
Console.WriteLine("Idade: ");
p2.age = int.Parse(Console.ReadLine() ?? "0");

if (p1.age > p2.age) {
    Console.WriteLine("Pessoa mais velha: " + p1.Name);
}
else {
    Console.WriteLine("Pessoa mais velha: " + p2.Name);
}
