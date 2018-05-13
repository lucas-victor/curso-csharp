using System;
using System.Globalization;

namespace Associacao
{
    class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidadeEmEstoque { get; private set; }
        public Fornecedor fornecedor { get; private set; }

        /*
        exemplo do get e set
        public string getNome() {
            return this.nome;
        }
        //*/

        public Produto(string nome, double preco, int quantidadeEmEstoque, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
            this.fornecedor = fornecedor;
        }

        public Produto(string nome, double preco, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
            this.fornecedor = fornecedor;
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
            return nome
                + ", R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + quantidadeEmEstoque.ToString()
                + ", Total: "
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + ", Fornecedor: "
                + fornecedor
                ;

        }

    }
}
