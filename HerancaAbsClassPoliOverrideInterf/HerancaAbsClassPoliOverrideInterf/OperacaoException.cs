using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAbsClassPoliOverrideInterf
{
    class OperacaoException : Exception
    {
        public OperacaoException(string errmsg) : base(errmsg){

        }
    }
}
