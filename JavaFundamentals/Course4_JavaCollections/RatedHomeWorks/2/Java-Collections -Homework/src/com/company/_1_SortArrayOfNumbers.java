package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class _1_SortArrayOfNumbers {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();
        Integer[] lines = new Integer[n];
        for (int i = 0; i < n; i++) {
            lines[i] = scanner.nextInt();
        }

        Arrays.sort(lines);

        for (int i = 0; i < lines.length; i++) {
            System.out.print(lines[i]+" ");
        }
    }
}
