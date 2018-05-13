using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosProdLojaMoveis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cadastrar Produto = 1 /n Cadastrar Pedido = 2 \n Sair = 3");
            Operacao operacao = (Operacao)int.Parse(Console.ReadLine());

            switch (operacao)
            {

                case (Operacao)1:
                   
                    break;

                case (Operacao)2:
                                        
                    break;

                case (Operacao)3:

                    break;

                case (Operacao)4:

                    break;

                default:
                    Console.WriteLine("Saindo do programa, tecle enter para sair: ");
                    Console.ReadLine();
                    break;
                
                
            }

            

        }
    }
}
