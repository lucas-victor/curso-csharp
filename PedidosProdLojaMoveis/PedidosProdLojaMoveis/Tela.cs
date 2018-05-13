using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosProdLojaMoveis
{
    class Tela
    {
        public static Produto lerProduto()
        {
            //cadastro produto
            Console.WriteLine("Digite os dados do Produto: ");

            Console.Write("Codigo: ");
            int cod = int.Parse(Console.ReadLine());

            Console.Write("Descricao: ");
            string desc = Console.ReadLine();

            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());

            return new Produto(cod, desc, preco);
        }

        public static Pedido lerPedido()
        {
            Console.WriteLine("Digite os dados do Pedido: ");

            Console.Write("Codigo: ");
            int cod = int.Parse(Console.ReadLine());

            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Quantos Itens tem o pedido? ");
            int numPed = int.Parse(Console.ReadLine());


            List<ItemPedido> listItemPedi = new List<ItemPedido>();

            //o 1 será o i do for.
            for (int i = 0; i < numPed; i++)
            {

                Console.WriteLine("Digite os dados do " + (i+1) + " item: ");

                Console.Write("Produto (código): ");
                int codProd = int.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int qtde = int.Parse(Console.ReadLine());

                Console.Write("Porcentagem de Desconto: ");
                double porcent = double.Parse(Console.ReadLine());

                ItemPedido objItemPedi = new ItemPedido(qtde, porcent);

                listItemPedi.Add(objItemPedi)
            }

            return new Pedido();
        }
    }
}
