using System;
using System.Globalization;
using Exercicios_dados_do_funcionario;

Funcionario f = new Funcionario();


Console.WriteLine("Nome: ");
f.Nome = Console.ReadLine();
Console.WriteLine("Salário bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Imposto: ");
f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine("Funcionário: " + f);
Console.WriteLine();

Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
double pc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(pc);
Console.WriteLine();

Console.WriteLine("Dados atualizados: " + f);