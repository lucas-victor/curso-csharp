using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    struct PontoStruct
    {
        public double x, y;

        
        public override string ToString()
        {
            //return base.ToString();
            return "(X: " + x + " Y: " + y + ")";   
            
        }
    }
}
