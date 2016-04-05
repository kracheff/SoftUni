package com.company;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _5_CountAllWords {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String [] line = input.nextLine().split("\\W+");
        System.out.println(line.length);
    }
}
