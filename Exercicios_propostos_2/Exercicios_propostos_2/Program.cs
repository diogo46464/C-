using System;
using System.Globalization;

double R, A, pi = 3.14159;

R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

A = pi * Math.Pow(R, 2);

Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));




