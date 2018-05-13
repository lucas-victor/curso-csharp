using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosProdLojaMoveis
{
    class Pedido
    {
        public int codPedi { get; set; }
        public int dia { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }

        public ItemPedido itemPeido { get; set; }

        //public string produtosVendidos { get; set; }

        List<Produto> listaProdPedido = new List<Produto>();
        public double porcentDesc { get; set; }

        public Pedido(int codPedi, int dia, int mes, int ano, string produtosVendidos) {
            this.codPedi = codPedi;
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
            //this.produtosVendidos = produtosVendidos;
            
        }


        
    }
}
