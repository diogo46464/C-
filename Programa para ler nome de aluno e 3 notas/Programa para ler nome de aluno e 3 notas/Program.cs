using System;
using System.Globalization;
using Programa_para_ler_nome_de_aluno_e_3_notas;

Aluno a = new Aluno();

Console.WriteLine("Nome do Aluno: ");
a.Nome = Console.ReadLine();
Console.WriteLine("Digite as 3 notas do aluno: ");
a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("NOTA FINAL = "
+ a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));


if (a.Aprovado()) {
    Console.WriteLine("APROVADO");
}
else {
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM "
    + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
    + " PONTOS");
}

