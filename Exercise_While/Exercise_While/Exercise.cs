

namespace Exercise_While {
    public class Exercise {
        public static void ex1() {
            string resultado;
            Console.WriteLine("Digite a senha:");
            string senha = Console.ReadLine()??"0";
            resultado = Funcao.senha(senha);
        }
    }
}
