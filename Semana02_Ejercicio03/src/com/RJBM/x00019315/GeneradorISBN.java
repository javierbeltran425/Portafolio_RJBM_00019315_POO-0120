package com.RJBM.x00019315;

// Invariantes de la clase:
// always nuevoID() >= 1
public final class GeneradorISBN {
    // Atributo
    private static int contador = 0;

    // Constructor privado
    private GeneradorISBN () {}

    // Métodos estáticos
    public static int nuevoISBN() {
        contador++;
        return contador;
    }
}