namespace Exercicio_propostos_5;
public class Exercicios {
    public static void exerciceFive() {
        string[] valores = Console.ReadLine().Split(' ');
        int firstCode = int.Parse(valores[0]);
        int firstquantity = int.Parse(valores[1]);
        double firstPrice = double.Parse(valores[2], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        int secondCode = int.Parse(valores[0]);
        int secondQuantity = int.Parse(valores[1]);
        double secondPrice = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double result = firstPrice * firstquantity + secondPrice * secondQuantity;

        Console.WriteLine("Valor a pagar: R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
    }

    public static void exerciceSix() {
        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        Console.WriteLine("TRIANGULO: " + (A * C / 2.0).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + (Math.PI * C * C).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + ((A + B) * C / 2.0).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + (B * B).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + (A * B).ToString("F3", CultureInfo.InvariantCulture));
    }
}

#region
//OBSERVAÇÕES
//CÓDIGO LIMPO
// EM HIPOTESE ALGUMA USE VARIAVEIS COM NUMERO, SOMENTE TEXTO E ELE DEVE SER AUTO EXPLICATIVO
// VARIAVEIS EXCETO BOOLEANO DEVE SER DO TIPO VAR, SALVO OBJETOS DE ENTRADA E RETORNO
// VARIAVEIS DEVEM SER SEPARADAS UMA A UMA E NUNCA ENFILEIRADAS NA MESMA INSTANCIA DE VARIAVEIS
// VARIAVEIS SEMPRE EM INGLES
#endregion