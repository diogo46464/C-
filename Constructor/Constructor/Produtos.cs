﻿using System.Globalization;

namespace Constructor {
     class Produtos {



        public string Nome;
        public double Preco;
        public int Quantidade;


        public Produtos() {

        }

        public Produtos(string nome, double preco) {
            Nome = nome;
            Preco = preco;
           
        }

        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + "unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
