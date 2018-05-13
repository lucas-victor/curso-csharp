using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosProdLojaMoveis
{
    class ItemPedido 
    {
        public int qtdItem { get; set; }
        public double porcentDesc { get; set; }

        public Pedido pedido { get; set; }
        public Produto produto { get; private set; }



        public ItemPedido(int qtdItem, double porcentDesc) {
            this.qtdItem = qtdItem;
            this.porcentDesc = porcentDesc;
        }

        public ItemPedido(Produto produto, int qtdItem, double porcentDesc)
        {
            this.produto = produto;
            this.qtdItem = qtdItem;
            this.porcentDesc = porcentDesc;
            
        }



        public void subTotal() {

        }
    }
}
