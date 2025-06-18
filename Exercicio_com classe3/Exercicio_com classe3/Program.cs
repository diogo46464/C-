using System.Globalization;
using Exercicio_com_classe3;

Funcionario f1 = new Funcionario();
Funcionario f2= new Funcionario();


Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
f1.Name = Console.ReadLine();
Console.Write("Salário: ");
f1.Wage  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
f2.Name = Console.ReadLine();
Console.Write("Salário: ");
f2.Wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (f1.Wage + f2.Wage) / 2.00;

Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));


