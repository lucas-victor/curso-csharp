using System;
using RevendedoraCarros.Dominio;
using System.Collections.Generic;

namespace RevendedoraCarros
{
    class Tela
    {
        public static void mostrarMenu()
        {

            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente*");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");

            //*/
        }

        public static void listarMarcas()
        {
            Console.WriteLine("LISTAGEM DE MARCAS: ");

            for (int i = 0; i < Program.marcasS.Count; i++)
            {
                int soma = 0;
                foreach (var item in Program.carrosS)
                {
                    if (item.marca.nome == Program.marcasS[i].nome)
                    {
                        soma += 1;
                    }
                }
                Console.WriteLine(Program.marcasS[i] + "Número de Carros: " + soma);
            }

        }

        public static void listarDetalhesUmCarro()
        {
            Console.Write("Digite o código do carro: ");
            int cod = int.Parse(Console.ReadLine());

            foreach (var carro in Program.carrosS)
            {
                if (cod == carro.codigo)
                {
                    Console.WriteLine(carro.ToString());
                    Carro.imprimirAcessorios(cod);
                }
            }

        }


        public static void listarCarrosUmaMarca()
        {
            Console.WriteLine("Digite o código da marca: ");
            int codUser = int.Parse(Console.ReadLine());
            Program.carrosS.Sort();

            for (int i = 0; i < Program.marcasS.Count; i++)
            {
                if (codUser == Program.marcasS[i].codigo)
                {
                    string auxMarca = Program.marcasS[i].nome;

                    for (int j = 0; j < Program.carrosS.Count; j++)
                    {
                        if (auxMarca == Program.carrosS[j].marca.nome)
                        {
                            Console.WriteLine(Program.carrosS[j].ToString());
                        }

                    }

                }
            }

        }

        public static void cadastrarAcessorio()
        {
            Console.WriteLine("Digite os dados do acessório: ");
            Console.Write("Carro (codigo): ");
            int carCod = int.Parse(Console.ReadLine());

            Console.Write("Descrição: ");
            string desc = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            for (int i = 0; i < Program.carrosS.Count; i++)
            {
                if (carCod == Program.carrosS[i].codigo)
                {
                    Program.carrosS[i].acessorios.Add(new Acessorio(desc, preco));
                }
            }
        }


        public static void cadastrarCarro()
        {
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (código): ");
            int codM = int.Parse(Console.ReadLine());
            Marca marca = null;

            for (int i = 0; i < Program.marcasS.Count; i++)
            {
                if (codM == Program.marcasS[i].codigo)
                {
                    marca = Program.marcasS[i];
                }
            }

            if (marca != null)
            {
                Console.Write("Código do carro: ");
                int codC = int.Parse(Console.ReadLine());
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Ano: ");
                int ano = int.Parse(Console.ReadLine());
                Console.Write("Preço básico: ");
                double preco = double.Parse(Console.ReadLine());

                Carro c = new Carro(codC, modelo, ano, preco, marca);
                Program.carrosS.Add(c);
            }
            else
            {
                Console.WriteLine("Digite uma marca existente ou cadastre uma nova marca antes.");
            }

        }

        public static void cadastrarMarca()
        {
            int aux = 0;
            while (aux == 0)
            {
                Console.WriteLine("Digite os dados da marca: ");
                Console.Write("Código: ");
                int codM = int.Parse(Console.ReadLine());

                for (int i = 0; i < Program.marcasS.Count; i++)
                {
                    if (codM == Program.marcasS[i].codigo)
                    {
                        aux = 1;
                    }
                }

                if (aux == 1)
                {
                    Console.WriteLine("O Código desta marca já existe, digite outro.");
                    Console.WriteLine();
                    aux = 0;
                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("País de origem: ");
                    string pais = Console.ReadLine();
                    aux = 1;
                    Program.marcasS.Add(new Marca(codM, nome, pais));
                    Console.WriteLine("Marca cadastrada com sucesso!");
                }
            }
        }



        //fim class
    }
}
