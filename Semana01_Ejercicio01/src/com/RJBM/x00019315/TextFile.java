package com.RJBM.x00019315;

import javax.swing.plaf.synth.SynthUI;
import javax.xml.namespace.QName;

public class TextFile {
    private String name;
    private int tamano;

    public TextFile() {
        this.name = "Mi_Archivo";
        this.tamano = 100;
    }

    public TextFile(String name, int tamano) {
        this.name = name;
        this.tamano = tamano;
    }

    //Getters y setters de name
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    //Getters y setters de tamano


    public int getTamano() {
        return tamano;
    }

    public void setTamano(int tamano) {
        this.tamano = tamano;
    }

    //Metodos

    public void openFile() {
        System.out.println("Abriendo documento de Word");
        System.out.println("Creando archivo nuevo " + name);
    }

    public void typeText(){
        System.out.println("Digitando texto...");
        System.out.println("Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "\nsed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "\nUt enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                "\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "\nExcepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
        System.out.println("Texto digitado");
    }

    public void saveFile(){
        System.out.println("Guardando Archivo...");
        System.out.println("Archivo guardado como " + name);
    }

    public void closeFile(){
        System.out.println("Cerrando Word...");
        System.out.println("Word se ha cerrado");
    }
}