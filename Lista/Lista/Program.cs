using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lista = new List<string>();

            Produto p;

            lista.Add("joão");
            lista.Add("maria");
            lista.Add("josé");
            lista.Add("lucas");

            int pos = lista.FindIndex(x => x == "lucas");

            Console.WriteLine(pos);



            Console.ReadLine();


        }
    }
}
