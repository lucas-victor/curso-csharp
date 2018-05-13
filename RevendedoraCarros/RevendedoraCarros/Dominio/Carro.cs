using System;
using System.Collections.Generic;
using System.Globalization;

namespace RevendedoraCarros.Dominio
{
    class Carro : IComparable
    {
        //código, modelo, ano de fabricação, preço básico e uma marca
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public double precoCompleto { get; private set; }
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

        public void precoTotal()
        {
            //O preço total de um carro é a soma de seu preço básico mais os preços de seus acessórios

            foreach (var carro in Program.carrosS)
            {
                double soma = 0.0;
                soma = carro.precoBasico;
                for (int i = 0; i < acessorios.Count; i++)
                {
                    if (carro.acessorios != null)
                    {
                        soma += acessorios[i].preco;
                    }

                }
                precoCompleto = soma;
            }
        }

        public int CompareTo(object obj)
        {
            Carro c = (Carro)obj;

            int aux = modelo.CompareTo(c.modelo);
            if (aux != 0)
            {
                return aux;
            }
            return -precoCompleto.CompareTo(c.precoCompleto);
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
                + precoCompleto.ToString("F2", CultureInfo.InvariantCulture)
                + "\n Acessórios: ";
            //+ //falta colocar a lista de acessorios

            foreach (var carro in Program.carrosS)
            {
                if (carro.acessorios != null)
                {
                    for (int i = 0; i < carro.acessorios.Count; i++)
                    {
                        s += acessorios[i];
                    }

                }
            }
            return s;
            /*

            Acessórios:
              Engate, Preço: 200.00
             */
        }


    }
}
