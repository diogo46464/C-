using System;

int UM, B, C, D,dif;

UM = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());
C = int.Parse(Console.ReadLine());

D = int.Parse(Console.ReadLine());

dif = UM * B - C * D;
Console.WriteLine("Diferença =" + dif);