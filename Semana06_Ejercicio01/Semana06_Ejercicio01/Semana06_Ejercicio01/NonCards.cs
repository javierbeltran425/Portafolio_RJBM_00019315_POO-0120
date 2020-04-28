using System;

namespace Semana06_Ejercicio01
{
    public class NonCards : Exception
    {
        public NonCards(string message) : base(message)
        {
        }
    }
}