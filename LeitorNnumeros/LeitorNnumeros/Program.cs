using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace LeitorNnumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double x, y, div;

            Console.WriteLine("Digite o número de divisoes: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite 1 par de números separados por espaço para divisão:");
                string[] vet = Console.ReadLine().ToString().Split(' ');

                x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);

                if (y == 0.0)
                {
                    div = x / y;

                    Console.WriteLine("O resultado da divisão é: " + div.ToString("F4", CultureInfo.InvariantCulture));
                    Console.ReadLine();
                }
                
            }

            Console.ReadLine();
        }
    }
}
