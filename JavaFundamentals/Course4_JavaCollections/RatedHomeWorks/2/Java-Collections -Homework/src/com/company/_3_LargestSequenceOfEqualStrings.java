package com.company;
import java.util.Scanner;

public class _3_LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);
        String input = scn.nextLine();

        String[] strArr = input.split(" ");
        String largest = strArr[0];

        int count = 1;
        int max = 1;

        for (int i = 1; i < strArr.length; i++) {
            if (strArr[i].equals(strArr[i - 1])) {
                count++;
                if (count > max) {
                    max = count;
                    largest = strArr[i];
                }
            } else {
                count = 1;
            }
        }

        for (int i = 0; i < max; i++) {
            System.out.print(largest + " ");
        }
    }
}
