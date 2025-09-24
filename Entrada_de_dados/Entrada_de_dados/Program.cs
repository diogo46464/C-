using System;

namespace Entrada_de_dados {
    class Program {
        static void Main(string[] args) {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();

            string[] vet = s.Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(s);
         
        }
    }
}
