using System;

double? x = null;
double? y = 10.0;

Console.WriteLine(x.GetValueOrDefault());

Console.WriteLine(y.GetValueOrDefault());