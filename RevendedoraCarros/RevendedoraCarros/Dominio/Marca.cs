using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevendedoraCarros.Dominio
{
    class Marca
    {
        // Cada marca possui um código, nome e país de origem

        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<Carro> carros { get; set; }

        public Marca(int codigo, string nome, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            carros = new List<Carro>();
        }


        public override string ToString()
        {
            return codigo
                + ", "
                + nome
                + ", "
                + "País: "
                + pais
                + ", "
                ;
        }
    }
}
