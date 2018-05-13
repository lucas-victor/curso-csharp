using System;
using System.Collections.Generic;
using PedidosLojaMoveis2Exec.Dominio;

namespace PedidosLojaMoveis2Exec
{
    class Program
    {
        public static List<Produto> Produtos = new List<Produto>();
        public static List<Pedido> Pedidos = new List<Pedido>();

        static void Main(string[] args)
        {
            int opcao = 0;

            Produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            Produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            Produtos.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
            Produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            Produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));


            while (opcao != 5)
            {
                //limpa console.
                Console.Clear();
                //Mostra o menu.
                Tela.mostrarMenu();

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERRO INESPERADO: " + e.Message + "\n" + "Digite um valor válido!");
                }
                Console.WriteLine();

                if (opcao == 1)
                {

                    //*/ Imprime os produtos na tela em ordem decrescente. Compara primeiro a descrição e somente se for igual compara e ordena pelo valor.
                    Tela.imprimeProds();
                }
                else if (opcao == 2)
                {
                    //tenta cadastrar produto. Se não conseguir exibe exception.
                    try
                    {
                        Tela.cadastrarProdutos();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Verifique os dados cadastrados. Exibido o seguinte erro: " + e.Message);
                        Console.ReadLine();
                    }
                }
                else if (opcao == 3)
                {
                    //Cadastrar Pedido
                    try
                    {
                        Tela.cadastrarPedido();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Falha ao cadastrar o pedido, verifique os dados e tente novamente. " + e.Message + " ");
                        Console.ReadLine();
                    }
                }
                else if (opcao == 4)
                {
                    try
                    {
                        //Mostrar dados de um pedido.
                        Tela.mostrarDadosPedido();
                    }
                    catch (ModelException e){
                        Console.WriteLine("Erro de negócio." + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro ao exibir o pedido, verifique os dados e tente novamente.");
                        Console.ReadLine();
                    }
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Fim do Programa!");
                }
                else
                {
                    Console.WriteLine("Digitado 0. Por favor, digite de 1 a 5.");
                    Console.ReadLine();
                }

            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadLine();


        }
    }
}

