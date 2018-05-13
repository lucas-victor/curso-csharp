using System;
using RevendedoraCarros.Dominio;

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
            Console.ReadLine();

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
            Console.ReadLine();


        }



        /*
        public static void listarCarros()
        {
            Program.carrosS.Sort();
            for (int i = 0; i < Program.carrosS.Count; i++)
            {
                Console.WriteLine(Program.carrosS[i]);
            }
            Console.ReadLine();
        }
        */

    }
}
