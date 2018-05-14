using System;
using RevendedoraCarros.Dominio;
using System.Collections.Generic;
using System.Globalization;

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
                Console.WriteLine(Program.marcasS[i]);
            }

        }

        public static void listarDetalhesUmCarro()
        {
            Console.Write("Digite o código do carro: ");
            int cod = int.Parse(Console.ReadLine());
            int pos = Program.carrosS.FindIndex(x => x.codigo == cod);
            if (pos == -1)
            {
                throw new ModelException("Carro não encontrado (código): " + cod);
            }

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
            Console.Write("Digite o código da marca: ");
            int codM = int.Parse(Console.ReadLine());

            int pos = Program.marcasS.FindIndex(x => x.codigo == codM);
            if (pos == -1)
            {
                throw new ModelException("Marca não encontrada: " + codM);
            }

            Marca M = Program.marcasS[pos];
            Console.WriteLine("Carros da marca " + M.nome + ": ");
            List<Carro> lista = Program.marcasS[pos].carros;

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(M.carros[i].ToString());
            }
            
        }

        public static void cadastrarAcessorio()
        {
            Console.WriteLine("Digite os dados do acessório: ");
            Console.Write("Carro (codigo): ");
            int carCod = int.Parse(Console.ReadLine());
            int pos = Program.carrosS.FindIndex(x => x.codigo == carCod);
            if (pos == -1)
            {
                throw new ModelException("Carro correspondente ao código digitado não encontrado. Por favor,Verifique o código digitado.");
            }
            Console.Write("Descrição: ");
            string desc = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //pegando o carro instanciado na posição da lista e adicionando o acessorio na lista deste carro.
            Program.carrosS[pos].acessorios.Add(new Acessorio(desc, preco));
        }


        public static void cadastrarCarro()
        {
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (código): ");
            int codM = int.Parse(Console.ReadLine());
            int pos = Program.carrosS.FindIndex(x => x.codigo == codM);
            if (pos == -1)
            {
                throw new ModelException("A código da marca digitada é inválido.");
            }

            Console.Write("Código do carro: ");
            int codC = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Preço básico: ");
            double preco = double.Parse(Console.ReadLine());

            // instanciando a marca encontrada o carro e adicionando nas listas.
            Marca M = Program.marcasS[pos];
            Carro c = new Carro(codC, modelo, ano, preco, M);
            M.addCarro(c);
            Program.carrosS.Add(c);

        }

        public static void cadastrarMarca()
        {
            Console.WriteLine("Digite os dados da marca: ");
            Console.Write("Código: ");
            int codM = int.Parse(Console.ReadLine());
            int pos = Program.marcasS.FindIndex(x => x.codigo == codM);
            if (pos != -1)
            {
                throw new ModelException("Existe uma marca cadastrada com este código, por favor, digite outro.");
            }

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("País de origem: ");
            string pais = Console.ReadLine();

            Program.marcasS.Add(new Marca(codM, nome, pais));
            Console.WriteLine("Marca cadastrada com sucesso!");

        }



        //fim class
    }
}
