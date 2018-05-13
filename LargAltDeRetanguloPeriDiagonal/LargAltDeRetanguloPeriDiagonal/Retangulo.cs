using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LargAltDeRetanguloPeriDiagonal
{
    class Retangulo
    {

        public double largura, altura;

        /*
         * Area
        A=b.h
        Onde,
        A: área
        b: base
        h: altura
         */
        public double area()
        {
            return largura * altura;
        }

        /*
         Perímetro: valor encontrado quando se soma os quatro lados da figura. 
         É expresso pela fórmula: 2(b + h). Assim, 
         ele corresponde a soma de duas vezes a base e a altura (2b + 2h)
        */
        public double perimetro()
        {
            return 2 * (largura + altura); 
        }

        /*
         Raiz de a²*l². <-- é L
         */

        public double diagonal()
        {
            return Math.Sqrt(altura * altura + largura * largura);
        }

        public override string ToString()
        {
            return "Area: "
                + area().ToString("F2", CultureInfo.InvariantCulture)
                + ", Perimetro: "
                + perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + ", Diagonal: "
                + diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
