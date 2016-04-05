package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String[] numbers = sc.nextLine().split("\\s+");

        int a = Integer.parseInt(numbers[0]);
        double b = Double.parseDouble(numbers[1]);
        double c = Double.parseDouble(numbers[2]);

        System.out.printf("|%-10X|", a);
        System.out.printf("%010d|", Integer.parseInt(Integer.toBinaryString(a)));
        System.out.printf("%10.2f|", b);
        System.out.printf("%-10.3f|", c);
    }
}
