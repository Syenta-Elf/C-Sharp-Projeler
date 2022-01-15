package Algoritma;

import java.util.Scanner;

/**
 * Main
 */
public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        letter(sc.nextLine());
        sc.close();
    }

    static void letter(String str)
    {   
        String newStr = str.replaceAll("[^A-Za-z]", "");

        System.out.println(newStr);

    }
}