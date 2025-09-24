using System;

namespace Conversão_implicita_e_casting {
    class Program {
        static void Main(string[] args) {

            float x = 4.5f;

            double y = x; // Conversão implícita de float para double   
            Console.WriteLine(y);

            //-----------------------------------------------------------

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            //-----------------------------------------------------------

            double c;
            int d;

            c = 5.1;
            d = (int)a;
            Console.WriteLine(d);


            //-----------------------------------------------------------

            int e = 5;
            int f = 2;

            double resultado = (double) e / f;
            Console.WriteLine(resultado);




        }
    }
}