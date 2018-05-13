using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LerNumerosInfinity
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite quantos números vc quiser:");


            int idade = 0;
            int soma = 0;
            int count = 0;
            double media;


            idade = int.Parse(Console.ReadLine());
            if (idade <= 0)
            {
                Console.WriteLine("A idade é menor que ou igual a 0, digite uma idade correta.");
                Console.ReadLine();

                
            }

            while (idade > 0)
            {
                soma += idade;
                count++;

                idade = int.Parse(Console.ReadLine());
                if (count == 5)
                {
                    break;
                }
            }

            if (soma > 0)
            {
                media = (double)soma / count;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

















        }
    }
}
