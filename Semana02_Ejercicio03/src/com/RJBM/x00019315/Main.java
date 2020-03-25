package com.RJBM.x00019315;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {
    static Scanner in = new Scanner(System.in);
    static List<Autor> myAuthors = new ArrayList<Autor>();
    static List<Libro> myBooks = new ArrayList<Libro>();

    public static void main(String[] args) {
        boolean showMenu = true;

        do {
            menu();     // Llamado a la funciòn menù
            int option = in.nextInt();
            in.nextLine();      //Se guarda la opciòn del usuario

            switch (option) {
                case 1:
                    addAuthors();
                    break;
                case 2: addBooks();
                    break;
                case 3: removeAuthor();
                    break;
                case 4: removeBook();
                    break;
                case 5:
                    showAuthors();
                    break;
                case 6: showBooks();
                    break;
                case 7: showMenu = false;
                    break;
                default: System.out.println("Opción inválida");
            }
        }while (showMenu);
    }

    private static void menu(){         // Se despliegua el menù
        System.out.println("***************");
        System.out.println("     MENU");
        System.out.println("***************");
        System.out.println("");
        System.out.println("\t1. Agregar Autor\n\t2. Agregar libro\n\t3. Quitar autor\n\t4. Quitar libro\n\t5. Mostrar autores" +
                "\n\t6. Mostrar libros\n\t7. Salir");
        System.out.print("Su opcion: ");
    }

    private static void addAuthors(){  // Funcion para agregar autores
        String email;
        char gender;
        Pattern p = Pattern.compile("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");  // Se hace uso de una "expresiòn regular" para poder hacer la validaciòn del correo electrònico
        Matcher m = null;
        boolean check = false;
        System.out.println("******************************");
        System.out.println("Sistema de registro de autores");
        System.out.println("******************************");

        System.out.println("");
        System.out.print("Nombre: "); String name = in.nextLine();      // Se guarda el nombre

        do {
            System.out.print("email: ");
            email = in.nextLine();      // Se guarda el correo
            m = p.matcher(email);
            if (!m.find()) {        // Validaciòn del correo electronico
                System.out.println("Direccion de correo inválida");
            }else{
                check = true;
            }
        }while (check == false);

        do {
            check = false;
            System.out.print("Genero (f/m): ");     // Se guarda el gènero
            gender = in.next().charAt(0);
            in.nextLine();
            if(gender == 'f' || gender == 'F' || gender == 'm' || gender == 'M'){       // Validaciòn del gènero
                check = true;
            }else{
                System.out.println("Opción inválida");
            }
        }while(check == false);

        myAuthors.add(new Autor(name, email, gender));
    }

    private static void addBooks(){     // Funciòn para agregar libros
        int sheets = 0;
        String name;

        System.out.println("******************************");
        System.out.println("Sistema de registro de libros");
        System.out.println("******************************");

        System.out.println("");
        System.out.print("Nombre: ");
        name = in.nextLine();

        System.out.print("Paginas: ");
        sheets = in.nextInt(); in.nextLine();

        myBooks.add(new Libro(name, sheets));
    }

    private static void removeAuthor() {        // Funciòn para remover autores
        String name;
        boolean flag = false;
        System.out.println("******************************");
        System.out.println("Sistema de borrado de autores");
        System.out.println("******************************");

        System.out.println("Nombre: ");
        name = in.nextLine();
        for (Autor aux : myAuthors) {
            if (aux.getName().equals(name)) {
                myAuthors.remove(aux);
                flag = true;
                break;
            }
        }
        if(flag){
            System.out.println("Autor eliminado");
        }else{
            System.out.println("No se encontró el autor");
        }
    }
    private static void removeBook(){       //Función para remover libros
        String name;
        boolean flag = false;
        System.out.println("******************************");
        System.out.println("Sistema de borrado de libros");
        System.out.println("******************************");

        System.out.println("Nombre: ");
        name = in.nextLine();
        for (Libro aux: myBooks) {
            if(aux.getName().equals(name)) {
                myBooks.remove(aux);
                flag = true;
                break;
            }
        }
        if(flag){
            System.out.println("Libro eliminado");
        }else{
            System.out.println("No se encontró el libro");
        }
    }

    private static void showAuthors() {      // Función para mostrar a los autores
        System.out.println("********");
        System.out.println("Autores:");
        System.out.println("********");

        if (!myAuthors.isEmpty()) {
            for (Autor aux : myAuthors) {
                System.out.println(aux.toString());
            }
        }else{
            System.out.println("La lista esta vacía");
        }
    }

    private static void showBooks() {    // Función para mostrar los libros
        System.out.println("********");
        System.out.println("Libros:");
        System.out.println("********");

        if (!myBooks.isEmpty()) {
            for (Libro aux : myBooks) {
                System.out.println(aux.toString());
            }
        }else{
            System.out.println("La lista esta vacía");
        }
    }
}
