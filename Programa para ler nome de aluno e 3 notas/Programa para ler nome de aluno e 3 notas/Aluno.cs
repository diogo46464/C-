using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Programa_para_ler_nome_de_aluno_e_3_notas {
    internal class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() {
            if (NotaFinal() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }
        public double NotaRestante() {
            if (Aprovado()) {
                return 0.0;
            }
            else {
                return 60.0 - NotaFinal();
            }



        }


    }
}
