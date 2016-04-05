package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        String number = sc.nextLine();
        System.out.println(convertToSevenBased(number));

    }

    static String convertToSevenBased(String n) {

        String result = "";
        int number = Integer.parseInt(n);

        for (int i = 0; i < n.length(); i++) {

            result += number % 7;
            number /= 7;


        }
        String finalResult = new StringBuilder(result).reverse().toString();

        return finalResult;
    }
}
