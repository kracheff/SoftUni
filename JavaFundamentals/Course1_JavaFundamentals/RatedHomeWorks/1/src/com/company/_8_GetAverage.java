package com.company;

import java.util.Scanner;

/**
 *
 */
public class _8_GetAverage {
    public static void main(String[] args) {
        double a,b,c;
        a = Double.parseDouble(new Scanner(System.in).nextLine());
        b = Double.parseDouble(new Scanner(System.in).nextLine());
        c = Double.parseDouble(new Scanner(System.in).nextLine());

        getAverage(a,b,c);
    }
    public static void getAverage(double a,double b,double c){
        System.out.printf("%.2f",(a+b+c)/3);
    }
}
