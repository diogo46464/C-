using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_largura_e_altura_do_retângulo {
    internal class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {

            double A = Largura * Altura;
            return A;
        }

        public double Perimetro() {

            double P = 2 * (Largura + Altura);

            return P;
        }

        public double Diagonal() {

            double D = Math.Sqrt((Largura * Largura) + (Altura * Altura));

            return D;
        }

    }
}
