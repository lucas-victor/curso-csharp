using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Fornecedor F;
            Produto p;

            #region Dados do fornecedor.
            
            //Como o produto depende do fornecedor, é preciso instaciá-lo primeiro, antes do produto. Erro de inicialização de variável. Tipo produto ser filho do fornecedor.
            Console.WriteLine("Informe os dados do fornecedor: ");
            Console.Write("Nome: ");
            string nomef = Console.ReadLine();

            Console.Write("Email: ");
            string emailf = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefonef = Console.ReadLine();
            
            //instanciando o objeto fornecedor após ter lido os valores com as variáveis auxiliares.
            F = new Fornecedor(nomef, emailf, telefonef);
            Console.WriteLine();

            #endregion
            

            #region Dados do Produto.

            Console.WriteLine("Informe os dados do produtos: ");
            Console.Write("Nome: ");
            string nomep = Console.ReadLine();

            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Deseja informar quantidade (s/n)? ");
            char ch = char.Parse(Console.ReadLine());

            if (ch == 's')
            {
                Console.Write("Informe a quantidade de produtos: ");
                int qtd = int.Parse(Console.ReadLine());
                
                //instanciando o objeto produto após ter lido os valores com as variáveis auxiliares.
                p = new Produto(nomep, preco, qtd, F);
                Console.WriteLine(p);
            }
            else
            {
                p = new Produto(nomep, preco, F);
                Console.WriteLine(p);
            }
            


            // imprimindo o produto contendo os dados da classe fornecedor, como sendo um atributo do produto.
            // no diagrama UML, vem o produto contendo o fornecedor... tipo assim: Classe Produto ---------> Classe Fornecedor.

            Console.WriteLine();

            #endregion

            Console.ReadLine();


        }
    }
}
