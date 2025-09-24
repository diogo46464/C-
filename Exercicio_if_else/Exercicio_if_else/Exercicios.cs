

namespace Exercicio_if_else;

public class Exercicio() {

    public static void ExerciseOne() {
        Console.WriteLine("Digite o primeirpo número: ");
        int numberOne = int.Parse(Console.ReadLine() ?? "0");

        if (numberOne >= 0) {
            Console.WriteLine("Não negativo");
        }
        else {
            Console.WriteLine("Negativo");
        }
    }

    public static void ExerciseTwo() {
        Console.WriteLine("Digite o número:");
        double number = double.Parse(Console.ReadLine() ?? "0");

        if (number % 2 == 0) {
            Console.WriteLine("O número é par!");
        }
        else {
            Console.WriteLine("O número é impar");

        }
    }

    public static void ExerciseThree() {
        string[] valores = Console.ReadLine().Split(' ');
        int number1 = int.Parse(valores[0]);
        int number2 = int.Parse(valores[1]);

        if(number1 % number2 == 0 || number2 % number1 == 0) {
            Console.WriteLine("Os números são multiplos por eles mesmos");
        }
        else {
            Console.WriteLine("Os números não são multiplos por eles mesmos");
        }
    }

}