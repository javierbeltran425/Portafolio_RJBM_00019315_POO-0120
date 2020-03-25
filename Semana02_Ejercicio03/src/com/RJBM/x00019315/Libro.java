package com.RJBM.x00019315;

public class Libro {
    // Atributos
    private int ISBN = GeneradorISBN.nuevoISBN();
    private String name;
    private int sheets;

    // Constructor
    public Libro(String name, int sheets) {
        this.name = name;
        this.sheets = sheets;
    }

    // Getters
    public int getISBN() {
        return ISBN;
    }

    public String getName() {
        return name;
    }

    public int getSheets() {
        return sheets;
    }

    // toString
    @Override
    public String toString() {
        return ISBN + ": " + name + " (" + sheets + ")";
    }
}
