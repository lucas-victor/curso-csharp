﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevendedoraCarros.Dominio
{
    class Acessorio
    {
        // descrição e um preço >> (um mesmo acessório só é associado e um carro)

        public string descricao { get; set; }
        public double preco { get; set; }
        public Carro carro { get; set; }

        public Acessorio(string descricao, double preco, Carro carro) {
            this.descricao = descricao;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString()
        {
            return descricao
                + ", Preco:"
                + preco
                + ", carro: "
                + carro
                ;
        }
    }
}
