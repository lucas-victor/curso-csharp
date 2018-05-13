using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAbsClassPoliOverrideInterf
{
    abstract class Figuras
    {
        //Elemento Atributos.
        public Cor cor { get; set; }
        public TipoMaterial material { get; set; }
        public MesEnum mes { get; set; }


        //Elemento Metodos.
        public Figuras(Cor cor,  MesEnum mes, TipoMaterial material)
        {
            this.cor = cor;
            this.mes = mes;
            this.material = material;
        }

        public Figuras(Cor cor, MesEnum mes) {

            this.cor = cor;
            this.mes = mes;
        }

        //Calcula Area
        public abstract double area();

        //Calcula Perimetro >> implementar metodo perimetro sendo triangulo >> a + b + c || Retangulo >> 2 * (largura + altura) >> soma dos 4 lados.
        public abstract double perimetro();
    }
}
