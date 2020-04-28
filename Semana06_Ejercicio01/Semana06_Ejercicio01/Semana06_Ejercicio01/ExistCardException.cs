using System;

namespace Semana06_Ejercicio01
{
    public class ExistCardException : Exception
    {
        public ExistCardException(string message) : base(message)
        {
        }
    }
}