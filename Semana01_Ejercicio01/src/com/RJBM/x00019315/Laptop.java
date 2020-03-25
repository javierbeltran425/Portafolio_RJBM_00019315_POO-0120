package com.RJBM.x00019315;

public class Laptop {
    private String brand;
    private String model;

    public Laptop() {
        this.brand = "HP";
        this.model = "Probook";
    }

    public Laptop(String lBrand, String lModel){
        this.brand = lBrand;
        this.model = lModel;
    }

    // Setters y getters del atributo brand
    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    // Setters y getters del atributo model

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    // Otros métodos
    public void turnOn(){
        System.out.println(brand + " " + model + " encendiendo");
        System.out.println("La computadora se ha encendido");
    }

    public void trunOff(){
        System.out.println(brand + " " + model + " apagando");
        System.out.println("La computadora se ha apagado");
    }

    public void logIn(String user){
        System.out.println("Bienvenido: " + user);
        System.out.println("Se ha iniciado sesión correctamente");
    }
}