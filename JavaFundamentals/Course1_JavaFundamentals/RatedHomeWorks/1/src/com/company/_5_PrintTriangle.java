package com.company;

import java.util.Scanner;

/**
 *
 */
public class _5_PrintTriangle {
    public static void main(String[] args) {
        int inputNumber = Integer.parseInt(new Scanner(System.in).nextLine());


        for (int i = 0; i <= inputNumber; i++) {
            for (int j = 0; j < i; j++) {
                char ch ='a';
                System.out.printf("%c ",ch+j);
            }
            System.out.println();
        }
        for (int i = inputNumber -1; i >=0; i--) {
            char ch ='a';
            for (int j = 0; j < i; j++) {
                System.out.printf("%c ",ch+j);
            }
            System.out.println();
        }
    }
}
