using System;
using System.Globalization;

namespace PedidosLojaMoveis2Exec.Dominio
{
    class Produto : IComparable
    {
        public int codProd { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }

        public Produto(int codProd, string descricao, double preco)
        {
            this.codProd = codProd;
            this.descricao = descricao;
            this.preco = preco;

        }

        public override string ToString()
        {
            return codProd
                + ", "
                + descricao
                + ", "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }

        public int CompareTo(object obj)
        {
            Produto outro = (Produto)obj;
            int resultComp = descricao.CompareTo(outro.descricao);

            if (resultComp != 0)
            {
                //resultComp;
                return codProd.CompareTo(outro.codProd);
            }
            else {

                return -preco.CompareTo(outro.codProd); //-preco.CompareTo(outro.preco);
            }
        }
    }
}
