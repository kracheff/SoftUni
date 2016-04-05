package com.company;


import java.util.Scanner;

public class Pr10CharacterMultiplier {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String first = scan.next(), second = scan.next();
        int shorterLength = 0;
        boolean firstShorter = Math.min(first.length(), second.length()) == first.length();
        int sum = 0;
        if (firstShorter == true) {
            sum = GetSum(first, second);
        } else {
            sum = GetSum(second, first);
        }
        System.out.println(sum);
    }


    private static int GetSum(String first, String second) {
        int sum = 0;
        for (int i = second.length() - 1; i >= 0; i--) {
            if (i > first.length() - 1) {
                sum += second.charAt(i);
            }
            else{
                sum+=first.charAt(i)*second.charAt(i);
            }
        }

        return sum;
    }
}