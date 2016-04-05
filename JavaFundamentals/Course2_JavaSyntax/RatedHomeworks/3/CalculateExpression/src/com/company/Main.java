package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double a = sc.nextDouble();
        double b = sc.nextDouble();
        double c = sc.nextDouble();

        double f1 = fisrtFormulaCalculator(a, b, c);
        double f2 = secondFormulaCalculator(a, b, c);
        double diff = Math.abs((a + b + c) / 3 - (f1 + f2) / 2);

        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", f1, f2, diff);
    }

    static double fisrtFormulaCalculator(double a, double b, double c){

        double result = Math.pow(((a * a + b * b) / (a * a - b * b)), (a + b + c) / Math.sqrt(c));
        return result;

    }

    static double secondFormulaCalculator(double a, double b, double c){

        double result = Math.pow((a * a + b * b - c * c * c), a - b);
        return result;
    }
}
