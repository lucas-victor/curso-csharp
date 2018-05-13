using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgProdutoVetClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] vet;
            int qtdProduto;

            double[] vet2 = { 2.0, 2};

            Console.WriteLine("Digite o número de produtos que deseja cadastrar: ");
            qtdProduto = int.Parse(Console.ReadLine());

            //também posso fazer assim. Para ler oq for digitado já convertendo para inteiro e passando para o tamanho do vetor criado.
            //vet = new Produto[int.Parse(Console.ReadLine())];
            vet = new Produto[qtdProduto];


            Console.WriteLine("Digite respectivamente o Nome e o Preco dos produtos: ");

            for (int i = 0; i < qtdProduto; i++) {

                
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                vet[i] = new Produto(nome, preco);

            }

            //double soma = 0.0;

            for (int i = 0; i < qtdProduto; i++)
            {
                //soma += vet[i].preco;

                //vet[i].soma(vet[i].preco);

            }

            
            //estão errados, necessario entender como utilizar uma variável comundo para todos os objetos do mesmo tipo.
            //sem isto, não é possível armazenar uma variável SOMA dentro da classe para receber o valor de todos os produtos.
            //Verificar como fazer a utilização para a implementação abaixo.
            //Console.WriteLine(vet[2].retMedia(qtdProduto).ToString());
            //Console.WriteLine("Este é o preço médio dos produtos: " + vet[0].retMedia(qtdProduto).ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();


        }
    }
}
