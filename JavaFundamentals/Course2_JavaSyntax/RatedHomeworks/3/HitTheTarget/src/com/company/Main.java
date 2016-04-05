package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int target  = sc.nextInt();

        for (int i = 1; i <=20 ; i++) {

            for (int j = 1; j <= 20 ; j++) {

                if (i + j == target){

                    System.out.printf("%d + %d = %d\n", i, j, target);
                }
            }

            for (int j = 20; j >=1 ; j--) {

                if (i - j == target){

                    System.out.printf("%d - %d = %d\n", i, j, target);
                }
            }
        }

    }
}
