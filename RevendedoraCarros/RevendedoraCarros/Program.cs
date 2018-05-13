using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Carro C1 = new Carro(101, "fusca", 1980, 5000.00, M1); ;
            Carro C2 = new Carro(102, "Golf", 2016, 60000.00, M1);
            Carro C3 = new Carro(103, "Fox", 2017, 30000.00, M1);
            Carro C4 = new Carro(104, "Cruze", 2016, 30000.00, M2);
            Carro C5 = new Carro(105, "Cobalt", 2015, 25000.00, M2);
            Carro C6 = new Carro(106, "Cobalt", 2015, 35000.00, M2);
           
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
                catch(ModelException e)
                {
                    //throw new ModelException("Opcao inválida, digite um valor válido! " + e.Message);
                    Console.WriteLine("Opcao inválida, digite um valor válido! " + e.Message);
                }

                if (opcao == 1)
                {
                    Tela.listarMarcas();
                }
                else if (opcao == 2)
                {
                    Tela.listarCarrosUmaMarca();
                }
                else if (opcao == 3)
                {

                }
                else if (opcao == 4)
                {
                }
                else if (opcao == 5)
                {
                }
                else if (opcao == 6)
                {

                }
                else if (opcao == 7)
                {
                    Console.WriteLine("Fim do programa, aperte qualquer tecla para sair.");
                }
                else
                {
                    Console.WriteLine("Opcao digitada inválida.");
                }
                    
                 Console.ReadLine();
            }

            
        }
    }
}
