using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace HerancaAbsClassPoliOverrideInterf
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Figuras> lista = new List<Figuras>();

            Console.Write("Quantas figuras voce deseja calcular? ");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Figura " + (i + 1) + " - tringulo ou retangulo (t/r): ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'r')
                {
                    //declarando variável f do tipo da abstract class Figuras, para armazenar o objeto retangulo.
                    Figuras f = Tela.lerRetangulo();

                    //adicionando o objeto na lista de objetos da superclasse Figuras, podendo ser triangulos ou retangulos.
                    lista.Add(f);
                }
                else
                {
                    Figuras f = Tela.lerTriangulo();

                    //adicionando o objeto na lista de objetos da superclasse Figuras, podendo ser triangulos ou retangulos.
                    lista.Add(f);
                }

            }


            Console.WriteLine("Dados e areas das Figuras: ");

            for (int i = 0; i < lista.Count; i++)
            {
                //exibe os dados da figura.
                Console.WriteLine("Dados Calculados: " + lista[i].ToString());
                //Resultado do calculo da area.
                Console.WriteLine("Figura " + (i + 1) + ": " + lista[i].area().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
