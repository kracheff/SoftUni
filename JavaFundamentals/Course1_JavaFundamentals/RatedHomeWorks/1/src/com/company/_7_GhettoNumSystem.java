package com.company;

import java.util.Scanner;

/**
 *
 */
public class _7_GhettoNumSystem {
    public static void main(String[] args) {
        String[] ghettoWords = new String[] {"Gee","Bro","Zuz","Ma","Duh",
                                            "Yo","Dis","Hood","Jam","Mack"};
        String input = new Scanner(System.in).nextLine();
        for (int i = 0; i < input.length(); i++) {
            for (int j = 0; j < 10; j++) {
                if ((Character.getNumericValue(input.charAt(i))) == j){
                    System.out.print(ghettoWords[j]);
                }
            }
        }
    }
}
