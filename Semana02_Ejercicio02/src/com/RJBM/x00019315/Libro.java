package com.RJBM.x00019315;

public class Libro {
    // Atributos
    private String ISBN;
    private String name;
    private int sheets;

    // Constructor
    public Libro(String ISBN, String name, int sheets) {
        this.ISBN = ISBN;
        this.name = name;
        this.sheets = sheets;
    }

    // Getters
    public String getISBN() {
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
