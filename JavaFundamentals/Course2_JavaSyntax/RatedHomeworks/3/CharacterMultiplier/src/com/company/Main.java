package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        String firstStr = sc.next();
        String secondStr = sc.next();
        System.out.println(charMultiplier(firstStr, secondStr));
    }

    static int charMultiplier(String str1, String str2) {

        int sum = 0;
        String longerStr = str1;
        String shorterStr = str2;
        if (str2.length() > str1.length()){
            
            longerStr = str2;
            shorterStr = str1;
        }

        for (int i = 0; i < shorterStr.length(); i++) {

             sum += str1.charAt(i) * str2.charAt(i);
        }


        int remainingChars = longerStr.length() - shorterStr.length();

        for (int i = longerStr.length() - remainingChars - 1; i < remainingChars; i++) {

            sum += longerStr.charAt(i);
        }


        return sum;
    }
}
