using System;
using System.Collections.Generic;
using RevendedoraCarros.Dominio;

namespace RevendedoraCarros
{
    class Program
    {
        public static List<Marca> marcasS = new List<Marca>();
        public static List<Carro> carrosS = new List<Carro>();

        static void Main(string[] args)
        {
            int opcao = 0;

            //Instanciando Marcas.
            Marca M1 = new Marca(1001, "Volkswagen", "Alemanha"); ;
            Marca M2 = new Marca(1002, "General Motors", "Estados Unidos");
            //instanciando os carros.
            Carro C1 = new Carro(101, "fusca", 1980, 5000.00, M1);
            M1.addCarro(C1); // adicionando os carros na lista interna da marca.
            Carro C2 = new Carro(102, "Golf", 2016, 60000.00, M1);
            M1.addCarro(C2); // adicionando os carros na lista interna da marca.
            Carro C3 = new Carro(103, "Fox", 2017, 30000.00, M1);
            M1.addCarro(C3); // adicionando os carros na lista interna da marca.
            Carro C4 = new Carro(104, "Cruze", 2016, 30000.00, M2);
            M2.addCarro(C4); // adicionando os carros na lista interna da marca.
            Carro C5 = new Carro(105, "Cobalt", 2015, 25000.00, M2);
            M2.addCarro(C5); // adicionando os carros na lista interna da marca.
            Carro C6 = new Carro(106, "Cobalt", 2015, 35000.00, M2);
            M2.addCarro(C6); // adicionando os carros na lista interna da marca.

            //instanciando acessorios na lista de acessorios do carro C5.
            C5.acessorios.Add(new Acessorio("engate", 200.00));
            C5.acessorios.Add(new Acessorio("Antena", 100.00));


            //adicionando marcas na lista.
            marcasS.Add(M1);
            marcasS.Add(M2);

            //adicionando os carros na lista.
            carrosS.Add(C1);
            carrosS.Add(C2);
            carrosS.Add(C3);
            carrosS.Add(C4);
            carrosS.Add(C5);
            carrosS.Add(C6);


            while (opcao != 7)
            {
                Console.Clear();
                Tela.mostrarMenu();

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //throw new ModelException("Opcao inválida, digite um valor válido! " + e.Message);
                    Console.WriteLine("Opcao inválida, digite um valor válido! " + e.Message);
                    opcao = 0;
                }

                if (opcao == 1)
                {
                    //listar marcas
                    Tela.listarMarcas();
                }
                else if (opcao == 2)
                {
                    try
                    {
                        //Listar carros de uma marca.
                        Tela.listarCarrosUmaMarca();
                    }catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (opcao == 3)
                {
                    try
                    {
                        //cadastrar um marca;
                        Tela.cadastrarMarca();
                    }catch(Exception e)
                    {
                        Console.WriteLine("Não foi possível cadastrar a marca: " + e.Message);
                    }
                }
                else if (opcao == 4)
                {
                    try
                    {
                    // cadastrar um carro;
                    Tela.cadastrarCarro();
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Não foi possível cadastrar um carro: " + e.Message);
                    }
                }
                else if (opcao == 5)
                {
                    try
                    {
                    //cadastrar acessorio;
                    Tela.cadastrarAcessorio();
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Não foi possível cadastrar um acessório: " + e.Message);
                    }
                }
                else if (opcao == 6)
                {
                    try
                    {
                    //mostrar detalhes de um carro:
                    Tela.listarDetalhesUmCarro();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Não foi possível listar os detalhes: " + e.Message);
                    }
                }
                else if (opcao == 7)
                {
                    //saindo do programa.
                    Console.WriteLine("Fim do programa, aperte qualquer tecla para sair.");
                }
                else
                {
                    //aviso para digitar uma opção válida.
                    Console.WriteLine("Opcao digitada inválida.");
                }

                //aguarda o usuário ler antes de limpar a tela.
                Console.ReadLine();
            }


        }
    }
}
