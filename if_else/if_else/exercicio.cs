

using System.Security.Cryptography.X509Certificates;

class Exercicio {
    public static void exerciseone() {
        Console.WriteLine("Entre com um número inteiro:");
        int number1 = int.Parse(Console.ReadLine() ?? "0");

        if (number1 % 2 == 0) {
            Console.WriteLine("Par!");
        }

        else {
            Console.WriteLine("Impar!");
        }
    }
    public static void exerciseotwo() {
        Console.WriteLine("Qual a hora atual?");
        double number = double.Parse(Console.ReadLine() ?? "0");

        if (number < 12) {
            Console.WriteLine("Bom dia");
        }
        else if (number < 18) {
            Console.WriteLine("Boa tarde");

        }
        else {
            Console.WriteLine("Boa noite");
        }
    }

    public static void exercisethree() {
        Console.Write("Digite um número qualquer: ");
        double number = double.Parse(Console.ReadLine() ?? "0");

        if(number >= 0) {
            Console.WriteLine("NÃO NEGATIVO");
        }
        else {
            Console.WriteLine("NEGATIVO");
                }
    }
}
    