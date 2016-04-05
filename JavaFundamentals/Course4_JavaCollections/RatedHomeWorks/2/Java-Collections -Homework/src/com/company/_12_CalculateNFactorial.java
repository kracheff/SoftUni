package com.company;

import java.util.Scanner;

public class _12_CalculateNFactorial {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int n = input.nextInt();

        long factorial = 1;

        while (true) {
            if (n == 1) {
                break;
            }
            factorial *= n;
            n--;
        }
        System.out.println("n! = " + factorial);
    }
}
