package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        String n = new StringBuilder(sc.nextLine()).reverse().toString();
        System.out.println(convertSevenBaseToDecimal(n));


    }

    static int convertSevenBaseToDecimal(String number) {


        int result = 0;
        int temp = 0;

        for (int i = 0; i < number.length(); i++) {


            temp = Character.getNumericValue(number.charAt(i));
            result += temp * Math.pow(7, i);

        }
        return result;
    }
}
