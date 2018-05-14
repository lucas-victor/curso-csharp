using System;
using System.Collections.Generic;
using System.Globalization;
using RevendedoraCarros;

namespace RevendedoraCarros.Dominio
{
    class Carro : IComparable
    {
        //código, modelo, ano de fabricação, preço básico e uma marca
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public Marca marca { get; set; }
        public List<Acessorio> acessorios { get; set; }


        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
            this.acessorios = new List<Acessorio>();
        }

        public double precoTotal()
        {
            //O preço total de um carro é a soma de seu preço básico mais os preços de seus acessórios
            double somaTotal = precoBasico;

            for (int i = 0; i < acessorios.Count; i++)
            {
                somaTotal += acessorios[i].preco;
            }
            return somaTotal;
        }

        public static void imprimirAcessorios(int codCarro)
        {
            Console.WriteLine("Acessórios: ");
            foreach (var carro in Program.carrosS)
            {
                if (codCarro == carro.codigo)
                {
                    for (int i = 0; i < carro.acessorios.Count; i++)
                    {
                        if (carro.acessorios[i] != null)
                        {
                            Console.WriteLine(carro.acessorios[i].ToString());
                        }
                    }
                }
            }
        }

        public override string ToString()
        {

            String s;

            s = codigo
                + ", "
                + modelo
                + ", Ano: "
                + ano
                + ", Preço Básico: "
                + precoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + ", Preço Total: "
                + precoTotal().ToString("F2", CultureInfo.InvariantCulture);

            //+ //falta colocar a lista de acessorios


            return s;

        }

        public int CompareTo(object obj)
        {
            Carro outro = (Carro)obj;
            int aux = modelo.CompareTo(outro.modelo);

            if (aux != 0)
            {
                return aux;
            }

            return -precoTotal().CompareTo(outro.precoTotal());

        }
    }


}

