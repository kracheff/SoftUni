package com.company;
import java.util.Scanner;

public class GhettoNumeralSystem {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        char[] numbers = console.nextLine().toCharArray();

        StringBuilder numSys = new StringBuilder();

        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] == '0') {
                numSys.append("Gee");
            }
            else if (numbers[i] == '1') {
                numSys.append("Bro");
            }
            else if (numbers[i] == '2') {
                numSys.append("Zuz");
            }
            else if (numbers[i] == '3') {
                numSys.append("Ma");
            }
            else if (numbers[i] == '4') {
                numSys.append("Duh");
            }
            else if (numbers[i] == '5') {
                numSys.append("Yo");
            }
            else if (numbers[i] == '6') {
                numSys.append("Dis");
            }
            else if (numbers[i] == '7') {
                numSys.append("Hood");
            }
            else if (numbers[i] == '8') {
                numSys.append("Jam");
            }
            else if (numbers[i] == '9') {
                numSys.append("Mack");
            }
        }
        System.out.println(numSys.toString());
    }
}