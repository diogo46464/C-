﻿using System;
using System.Globalization;
using System.Xml.Linq;



double xA, xB, xC, yA, yB, yC;

Console.WriteLine("Entre com as medidas do triângulo X:");

xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y:");

yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2.00;

double areaX= Math.Sqrt(p*(p-xA)*(p-xB)*(p-xC));

 p = (yA + yB + yC) / 2.00;

double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

Console.WriteLine("Área de X = " + areaX.ToString("F4",CultureInfo.InvariantCulture) );

Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if(areaX > areaY) {
    Console.WriteLine("Maior área é: X");
}
else {
    Console.WriteLine("Maior área é: Y");
}



