using System.Globalization;
using System;
using Membros_Estáticos;

Console.Write("Qual acotação do dolar: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você ira comprar: ");
double quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double result = ConversorDeMoeda.DolarParaReal(quantidade, valor);

Console.Write("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
    