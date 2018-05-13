using System;
using System.Globalization;
using System.Collections.Generic;

namespace Lista
{
    class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        private int quantidadeEmEstoque { get; set; }
        
        /*
        exemplo do get e set
            public string getNome() {
            return this.nome;
        }
        //*/

        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
        }

        public Produto()
        {
        }

        public double valorTotalEmEstoque()
        {
            return quantidadeEmEstoque * preco;
        }

        public void realizarEntrada(int qtd)
        {
            quantidadeEmEstoque += qtd;
        }

        public void realizarSaida(int qtd)
        {
            quantidadeEmEstoque -= qtd;
        }


        public override string ToString()
        {
            return "Nome: "
                + nome
                + ", R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + quantidadeEmEstoque.ToString()
                + ", Total: "
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}

