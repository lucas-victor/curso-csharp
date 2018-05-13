using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LargAltDeRetanguloPeriDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;

            r = new Retangulo();

            Console.WriteLine("Informe os valores da Largura do retangulo: ");
            r.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da Altura do retangulo: ");
            r.altura = double.Parse(Console.ReadLine());
            

            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
