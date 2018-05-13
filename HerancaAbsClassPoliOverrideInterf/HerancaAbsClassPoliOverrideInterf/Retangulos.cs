using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAbsClassPoliOverrideInterf
{
    class Retangulos : Figuras
    {
        //Elemento Atributos
        public double largura { get; set; }
        public double altura { get; set; }

        //Elemento Metodos:
        public Retangulos(double largura, double altura, Cor cor, MesEnum mes) : base(cor, mes)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public Retangulos(double largura, double altura, Cor cor, MesEnum mes, TipoMaterial material) : base(cor, mes, material)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override double area()
        {
            return largura * altura;
        }

        //implementar metodo perimetro sendo triangulo >> a + b + c || Retangulo >> 2 * (largura + altura) >> soma dos 4 lados.
        public override double perimetro()
        {
            return 2 * (largura + altura);
        }

        public override string ToString()
        {
            return "Largura: "
                + largura
                + ", Altura: "
                + altura
                + ", Cor: "
                + cor
                + ", Material: "
                + material
                + ", Mes: "
                + mes
                ;
        }
    }
}
