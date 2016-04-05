package com.company;


import java.util.Locale;
import java.util.Scanner;

public class Pr03FormattingNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        scan.useLocale(Locale.ENGLISH);
        int a =scan.nextInt();
        double b = scan.nextDouble();
        double c = scan.nextDouble();
        String aInBinaryString = String.format("%10s", Integer.toBinaryString(a)).replace(" ", "0");

        System.out.printf("|%-10X|%s|%10.2f|%-10.3f|",a,aInBinaryString,b,c);

    }
}
