using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(1);
            A.Add(2);
            A.Add(3);
            A.Add(4);

            B.Add(5);
            B.Add(6);
            B.Add(2);
            B.Add(1);

            //UnionWith
            //IntersectWith
            //ExceptWith

            A.UnionWith(B);

            //Conjuntos não tem index, por isso é preciso para imprimir todos utilizar o foreach.

            foreach (int x in A) {

                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
