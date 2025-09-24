

namespace Exercise_While {
    public class Funcao {
        public static string senha(string senha) {
            string resultado="";

            string login = "2002";
            
            while (senha != login) {
                Console.WriteLine("Senha Invalida");
                senha = Console.ReadLine()??"0";
            }

            Console.WriteLine("Acesso Permitido");
            return resultado;
        }
      
    }
    }

