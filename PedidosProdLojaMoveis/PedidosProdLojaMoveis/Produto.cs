using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosProdLojaMoveis
{
    class Produto 
    {
        public int codProd { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        
        public Produto(int codProd, string descricao, double preco)
        {
            this.codProd = codProd;
            this.descricao = descricao;
            this.preco = preco;

        }

        

        
    }
}
