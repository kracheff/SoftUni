package com.company;

import java.util.Scanner;

/**
 *
 */
public class _6_SumNumbers {
    public static void main(String[] args) {
        int inputNumber = Integer.parseInt(new Scanner(System.in).nextLine());
        int sum = 0;
        for (int i = 1; i <=inputNumber ; i++) {
            sum+=i;
        }
        System.out.println(sum);
    }
}
