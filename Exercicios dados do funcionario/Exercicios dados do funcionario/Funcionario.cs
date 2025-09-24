using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios_dados_do_funcionario {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido() {

            double SL = SalarioBruto - Imposto;
            return SL;

        }

        public void AumentarSalario(double porcentagem) {

          SalarioBruto = SalarioBruto +  (SalarioBruto * porcentagem / 100.0);


        }

        public override string ToString() {

            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
            
        
        
        }

    }
}
