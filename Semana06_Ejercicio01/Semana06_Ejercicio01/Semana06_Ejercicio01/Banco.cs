using System;

namespace Semana06_Ejercicio01
{
    public static class Banco
    {
        public static void registrarTarjeta(){
                Console.Write("Número de tarjeta: ");
                string numero = Console.ReadLine();

                if (GestorArchivos.Buscar("Tarjetas.txt", numero))
                {
                    throw new ExistCardException("La tarjeta ya existe");
                }

                try
                {
                    GestorArchivos.Anexar("Tarjetas.txt", numero);
                    Console.WriteLine("Tarjeta creada exitosamente!");
                }
                catch
                {
                    throw new Exception("No se pudo guardar la tarjeta, por favor intentelo mas tarde...");
                }
        }
            
            public static void consultarTarjetas(){
                if (GestorArchivos.Leer("Tarjetas.txt") is null)
                {
                    throw new NonCards("No existen tarjetas en el sistema");
                }
                    
                Console.WriteLine(GestorArchivos.Leer("Tarjetas.txt"));
            }
            
            public static bool realizarCompras(string tarjeta){
                return GestorArchivos.Buscar("Tarjetas.txt", tarjeta);
            }
    }
}