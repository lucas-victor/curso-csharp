using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x;

            PontoStruct P;
            int n;
            /* Continuado no programa de produtos conforme exemplo do video sobre vetores do curso da Udemy.
            Console.WriteLine("Digite o número de alturas que deseja cadastrar: ");
            n = int.Parse(Console.ReadLine());

            Conta[] vet;
            vet = new Conta[n];


            for (int i = 0; i <= vet.Length; i++) {

                int num = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();

                vet[i] = new Conta(num, name);
            }

            
            vet = new Conta[10];

            for (int i = 0; i < vet.Length; i++)
            {
                string no = Console.ReadLine();
                vet[i] = new Conta(i, no);
            }
            //*/


            Console.Write("digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n): ");
            char depInicial = char.Parse(Console.ReadLine());


            if (depInicial == 's')
            {
                Console.Write("digite o saldo da conta: ");
                double saldo = double.Parse(Console.ReadLine());

                x = new Conta(numero, nome, saldo);

                Console.WriteLine(x);

                Console.ReadLine();
            }
            else if (depInicial == 'n')
            {
                x = new Conta(numero, nome);

                Console.WriteLine(x);

                Console.ReadLine();
            }
            else
                Console.WriteLine("digite um valor correto (s/n).");
           



            Console.ReadLine();


        }
    }
}
