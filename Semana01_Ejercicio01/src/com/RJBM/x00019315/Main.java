package com.RJBM.x00019315;

public class Main {

    public static void main(String[] args) {
        Laptop hp = new Laptop("HP", "hp-14");
        TextFile myFile = new TextFile("Mi_Archivo", 100);

        hp.turnOn();
        hp.logIn("Javier");
        myFile.openFile();
        myFile.typeText();
        myFile.saveFile();
        myFile.closeFile();
        hp.trunOff();

        //Modificando valores de los atributos
        hp.setBrand("ASUS");
        hp.setModel("N4000");
        myFile.setName("Lorem ipsum");
        myFile.setTamano(200);

        System.out.println("\n");

        hp.turnOn();
        hp.logIn("Javier");
        myFile.openFile();
        myFile.typeText();
        myFile.saveFile();
        myFile.closeFile();
        hp.trunOff();

        //Obteniendo valores de los atributos
        System.out.println("\nMarca: " + hp.getBrand());
        System.out.println("Modelo: " + hp.getModel());
        System.out.println("Nombre del archivo: " + myFile.getName());
        System.out.println("Tamaño del archivo: " + myFile.getTamano());
    }
}