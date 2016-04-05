package com.company;


import java.math.BigInteger;
import java.util.Scanner;

public class Pr05ConvertFromDecTo7BaseSystem {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int number=scan.nextInt();
        String output= "";
        output = Integer.toString(number, 7);
        System.out.println(output);
    }
}
