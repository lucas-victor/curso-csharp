using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAbsClassPoliOverrideInterf
{
    class Tela
    {
        public static Figuras lerRetangulo()
        {
            try
            {


                //Retangulo Largura e Altura >>  1 = L10.0 A5.0 >> 3 = L4.0 A2.0
                Console.WriteLine("Selecionado Retangulo: ");
                Console.Write("Largura: ");
                double largura = double.Parse(Console.ReadLine());

                Console.Write("altura: ");
                double altura = double.Parse(Console.ReadLine());

                Console.Write("Cor: ");
                Cor cor = (Cor)int.Parse(Console.ReadLine());

                Console.Write("Mes de Construcao: ");
                MesEnum mes = (MesEnum)int.Parse(Console.ReadLine());

                Console.Write("Informa Material? (s/n): ");
                char chcor = char.Parse(Console.ReadLine());

                if (chcor == 's')
                {
                    Console.Write("Material: ");
                    TipoMaterial material = (TipoMaterial)int.Parse(Console.ReadLine());

                    //quebra de linha.
                    Console.WriteLine();

                    //instanciando um objeto abstrato figura como um retangulo, usando polimorfismo.
                    //instanciando o objeto com material.
                    return new Retangulos(largura, altura, cor, mes, material);
                }
                else
                {
                    //quebra de linha.
                    Console.WriteLine();
                    //instanciando um objeto abstrato figura como um retangulo, usando polimorfismo.
                    //adicionando o objeto Retangulo na lista de objetos da superclasse Figuras, podendo ser triangulos ou retangulos oq caracteriza polimorfismo.
                    return new Retangulos(largura, altura, cor, mes);

                }
            }
            catch (Exception e)
            {

                throw new OperacaoException(e.ToString());
            }

        }


        public static Triangulos lerTriangulo()
        {
            try
            {


                //triangulo lados A, B e C. >>  2 = LA3.0 LB4.0 LC5.0
                Console.WriteLine("Selecionado Triangulo: ");
                Console.Write("lado a: ");
                double A = double.Parse(Console.ReadLine());

                Console.Write("Lado b: ");
                double B = double.Parse(Console.ReadLine());

                Console.Write("lado c: ");
                double C = double.Parse(Console.ReadLine());

                Console.Write("Cor: ");
                Cor cor = (Cor)int.Parse(Console.ReadLine());

                Console.Write("Mes Construcao: ");
                MesEnum mes = (MesEnum)int.Parse(Console.ReadLine());

                Console.Write("Informa material? (s/n) ");
                char chMat = char.Parse(Console.ReadLine());

                if (chMat == 's')
                {
                    Console.Write("Material: ");
                    TipoMaterial material = (TipoMaterial)int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    //Adicionando o triangulo com material na lista de abstract class ou superclasse, que é a Figuras.
                    return new Triangulos(A, B, C, cor, mes, material);
                }
                else
                {
                    Console.WriteLine();
                    //instanciando a superclasse Figuras como um objeto Triangulo utilizando polimorfismo.
                    return new Triangulos(A, B, C, cor, mes);
                }
            }
            catch (Exception e)
            {
                throw new OperacaoException(e.ToString());
            }
        }


    }
}
