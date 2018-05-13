using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ProgProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            p = new Produto();

            string nome;
            double preco;
            int qtd;

            Console.WriteLine("Digite os dados do produto: ");

            Console.Write("Nome: " + p.nome);
            nome = Console.ReadLine();
                                    
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: " );
            qtd = int.Parse(Console.ReadLine());


            p = new Produto(nome, preco, qtd);
            

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Realize a entrada de quantidades para o produto: ");
            p.realizarEntrada(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do produto: " + p);
            Console.ReadLine();

            Console.WriteLine("Realiza a saída de quantidades para o produto: ");
            p.realizarSaida(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do produto: " + p);
            Console.ReadLine();

        }
    }
}
