using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] mat;
            
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            //instanciando a matriz declarada anteriormente.
            mat = new int[n, n];
            
            Console.WriteLine("Digite os " + n + " valores separados por espaços: ");

            for (int i = 0; i < n; i++)
            {
                string[] linhas = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(linhas[j]);
                    
                }
            }

            Console.WriteLine();
            Console.WriteLine("Imprimindo a matriz: ");

            
            string todos = " ";
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i,j] + " ");

                    if (mat[i,j] < 0)
                    {
                        cont++;
                    }
                }

                Console.WriteLine();
            }

            Console.ReadLine();

            Console.WriteLine("Imprimindo a diagonal da matriz: ");

            //imprime diagonal da matriz.
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");

            }

            Console.WriteLine();
            Console.ReadLine();


            Console.WriteLine("Quantidade de Números negativos: " + cont);
            Console.ReadLine();




        }
    }
}
