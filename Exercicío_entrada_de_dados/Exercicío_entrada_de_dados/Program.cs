using System;
using System.Globalization;

Console.WriteLine("Digite seu nome completo:");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int numeroQuartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre seu último nome, idade e altura (mesma linha) :");
string[] dados = Console.ReadLine().Split(' ');
string ultimoNome = dados[0];
int idade = int.Parse(dados[1]);
double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

Console.WriteLine(nomeCompleto);
Console.WriteLine(numeroQuartos);
Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));