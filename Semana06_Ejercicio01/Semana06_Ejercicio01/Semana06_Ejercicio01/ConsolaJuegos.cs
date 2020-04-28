using System;

namespace Semana06_Ejercicio01
{
    public static class ConsolaJuegos
    {
        public static void comprarJuego(){
            Console.Write("Número de tarjeta: ");
            string numero = Console.ReadLine();
            
            if(Banco.realizarCompras(numero)){
                Console.Write("Nombre del juego: ");
                string juego = Console.ReadLine();
                if (GestorArchivos.Buscar("Juegos.txt", juego))
                {
                    throw new ExistGameException("Ya tienes este juego");
                }
                GestorArchivos.Anexar("Juegos.txt", juego);
            
                Console.WriteLine("Juego comprado exitosamente!");
            }
            else
            {
                throw new NonExistCardException("La tarjeta no Existe");
            }
        }
    
        public static void jugar(){
            Console.Write("Nombre del juego: ");
            string juego = Console.ReadLine();
        
            if(GestorArchivos.Buscar("Juegos.txt", juego))
                Console.WriteLine("Listo para jugar!");
            else
                Console.WriteLine("Primero debe comprar el juego :(");
        }
    }
}