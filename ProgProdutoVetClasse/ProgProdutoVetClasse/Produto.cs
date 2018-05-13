using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgProdutoVetClasse
{
    class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public double media {get; private set;}
        public double sum { get; private set; }

        
        public Produto(string nome, double preco) {
            this.nome = nome;
            this.preco = preco;
        }

        public Produto(string nome) {
            this.nome = nome;
            preco = 0.0;
        }

        public void soma(double soma) {

            this.sum += soma; 
        }

        public double retMedia(int qtde) {

            this.media = sum / qtde;

            return media;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
