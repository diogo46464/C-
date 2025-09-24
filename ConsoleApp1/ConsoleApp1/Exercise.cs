using System;


namespace ConsoleApp1 {
    public class Exercise {
        public static void ex1() {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine()??"0");
            int n2 = int.Parse(Console.ReadLine()??"0");
            int n3 = int.Parse(Console.ReadLine()??"0");
            double resultado = Funcao.Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
        }
    }
}
