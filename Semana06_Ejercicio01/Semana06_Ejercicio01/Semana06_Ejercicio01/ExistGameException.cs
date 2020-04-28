using System;

namespace Semana06_Ejercicio01
{
    public class ExistGameException : Exception
    {
        public ExistGameException(string message) : base(message)
        {
        }
    }
}