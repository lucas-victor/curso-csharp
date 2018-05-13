using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAbsClassPoliOverrideInterf
{
    class Triangulos : Figuras 
    {
        //triangulo lados A, B e C.

        public double ladoA { get; set; }
        public double ladoB { get; set; }
        public double ladoC { get; set; }

        public Triangulos(double ladoA, double ladoB, double ladoC, Cor cor, MesEnum mes) : base(cor, mes) {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public Triangulos(double ladoA, double ladoB, double ladoC, Cor cor, MesEnum mes, TipoMaterial material) : base(cor, mes, material)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public override double area() {
            double p = (ladoA + ladoB + ladoC) / 2.0;
            return Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
        }

        public override double perimetro()
        {
            return ladoA + ladoB + ladoC;
        }

        public override string ToString()
        {
            return "Lado A: "
                + ladoA
                + ", Lado B: "
                + ladoB
                + ", Lado C: "
                + ladoC
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
