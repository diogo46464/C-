using System;
using System.Globalization;

int numero, hora;
 double  valor_hora, salario;

numero = int.Parse(Console.ReadLine());
hora = int.Parse(Console.ReadLine());
valor_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

salario = valor_hora * hora;
Console.WriteLine("NUMBER = " + numero);
Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));