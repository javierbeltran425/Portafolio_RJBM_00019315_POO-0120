using System;

namespace Semana06_Ejercicio01
{
    public class NonExistCardException : Exception
    {
        public NonExistCardException(string message) : base(message)
        {
        }
    }
}