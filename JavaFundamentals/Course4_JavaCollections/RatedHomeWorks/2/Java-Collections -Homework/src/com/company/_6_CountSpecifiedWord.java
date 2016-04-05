package com.company;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _6_CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String inText = input.nextLine().toUpperCase();
        String[] text = inText.split("\\W+");
        String purpose = input.nextLine().toUpperCase();

        int count =0;
        for (int i = 0; i < text.length; i++) {
            if (purpose.equals(text[i])){
                count++;
            }
        }
        System.out.print(count);
    }
}
