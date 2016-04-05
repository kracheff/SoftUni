package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int [] numbers = Arrays.stream(sc.nextLine().split("\\s+"))
                .mapToInt(Integer :: parseInt).toArray();


        if (numbers.length % 2 != 0) {

            System.out.println("Invalid lenght!");
        } else {


            for (int i = 0; i < numbers.length; i += 2) {

                if (numbers[i] % 2 == 0 && numbers[i + 1] % 2 == 0) {

                    System.out.printf("%d, %d -> both are even\n", numbers[i], numbers[i + 1]);
                } else if (numbers[i] % 2 != 0 && numbers[i + 1] % 2 != 0) {

                    System.out.printf("%d, %d -> both are odd\n", numbers[i], numbers[i + 1]);
                } else {
                    System.out.printf("%d, %d -> different\n", numbers[i], numbers[i + 1]);
                }
            }
        }


    }
}
