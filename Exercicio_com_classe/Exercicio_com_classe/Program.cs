﻿using System.Globalization;
using Exercicio_com_classe;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X:");

 x.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y:");

y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();
double areaY = y.Area();

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY) {
    Console.WriteLine("Maior área é: X");
}
else {
    Console.WriteLine("Maior área é: Y");
}