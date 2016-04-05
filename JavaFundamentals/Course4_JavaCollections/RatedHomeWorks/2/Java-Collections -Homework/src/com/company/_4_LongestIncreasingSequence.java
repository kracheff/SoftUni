package com.company;

import java.util.Scanner;

public class _4_LongestIncreasingSequence {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        String[] arr = scan.nextLine().split(" ");
        int[] parseNum = new int[arr.length];
        for (int i = 0; i < parseNum.length; i++) {
            parseNum[i] = Integer.parseInt(arr[i]);
        }
        scan.close();
        int prev = 0;
        int curr = 0;
        int maxLength = 0;
        int currLength = 0;
        int startIndex1 = 0;
        for (int i = 0; i < arr.length; i++) {
            if (i == 0) {
                System.out.print(arr[0] + " ");
                currLength++;
                continue;
            }
            prev = parseNum[i - 1];
            curr = parseNum[i];
            if (curr > prev) {
                currLength++;
                System.out.print(curr + " ");
                if (currLength > maxLength) {
                    maxLength = currLength;
                    startIndex1 = i - maxLength + 1;
                }
            } else {
                System.out.println();
                System.out.print(curr + " ");
                currLength = 1;
            }
        }
        if (maxLength == 1 || maxLength == 0) {
            System.out.print("Longest: " + arr[0] + " ");
        } else {
            System.out.println();
            System.out.print("Longest: ");
            for (int i = 0; i < maxLength; i++) {
                System.out.print(arr[startIndex1++] + " ");
            }
        }
    }
}
