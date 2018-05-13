using System.Globalization;

namespace PedidosLojaMoveis2Exec.Dominio
{
    class ItemPedido
    {
        public int qtdItem { get; set; }
        public double porcentDesc { get; set; }
        public Produto produto { get;  set; }
        public Pedido pedido { get; set; }
        
        public ItemPedido(int qtdItem, double porcentDesc, Produto produto, Pedido pedido)
        {
            this.qtdItem = qtdItem;
            this.porcentDesc = porcentDesc;
            this.produto = produto;
            this.pedido = pedido;
        }

        public double subTotal()
        {
            double desconto = produto.preco * porcentDesc / 100.00;
            return (produto.preco - desconto) * qtdItem;
        }


        public override string ToString()
        {
            return produto.descricao
                + ", Preco: "
                + produto.preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Qte: "
                + qtdItem
                + ", Desconto: "
                + porcentDesc
                + "%, Subtotal: "
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
                ;
        }

    }
}
