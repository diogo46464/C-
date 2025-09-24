using System;
using System.Globalization;
using Exercicio_com_metodos;

Produto  p = new Produto();


Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
p.Nome = Console.ReadLine()??" ";
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();

Console.Write("Digite o numero de produtos a ser adicionado ao estoque:");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine("Dados atualizado: " + p);

Console.WriteLine();

Console.Write("Digite o numero de produtos a ser removido do estoque:");
 qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);


Console.WriteLine();
Console.WriteLine("Dados atualizado: " + p);
