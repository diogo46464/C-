

namespace Exercicio_for_ {
    public class Funcao {
        public static int ex1(int x) {

            int result = 0;

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }

            }
            return result;
        }
        public static int ex2(int N) {
            int result = 0;
            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < N; i++) {
                int X = int.Parse(Console.ReadLine() ?? "0");
                if (X >= 10 && X <= 20) {

                    cont_in = cont_in + 1;
                }
                else {
                    cont_out = cont_out + 1;
                }

            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
            return result;

        }

        public static int ex3(int N) {
            int result = 0;

            for (int i = 0; i < N; i++) {
                string[] valor = Console.ReadLine().Split(' ');


                double a = double.Parse(valor[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valor[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valor[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
            return result;


        }

        public static int ex4(int N) {
            int result = 0;
            for (int i = 0; i < N; i++) {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            return result;

        }

        public static int ex5(int N) {
            int result = 0;

            int fat = 1;
            for (int i = 1; i <= N; i++) {
                fat = fat * i;
            }

            Console.WriteLine(fat);
            return result;
        }

        public static int ex6(int N) {
            int result = 0;

            for (int i = 1; i <= N; ++i) {

                if (N % i == 0) {
                    Console.WriteLine(i);
                }

            }
            return result;
        }

        public static int ex7(int N) {

            int result = 0;
            for (int i = 1; i <= N; i++) {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
            return result;
        }
    }
}


