using System;
using System.Collections.Generic;
using System.Globalization;


namespace PedidosLojaMoveis2Exec.Dominio
{
    class Pedido
    {
        public int codPedi { get; set; }
        public DateTime date { get; set; }
        public List<ItemPedido> itens { get; set; }

        //public string produtosVendidos { get; set; }

        public Pedido(int codPedi, int dia, int mes, int ano)
        {
            this.codPedi = codPedi;
            this.date = new DateTime(ano, mes, dia);
            itens = new List<ItemPedido>();
        }

        public double valorTotal()
        {
            double soma = 0.0;
            for (int i = 0; i < itens.Count; i++)
            {
                soma += itens[i].subTotal();
            }

            return soma;
        }

        public override string ToString()
        {
            String s = "Pedido "
                + codPedi
                + ", Data: " + date.Day + "/" + date.Month + "/" + date.Year + "\n"
                + "Itens:\n"
                ;

            //imprime itens do pedido.
            for (int i = 0; i < itens.Count; i++)
            {
                s = s + itens[i] + "\n";
            }

            s = s
                + "Total do Pedido: "
                + valorTotal().ToString("F2", CultureInfo.InvariantCulture)
                ;

            return s;
            
        }


    }
}
