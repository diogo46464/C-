using System;
using System.Globalization;
using Exercicio_largura_e_altura_do_retângulo;

Retangulo r = new Retangulo();

Console.WriteLine("Entre a largura e a altura do retângulo: ");
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
