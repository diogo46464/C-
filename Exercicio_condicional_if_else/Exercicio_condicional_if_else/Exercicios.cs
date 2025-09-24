

using System.Security.Cryptography.X509Certificates;

namespace Exercicio_condicional_if_else {
    public class Exercicios {

        public static void exerciseone() {
            Console.WriteLine("Digite um número e veja se ele é positivo ou negativo");
            double number = double.Parse(Console.ReadLine() ?? "");

            Console.WriteLine(number < 0 ? "Negativo" : "Não negativo!");
        }

        public static void exercisetwo() {
            Console.WriteLine("Digite um número e verifique se ele é um número par ou impar:");
            double number = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine(number % 2 == 0 ? "Número par" : "Número impar");

        }

        public static void exercisethree() {

            string[] valores = (Console.ReadLine() ?? "").Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("São multiplos");
            }
            else {
                Console.WriteLine("Não são multiplos");
            }


        }

        public static void exercisefour() {

            string[] valores = (Console.ReadLine() ?? "").Split(' ');
            int horaInicial = int.Parse((string)valores[0]);
            int horaFinal = int.Parse((string)valores[1]);

            int durasao;

            if (horaInicial < horaFinal) {
                durasao = horaFinal - horaInicial;

            }
            else {
                durasao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O Jogo durou " + durasao + " hora(s)");
        }

        public static void exercisefive() {
            string[] valores = (Console.ReadLine()??"").Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;

            if (codigo == 1) {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) {
                total = quantidade * 4.5;
            }
            else if (codigo == 3) {
                total = quantidade * 5.0;
            }
            else if (codigo == 4) {
                total = quantidade * 2.0;
            }
            else {
                total = quantidade * 1.5;
            }

            Console.WriteLine($"Total : R${total}");
        }

 
        public static void exercisesix() {
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0) {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            }
            else {
                Console.WriteLine("Intervalo (75,100]");
            }

        }
        public static void exerciseven() {
            string[] valores = (Console.ReadLine()??"").Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
        }
        public static void exerciseeight() {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0) {
                imposto = 0.0;
            }
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
        
    }
}