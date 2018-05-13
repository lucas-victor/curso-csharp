using System;
using PedidosLojaMoveis2Exec.Dominio;
using System.Globalization;


namespace PedidosLojaMoveis2Exec
{
    class Tela
    {

        public static void mostrarMenu()
        {
            Console.WriteLine("1 – Listar produtos ordenadamente");
            Console.WriteLine("2 – Cadastrar produto");
            Console.WriteLine("3 – Cadastrar pedido");
            Console.WriteLine("4 – Mostrar dados de um pedido");
            Console.WriteLine("5 – Sair");
            Console.Write("Digite uma opcao : ");
        }

        public static void imprimeProds()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS: ");

            // Ordena a lista para exibir.
            Program.Produtos.Sort();
            for (int i = 0; i < Program.Produtos.Count; i++)
            {
                Console.WriteLine(Program.Produtos[i].ToString());
            }
            Console.ReadLine();
        }


        public static void cadastrarProdutos()
        {
            Console.WriteLine("Digite os dados do Produto: ");
            Console.Write("Código: ");
            int cod = int.Parse(Console.ReadLine());

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto P = new Produto(cod, descricao, preco);
            Program.Produtos.Add(P);

            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.ReadLine();
        }



        public static void cadastrarPedido()
        {
            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Código: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Quantos itens tem o pedido ? ");
            int qtde = int.Parse(Console.ReadLine());

            //instanciando um novo pedido.
            Pedido pedido = new Pedido(cod, dia, mes, ano);

            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine("Digite os dados do " + (i + 1) + "º item: ");
                Console.Write("Produto(código): ");
                int codProd = int.Parse(Console.ReadLine());
                
                //Verifica se o item pesquisado existe em alguma posição da lista. Caso não exista retornará -1.
                int pos = Program.Produtos.FindIndex(x => x.codProd == codProd);

                if (pos == -1)
                {
                   throw new ModelException("ERRO DE NEGÓCIO, CÓDIGO DO PRODUTO NÂO ENCONTRADO: " + codProd.ToString());
                }

                Console.Write("Quantidade: ");
                int qtdeItem = int.Parse(Console.ReadLine());

                Console.Write("Porcentagem de desconto: ");
                double porcentDesc = double.Parse(Console.ReadLine());

                //instanciando um item de pedido.
                ItemPedido ip = new ItemPedido(qtdeItem, porcentDesc, Program.Produtos[pos], pedido);
                //adicionando o 
                pedido.itens.Add(ip);
                
                // ########## Atenção ##########
                // é possível fazer assim também.
                //pedido.itens.Add(new ItemPedido(qtdeItem, porcentDesc, Program.Produtos[pos], pedido));
                
            }
            Program.Pedidos.Add(pedido);
            Console.WriteLine("Pedido cadastrado com sucesso!");
            Console.ReadLine();
        }

        public static void mostrarDadosPedido()
        {
            Console.Write("Digite o código do pedido: ");
            int codPedi = int.Parse(Console.ReadLine());

            int pos = Program.Pedidos.FindIndex(x => x.codPedi == codPedi);

            if (pos == -1)
            {
                Console.WriteLine("Pedido não encontrado, digite um código válido.");
            }
            else {
               Console.WriteLine(Program.Pedidos[pos]);
               
            }
            Console.ReadLine();
        }


    }
}

