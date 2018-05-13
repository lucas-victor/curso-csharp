using System;

namespace RevendedoraCarros.Dominio
{
    class ModelException : Exception
    {
        public ModelException(string msg) : base(msg) {
        }
    }
}
